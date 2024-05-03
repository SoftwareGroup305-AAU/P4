using P4.TinyCell.Language.AbstractSyntaxTree;
using P4.TinyCell.Language.AbstractSyntaxTree.Function;
using P4.TinyCell.Language.AbstractSyntaxTree.Types;
using P4.TinyCell.Language.AbstractSyntaxTree.Primitive;
using P4.TinyCell.Language.AbstractSyntaxTree.Expression;
using P4.TinyCell.Language.AbstractSyntaxTree.NumExpr;
using P4.TinyCell.Language.AbstractSyntaxTree.CompExpr;
using P4.TinyCell.Language.AbstractSyntaxTree.Statement;
using P4.TinyCell.Language.AbstractSyntaxTree.Assignment;
using P4.TinyCell.Language.AbstractSyntaxTree.PinExpr;

namespace P4.TinyCell.Languages.TinyCell
{
    class TypeCheckerVisitor : AstBaseVisitor<TcType>
    {
        private List<Function> fTable = new();
        private Stack<Stack<KeyValuePair<string, TcType>>> vTableStack = new();

        private class Function
        {
            public TcType Type { get; set; }
            public string? Id { get; set; }
            public List<TcType> Parameters { get; set; } = new();
        }

        public override TcType VisitRootNode(RootNode rootNode)
        {
            vTableStack.Push(new Stack<KeyValuePair<string, TcType>>());
            return base.VisitRootNode(rootNode);
        }

        public override TcType VisitFunctionDefinitionNode(FunctionDefinitionNode functionDefinitionNode)
        {
            vTableStack.Push(new Stack<KeyValuePair<string, TcType>>());
            var function = CreateFunction(functionDefinitionNode);
            UpdateFtable(function);
            UpdateVtable(function.Parameters.Select((p, i) => new KeyValuePair<string, TcType>(functionDefinitionNode.ParameterList.Parameters[i].Identifier.Value, p)).ToList());
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
            var idNode = assignNode.Children[0] as IdentifierNode;
            var assignedType = Visit(assignNode.Children[1]);
            var id  = LookupVariable(idNode.Value, vTableStack);
            CheckTypeMismatch(id.Value, assignedType, new List<TcType> {TcType.PIN, TcType.INT});
            return id.Value;
        }

        public override TcType VisitDeclarationNode(DeclarationNode declarationNode)
        {
            
            var declaredIdNode = declarationNode.Children[1] as IdentifierNode;
            var declaredTypeNode = declarationNode.Children[0] as TypeNode; 
            UpdateVtable(new KeyValuePair<string, TcType>(declaredIdNode.Value, declaredTypeNode.Type));
            if (declarationNode.Children.Count > 2)
            {
                var actionType = Visit(declarationNode.Children[2]);
                CheckTypeMismatch(declaredTypeNode.Type, actionType, new List<TcType> {TcType.PIN, TcType.INT});
                
            }
            return declaredTypeNode.Type;
        }

        public override TcType VisitOrExprNode(OrExprNode orExprNode)
        {
            var left = Visit(orExprNode.Left);
            var right = Visit(orExprNode.Right);   
            CheckComparisonTypes(left, right, new List<TcType> {TcType.BOOL});
            return TcType.BOOL;
        }

        public override TcType VisitAndExprNode(AndExprNode andExprNode)
        {
            var left = Visit(andExprNode.Left);
            var right = Visit(andExprNode.Right);   
            CheckComparisonTypes(left, right, new List<TcType> {TcType.BOOL});
            return TcType.BOOL;
        }

        public override TcType VisitEqualExprNode(EqualExprNode equalExprNode)
        {
            var left = Visit(equalExprNode.Left);
            var right = Visit(equalExprNode.Right);   
            CheckComparisonTypes(left, right);
            return TcType.BOOL;
        }

        public override TcType VisitNotEqualExprNode(NotEqualExprNode notEqualExprNode)
        {
            var left = Visit(notEqualExprNode.Left);
            var right = Visit(notEqualExprNode.Right);   
            CheckComparisonTypes(left, right);
            return TcType.BOOL;
        }

        public override TcType VisitLessThanExprNode(LessThanExprNode lessThanExprNode)
        {
            var left = Visit(lessThanExprNode.Left);
            var right = Visit(lessThanExprNode.Right);   
            CheckComparisonTypes(left, right);
            return TcType.BOOL;
        }

        public override TcType VisitGreaterThanExprNode(GreaterThanExprNode greaterThanExprNode)
        {
            var left = Visit(greaterThanExprNode.Left);
            var right = Visit(greaterThanExprNode.Right);   
            CheckComparisonTypes(left, right);
            return TcType.BOOL;
        }

