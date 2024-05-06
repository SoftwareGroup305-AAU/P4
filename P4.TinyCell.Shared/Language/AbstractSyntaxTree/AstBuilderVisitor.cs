// using Antlr4.Runtime.Misc;
// using Antlr4.Runtime.Tree;
// using P4.TinyCell.Shared.Language.AbstractSyntaxTree.Assignment;
// using P4.TinyCell.Shared.Language.AbstractSyntaxTree.BitwiseExpr;
// using P4.TinyCell.Shared.Language.AbstractSyntaxTree.CompExpr;
// using P4.TinyCell.Shared.Language.AbstractSyntaxTree.Expression;
// using P4.TinyCell.Shared.Language.AbstractSyntaxTree.Function;
// using P4.TinyCell.Shared.Language.AbstractSyntaxTree.NumExpr;
// using P4.TinyCell.Shared.Language.AbstractSyntaxTree.ParameterNodes;
// using P4.TinyCell.Shared.Language.AbstractSyntaxTree.PinExpr;
// using P4.TinyCell.Shared.Language.AbstractSyntaxTree.Primitive;
// using P4.TinyCell.Shared.Language.AbstractSyntaxTree.Statement;
// using P4.TinyCell.Shared.Language.AbstractSyntaxTree.Types;
// using P4.TinyCell.Shared.Language.AbstractSyntaxTree.UnaryExpr;
// using System.Globalization;

// namespace P4.TinyCell.Shared.Language.AbstractSyntaxTree;

// public class AstBuilderVisitor : TinyCellBaseVisitor<AstNode>
// {
//     public override AstNode VisitAdditiveExpression([NotNull] TinyCellParser.AdditiveExpressionContext context)
//     {
//         if (context.PLUS() is not null)
//         {
//             return new AddExprNode(Visit(context.additiveExpression()), Visit(context.multiplicativeExpression()));
//         }
//         if (context.MINUS() is not null)
//         {
//             return new SubExprNode(Visit(context.additiveExpression()), Visit(context.multiplicativeExpression()));
//         }
//         return Visit(context.multiplicativeExpression());
//     }

//     public override AstNode VisitAndExpression([NotNull] TinyCellParser.AndExpressionContext context)
//     {
//         if (context.AND() is not null)
//         {
//             return new AndExprNode(Visit(context.andExpression()), Visit(context.equalityExpression()));
//         }
//         return Visit(context.equalityExpression());
//     }

//     public override AstNode VisitArgument([NotNull] TinyCellParser.ArgumentContext context)
//     {
//         if (context.identifier() is not null)
//         {
//             return new ArgumentNode(Visit(context.identifier()));
//         }

//         if (context.functionCall() is not null)
//         {
//             return new ArgumentNode(Visit(context.functionCall()));
//         }

//         if (context.Numeral() is not null)
//         {
//             return new ArgumentNode(Visit(context.Numeral()));
//         }

//         if (context.String() is not null)
//         {
//             return new ArgumentNode(Visit(context.String()));
//         }

//         return new ArgumentNode(Visit(context.Bool()));
//     }

//     public override AstNode VisitArgumentList([NotNull] TinyCellParser.ArgumentListContext context)
//     {
//         var arguments = new List<ArgumentNode>();

//         if (context.argumentList() is not null)
//         {
//             var argumentListNode = Visit(context.argumentList()) as ArgumentListNode;
//             arguments.AddRange(argumentListNode.Arguments);
//         }

//         arguments.Add((ArgumentNode)Visit(context.argument()));

//         return new ArgumentListNode([.. arguments]);
//     }

//     public override AstNode VisitAssignment([NotNull] TinyCellParser.AssignmentContext context)
//     {
//         if (context.assignmentOperator().ASSIGN() is not null)
//         {
//             return new AssignNode((IdentifierNode)Visit(context.identifier()), Visit(context.expression()));
//         }

