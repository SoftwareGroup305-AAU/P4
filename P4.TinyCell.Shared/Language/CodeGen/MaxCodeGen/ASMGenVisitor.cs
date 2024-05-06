using System.Runtime.CompilerServices;
using System.Transactions;
using P4.TinyCell.Shared.Language.AbstractSyntaxTree;
using P4.TinyCell.Shared.Language.AbstractSyntaxTree.Expression;
using P4.TinyCell.Shared.Language.AbstractSyntaxTree.NumExpr;
using P4.TinyCell.Shared.Language.AbstractSyntaxTree.Primitive;

namespace CodeGen
{
    public class ASMGenVisitor : AstBaseVisitor<string>
    {
        private string currentVariable = "";
        private int labelCount = 0;
        private int ifLabelCount = 0;
        private int WhileLabelCount = 0;
        private int ForLabelCount = 0;
        /// <summary>
        /// A dictonary to keep track of digital and analog pins
        /// </summary>
        /// <returns>true if digital, false if analog</returns>
        Dictionary<string, bool> IsDigitalPinMap = new Dictionary<string, bool>();

        Dictionary<string, Dictionary<string, string>> RegisterScopes = new Dictionary<string, Dictionary<string, string>>();
        private string CurrentFunction = "";

        private Stack<string> Scopes = new();

        public ASMGenVisitor(Dictionary<string, Dictionary<string, string>> registerScopes)
        {
            RegisterScopes = registerScopes;
        }
        public override string VisitRootNode(RootNode rootNode)
        {
            Scopes.Push("document");
            return base.VisitRootNode(rootNode);
        }

        public override string VisitDeclarationNode(DeclarationNode declarationNode)
        {
            currentVariable = declarationNode.Identifier.Value;
            if (declarationNode.Action != null)
            {
                return Visit(declarationNode.Action);
            }
            return base.VisitDeclarationNode(declarationNode);
        }

        public override string VisitAddExprNode(AddExprNode addExprNode)
        {
            string register = RegisterScopes[Scopes.First()][currentVariable];
            string code1 = Visit(addExprNode.Right);
            string code2 = Visit(addExprNode.Left);

            return code1 + code2;
        }

        public override string VisitMultExprNode(MultExprNode multExprNode)
        {
            string register = RegisterScopes[Scopes.First()][currentVariable];
            string code1 = Visit(multExprNode.Right);
            string code2 = Visit(multExprNode.Left);
            if (isLeafNode(multExprNode.Left) && isLeafNode(multExprNode.Right))
            {
                return $"MOV r9, {code1}\n" + $"MUL r9, r9, {code2}\n";
            }
            return code1 + code2;
        }

        public override string VisitIntNode(IntNode intNode)
        {
            return "#" + intNode.Value.ToString();
        }

        public override string VisitIdentifierNode(IdentifierNode identifierNode)
        {
            return RegisterScopes["document"][currentVariable];
        }

        private bool isLeafNode(AstNode node)
        {
            return node.Children.Count == 0;
        }
    }
}