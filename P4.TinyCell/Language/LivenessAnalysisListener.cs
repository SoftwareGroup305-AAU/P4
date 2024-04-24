using Antlr4.Runtime;
using Antlr4.Runtime.Misc;


namespace P4.TinyCell.Languages.TinyCell
{
    internal class LivenessAnalysisListener : TinyCellBaseListener
    {
        /// <summary>
        /// List of instructions
        /// </summary>
        public List<IInstruction>? instructions;

        public Stack<IInstruction>? branchParents;
        /// <summary>
        /// Gets or sets the current instruction in the tree walk
        /// </summary>
        private IInstruction? currentInstruction;

        private Dictionary<string, IInstruction> FTable;

        /// <summary>
        /// Keeps track of whether the variables seen in the current context are assigned (Right-hand side) or not
        /// </summary>
        private bool isAssigned;
        /// <summary>
        /// Keeps of whether the next instruction is the first in a function definition
        /// </summary>
        private bool isFirstInstruction;
        /// <summary>
        /// Stores the <see cref="string"></see> name of the current function identifier
        /// </summary>
        private string? currentFunctionIdentifier;
        public LivenessAnalysisListener()
        {
            instructions = [];
            branchParents = [];
            FTable = new Dictionary<string, IInstruction>();
        }

        public override void EnterDeclaration([NotNull] TinyCellParser.DeclarationContext context)
        {

            Instruction<TinyCellParser.DeclarationContext> instruction = new Instruction<TinyCellParser.DeclarationContext>(context);
            if (currentFunctionIdentifier != null)
            {
                FTable.Add(currentFunctionIdentifier, instruction);
                isFirstInstruction = false;
                currentFunctionIdentifier = null;
                return;
            }
            if (currentInstruction != null )
            {
                if (isFirstInstruction)
                {
                    branchParents.Last().addSucc(instruction);
                } else
                {
                    currentInstruction.addSucc(instruction);
                }
            }
            currentInstruction = instruction;
            instructions.Add(instruction);
            
        }
        //public override void EnterPinExpression([NotNull] TinyCellParser.PinExpressionContext context)
        //{
        //    Instruction<TinyCellParser.PinExpressionContext> instruction = new Instruction<TinyCellParser.PinExpressionContext>(context);
        //    currentInstruction = instruction;
        //    instructions.Add(instruction);
        //}

        public override void EnterFunctionCall([NotNull] TinyCellParser.FunctionCallContext context)
        {
            IInstruction nextInstruction;
            FTable.TryGetValue(context.identifier().GetText(), out nextInstruction);
            currentInstruction.addSucc(nextInstruction);
            isAssigned = true;
        }

        public override void ExitFunctionCall([NotNull] TinyCellParser.FunctionCallContext context)
        {
            isAssigned = false;
        }

        public override void EnterCompoundStatement([NotNull] TinyCellParser.CompoundStatementContext context)
        {
            isFirstInstruction = true;
            if (currentInstruction != null)
            {
                branchParents.Push(currentInstruction);
            }
        }


        public override void EnterFunctionDefinition([NotNull] TinyCellParser.FunctionDefinitionContext context)
        {
            
        }

        public override void ExitFunctionDefinition([NotNull] TinyCellParser.FunctionDefinitionContext context)
        {
            currentInstruction = null;
            isFirstInstruction = false;
        }

        public override void EnterIfStatement([NotNull] TinyCellParser.IfStatementContext context)
        {
            Instruction<TinyCellParser.IfStatementContext> instruction = new Instruction<TinyCellParser.IfStatementContext>(context);
            currentInstruction = instruction;
        }

        public override void ExitIfStatement([NotNull] TinyCellParser.IfStatementContext context)
        {
            branchParents.Pop();
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
            if (context.Parent is TinyCellParser.FunctionDefinitionContext)
            {
                currentFunctionIdentifier = context.GetText();
            }
            if (isAssigned)
            {
                currentInstruction.addGen(context);
            }
            else
            {
                currentInstruction.addKill(context);
            }
        }
        /// <summary>
        /// Represents an instruction in the liveliness analysis./// </summary>
        /// <typeparam name="T">The type of <see cref="ParserRuleContext"/> instruction  </typeparam>
        private class Instruction<T> : IInstruction where T : ParserRuleContext
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
                outs = [];
                ins = [];
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
            public List<IInstruction>? succ { get; set; }

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
        }
        /// <summary>
        /// Interface to generalize instruction to generic
        /// </summary>
        public interface IInstruction
        {
            public void addGen(TinyCellParser.IdentifierContext context);

            public void addKill(TinyCellParser.IdentifierContext context);

            public void addSucc(IInstruction instruction);
        }
    }
}