//         if (context.assignmentOperator().MULTASSIGN() is not null)
//         {
//             return new MultAssignNode((IdentifierNode)Visit(context.identifier()), Visit(context.expression()));
//         }

//         if (context.assignmentOperator().DIVASSIGN() is not null)
//         {
//             return new DivAssignNode((IdentifierNode)Visit(context.identifier()), Visit(context.expression()));
//         }

//         if (context.assignmentOperator().PLUSASSIGN() is not null)
//         {
//             return new PlusAssignNode((IdentifierNode)Visit(context.identifier()), Visit(context.expression()));
//         }

//         return new MinusAssignNode((IdentifierNode)Visit(context.identifier()), Visit(context.expression()));
//     }

//     public override AstNode VisitBitshiftExpression([NotNull] TinyCellParser.BitshiftExpressionContext context)
//     {
//         if (context.BITSHIFTL() is not null)
//         {
//             return new BitshiftLExprNode(Visit(context.bitshiftExpression()), Visit(context.additiveExpression()));
//         }
//         if (context.BITSHIFTR() is not null)
//         {
//             return new BitshiftRExprNode(Visit(context.bitshiftExpression()), Visit(context.additiveExpression()));
//         }
//         return Visit(context.additiveExpression());
//     }

//     public override AstNode VisitComparisonExpression([NotNull] TinyCellParser.ComparisonExpressionContext context)
//     {
//         if (context.LT() is not null)
//         {
//             return new LessThanExprNode(Visit(context.comparisonExpression()), Visit(context.bitshiftExpression()));
//         }
//         if (context.GT() is not null)
//         {
//             return new GreaterThanExprNode(Visit(context.comparisonExpression()), Visit(context.bitshiftExpression()));
//         }
//         if (context.LTE() is not null)
//         {
//             return new LessThanEqualExprNode(Visit(context.comparisonExpression()), Visit(context.bitshiftExpression()));
//         }
//         if (context.GTE() is not null)
//         {
//             return new GreaterThanEqualExprNode(Visit(context.comparisonExpression()), Visit(context.bitshiftExpression()));
//         }

//         return Visit(context.bitshiftExpression());
//     }

//     public override AstNode VisitCompoundStatement([NotNull] TinyCellParser.CompoundStatementContext context)
//     {
//         return new StatementCollectionNode(context.statement().Select(Visit).ToArray());
//     }

//     public override AstNode VisitDeclaration([NotNull] TinyCellParser.DeclarationContext context)
//     {
//         InitialDeclerationNode initialDecleration = Visit(context.initialDeclaration()) as InitialDeclerationNode;
//         if (initialDecleration.Action is not null)
//         {
//             return new DeclarationNode((TypeNode)Visit(context.type()), (IdentifierNode)initialDecleration.Identifier, initialDecleration.Action);
//         }
//         return new DeclarationNode((TypeNode)Visit(context.type()), (IdentifierNode)initialDecleration.Identifier);
//     }

//     public override AstNode VisitDocument([NotNull] TinyCellParser.DocumentContext context)
//     {
//         RootNode document = new();
//         foreach (var child in context.children)
//         {
//             AstNode childNode = Visit(child);
//             document.AddChild(childNode);
//         }
//         return document;
//     }

//     public override AstNode VisitEqualityExpression([NotNull] TinyCellParser.EqualityExpressionContext context)
//     {
//         if (context.EQ() is not null)
//         {
//             return new EqualExprNode(Visit(context.equalityExpression()), Visit(context.comparisonExpression()));
//         }
//         if (context.NEQ() is not null)
//         {
//             return new NotEqualExprNode(Visit(context.equalityExpression()), Visit(context.comparisonExpression()));
//         }
//         return Visit(context.comparisonExpression());
//     }

//     public override AstNode VisitExpression([NotNull] TinyCellParser.ExpressionContext context)
//     {
//         return Visit(context.ternaryExpression());
//     }

