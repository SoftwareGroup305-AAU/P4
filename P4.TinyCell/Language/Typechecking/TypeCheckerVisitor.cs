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
using P4.TinyCell.Language.AbstractSyntaxTree.Statement;
using P4.TinyCell.Language.AbstractSyntaxTree.Assignment;
namespace P4.TinyCell.Languages.TinyCell
{
    class TypeCheckerVisitor : AstBaseVisitor<TcType>
    {
        private List<Function> fTable = [];

        private Stack<Stack<KeyValuePair<string, TcType>>> vTableStack = [];
        

        private class Function
        {
            public TcType Type { get; set; }
            public string? Id { get; set; }
            public List<TcType> Parameters = [];
        }

        public override TcType VisitRootNode(RootNode rootNode)
        {
            vTableStack.Push(new Stack<KeyValuePair<string, TcType>>());
            return base.VisitRootNode(rootNode);
        }


        public override TcType VisitFunctionDefinitionNode(FunctionDefinitionNode functionDefinitionNode)
        {
            vTableStack.Push(new Stack<KeyValuePair<string, TcType>>());
            var function = new Function
            {
                Type = functionDefinitionNode.Type.Type,
                Id = functionDefinitionNode.Identifier.Value,
                Parameters = functionDefinitionNode.ParameterList.Parameters.Select(p => p.TypeNode.Type).ToList()
            };
            foreach (var parameter in functionDefinitionNode.ParameterList.Parameters)
            {
                vTableStack.First().Push(new KeyValuePair<string, TcType>(parameter.Identifier.Value, parameter.TypeNode.Type));
            }
            fTable.Add(function);
            Visit(functionDefinitionNode.CompoundStatement);
            vTableStack.Pop();
            return default;
        }


        public override TcType VisitReturnNode(ReturnNode returnNode)
        {
            var returnType = Visit(returnNode.Children[0]);
            if (returnType != fTable.Last().Type)
            {
                throw new Exception($"Type mismatch: Expected return statement of type {fTable.Last().Type}");
            }
            return returnType;
        }

        public override TcType VisitAssignNode(AssignNode assignNode)
        {
            var id = assignNode.Children[0] as IdentifierNode;
            var assignedType = Visit(assignNode.Children[1]);
            KeyValuePair<string, TcType> type = default;
            foreach (var stack in vTableStack)
            {
                type = stack.FirstOrDefault(x => x.Key == id.Value);
                if (!type.Equals(default(KeyValuePair<string, TcType>)))
                {
                    break;
                }
            }
            if (type.Equals(default(KeyValuePair<string, TcType>)))
            {
                throw new Exception($"Variable {id.Value} not declared");
            }
            if (type.Value != assignedType)
                {
                    if (type.Value != TcType.PIN || assignedType != TcType.INT)
                    {
                        throw new Exception($"Type mismatch: expected {type.Value}, but got {assignedType}");
                    }
                }
            return type.Value;
        }

        public override TcType VisitDeclarationNode(DeclarationNode declarationNode)
        {
            
            var declaredId = declarationNode.Children[1] as IdentifierNode;
            var declaredType = declarationNode.Children[0] as TypeNode; 
            if (vTableStack.First().Any(x => x.Key == declaredId.Value))
            {
                throw new Exception($"Variable {declaredId.Value} already declared");
            }
            vTableStack.First().Push(new KeyValuePair<string, TcType>(declaredId.Value, declaredType.Type));
            if (declarationNode.Children.Count > 2)
            {
                var actionType = Visit(declarationNode.Children[2]);

                if (declaredType.Type != TcType.PIN)
                {
                    if (actionType != declaredType.Type)
                {
                    throw new Exception($"Type mismatch: expected {declaredType.Type}, but got {actionType}");
                }
                }
                else if (actionType != TcType.INT)
                {
                    throw new Exception($"Type mismatch: expected {TcType.INT}, but got {actionType}");
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
            if (!(left == TcType.INT || left == TcType.FLOAT) && !(right == TcType.INT || right == TcType.FLOAT))
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
            foreach (var stack in vTableStack)
            {
                var type = stack.FirstOrDefault(x => x.Key == id);
                if (!type.Equals(default(KeyValuePair<string, TcType>)))
                {
                    return type.Value;
                }
            }
            throw new Exception($"Variable {id} not declared");
        }

        public override TcType VisitFunctionCallNode(FunctionCallNode functionCallNode)
        {
            var parameterList = functionCallNode.ArgumentList;
            
            var function = fTable.FirstOrDefault(x => x.Id == functionCallNode.Identifier.Value);
            if (function is null)
            {
                throw new Exception($"Function {functionCallNode.Identifier.Value} not declared");
            }
            if (parameterList is not null)
            {
                if (parameterList.Arguments.Count() != function.Parameters.Count)
                {
                    throw new Exception($"Function {functionCallNode.Identifier.Value} expects {function.Parameters.Count} parameters, but got {parameterList.Arguments.Count()}");
                }
                for (int i = 0; i < parameterList.Arguments.Count(); i++)
                {
                    var parameterType = Visit(parameterList.Arguments[i].Children[i]);
                    if (parameterType != function.Parameters[i])
                    {
                        throw new Exception($"Function {functionCallNode.Identifier.Value} expects parameter {i} to be of type {function.Parameters[i]}, but got {parameterType}");
                    }
                }
            }
            return function.Type;
        }

        public override TcType VisitForStatementNode(ForStatementNode forStatementNode)
        {
            vTableStack.Push(new Stack<KeyValuePair<string, TcType>>());   
            Visit(forStatementNode.Variable);
            Visit(forStatementNode.Condition);
            Visit(forStatementNode.Expression);
            Visit(forStatementNode.CompoundStatement);
            vTableStack.Pop();
            return default;
        }

        public override TcType VisitWhileStatementNode(WhileStatementNode whileStatementNode)
        {
            vTableStack.Push(new Stack<KeyValuePair<string, TcType>>());
            Visit(whileStatementNode.Condition);
            Visit(whileStatementNode.CompoundStatement);
            vTableStack.Pop();
            return default;
        }

        public override TcType VisitIfStatementNode(IfStatementNode ifStatementNode)
        {
            vTableStack.Push(new Stack<KeyValuePair<string, TcType>>());
            Visit(ifStatementNode.Condition);
            Visit(ifStatementNode.TrueExpr);
            if (ifStatementNode.ElseExpr is not null)
            {
                Visit(ifStatementNode.ElseExpr);
            }
            vTableStack.Pop();
            return default;
        }

        public override TcType VisitIntNode(IntNode intNode)
        {
            return intNode.Type;
        }

        public override TcType VisitFloatNode(FloatNode floatNode)
        {
            return floatNode.Type;
        }

        public override TcType VisitStringNode(StringNode stringNode)
        {
            return stringNode.Type;
        }

        public override TcType VisitBoolNode(BoolNode boolNode)
        {
            return boolNode.Type;
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