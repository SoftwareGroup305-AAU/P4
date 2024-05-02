using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using Antlr4.Runtime.Misc;
using P4.TinyCell.Language.AbstractSyntaxTree;
using P4.TinyCell.Language.AbstractSyntaxTree.Function;
using P4.TinyCell.Language.AbstractSyntaxTree.Types;
using P4.TinyCell.Language.AbstractSyntaxTree.Primitive;
using P4.TinyCell.Language.AbstractSyntaxTree.Expression;
using P4.TinyCell.Language.AbstractSyntaxTree.NumExpr;
using P4.TinyCell.Language.AbstractSyntaxTree.CompExpr;

namespace P4.TinyCell.Languages.TinyCell
{
    class TypeCheckerVisitor : AstBaseVisitor<TcType>
    {
        private List<Function> fTable = [];
        private Stack<KeyValuePair<string, TcType>> vTable = [];

        private class Function
        {
            public TcType? Type { get; set; }
            public string? Id { get; set; }
            public List<TcType> Parameters = [];
        }


        public override TcType VisitFunctionDefinitionNode(FunctionDefinitionNode functionDefinitionNode)
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

        public override TcType VisitRootNode(RootNode rootNode)
        {
            int a = 2;
            return base.VisitRootNode(rootNode);
        }
        public override TcType VisitDeclarationNode(DeclarationNode declarationNode)
        {
            
            var declaredId = declarationNode.Children[1] as IdentifierNode;
            var declaredType = declarationNode.Children[0] as TypeNode;
            vTable.Push(new KeyValuePair<string, TcType>(declaredId.Value, declaredType.Type));
            if (declarationNode.Children.Count > 2)
            {
                var actionType = Visit(declarationNode.Children[2]);
                if (actionType != declaredType.Type)
                {
                    throw new Exception($"Type mismatch: expected {declaredType.Type}, but got {actionType}");
                }
            }
            return declaredType.Type;
        }

        public override TcType VisitOrExprNode(OrExprNode orExprNode)
        {
            var left = Visit(orExprNode.Left);
            var right = Visit(orExprNode.Right);   
            if (left != TcType.BOOL || right != TcType.BOOL)
            {
                throw new Exception($"Type mismatch: comparison between {left} and {right}");
            }
            return TcType.BOOL;
        }

        public override TcType VisitAndExprNode(AndExprNode andExprNode)
        {
            var left = Visit(andExprNode.Left);
            var right = Visit(andExprNode.Right);   
            if (left != TcType.BOOL || right != TcType.BOOL)
            {
                throw new Exception($"Type mismatch: comparison between {left} and {right}");
            }
            return TcType.BOOL;
        }

        public override TcType VisitEqualExprNode(EqualExprNode equalExprNode)
        {
            var left = Visit(equalExprNode.Left);
            var right = Visit(equalExprNode.Right);   
            if (left != right)
            {
                throw new Exception($"Type mismatch: comparison between {left} and {right}");
            }
            return TcType.BOOL;
        }

        public override TcType VisitNotEqualExprNode(NotEqualExprNode notEqualExprNode)
        {
            var left = Visit(notEqualExprNode.Left);
            var right = Visit(notEqualExprNode.Right);   
            if (left != right)
            {
                throw new Exception($"Type mismatch: comparison between {left} and {right}");
            }
            return TcType.BOOL;
        }

        public override TcType VisitLessThanExprNode(LessThanExprNode lessThanExprNode)
        {
            var left = Visit(lessThanExprNode.Left);
            var right = Visit(lessThanExprNode.Right);   
            if (left != right)
            {
                throw new Exception($"Type mismatch: comparison between {left} and {right}");
            }
            return TcType.BOOL;
        }

        public override TcType VisitGreaterThanExprNode(GreaterThanExprNode greaterThanExprNode)
        {
            var left = Visit(greaterThanExprNode.Left);
            var right = Visit(greaterThanExprNode.Right);   
            if (left != right)
            {
                throw new Exception($"Type mismatch: comparison between {left} and {right}");
            }
            return TcType.BOOL;
        }

        public override TcType VisitAddExprNode(AddExprNode addExprNode)
        {
            var left = Visit(addExprNode.Left);
            var right = Visit(addExprNode.Right);   
            if (left != TcType.INT || left != TcType.FLOAT || right != TcType.INT || right != TcType.FLOAT)
            {
                throw new Exception($"Type mismatch: expected {TcType.INT} or {TcType.FLOAT}, but got {left} and {right}");
            }
            return left >= right ? left : right;
        }

        public override TcType VisitGreaterThanEqualExprNode(GreaterThanEqualExprNode greaterThanOrEqualExprNode)
        {
            var left = Visit(greaterThanOrEqualExprNode.Left);
            var right = Visit(greaterThanOrEqualExprNode.Right);   
            if (left != right)
            {
                throw new Exception($"Type mismatch: comparison between {left} and {right}");
            }
            return TcType.BOOL;
        }

        public override TcType VisitLessThanEqualExprNode(LessThanEqualExprNode lessThanOrEqualExprNode)
        {
            var left = Visit(lessThanOrEqualExprNode.Left);
            var right = Visit(lessThanOrEqualExprNode.Right);   
            if (left != right)
            {
                throw new Exception($"Type mismatch: comparison between {left} and {right}");
            }
            return TcType.BOOL;
        }

        public override TcType VisitDivExprNode(DivExprNode divExprNode)
        {
            var left = Visit(divExprNode.Left);
            var right = Visit(divExprNode.Right);   
            if (left != TcType.INT || left != TcType.FLOAT || right != TcType.INT || right != TcType.FLOAT)
            {
                throw new Exception($"Type mismatch: expected {TcType.INT} or {TcType.FLOAT}, but got {left} and {right}");
            }
            return left >= right ? left : right;
        }

        public override TcType VisitSubExprNode(SubExprNode subExprNode)
        {
            var left = Visit(subExprNode.Left);
            var right = Visit(subExprNode.Right);   
            if (left != TcType.INT || left != TcType.FLOAT || right != TcType.INT || right != TcType.FLOAT)
            {
                throw new Exception($"Type mismatch: expected {TcType.INT} or {TcType.FLOAT}, but got {left} and {right}");
            }
            return left >= right ? left : right;
        }

        public override TcType VisitMultExprNode(MultExprNode mulExprNode)
        {
            var left = Visit(mulExprNode.Left);
            var right = Visit(mulExprNode.Right);   
            if (left != TcType.INT || left != TcType.FLOAT || right != TcType.INT || right != TcType.FLOAT)
            {
                throw new Exception($"Type mismatch: expected {TcType.INT} or {TcType.FLOAT}, but got {left} and {right}");
            }
            return left >= right ? left : right;
        }

        public override TcType VisitModExprNode(ModExprNode modExprNode)
        {
            var left = Visit(modExprNode.Left);
            var right = Visit(modExprNode.Right);   
            if (left != TcType.INT || left != TcType.FLOAT || right != TcType.INT || right != TcType.FLOAT)
            {
                throw new Exception($"Type mismatch: expected {TcType.INT} or {TcType.FLOAT}, but got {left} and {right}");
            }
            return left >= right ? left : right;
        }

        public override TcType VisitIdentifierNode(IdentifierNode identifierNode)
        {
            var id = identifierNode.Value;
            var type = vTable.FirstOrDefault(x => x.Key == id);
            if (type.Equals(default(KeyValuePair<string, TcType>)))
            {
                throw new Exception($"Variable {id} not declared");
            }
            return type.Value;
        }

        public override TcType VisitIntNode(IntNode intNode)
        {
            return intNode.Type;
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