        public override TcType VisitAddExprNode(AddExprNode addExprNode)
        {
            var left = Visit(addExprNode.Left);
            var right = Visit(addExprNode.Right);
            CheckAritmeticOperation(left, right, new List<TcType> {TcType.INT, TcType.FLOAT});
            return left >= right ? left : right;
        }

        public override TcType VisitGreaterThanEqualExprNode(GreaterThanEqualExprNode greaterThanOrEqualExprNode)
        {
            var left = Visit(greaterThanOrEqualExprNode.Left);
            var right = Visit(greaterThanOrEqualExprNode.Right);   
            CheckComparisonTypes(left, right);
            return TcType.BOOL;
        }

        public override TcType VisitLessThanEqualExprNode(LessThanEqualExprNode lessThanOrEqualExprNode)
        {
            var left = Visit(lessThanOrEqualExprNode.Left);
            var right = Visit(lessThanOrEqualExprNode.Right);   
            CheckComparisonTypes(left, right);
            return TcType.BOOL;
        }

        public override TcType VisitDivExprNode(DivExprNode divExprNode)
        {
            var left = Visit(divExprNode.Left);
            var right = Visit(divExprNode.Right);   
            CheckAritmeticOperation(left, right, new List<TcType> {TcType.INT, TcType.FLOAT});
            return left >= right ? left : right;
        }

        public override TcType VisitSubExprNode(SubExprNode subExprNode)
        {
            var left = Visit(subExprNode.Left);
            var right = Visit(subExprNode.Right);   
            CheckAritmeticOperation(left, right, new List<TcType> {TcType.INT, TcType.FLOAT});
            return left >= right ? left : right;
        }

        public override TcType VisitMultExprNode(MultExprNode mulExprNode)
        {
            var left = Visit(mulExprNode.Left);
            var right = Visit(mulExprNode.Right);   
            CheckAritmeticOperation(left, right, new List<TcType> {TcType.INT, TcType.FLOAT});
            return left >= right ? left : right;
        }

        public override TcType VisitModExprNode(ModExprNode modExprNode)
        {
            var left = Visit(modExprNode.Left);
            var right = Visit(modExprNode.Right);   
            CheckAritmeticOperation(left, right, new List<TcType> {TcType.INT});
            return left >= right ? left : right;
        }

        public override TcType VisitIdentifierNode(IdentifierNode identifierNode)
        {
            var id = identifierNode.Value;
            return LookupVariable(id, vTableStack).Value;
        }