//     public override AstNode VisitFunctionCall([NotNull] TinyCellParser.FunctionCallContext context)
//     {
//         IEnumerable<ArgumentNode>? allArguments = context.argumentList()?.Select(al => (ArgumentListNode)Visit(al)).Select(al => al.Arguments).SelectMany(x => x) ?? null;
//         ArgumentListNode? aggregatedArgumentList = allArguments is not null ? new(allArguments.ToArray()) : null;

//         return new FunctionCallNode((IdentifierNode)Visit(context.identifier()), aggregatedArgumentList);
//     }

//     public override AstNode VisitFunctionDefinition([NotNull] TinyCellParser.FunctionDefinitionContext context)
//     {
//         var allParameters = context.parameterList().Select(al => (ParameterListNode)Visit(al)).Select(al => al.Parameters).SelectMany(x => x).Cast<ParameterNode>();
//         ParameterListNode aggregatedParameterList = new(allParameters.ToArray());

//         return new FunctionDefinitionNode((TypeNode)Visit(context.type()), (IdentifierNode)Visit(context.identifier()), aggregatedParameterList, (StatementCollectionNode)Visit(context.compoundStatement()));
//     }

//     public override AstNode VisitGeneralDeclaration([NotNull] TinyCellParser.GeneralDeclarationContext context)
//     {
//         if (context.functionDefinition() is not null)
//         {
//             return Visit(context.functionDefinition());
//         }
//         return Visit(context.declaration());
//     }

//     public override AstNode VisitIdentifier([NotNull] TinyCellParser.IdentifierContext context)
//     {
//         return new IdentifierNode(context.GetText());
//     }

//     public override AstNode VisitIfStatement([NotNull] TinyCellParser.IfStatementContext context)
//     {
//         if (context.ELSE() is not null)
//         {
//             return new IfStatementNode(Visit(context.expression()), Visit(context.compoundStatement().First()), Visit(context.compoundStatement().Last()));
//         }
//         return new IfStatementNode(Visit(context.expression()), Visit(context.compoundStatement().First()), null);
//     }

//     public override AstNode VisitInitialDeclaration([NotNull] TinyCellParser.InitialDeclarationContext context)
//     {
//         if (context.ASSIGN() is not null)
//         {
//             AstNode action = context.expression() is not null ? Visit(context.expression()) : Visit(context.functionCall());
//             return new InitialDeclerationNode(Visit(context.identifier()), action);
//         }
//         return new InitialDeclerationNode(Visit(context.identifier()));
//     }

//     public override AstNode VisitJumpStatement([NotNull] TinyCellParser.JumpStatementContext context)
//     {
//         if (context.CONTINUE() is not null)
//         {
//             return new ContinueNode();
//         }
//         if (context.BREAK() is not null)
//         {
//             return new BreakNode();
//         }
//         if (context.expression() is not null)
//         {
//             return new ReturnNode(Visit(context.expression()));
//         }
//         return new ReturnNode();
//     }

//     public override AstNode VisitLoopStatement([NotNull] TinyCellParser.LoopStatementContext context)
//     {
//         if (context.WHILE() is not null)
//         {
//             return new WhileStatementNode(Visit(context.expression().First()), Visit(context.compoundStatement()));
//         }

//         return new ForStatementNode(Visit(context.GetChild(2)), Visit(context.GetChild(4)), Visit(context.GetChild(6)), Visit(context.GetChild(8)));
//     }

//     public override AstNode VisitMultiplicativeExpression([NotNull] TinyCellParser.MultiplicativeExpressionContext context)
//     {
//         if (context.MULT() is not null)
//         {
//             return new MultExprNode(Visit(context.multiplicativeExpression()), Visit(context.primitiveExpression()));
//         }
//         else if (context.DIV() is not null)
//         {
//             return new DivExprNode(Visit(context.multiplicativeExpression()), Visit(context.primitiveExpression()));
//         }
//         else if (context.MOD() is not null)
//         {
//             return new ModExprNode(Visit(context.multiplicativeExpression()), Visit(context.primitiveExpression()));
//         }
//         else
//         {
//             return Visit(context.unaryExpression());
//         }
//     }

