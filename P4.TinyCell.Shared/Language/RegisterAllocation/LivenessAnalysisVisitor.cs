using P4.TinyCell.Shared.Language.AbstractSyntaxTree;
using P4.TinyCell.Shared.Language.AbstractSyntaxTree.Expression;
using P4.TinyCell.Shared.Language.AbstractSyntaxTree.Primitive;
using P4.TinyCell.Shared.Language.AbstractSyntaxTree.Assignment;
using P4.TinyCell.Shared.Language.AbstractSyntaxTree.Statement;
using P4.TinyCell.Shared.Utilities;
using P4.TinyCell.Shared.Language.AbstractSyntaxTree.Function;

namespace P4.TinyCell.Shared.Language.RegisterAllocation
{
    public class LivenessAnalysisVisitor : AstBaseVisitor<HashSet<string>>
    {
        private List<IInstruction> lastInstructions = new();

        private List<IInstruction> prevInstructions = new();

        private bool firstInstruction = false;

        Stack<List<string>> currentVariables = new();
        private Stack<IInstruction> parentInstructions = new();
        public Dictionary<string, List<IInstruction>> Scopes { get; set; } = new();
        private Stack<Dictionary<string, int>> toBeRenamed = new();

        public override HashSet<string> VisitChildren(AstNode node)
        {
            HashSet<string> res = new();

            foreach (AstNode child in node.Children)
            {
                res.UnionWith(child.Accept(this));
            }
            return res;
        }

        public override HashSet<string> VisitRootNode(RootNode rootNode)
        {
            Scopes.Add("global", new List<IInstruction>());
            currentVariables.Push(new List<string>());
            VisitChildren(rootNode);
            return new HashSet<string>();
        }

        public override HashSet<string> VisitDeclarationNode(DeclarationNode declarationNode)
        {
            declarationNode.Identifier.Value = CheckPrevId(declarationNode.Identifier.Value);
            var id = declarationNode.Identifier.Value;
            var instruction = new Instruction<DeclarationNode>(declarationNode);
            instruction.addKill(id);
            HashSet<string> res = Visit(declarationNode.Action);
            foreach (var identifier in res)
            {
                instruction.addGen(identifier);
            }
            AddInstruction(instruction);
            return new HashSet<string>();
        }

        public override HashSet<string> VisitIdentifierNode(IdentifierNode identifierNode)
        {
            if (toBeRenamed.Count() != 0 && toBeRenamed.Peek().ContainsKey(identifierNode.Value))
            {
                identifierNode.Value += $"_{toBeRenamed.Peek()[identifierNode.Value]}";
            }
            HashSet<string> res = [identifierNode.Value];
            return res;
        }

        public override HashSet<string> VisitAssignNode(AssignNode assignmentNode)
        {
            if (toBeRenamed.Peek().ContainsKey(assignmentNode.Identifier.Value))
            {
                assignmentNode.Identifier.Value += $"_{toBeRenamed.Peek()[assignmentNode.Identifier.Value]}";
            }
            var id = assignmentNode.Identifier.Value;
            var instruction = new Instruction<AssignNode>(assignmentNode);
            instruction.addKill(id);
            HashSet<string> res = Visit(assignmentNode.Expression);
            foreach (var identifier in res)
            {
                instruction.addGen(identifier);
            }
            AddInstruction(instruction);
            return new HashSet<string>();
        }

        public override HashSet<string> VisitFunctionDefinitionNode(FunctionDefinitionNode functionDefinitionNode)
        {
            Scopes.Add(functionDefinitionNode.Identifier.Value, new List<IInstruction>());
            toBeRenamed.Push(new Dictionary<string, int>());
            VisitChildren(functionDefinitionNode);
            toBeRenamed.Pop();
            return new HashSet<string>();
        }

        public override HashSet<string> VisitIfStatementNode(IfStatementNode ifStatementNode)
        {
            var instruction = new Instruction<IfStatementNode>(ifStatementNode);
            AddInstruction(instruction);
            parentInstructions.Push(instruction);
            var gens = Visit(ifStatementNode.Condition);
            foreach (var gen in gens)
            {
                instruction.addGen(gen);
            }
            if (ifStatementNode.TrueExpr.Children.Count > 0)
            {
                toBeRenamed.Push(new Dictionary<string, int>());
                firstInstruction = true;
                Visit(ifStatementNode.TrueExpr);
                lastInstructions.AddRange(prevInstructions);
                toBeRenamed.Pop();
                if (ifStatementNode.ElseExpr != null && ifStatementNode.ElseExpr.Children.Count > 0)
                {
                    toBeRenamed.Push(new Dictionary<string, int>());
                    prevInstructions.Clear();
                    firstInstruction = true;
                    Visit(ifStatementNode.ElseExpr);
                    lastInstructions.AddRange(prevInstructions);
                    toBeRenamed.Pop();
                }
                else {
                    prevInstructions.Clear();
                    prevInstructions.Add(instruction);
                    prevInstructions.AddRange(lastInstructions);
                }
               
                
            }
            return new HashSet<string>();
        }

        private string CheckPrevId(string id)
        {

            if (currentVariables.Peek().Contains(id))
            {
                return RenameId(id);
            }
            else
            {
                currentVariables.Peek().Add(id);
                return id;
            }
        }
        private string RenameId(string id)
        {
            foreach (var stack in toBeRenamed.Reverse())
            {
                if (stack.ContainsKey(id))
                {
                    stack[id]++;
                    return id += $"_{stack[id]}";
                }
            }
            toBeRenamed.Peek().Add(id, 0);
            return id += $"_{toBeRenamed.Peek()[id]}";
        }

        private void AddInstruction(IInstruction instruction)
        {
            if (firstInstruction)
            {
                parentInstructions.Peek().addSucc(instruction);
                prevInstructions.Clear();
                firstInstruction = false;
            }
            else
            {
                prevInstructions.ForEach(prevInstruction => prevInstruction.addSucc(instruction));
                prevInstructions.Clear();
            }
            prevInstructions.Add(instruction);
            Scopes.Last().Value.Add(instruction);
        }


    }
}