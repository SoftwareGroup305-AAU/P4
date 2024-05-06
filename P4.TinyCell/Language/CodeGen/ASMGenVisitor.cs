using System.Runtime.CompilerServices;
using System.Transactions;
using System.Xml.XPath;
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

       public ASMGenVisitor(Dictionary<string, Dictionary<string, string>> registerScopes) {
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
            if (declarationNode.Action != null) {
                string code1 = Visit(declarationNode.Action);
                string x = code1 + $"MOV {RegisterScopes[Scopes.First()][currentVariable]}, r9\n";
                Console.WriteLine(x);
            }
            return base.VisitDeclarationNode(declarationNode);
        }

        public override string VisitAddExprNode(AddExprNode addExprNode)
        {
            string code1 = Visit(addExprNode.Left);
            string code2 = Visit(addExprNode.Right);
            return doArithmaticOperation("ADD", code1, code2, addExprNode.Left, addExprNode.Right);
        }

        public override string VisitMultExprNode(MultExprNode multExprNode)
        {
            string code1 = Visit(multExprNode.Left);
            string code2 = Visit(multExprNode.Right);
            return doArithmaticOperation("MUL", code1, code2, multExprNode.Left, multExprNode.Right);
        }

        public override string VisitSubExprNode(SubExprNode subExprNode)
        {
            string code1 = Visit(subExprNode.Left);
            string code2 = Visit(subExprNode.Right);

            string result = "";

            return result;
        }

        public override string VisitIdentifierNode(IdentifierNode identifierNode)
        {
            return RegisterScopes["document"][identifierNode.Value];
        }
       

        public override string VisitIntNode(IntNode intNode)
        {
            return "#" + intNode.Value.ToString();
        }

        private string doArithmaticOperation(string op, string code1, string code2, AstNode left, AstNode right) {
            string finalRegister = RegisterScopes[Scopes.First()][currentVariable];
            string result = "";
            if (isLeafNode(left) && isLeafNode(right))
            {
                result += $"MOV {finalRegister}, {code2}\n";
                result += $"{op} r9, {finalRegister}, {code1}\n";
            }
            else if (isLeafNode(left))
            {
                result += code2;
                result += $"{op} r9, r9, {code1}\n";
            }
            else if (isLeafNode(right))
            {
                result += code1;
                result += $"{op} r9, r9, {code2}\n";
            }
            else
            {
                result += code2;
                result += $"MOV r12, r9\n";
                result += code1;
                result += $"{op} r9, r12, r9\n";
            }
            return result;
        }


        private bool isLeafNode (AstNode node) {
            return node.Children.Count == 0;
        }




    }
}