//     public override AstNode VisitOrExpression([NotNull] TinyCellParser.OrExpressionContext context)
//     {
//         if (context.OR() is not null)
//         {
//             return new OrExprNode(Visit(context.orExpression()), Visit(context.andExpression()));
//         }
//         return Visit(context.andExpression());
//     }

//     public override AstNode VisitParameter([NotNull] TinyCellParser.ParameterContext context)
//     {
//         return new ParameterNode((TypeNode)Visit(context.type()), (IdentifierNode)Visit(context.identifier()));
//     }

//     public override AstNode VisitParameterList([NotNull] TinyCellParser.ParameterListContext context)
//     {
//         var parameters = new List<ParameterNode>();

//         if (context.parameterList() is not null)
//         {
//             var parameterListNode = Visit(context.parameterList()) as ParameterListNode;
//             parameters.AddRange(parameterListNode.Parameters.Cast<ParameterNode>());
//         }

//         parameters.Add((ParameterNode)Visit(context.parameter()));

//         return new ParameterListNode([.. parameters]);
//     }

//     public override AstNode VisitPinAssignmentExpression([NotNull] TinyCellParser.PinAssignmentExpressionContext context)
//     {
//         AstNode from = Visit(context.GetChild(1));
//         AstNode to = Visit(context.GetChild(3));

//         if (context.WRITE() is not null)
//         {
//             return new PinWriteExprNode(from, to);
//         }

//         return new PinReadExprNode(from, to);
//     }

//     public override AstNode VisitPinStatus([NotNull] TinyCellParser.PinStatusContext context)
//     {
//         if (context.PININ() is not null)
//         {
//             return new PinInNode();
//         }
//         return new PinOutNode();
//     }

//     public override AstNode VisitPinStatusExpression([NotNull] TinyCellParser.PinStatusExpressionContext context)
//     {
//         if (context.SET() is not null)
//         {
//             return new PinModeExprNode((IdentifierNode)Visit(context.identifier()), (PinModeNode)Visit(context.pinStatus()));
//         }
//         return Visit(context.pinAssignmentExpression());

//         throw new InvalidOperationException();
//     }

//     public override AstNode VisitPinVoltage([NotNull] TinyCellParser.PinVoltageContext context)
//     {
//         if (context.VOLHIGH() is not null)
//         {
//             return new VolHighNode();
//         }
//         else if (context.VOLLOW() is not null)
//         {
//             return new VolLowNode();
//         }

//         throw new InvalidOperationException();
//     }

//     public override AstNode VisitPrimitiveExpression([NotNull] TinyCellParser.PrimitiveExpressionContext context)
//     {
//         if (context.Numeral() is not null)
//         {
//             string num = context.Numeral().GetText();

//             return num.Contains('.') ? new FloatNode(float.Parse(num, CultureInfo.InvariantCulture)) : new IntNode(int.Parse(num));
//         }
//         if (context.Bool() is not null)
//         {
//             string b = context.Bool().GetText();

//             return new BoolNode(bool.Parse(b));
//         }
//         if (context.String() is not null)
//         {
//             string s = context.String().GetText()[1..^1];

//             return new StringNode(s);
//         }
//         if (context.identifier() is not null)
//         {
//             return new IdentifierNode(context.identifier().GetText());
//         }
//         if (context.functionCall() is not null)
//         {
//             return Visit(context.functionCall());
//         }
//         if (context.expression() is not null)
//         {
//             return Visit(context.expression());
//         }
//         throw new InvalidOperationException();
//     }

//     public override AstNode VisitSetupDefinition([NotNull] TinyCellParser.SetupDefinitionContext context)
//     {
//         return new FunctionDefinitionNode(new TypeNode(TcType.VOID), new IdentifierNode("setup"), new ParameterListNode([]), (StatementCollectionNode)Visit(context.compoundStatement()));
//     }

