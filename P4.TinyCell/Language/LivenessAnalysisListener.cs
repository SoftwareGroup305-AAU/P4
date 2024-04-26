using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using static P4.TinyCell.Languages.TinyCell.LivenessAnalysisListener;


namespace P4.TinyCell.Languages.TinyCell
{
    internal class LivenessAnalysisListener : TinyCellBaseListener
    {   

        public List<IInstruction> Instructions;

        private Stack<ParentStructure> parentStructureStack;

        private List<IInstruction> prevInstructions;

        private Dictionary<string, IInstruction> funcLabelTable;

        private bool isAssigned;
       
        public LivenessAnalysisListener() 
        { 
            parentStructureStack = new Stack<ParentStructure>();
            prevInstructions = new List<IInstruction>();
            funcLabelTable = new Dictionary<string, IInstruction>();
            Instructions = new List<IInstruction>();
            
        }

        public override void EnterDocument([NotNull] TinyCellParser.DocumentContext context)
        {
            parentStructureStack.Push(new ParentStructure());
            parentStructureStack.First().scopeStack.Push(new Scope());
        }

        public override void EnterSetupDefinition([NotNull] TinyCellParser.SetupDefinitionContext context)
        {
            var parentStructure = new ParentStructure();
            parentStructure.scopeStack.Push(new Scope());
            parentStructureStack.Push(parentStructure);
        }

        public override void EnterCompoundStatement([NotNull] TinyCellParser.CompoundStatementContext context)
        {
            if (context.children.Count != 0)
            {
                parentStructureStack.First().scopeStack.Push(new Scope());
            }  
        }

        public override void ExitCompoundStatement([NotNull] TinyCellParser.CompoundStatementContext context)
        {
            if (prevInstructions.Count != 0)
            {
                parentStructureStack.First().scopeStack.First().lastInstruction = prevInstructions.First();
            }
            prevInstructions.Clear();
        }

        public override void EnterIfStatement([NotNull] TinyCellParser.IfStatementContext context)
        {
            var instruction = new Instruction<TinyCellParser.IfStatementContext>(context);
            Instructions.Add(instruction);
            prevInstructions.ForEach(prevInstruction => prevInstruction.addSucc(instruction));
            prevInstructions.Clear();
            if (parentStructureStack.First().scopeStack.First().firstInstruction == null)
            {
                parentStructureStack.First().scopeStack.First().firstInstruction = instruction;
            }
            var parentStructure = new ParentStructure();
            parentStructure.Instruction = instruction;
            parentStructureStack.Push(parentStructure);
        }

        public override void ExitIfStatement([NotNull] TinyCellParser.IfStatementContext context)
        {
                var parentStructure = parentStructureStack.First();
                foreach (var scope in parentStructure.scopeStack)
                {
                    parentStructure.Instruction.addSucc(scope.firstInstruction);
                    prevInstructions.Add(scope.lastInstruction);
                }
                if (parentStructure.scopeStack.Count <= 1)
                {
                prevInstructions.Add(parentStructure.Instruction);
                }
                parentStructureStack.Pop();
        }

        public override void EnterLoopStatement([NotNull] TinyCellParser.LoopStatementContext context)
        {
            var instruction = new Instruction<TinyCellParser.LoopStatementContext>(context);
            Instructions.Add(instruction);
            prevInstructions.ForEach(prevInstruction => prevInstruction.addSucc(instruction));
            prevInstructions.Clear();
            if (parentStructureStack.First().scopeStack.First().firstInstruction == null)
            {
                parentStructureStack.First().scopeStack.First().firstInstruction = instruction;
            }
            var parentStructure = new ParentStructure();
            parentStructure.Instruction = instruction;
            parentStructureStack.Push(parentStructure);
        }

        public override void ExitLoopStatement ([NotNull] TinyCellParser.LoopStatementContext context)
        {
            var parentStructure = parentStructureStack.First();
            foreach (var scope in parentStructure.scopeStack)
            {
                parentStructure.Instruction.addSucc(scope.firstInstruction);
                prevInstructions.Add(scope.lastInstruction);
            }
            if (parentStructure.scopeStack.Count <= 1)
            {
                prevInstructions.Add(parentStructure.Instruction);
            }
            parentStructureStack.Pop();
        }

        public override void EnterDeclaration([NotNull] TinyCellParser.DeclarationContext context)
        {
            var instruction = new Instruction<TinyCellParser.DeclarationContext>(context);
            Instructions.Add(instruction);
            prevInstructions.ForEach(prevInstruction => prevInstruction.addSucc(instruction));
            prevInstructions.Clear();
            prevInstructions.Add(instruction);
            if (parentStructureStack.First().scopeStack.First().firstInstruction == null) 
            {
                parentStructureStack.First().scopeStack.First().firstInstruction = instruction;
            }
        }

        public override void EnterExpression([NotNull] TinyCellParser.ExpressionContext context)
        {
            isAssigned = true;
        }

        public override void ExitExpression([NotNull] TinyCellParser.ExpressionContext context)
        {
            isAssigned = false;
        }

        public override void EnterIdentifier([NotNull] TinyCellParser.IdentifierContext context)
        {
            if (isAssigned)
            {
                Instructions.Last().addGen(context);

            }
            else
            {
                Instructions.Last().addKill(context);
            }
        }






        private class ParentStructure
        {
            public IInstruction? Instruction;
            public Stack<Scope> scopeStack { get; set; }

            public ParentStructure()
            {
                scopeStack = new Stack<Scope>();
            }
        }

