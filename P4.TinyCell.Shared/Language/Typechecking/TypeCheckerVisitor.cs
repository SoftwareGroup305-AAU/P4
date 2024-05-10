using P4.TinyCell.Shared.Language.AbstractSyntaxTree;
using P4.TinyCell.Shared.Language.AbstractSyntaxTree.Function;
using P4.TinyCell.Shared.Language.AbstractSyntaxTree.Types;
using P4.TinyCell.Shared.Language.AbstractSyntaxTree.Primitive;
using P4.TinyCell.Shared.Language.AbstractSyntaxTree.Expression;
using P4.TinyCell.Shared.Language.AbstractSyntaxTree.NumExpr;
using P4.TinyCell.Shared.Language.AbstractSyntaxTree.CompExpr;
using P4.TinyCell.Shared.Language.AbstractSyntaxTree.Statement;
using P4.TinyCell.Shared.Language.AbstractSyntaxTree.Assignment;
using P4.TinyCell.Shared.Language.AbstractSyntaxTree.PinExpr;
using P4.TinyCell.Shared.Language.AbstractSyntaxTree.UnaryExpr;
using Antlr4.Runtime;
using P4.TinyCell.Shared.Utilities;

namespace P4.TinyCell.Shared.Language.Typechecking
{
    public class TypeCheckerVisitor : AstBaseVisitor<TcType>
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
            try
            {
                var function = CreateFunction(functionDefinitionNode);
                UpdateFtable(function);
                UpdateVtable(function.Parameters.Select((p, i) => new KeyValuePair<string, TcType>(functionDefinitionNode.ParameterList.Parameters[i].Identifier.Value, p)).ToList());
                if (functionDefinitionNode.CompoundStatement is not null)
                {
                    Visit(functionDefinitionNode.CompoundStatement);
                }

                if (function.Type != TcType.VOID && !AllPathsReturn(functionDefinitionNode.CompoundStatement))
                {
                    throw new Exception("not all paths return a value");
                }
            }
            catch (Exception e)
            {
                throw new Exception($"In function '{functionDefinitionNode.Identifier.Value}' -> {e.Message}");
            }
            vTableStack.Pop();
            return default;
        }

        private bool ContainsIdentifier(AstNode expression)
        {
            if (expression is IdentifierNode)
            {
                return true;
            }
            foreach (var child in expression.Children)
            {
                if (ContainsIdentifier(child))
                {
                    return true;
                }
            }
            return false;
        }

        public override TcType VisitReturnNode(ReturnNode returnNode)
        {
            if (returnNode.Children.Count == 0)
            {
                return TcType.VOID;
            }
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
            try
            {
                var assignedType = Visit(assignNode.Children[1]);
                var id = LookupVariable(idNode.Value, vTableStack);
                CheckTypeMismatch(id.Value, assignedType, new List<TcType> { TcType.APIN, TcType.DPIN, TcType.INT });
                return id.Value;
            }
            catch (Exception e)
            {
                throw new Exception($"While assigning to '{idNode.Value}' -> {e.Message}");
            }
        }

        public override TcType VisitDeclarationNode(DeclarationNode declarationNode)
        {

            var declaredIdNode = declarationNode.Children[1] as IdentifierNode;
            var declaredTypeNode = declarationNode.Children[0] as TypeNode;
            try
            {
                UpdateVtable(new KeyValuePair<string, TcType>(declaredIdNode.Value, declaredTypeNode.Type));
                if (declarationNode.Children.Count > 2)
                {
                    var actionType = Visit(declarationNode.Children[2]);
                    CheckTypeMismatch(declaredTypeNode.Type, actionType, new List<TcType> { TcType.APIN, TcType.DPIN, TcType.INT });

                }
            }
            catch (Exception e)
            {
                throw new Exception($"While declaring '{declaredIdNode.Value}' -> {e.Message}");
            }
            return declaredTypeNode.Type;
        }

        public override TcType VisitOrExprNode(OrExprNode orExprNode)
        {
            var left = Visit(orExprNode.Left);
            var right = Visit(orExprNode.Right);
            CheckComparisonTypes(left, right, new List<TcType> { TcType.BOOL });
            return TcType.BOOL;
        }

        public override TcType VisitAndExprNode(AndExprNode andExprNode)
        {
            var left = Visit(andExprNode.Left);
            var right = Visit(andExprNode.Right);
            CheckComparisonTypes(left, right, new List<TcType> { TcType.BOOL });
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
            CheckAritmeticOperation(left, right, new List<TcType> { TcType.INT, TcType.FLOAT });
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
            CheckAritmeticOperation(left, right, new List<TcType> { TcType.INT, TcType.FLOAT });
            return left >= right ? left : right;
        }

        public override TcType VisitSubExprNode(SubExprNode subExprNode)
        {
            var left = Visit(subExprNode.Left);
            var right = Visit(subExprNode.Right);
            CheckAritmeticOperation(left, right, new List<TcType> { TcType.INT, TcType.FLOAT });
            return left >= right ? left : right;
        }

        public override TcType VisitMultExprNode(MultExprNode mulExprNode)
        {
            var left = Visit(mulExprNode.Left);
            var right = Visit(mulExprNode.Right);
            CheckAritmeticOperation(left, right, new List<TcType> { TcType.INT, TcType.FLOAT });
            return left >= right ? left : right;
        }

        public override TcType VisitModExprNode(ModExprNode modExprNode)
        {
            var left = Visit(modExprNode.Left);
            var right = Visit(modExprNode.Right);
            CheckAritmeticOperation(left, right, new List<TcType> { TcType.INT });
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
            VisitChildren(forStatementNode);
            vTableStack.Pop();
            return default;
        }

        public override TcType VisitWhileStatementNode(WhileStatementNode whileStatementNode)
        {
            vTableStack.Push(new Stack<KeyValuePair<string, TcType>>());
            VisitChildren(whileStatementNode);
            vTableStack.Pop();
            return default;
        }

        public override TcType VisitIfStatementNode(IfStatementNode ifStatementNode)
        {
            vTableStack.Push(new Stack<KeyValuePair<string, TcType>>());
            VisitChildren(ifStatementNode);
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
            CheckAritmeticOperation(id.Value, assignedTypeNode, new List<TcType> { TcType.INT, TcType.DPIN, TcType.APIN });
            return id.Value;
        }

        public override TcType VisitMinusAssignNode(MinusAssignNode minusAssignNode)
        {
            var idNode = minusAssignNode.Identifier;
            var id = LookupVariable(idNode.Value, vTableStack);
            var assignedTypeNode = Visit(minusAssignNode.Expression);
            CheckAritmeticOperation(id.Value, assignedTypeNode, new List<TcType> { TcType.INT, TcType.DPIN, TcType.APIN });
            return id.Value;
        }

        public override TcType VisitMultAssignNode(MultAssignNode multAssignNode)
        {
            var idNode = multAssignNode.Identifier;
            var id = LookupVariable(idNode.Value, vTableStack);
            var assignedTypeNode = Visit(multAssignNode.Expression);
            CheckAritmeticOperation(id.Value, assignedTypeNode, new List<TcType> { TcType.INT, TcType.APIN, TcType.DPIN });
            return id.Value;
        }

        public override TcType VisitDivAssignNode(DivAssignNode divAssignNode)
        {
            var idNode = divAssignNode.Identifier;
            var id = LookupVariable(idNode.Value, vTableStack);
            var assignedTypeNode = Visit(divAssignNode.Expression);
            CheckAritmeticOperation(id.Value, assignedTypeNode, new List<TcType> { TcType.INT, TcType.APIN, TcType.DPIN });
            return id.Value;
        }


        public override TcType VisitPinModeExprNode(PinModeExprNode pinModeExprNode)
        {
            var id = LookupVariable(pinModeExprNode.Identifier.Value, vTableStack);
            if (id.Value != TcType.APIN && id.Value != TcType.DPIN)
            {
                throw new Exception($"Variable '{pinModeExprNode.Identifier.Value}' is not a 'pin'");
            }
            return default;
        }

        public override TcType VisitPinWriteExprNode(PinWriteExprNode pinWriteExprNode)
        {
            var toType = Visit(pinWriteExprNode.To);
            if (toType == TcType.DPIN)
            {
                if (pinWriteExprNode.From is not VoltageNode || pinWriteExprNode.From is not BoolNode)
                {
                    throw new Exception($"Variable '{pinWriteExprNode.To/*.Value*/}' is a 'digital pin' and expects a 'voltage' or 'bool'");
                }
                return default;
            }
            if (toType == TcType.APIN)
            {
                var valueType = Visit(pinWriteExprNode.From);
                if (valueType != TcType.INT)
                {
                    throw new Exception($"Variable '{pinWriteExprNode.To/*.Value*/}' is an 'analog pin' and expects an 'int'");
                }
                return default;
            }
            throw new Exception($"Variable '{pinWriteExprNode.To/*.Value*/}' is not a 'pin'");
        }

        public override TcType VisitPinReadExprNode(PinReadExprNode pinReadExprNode)
        {
            var toType = Visit(pinReadExprNode.To);
            var fromType = Visit(pinReadExprNode.From);
            if (fromType == TcType.DPIN)
            {
                CheckComparisonTypes(toType, fromType, new List<TcType> { TcType.BOOL, TcType.DPIN });
                return default;
            }
            if (fromType == TcType.APIN)
            {
                CheckComparisonTypes(toType, fromType, new List<TcType> { TcType.INT, TcType.APIN });
                return default;
            }
            throw new Exception($"Variable '{pinReadExprNode.To}' is not a pin");
        }

        public override TcType VisitIncludeNode(IncludeNode includeNode)
        {
            AstNode includeAst = AstHelper.GetAstFromFile(includeNode.FileName);
            Visit(includeAst);
            return default;
        }

        private static KeyValuePair<string, TcType> LookupVariable(string id, Stack<Stack<KeyValuePair<string, TcType>>> vTableStack)
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

        private static void CheckTypeMismatch(TcType expectedType, TcType actualType, List<TcType> exceptions = null)
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
        /// <returns>Function matching id</returns>
        private static Function LookupFunction(string id, List<Function> fTable)
        {
            var function = fTable.FirstOrDefault(x => x.Id == id);
            if (function is null)
            {
                throw new Exception($"Function '{id}' not declared");
            }
            return function;
        }

        /// <summary>
        /// Checks if the arguments of a function call match the expected parameters
        /// </summary>
        /// <param name="parameters">Declared function parameters</param>
        /// <param name="argumentList">called function argument node</param>
        /// <exception cref="Exception"></exception>
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
                    var parameterType = Visit(argumentList.Arguments[i].Children[0]);
                    if (parameterType != parameters[i])
                    {
                        throw new Exception($"Function expects parameter {i + 1} to be of type {parameters[i]}, but got {parameterType}");
                    }
                }
            }
        }


        private static void CheckAritmeticOperation(TcType left, TcType right, List<TcType> expectedTypes)
        {
            if (!expectedTypes.Contains(left) || !expectedTypes.Contains(right))
            {
                throw new Exception($"Type mismatch: expected {string.Join(", ", expectedTypes)}, but got {left} and {right}");
            }
        }
        /// <summary>
        /// Updates the function table with a new function
        /// </summary>
        /// <param name="function"></param>
        /// <exception cref="Exception"></exception>
        private void UpdateFtable(Function function)
        {
            if (fTable.Any(f => f.Id == function.Id))
            {
                throw new Exception($"Function '{function.Id}' has already been declared");
            }
            fTable.Add(function);
        }

        /// <summary>
        /// Updates the variable table with a list of variables
        /// </summary>
        /// <param name="variables"></param>
        /// <exception cref="Exception"></exception>
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
        /// <summary>
        /// Updates the variable table with a single variable
        /// </summary>
        /// <param name="variable"></param>
        /// <exception cref="Exception"></exception>
        private void UpdateVtable(KeyValuePair<string, TcType> variable)
        {
            if (vTableStack.First().Any(x => x.Key == variable.Key))
            {
                throw new Exception($"Variable '{variable.Key}' already declared");
            }
            vTableStack.First().Push(variable);
        }


        private static void CheckComparisonTypes(TcType left, TcType right, List<TcType> expectedTypes = null)
        {
            if (expectedTypes is not null && (!expectedTypes.Contains(left) || !expectedTypes.Contains(right)))
            {
                throw new Exception($"Type mismatch: comparison between {left} and {right}, expected ({string.Join(", ", expectedTypes)})");
            }
            if (left != right && expectedTypes is null)
            {
                throw new Exception($"Type mismatch: comparison between {left} and {right}");
            }
        }

        /// <summary>
        /// Creates a function object from a function definition node
        /// </summary>
        /// <param name="functionDefinitionNode"></param>
        /// <returns></returns>
        private static Function CreateFunction(FunctionDefinitionNode functionDefinitionNode)
        {
            return new Function
            {
                Type = functionDefinitionNode.Type.Type,
                Id = functionDefinitionNode.Identifier.Value,
                Parameters = functionDefinitionNode.ParameterList.Parameters.Select(p => p.TypeNode.Type).ToList()
            };
        }

        /// <summary>
        /// Checks if all code paths in a function definition return a value
        /// </summary>
        /// <param name="functionBody"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        private bool AllPathsReturn(AstNode functionBody)
        {
            foreach (var statement in functionBody.Children)
            {
                if (statement is IfStatementNode ifStatementNode && !ContainsIdentifier(ifStatementNode.Condition))
                {
                    if (EvaluateCondition(ifStatementNode.Condition) == 1)
                    {
                        return AllPathsReturn(ifStatementNode.TrueExpr);
                    }
                    else if (ifStatementNode.ElseExpr is not null)
                    {
                        return AllPathsReturn(ifStatementNode.ElseExpr);
                    }
                }
                else if (statement is WhileStatementNode whileStatementNode && !ContainsIdentifier(whileStatementNode.Condition))
                {
                    if (EvaluateCondition(whileStatementNode.Condition) == 1)
                    {
                        if (!AllPathsReturn(whileStatementNode.CompoundStatement))
                        {
                            throw new Exception("possible infinite loop in 'while' statement");
                        }
                        else
                        {
                            return true;
                        }
                    }
                }
                if (statement is ForStatementNode forStatementNode && !ContainsIdentifier(forStatementNode.Condition))
                {
                    if (EvaluateCondition(forStatementNode.Condition) == 1)
                    {
                        if (!AllPathsReturn(forStatementNode.CompoundStatement))
                        {
                            throw new Exception("possible infinite loop in 'for' statement");
                        }
                        else
                        {
                            return true;
                        }
                    }
                }
                else if (statement is ReturnNode || (!IsConditional(statement) && AllPathsReturn(statement)))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Evaluates a condition of a conditional statemnt in case it is static
        /// </summary>
        /// <param name="condition"></param>
        /// <returns>1 if the condition is true, 0 if it is false</returns>
        /// <exception cref="Exception"></exception>
        private int EvaluateCondition(AstNode condition)
        {
            if (condition is AddExprNode or SubExprNode or MultExprNode or DivExprNode or ModExprNode)
            {
                throw new Exception("Condition must evaluate to a boolean value");
            }
            return EvaluateConditionHelper(condition);



        }

        /// <summary>
        /// Evaluates a condition of a conditional statement, recursively, given it is static. Used by <see cref="EvaluateCondition"/>
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        private int EvaluateConditionHelper(AstNode condition)
        {
            return condition switch
            {
                IntNode intNode => intNode.Value,
                OrExprNode orExprNode => EvaluateConditionHelper(orExprNode.Left) | EvaluateConditionHelper(orExprNode.Right),
                AndExprNode andExprNode => EvaluateConditionHelper(andExprNode.Left) & EvaluateConditionHelper(andExprNode.Right),
                NotExprNode notExprNode => ~EvaluateConditionHelper(notExprNode.Operand),
                EqualExprNode equalExprNode => EvaluateConditionHelper(equalExprNode.Left) == EvaluateConditionHelper(equalExprNode.Right) ? 1 : 0,
                NotEqualExprNode notEqualExprNode => EvaluateConditionHelper(notEqualExprNode.Left) != EvaluateConditionHelper(notEqualExprNode.Right) ? 1 : 0,
                LessThanExprNode lessThanExprNode => EvaluateConditionHelper(lessThanExprNode.Left) < EvaluateConditionHelper(lessThanExprNode.Right) ? 1 : 0,
                GreaterThanExprNode greaterThanExprNode => EvaluateConditionHelper(greaterThanExprNode.Left) > EvaluateConditionHelper(greaterThanExprNode.Right) ? 1 : 0,
                GreaterThanEqualExprNode greaterThanOrEqualExprNode => EvaluateConditionHelper(greaterThanOrEqualExprNode.Left) >= EvaluateConditionHelper(greaterThanOrEqualExprNode.Right) ? 1 : 0,
                LessThanEqualExprNode lessThanOrEqualExprNode => EvaluateConditionHelper(lessThanOrEqualExprNode.Left) <= EvaluateConditionHelper(lessThanOrEqualExprNode.Right) ? 1 : 0,
                AddExprNode addExprNode => EvaluateConditionHelper(addExprNode.Left) + EvaluateConditionHelper(addExprNode.Right),
                SubExprNode subExprNode => EvaluateConditionHelper(subExprNode.Left) - EvaluateConditionHelper(subExprNode.Right),
                MultExprNode multExprNode => EvaluateConditionHelper(multExprNode.Left) * EvaluateConditionHelper(multExprNode.Right),
                DivExprNode divExprNode => EvaluateConditionHelper(divExprNode.Left) / EvaluateConditionHelper(divExprNode.Right),
                ModExprNode modExprNode => EvaluateConditionHelper(modExprNode.Left) % EvaluateConditionHelper(modExprNode.Right),
                BoolNode boolNode => boolNode.Value ? 1 : 0,
                _ => throw new Exception("Invalid condition")
            };
        }

        /// <summary>
        /// Checks if a statement is a conditional statement
        /// </summary>
        /// <param name="statement"></param>
        /// <returns></returns>
        private bool IsConditional(AstNode statement)
        {
            return statement is IfStatementNode or WhileStatementNode or ForStatementNode;
        }
    }
}