//     public override AstNode VisitStatement([NotNull] TinyCellParser.StatementContext context)
//     {
//         if (context.ifStatement() is not null)
//         {
//             return Visit(context.ifStatement());
//         }

//         if (context.loopStatement() is not null)
//         {
//             return Visit(context.loopStatement());
//         }

//         if (context.jumpStatement() is not null)
//         {
//             return Visit(context.jumpStatement());
//         }

//         if (context.declaration() is not null)
//         {
//             return Visit(context.declaration());
//         }

//         if (context.functionCall() is not null)
//         {
//             return Visit(context.functionCall());
//         }

//         if (context.pinStatusExpression() is not null)
//         {
//             return Visit(context.pinStatusExpression());
//         }

//         if (context.assignment() is not null)
//         {
//             return Visit(context.assignment());
//         }

//         if (context.expression() is not null)
//         {
//             return Visit(context.expression());
//         }
//         throw new InvalidOperationException();
//     }

//     public override AstNode VisitTerminal(ITerminalNode node)
//     {
//         if (node.Symbol.Type == TinyCellParser.Numeral)
//         {
//             string nodeText = node.GetText();
//             return nodeText.Contains('.') ? new FloatNode(float.Parse(nodeText, CultureInfo.InvariantCulture)) : new IntNode(int.Parse(nodeText));
//         }

//         if (node.Symbol.Type == TinyCellParser.String)
//         {
//             string nodeText = node.GetText()[1..^1];
//             return new StringNode(nodeText);
//         }

//         if (node.Symbol.Type == TinyCellParser.Bool)
//         {
//             string b = node.GetText();
//             return new BoolNode(bool.Parse(b));
//         }

//         return base.VisitTerminal(node);
//     }

//     public override AstNode VisitTernaryExpression([NotNull] TinyCellParser.TernaryExpressionContext context)
//     {
//         if (context.QUESTION() is not null)
//         {
//             return new IfStatementNode(Visit(context.orExpression()), Visit(context.GetChild(2)), Visit(context.GetChild(4)));
//         }
//         return Visit(context.orExpression());
//     }

//     public override AstNode VisitType([NotNull] TinyCellParser.TypeContext context)
//     {
//         if (context.VOID() is not null)
//         {
//             return new TypeNode(TcType.VOID);
//         }
//         if (context.STRING() is not null)
//         {
//             return new TypeNode(TcType.STRING);
//         }
//         if (context.INT() is not null)
//         {
//             return new TypeNode(TcType.INT);
//         }
//         if (context.FLOAT() is not null)
//         {
//             return new TypeNode(TcType.FLOAT);
//         }
//         if (context.BOOL() is not null)
//         {
//             return new TypeNode(TcType.BOOL);
//         }
//         if (context.APIN() is not null)
//         {
//             return new TypeNode(TcType.APIN);
//         }
//         if (context.DPIN() is not null)
//         {
//             return new TypeNode(TcType.DPIN);
//         }
//         throw new InvalidOperationException();
//     }

//     public override AstNode VisitUnaryExpression([NotNull] TinyCellParser.UnaryExpressionContext context)
//     {
//         if (context.UNARYPLUS() is not null)
//         {
//             return new UnaryPlusExprNode(Visit(context.identifier()));
//         }
//         if (context.UNARYMINUS() is not null)
//         {
//             return new UnaryMinusExprNode(Visit(context.identifier()));
//         }
//         if (context.NOT() is not null)
//         {
//             return new NotExprNode(Visit(context.primitiveExpression()));
//         }
//         return Visit(context.primitiveExpression());
//     }

//     public override AstNode VisitUpdateDefinition([NotNull] TinyCellParser.UpdateDefinitionContext context)
//     {
//         return new FunctionDefinitionNode(new TypeNode(TcType.VOID), new IdentifierNode("update"), new ParameterListNode([]), (StatementCollectionNode)Visit(context.compoundStatement()));
//     }
// }