        public void LivenessGraph()
        {
            if (Instructions.Count == 0)
            {
                return;
            }
            inizializeFirstOut();
            List<IInstruction> instructionsCopy;
            do
            {
                instructionsCopy = Instructions.Select(instruction => (IInstruction) instruction.Clone()).ToList();
                for (int i = Instructions.Count - 1; i >= 0; i--)
                {
                    var instruction = Instructions[i];
                    Update(instruction);
                }
            } while (!isListEqual(instructionsCopy, Instructions));
            
        }

        public void inizializeFirstOut()
        {
            for (int i = Instructions.Count - 1; i >= 0; i--)
            {
                if (Instructions[i].getGen().Count != 0)
                {
                    var lastInstructionIns = Instructions[i].getIns();
                    var lastInstructionGen = Instructions[i].getGen();
                    lastInstructionIns = lastInstructionIns.Union(lastInstructionGen).ToHashSet();
                    Instructions[i].setIns(lastInstructionIns);
                    break;
                }
            }
            
        }

        private bool isListEqual(List<IInstruction> list1, List<IInstruction> list2)
        {
            for (int i = 0; i < list1.Count; i++)
            {
                var instruction1 = list1[i];
                var instruction2 = list2[i];

                // Compare properties of the instructions
                if (!areInstructionsEqual(instruction1, instruction2))
                {
                    return false;
                }
            }
            return true;    


        }

        private bool areInstructionsEqual(IInstruction instruction1, IInstruction instruction2)
        {
            if (!instruction1.getIns().SetEquals(instruction2.getIns()))
            {
                return false;
            }
            if (!instruction1.getOuts().SetEquals(instruction2.getOuts()))
            {
                return false;
            }
            return true;
        }

        private void Update(IInstruction instruction)
        {
            UpdateOuts(instruction);
            UpdateIns(instruction);
        }

        private void UpdateOuts(IInstruction instruction)
        {
            var instructionOuts = instruction.getOuts();
            foreach (var succ in instruction.getSucc())
            {
                instructionOuts.UnionWith(succ.getIns());
            }
            instruction.setOuts(instructionOuts);
        }

        private void UpdateIns(IInstruction instruction)
        {
            var gen = instruction.getGen();
            var outs = instruction.getOuts();
            var kill = instruction.getKill();
            var outsMinusKill = new HashSet<string>(outs);
            outsMinusKill.ExceptWith(kill);
            var newIns = gen.Union(outsMinusKill).ToHashSet();
            instruction.setIns(newIns);
        }

        private class Scope
        {
            public IInstruction? firstInstruction { get; set; }
            public IInstruction? lastInstruction { get; set; }
        }

        /// <summary>
        /// Represents an instruction in the liveliness analysis./// </summary>
        /// <typeparam name="T">The type of <see cref="ParserRuleContext"/> instruction  </typeparam>
        private class Instruction<T> : IInstruction, ICloneable where T : ParserRuleContext
        {
            /// <summary>
            /// Gets or sets the instruction.
            /// </summary>
            public T? baseInstruction { get; set; }

            public Instruction(T instruction)
            {
                baseInstruction = instruction;
                gen = [];
                kill = [];
                succ = [];
                outs = new HashSet<string>();
                ins = new HashSet<string>();
            }

            /// <summary>
            /// Gets or sets the set of variables generated by this instruction.
            /// </summary>
            public HashSet<string>? gen { get; set; }

            /// <summary>
            /// Gets or sets the set of variables killed by this instruction.
            /// </summary>
            public HashSet<string>? kill { get; set; }

            /// <summary>
            /// Gets or sets the set of succeeding instructions
            /// </summary>
            public HashSet<IInstruction>? succ { get; set; }

            public HashSet<string>? outs { get; set; }

            public HashSet<string>? ins { get; set; }

            public void addGen(TinyCellParser.IdentifierContext context)
            {
                gen.Add(context.GetText());
            }

            public void addKill(TinyCellParser.IdentifierContext context)
            {
                kill.Add(context.GetText());
            }

            public void addSucc(IInstruction instruction)
            {
                succ.Add(instruction);
               
            }

            public HashSet<IInstruction> getSucc()
            {
                return succ;
            }

            public HashSet<string> getIns()
            {
                return ins;
            }

            public HashSet<string> getGen()
            {
                return gen;
            }

            public HashSet<string> getOuts()
            {
                return outs;
            }

            public HashSet<string> getKill()
            {
                return kill;
            }

            public void setIns(HashSet<string> newIns)
            {
                ins = newIns;
            }

            public void setOuts(HashSet<string> newOuts)
            {
                outs = newOuts;
            }

            public object Clone()
            {
                Instruction<T> clone = new Instruction<T>(this.baseInstruction);

                clone.gen = new HashSet<string>(this.gen);
                clone.kill = new HashSet<string>(this.kill);
                clone.succ = new HashSet<IInstruction>(this.succ);
                clone.outs = new HashSet<string>(this.outs);
                clone.ins = new HashSet<string>(this.ins);

                return clone;
            }

        }
        /// <summary>
        /// Interface to generalize instruction to generic
        /// </summary>
        public interface IInstruction : ICloneable
        {
            public void addGen(TinyCellParser.IdentifierContext context);

            public void addKill(TinyCellParser.IdentifierContext context);

            public void addSucc(IInstruction instruction);

            public HashSet<IInstruction> getSucc();

            public HashSet<string> getIns();

            public HashSet<string> getGen();

            public HashSet<string> getOuts();

            public HashSet<string> getKill();

            public void setIns(HashSet<string> newSet);
            public void setOuts(HashSet<string> newOuts);
        }
    }
}