        public override TcType VisitFunctionCallNode(FunctionCallNode functionCallNode)
        {
            var argumentList = functionCallNode.ArgumentList;
            var function = LookupFunction(functionCallNode.Identifier.Value, fTable);
            CheckFunctionArguments(function.Parameters, argumentList);
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

        public override TcType VisitPlusAssignNode(PlusAssignNode plusAssignNode)
        {
            var idNode = plusAssignNode.Identifier;
            var id = LookupVariable(idNode.Value, vTableStack);
            var assignedTypeNode = Visit(plusAssignNode.Expression);
            CheckAritmeticOperation(id.Value, assignedTypeNode, new List<TcType> {TcType.INT, TcType.PIN});
            return id.Value;
        }

        public override TcType VisitMinusAssignNode(MinusAssignNode minusAssignNode)
        {
            var idNode = minusAssignNode.Identifier;
            var id = LookupVariable(idNode.Value, vTableStack);
            var assignedTypeNode = Visit(minusAssignNode.Expression);
            CheckAritmeticOperation(id.Value, assignedTypeNode, new List<TcType> {TcType.INT, TcType.PIN});
            return id.Value;
        }

        public override TcType VisitMultAssignNode(MultAssignNode multAssignNode)
        {
            var idNode = multAssignNode.Identifier;
            var id = LookupVariable(idNode.Value, vTableStack);
            var assignedTypeNode = Visit(multAssignNode.Expression);
            CheckAritmeticOperation(id.Value, assignedTypeNode, new List<TcType> {TcType.INT, TcType.PIN});
            return id.Value;
        }

        public override TcType VisitDivAssignNode(DivAssignNode divAssignNode)
        {
            var idNode = divAssignNode.Identifier;
            var id = LookupVariable(idNode.Value, vTableStack);
            var assignedTypeNode = Visit(divAssignNode.Expression);
            CheckAritmeticOperation(id.Value, assignedTypeNode, new List<TcType> {TcType.INT, TcType.PIN});
            return id.Value;
        }


        public override TcType VisitPinModeExprNode(PinModeExprNode pinModeExprNode)
        {
            var id = pinModeExprNode.Identifier;
            KeyValuePair<string, TcType> type = default;
            foreach (var stack in vTableStack)
            {
                type = stack.FirstOrDefault(pair => pair.Key == id.Value);
            }
            if (type.Equals(default(KeyValuePair<string, TcType>)))
            {
                throw new Exception($"Variable '{id.Value}' not declared");
            }
            if (type.Value != TcType.PIN)
            {
                throw new Exception($"Variable '{id.Value}' is not of type pin");
            }
            return type.Value;
        }

        private KeyValuePair<string, TcType> LookupVariable(string id, Stack<Stack<KeyValuePair<string, TcType>>> vTableStack)
        {
            foreach (var stack in vTableStack)
            {
                var type = stack.FirstOrDefault(x => x.Key == id);
                if (!type.Equals(default(KeyValuePair<string, TcType>)))
                {
                    return type;
                }
            }
            throw new Exception($"Variable '{id}' not declared");
        }

        private void CheckTypeMismatch(TcType expectedType, TcType actualType, List<TcType> exceptions = null)
        {
            if (expectedType != actualType)
            {
                if (exceptions is not null && exceptions.Contains(actualType) && exceptions.Contains(expectedType))
                {
                   return;
                }
                 throw new Exception($"Type mismatch: expected {expectedType}, but got {actualType}");     
            }
        }



        /// <summary>
        /// Looks up a function in the function table
        /// </summary>
        /// <param name="id">Function identifier</param>
        /// <returns>Returns <see cref="Function" no null if no function was found /></returns>
        private Function? LookupFunction(string id, List<Function> fTable)
        {
            var function = fTable.FirstOrDefault(x => x.Id == id);
            if (function is null)
            {
                throw new Exception($"Function '{id}' not declared");
            }
            return function;
        }

        private void CheckFunctionArguments(List<TcType> parameters, ArgumentListNode argumentList)
        {
            if (argumentList is not null)
            {
            if (argumentList.Arguments.Count() != parameters.Count)
            {
                throw new Exception($"Function expects {parameters.Count} parameters, but got {argumentList.Arguments.Count()}");
            }
            for (int i = 0; i < argumentList.Arguments.Count(); i++)
            {
                var parameterType = Visit(argumentList.Arguments[i].Children[i]);
                if (parameterType != parameters[i])
                {
                throw new Exception($"Function expects parameter {i} to be of type {parameters[i]}, but got {parameterType}");
                }
            }
            }
        }

        private void CheckAritmeticOperation(TcType left, TcType right, List<TcType> expectedTypes)
        {
            if (!expectedTypes.Contains(left) || !expectedTypes.Contains(right))
            {
                throw new Exception($"Type mismatch: expected {expectedTypes.ToString}, but got {left} and {right}");
            }
        }

        private void UpdateFtable(Function function)
        {
            if (fTable.Any(f => f.Id == function.Id))
            {
                throw new Exception($"Function '{function.Id}' has already been declared");
            }
            fTable.Add(function);
        }

        private void UpdateVtable(List<KeyValuePair<string, TcType>> variables)
        {
            foreach (var variable in variables)
            {
                if (vTableStack.First().Any(x => x.Key == variable.Key))
                {
                    throw new Exception($"Variable '{variable.Key}' already declared");
                }
                vTableStack.First().Push(variable);
            }
        }

        private void UpdateVtable(KeyValuePair<string, TcType> variable)
        {
            if (vTableStack.First().Any(x => x.Key == variable.Key))
            {
                throw new Exception($"Variable '{variable.Key}' already declared");
            }
            vTableStack.First().Push(variable);
        }

        private void CheckComparisonTypes(TcType left, TcType right, List<TcType> expectedTypes = null)
        {
            if (expectedTypes is not null && (!expectedTypes.Contains(left) || !expectedTypes.Contains(right)))
            {
                throw new Exception($"Type mismatch: comparison between {left} and {right}, expected {expectedTypes.ToString()}");
            }
            if (left != right)
            {
                throw new Exception($"Type mismatch: comparison between {left} and {right}");
            }
        }

        private Function CreateFunction(FunctionDefinitionNode functionDefinitionNode)
        {
            return new Function
            {
                Type = functionDefinitionNode.Type.Type,
                Id = functionDefinitionNode.Identifier.Value,
                Parameters = functionDefinitionNode.ParameterList.Parameters.Select(p => p.TypeNode.Type).ToList()
            };
        }
    }
}