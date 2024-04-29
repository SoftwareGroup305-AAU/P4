using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using P4.TinyCell.AST.BitwiseExpr;
using P4.TinyCell.AST.CompExpr;
using P4.TinyCell.AST.Function;
using P4.TinyCell.AST.NumExpr;
using P4.TinyCell.AST.Primitive;
using P4.TinyCell.AST.Statement;
using P4.TinyCell.AST.StatementExpr;
using P4.TinyCell.AST.Types;
using P4.TinyCell.AST.UnaryExpr;
using System.Globalization;

namespace P4.TinyCell.AST;

public class AstBuilderVisitor : TinyCellBaseVisitor<AstNode>
{
    protected override AstNode DefaultResult => base.DefaultResult;

    public override bool Equals(object? obj)
    {
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override string? ToString()
    {
        return base.ToString();
    }

    //public override AstNode Visit(IParseTree tree)
    //{
    //    return base.Visit(tree);
    //}

    public override AstNode VisitAdditiveExpression([NotNull] TinyCellParser.AdditiveExpressionContext context)
    {
        if (context.PLUS() is not null)
        {
            return new AddExprNode(Visit(context.additiveExpression()), Visit(context.multiplicativeExpression()));
        }
        if (context.MINUS() is not null)
        {
            return new SubExprNode(Visit(context.additiveExpression()), Visit(context.multiplicativeExpression()));
        }
        return Visit(context.multiplicativeExpression());
    }

    public override AstNode VisitAndExpression([NotNull] TinyCellParser.AndExpressionContext context)
    {
        if (context.AND() is not null)
        {
            return new AndExprNode(Visit(context.andExpression()), Visit(context.equalityExpression()));
        }
        return Visit(context.equalityExpression());
    }

    public override AstNode VisitArgument([NotNull] TinyCellParser.ArgumentContext context)
    {
        if (context.identifier() is not null)
        {
            return new ArgumentNode((IdentifierNode)Visit(context.identifier()));
        }

        if (context.functionCall() is not null)
        {
            return new ArgumentNode(Visit(context.functionCall()));
        }

        if (context.Numeral() is not null)
        {
            return new ArgumentNode(Visit(context.Numeral()));
        }

        if (context.String() is not null)
        {
            return new ArgumentNode(Visit(context.String()));
        }

        return new ArgumentNode(Visit(context.Bool()));
    }

    public override AstNode VisitArgumentList([NotNull] TinyCellParser.ArgumentListContext context)
    {
        var arguments = new List<ArgumentNode>();

        if (context.argumentList() is not null)
        {
            var argumentListNode = Visit(context.argumentList()) as ArgumentListNode;
            arguments.AddRange(argumentListNode.Arguments);
        }

        arguments.Add((ArgumentNode)Visit(context.argument()));

        return new ArgumentListNode([.. arguments]); ;
    }

    public override AstNode VisitAssignment([NotNull] TinyCellParser.AssignmentContext context)
    {
        return base.VisitAssignment(context);
    }

    public override AstNode VisitAssignmentOperator([NotNull] TinyCellParser.AssignmentOperatorContext context)
    {

        return base.VisitAssignmentOperator(context);
    }

    public override AstNode VisitBitshiftExpression([NotNull] TinyCellParser.BitshiftExpressionContext context)
    {
        if (context.BITSHIFTL() is not null)
        {
            return new BitshiftLExprNode(Visit(context.bitshiftExpression()), Visit(context.additiveExpression()));
        }
        if (context.BITSHIFTR() is not null)
        {
            return new BitshiftRExprNode(Visit(context.bitshiftExpression()), Visit(context.additiveExpression()));
        }
        return Visit(context.additiveExpression());
    }

    public override AstNode VisitChildren(IRuleNode node)
    {
        return base.VisitChildren(node);
    }

    public override AstNode VisitComparisonExpression([NotNull] TinyCellParser.ComparisonExpressionContext context)
    {
        if (context.LT() is not null)
        {
            return new LessThanExprNode(Visit(context.comparisonExpression()), Visit(context.bitshiftExpression()));
        }
        if (context.GT() is not null)
        {
            return new GreaterThanExprNode(Visit(context.comparisonExpression()), Visit(context.bitshiftExpression()));
        }
        if (context.LTE() is not null)
        {
            return new LessThanEqualExprNode(Visit(context.comparisonExpression()), Visit(context.bitshiftExpression()));
        }
        if (context.GTE() is not null)
        {
            return new GreaterThanEqualExprNode(Visit(context.comparisonExpression()), Visit(context.bitshiftExpression()));
        }

        return Visit(context.bitshiftExpression());
    }

    public override AstNode VisitCompoundStatement([NotNull] TinyCellParser.CompoundStatementContext context)
    {
        return new StatementCollectionNode(context.statement().Select(Visit).ToArray());
    }

    public override AstNode VisitDeclaration([NotNull] TinyCellParser.DeclarationContext context)
    {
        InitialDeclerationNode initialDecleration = Visit(context.initialDeclaration()) as InitialDeclerationNode;
        if (initialDecleration.Action is not null)
        {
            var typ = Visit(context.type());
            return new DeclarationNode(Visit(context.type()), initialDecleration.Identifier, initialDecleration.Action);
        }
        return new DeclarationNode(Visit(context.type()), Visit(initialDecleration.Identifier));
    }

    public override AstNode VisitDocument([NotNull] TinyCellParser.DocumentContext context)
    {
        AstNode document = new();
        foreach (var child in context.children)
        {
            AstNode childNode = Visit(child);
            document.AddChild(childNode);
        }
        return document;
    }

    public override AstNode VisitEqualityExpression([NotNull] TinyCellParser.EqualityExpressionContext context)
    {
        if (context.EQ() is not null)
        {
            return new EqualExprNode(Visit(context.equalityExpression()), Visit(context.comparisonExpression()));
        }
        if (context.NEQ() is not null)
        {
            return new NotEqualExprNode(Visit(context.equalityExpression()), Visit(context.comparisonExpression()));
        }
        return Visit(context.comparisonExpression());
    }

    public override AstNode VisitErrorNode(IErrorNode node)
    {
        return base.VisitErrorNode(node);
    }

    public override AstNode VisitExpression([NotNull] TinyCellParser.ExpressionContext context)
    {
        return Visit(context.ternaryExpression());
    }

    public override AstNode VisitFunctionCall([NotNull] TinyCellParser.FunctionCallContext context)
    {
        var allArguments = context.argumentList().Select(al => (ArgumentListNode)Visit(al)).Select(al => al.Arguments).SelectMany(x => x);
        ArgumentListNode aggregatedArgumentList = new(allArguments.ToArray());

        return new FunctionCallNode(Visit(context.identifier()), aggregatedArgumentList);
    }

    public override AstNode VisitFunctionDefinition([NotNull] TinyCellParser.FunctionDefinitionContext context)
    {
        var allParameters = context.parameterList().Select(al => (ParameterListNode)Visit(al)).Select(al => al.Parameters).SelectMany(x => x);
        ParameterListNode aggregatedParameterList = new(allParameters.ToArray());


        return new FunctionDefinitionNode(Visit(context.type()), Visit(context.identifier()), aggregatedParameterList, Visit(context.compoundStatement()));
    }

    public override AstNode VisitGeneralDeclaration([NotNull] TinyCellParser.GeneralDeclarationContext context)
    {
        if (context.functionDefinition() is not null)
        {
            return Visit(context.functionDefinition());
        }
        return Visit(context.declaration());
    }

    public override AstNode VisitIdentifier([NotNull] TinyCellParser.IdentifierContext context)
    {
        return new IdentifierNode(context.GetText());
    }

    public override AstNode VisitIfStatement([NotNull] TinyCellParser.IfStatementContext context)
    {
        if (context.ELSE() is not null)
        {
            return new IfStatementNode(Visit(context.expression()), Visit(context.compoundStatement().First()), Visit(context.compoundStatement().Last()));
        }
        return new IfStatementNode(Visit(context.expression()), Visit(context.compoundStatement().First()), null);
    }

    public override AstNode VisitInitialDeclaration([NotNull] TinyCellParser.InitialDeclarationContext context)
    {
        if (context.ASSIGN() is not null)
        {
            AstNode action = context.expression() is not null ? Visit(context.expression()) : Visit(context.functionCall());
            return new InitialDeclerationNode(Visit(context.identifier()), action);
        }
        return new InitialDeclerationNode(Visit(context.identifier()));
    }

    public override AstNode VisitJumpStatement([NotNull] TinyCellParser.JumpStatementContext context)
    {
        if (context.CONTINUE() is not null)
        {
            return new ContinueNode();
        }
        if (context.BREAK() is not null)
        {
            return new BreakNode();
        }
        return new ReturnNode(Visit(context.expression()));
    }

    public override AstNode VisitLoopStatement([NotNull] TinyCellParser.LoopStatementContext context)
    {
        if (context.WHILE() is not null)
        {
            return new WhileStatementNode(Visit(context.expression().First()), Visit(context.compoundStatement()));
        }

        return new ForStatementNode(Visit(context.GetChild(2)), Visit(context.GetChild(4)), Visit(context.GetChild(6)), Visit(context.GetChild(8)));
    }

    public override AstNode VisitMultiplicativeExpression([NotNull] TinyCellParser.MultiplicativeExpressionContext context)
    {
        if (context.MULT() is not null)
        {
            return new MultExprNode(Visit(context.multiplicativeExpression()), Visit(context.primitiveExpression()));
        }
        else if (context.DIV() is not null)
        {
            return new DivExprNode(Visit(context.multiplicativeExpression()), Visit(context.primitiveExpression()));
        }
        else if (context.MOD() is not null)
        {
            return new ModExprNode(Visit(context.multiplicativeExpression()), Visit(context.primitiveExpression()));
        }
        else
        {
            return Visit(context.unaryExpression());
        }
    }

    public override AstNode VisitOrExpression([NotNull] TinyCellParser.OrExpressionContext context)
    {
        if (context.OR() is not null)
        {
            return new OrExprNode(Visit(context.orExpression()), Visit(context.andExpression()));
        }
        return Visit(context.andExpression());
    }

    public override AstNode VisitParameter([NotNull] TinyCellParser.ParameterContext context)
    {
        return new ParameterNode(Visit(context.type()), Visit(context.identifier()));
    }

    public override AstNode VisitParameterList([NotNull] TinyCellParser.ParameterListContext context)
    {
        var parameters = new List<AstNode>();

        if (context.parameterList() is not null)
        {
            var parameterListNode = Visit(context.parameterList()) as ParameterListNode;
            parameters.AddRange(parameterListNode.Parameters);
        }

        parameters.Add(Visit(context.parameter()));

        return new ParameterListNode([.. parameters]);
    }

    public override AstNode VisitPinAssignmentExpression([NotNull] TinyCellParser.PinAssignmentExpressionContext context)
    {
        if (context.WRITE() is not null)
        {
            if (context.pinVoltage() is not null)
            {
                if (context.Numeral() is not null)
                {
                    return new PinWriteExprNode(Visit(context.pinVoltage()), Visit(context.Numeral()));
                }

                return new PinWriteExprNode(Visit(context.pinVoltage()), Visit(context.identifier().First()));
            }

            if (context.Numeral() is not null)
            {
                return new PinWriteExprNode(Visit(context.pinVoltage()), Visit(context.Numeral()));
            }

            return new PinWriteExprNode(Visit(context.identifier().First()), Visit(context.identifier().Last()));
        }

        if (context.Numeral() is not null)
        {
            return new PinReadExprNode(Visit(context.Numeral()), Visit(context.identifier().First()));
        }

        return new PinReadExprNode(Visit(context.identifier().First()), Visit(context.identifier().Last()));
    }

    public override AstNode VisitPinStatus([NotNull] TinyCellParser.PinStatusContext context)
    {
        if (context.PININ() is not null)
        {
            return new PinInNode();
        }
        return new PinOutNode();
    }

    public override AstNode VisitPinStatusExpression([NotNull] TinyCellParser.PinStatusExpressionContext context)
    {
        if (context.SET() is not null)
        {
            return new PinModeExprNode((IdentifierNode)Visit(context.identifier()), (PinModeNode)Visit(context.pinStatus()));
        }
        return base.VisitPinStatusExpression(context);
    }

    public override VoltageNode VisitPinVoltage([NotNull] TinyCellParser.PinVoltageContext context)
    {
        if (context.VOLHIGH() is not null)
        {
            return new VolHighNode();
        }
        else if (context.VOLLOW() is not null)
        {
            return new VolLowNode();
        }

        throw new InvalidOperationException();
    }

    public override AstNode VisitPrimitiveExpression([NotNull] TinyCellParser.PrimitiveExpressionContext context)
    {
        if (context.Numeral() is not null)
        {
            string num = context.Numeral().GetText();

            return num.Contains('.') ? new FloatNode(float.Parse(num, CultureInfo.InvariantCulture)) : new IntNode(int.Parse(num));
        }
        else if (context.Bool() is not null)
        {
            string b = context.Bool().GetText();

            return new BoolNode(bool.Parse(b));
        }
        else if (context.String() is not null)
        {
            string s = context.String().GetText()[1..^1];

            return new StringNode(s);
        }
        if (context.identifier() is not null)
        {
            return new IdentifierNode(context.identifier().GetText());
        }
        if (context.functionCall() is not null)
        {
            return Visit(context.functionCall());
        }
        if (context.expression() is not null)
        {
            return Visit(context.expression());
        }
        throw new InvalidOperationException();
    }

    public override AstNode VisitSetupDefinition([NotNull] TinyCellParser.SetupDefinitionContext context)
    {
        return new FunctionDefinitionNode(new VoidTypeNode(), new IdentifierNode("setup"), new ParameterListNode([]), Visit(context.compoundStatement()));
    }

    public override AstNode VisitStatement([NotNull] TinyCellParser.StatementContext context)
    {
        if (context.ifStatement() is not null)
        {
            return Visit(context.ifStatement());
        }

        else if (context.loopStatement() is not null)
        {
            return Visit(context.loopStatement());
        }

        else if (context.jumpStatement() is not null)
        {
            return Visit(context.jumpStatement());
        }

        else if (context.declaration() is not null)
        {
            return Visit(context.declaration());
        }

        else if (context.functionCall() is not null)
        {
            return Visit(context.functionCall());
        }

        else if (context.assignment() is not null)
        {
            return Visit(context.assignment());
        }

        else if (context.expression() is not null)
        {
            return Visit(context.expression());
        }

        return base.VisitStatement(context);
    }

    public override AstNode VisitTerminal(ITerminalNode node)
    {
        if (node.Symbol.Type == TinyCellParser.Numeral)
        {
            string nodeText = node.GetText();
            return nodeText.Contains('.') ? new FloatNode(float.Parse(nodeText, CultureInfo.InvariantCulture)) : new IntNode(int.Parse(nodeText));
        }

        if (node.Symbol.Type == TinyCellParser.String)
        {
            string nodeText = node.GetText()[1..^1];
            return new StringNode(nodeText);
        }

        if (node.Symbol.Type == TinyCellParser.Bool)
        {
            string b = node.GetText();
            return new BoolNode(bool.Parse(b));
        }
        return base.VisitTerminal(node);
    }

    public override AstNode VisitTernaryExpression([NotNull] TinyCellParser.TernaryExpressionContext context)
    {
        if (context.QUESTION() is not null)
        {
            return new IfStatementNode(Visit(context.orExpression()), Visit(context.GetChild(2)), Visit(context.GetChild(4)));
        }
        return Visit(context.orExpression());
    }

    public override AstNode VisitType([NotNull] TinyCellParser.TypeContext context)
    {
        if (context.VOID() is not null)
        {
            return new VoidTypeNode();
        }
        if (context.STRING() is not null)
        {
            return new StringTypeNode();
        }
        if (context.INT() is not null)
        {
            return new IntTypeNode();
        }
        if (context.FLOAT() is not null)
        {
            return new FloatTypeNode();
        }
        if (context.BOOL() is not null)
        {
            return new BoolTypeNode();
        }
        if (context.PIN() is not null)
        {
            return new PinTypeNode();
        }
        throw new InvalidOperationException();
    }

    public override AstNode VisitUnaryExpression([NotNull] TinyCellParser.UnaryExpressionContext context)
    {
        if (context.UNARYPLUS() is not null)
        {
            return new UnaryPlusExprNode(Visit(context.primitiveExpression()));
        }
        if (context.UNARYMINUS() is not null)
        {
            return new UnaryMinusExprNode(Visit(context.primitiveExpression()));
        }
        if (context.NOT() is not null)
        {
            return new NotExprNode(Visit(context.primitiveExpression()));
        }
        else
        {
            return Visit(context.primitiveExpression());
        }
    }

    public override AstNode VisitUpdateDefinition([NotNull] TinyCellParser.UpdateDefinitionContext context)
    {
        return base.VisitUpdateDefinition(context);
    }

    protected override AstNode AggregateResult(AstNode aggregate, AstNode nextResult)
    {
        return base.AggregateResult(aggregate, nextResult);
    }

    protected override bool ShouldVisitNextChild(IRuleNode node, AstNode currentResult)
    {
        return base.ShouldVisitNextChild(node, currentResult);
    }
}
