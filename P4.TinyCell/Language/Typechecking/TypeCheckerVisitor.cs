using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using Antlr4.Runtime.Misc;
using P4.TinyCell.Language.AbstractSyntaxTree;
using P4.TinyCell.Language.AbstractSyntaxTree.Function;
using P4.TinyCell.Language.AbstractSyntaxTree.Types;
using P4.TinyCell.Language.AbstractSyntaxTree.Primitive;

namespace P4.TinyCell.Languages.TinyCell
{
    class TypeCheckerVisitor : AstBaseVisitor<AstNode>
    {
        private List<Function> fTable;

        // private Stack<KeyValuePair> vTable;

        private class Function
        {
            public TcType? Type { get; set; }
            public string? Id { get; set; }
            public List<TcType> Parameters = [];
        }


        public override AstNode VisitFunctionDefinitionNode(FunctionDefinitionNode functionDefinitionNode)
        {
            var function = new Function
            {
                Type = functionDefinitionNode.Type.Type,
                Id = functionDefinitionNode.Identifier.Value,
                Parameters = functionDefinitionNode.ParameterList.Parameters.Select(p => p.TypeNode.Type).ToList()
            };

            fTable.Add(function);

            return base.VisitFunctionDefinitionNode(functionDefinitionNode);
        }

        public static void BuildFunctionTable()
        {

        }

        // public string GetType(AstNode node)
        // {
        //     switch (node)
        //     {
        //         case VoidTypeNode:
        //             return "void";
        //         case BoolTypeNode:
        //             return "bool";
        //         case IntTypeNode:
        //             return "int";
        //         case FloatTypeNode:
        //             return "float";
        //         case PinTypeNode:
        //             return "pin";
        //         case StringTypeNode:
        //             return "string";
        //         default:
        //             return "";
        //     }
        // }
    }
}