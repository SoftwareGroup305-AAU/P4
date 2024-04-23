using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;

namespace P4.TinyCell.AST;

public class FuckVisitor : TinyCellBaseVisitor<AstNode>
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

    public override AstNode Visit(IParseTree tree)
    {
        return base.Visit(tree);
    }

    public override AstNode VisitAdditiveExpression([NotNull] TinyCellParser.AdditiveExpressionContext context)
    {
        return new AddExprNode(new AstNode(), new AstNode());
    }

    public override AstNode VisitAndExpression([NotNull] TinyCellParser.AndExpressionContext context)
    {
        if (context.equalityExpression() is not null)
        {
            return Visit(context.equalityExpression());
        }
        return base.VisitAndExpression(context);
    }

    public override AstNode VisitArgument([NotNull] TinyCellParser.ArgumentContext context)
    {
        return base.VisitArgument(context);
    }

    public override AstNode VisitArgumentList([NotNull] TinyCellParser.ArgumentListContext context)
    {
        return base.VisitArgumentList(context);
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
        if (context.additiveExpression() is not null)
        {
            return Visit(context.additiveExpression());
        }
        return base.VisitBitshiftExpression(context);
    }

    public override AstNode VisitChildren(IRuleNode node)
    {
        return base.VisitChildren(node);
    }

    public override AstNode VisitComparisonExpression([NotNull] TinyCellParser.ComparisonExpressionContext context)
    {
        if (context.bitshiftExpression() is not null)
        {
            return Visit(context.bitshiftExpression());
        }

        return base.VisitComparisonExpression(context);
    }

    public override AstNode VisitCompoundStatement([NotNull] TinyCellParser.CompoundStatementContext context)
    {
        return base.VisitCompoundStatement(context);
    }

    public override AstNode VisitDeclaration([NotNull] TinyCellParser.DeclarationContext context)
    {
        return base.VisitDeclaration(context);
    }

    public override AstNode VisitDocument([NotNull] TinyCellParser.DocumentContext context)
    {
        AstNode document = new();
        foreach (var child in context.children)
        {
            document.AddChild(Visit(child));
        }
        return document;
    }

    public override AstNode VisitEqualityExpression([NotNull] TinyCellParser.EqualityExpressionContext context)
    {
        if (context.comparisonExpression() is not null)
        {
            return Visit(context.comparisonExpression());
        }
        return base.VisitEqualityExpression(context);
    }

    public override AstNode VisitErrorNode(IErrorNode node)
    {
        return base.VisitErrorNode(node);
    }

    public override AstNode VisitExpression([NotNull] TinyCellParser.ExpressionContext context)
    {
        return base.VisitExpression(context);
    }

    public override AstNode VisitFunctionCall([NotNull] TinyCellParser.FunctionCallContext context)
    {
        return base.VisitFunctionCall(context);
    }

    public override AstNode VisitFunctionDefinition([NotNull] TinyCellParser.FunctionDefinitionContext context)
    {
        return base.VisitFunctionDefinition(context);
    }

    public override AstNode VisitGeneralDeclaration([NotNull] TinyCellParser.GeneralDeclarationContext context)
    {
        return base.VisitGeneralDeclaration(context);
    }

    public override AstNode VisitIdentifier([NotNull] TinyCellParser.IdentifierContext context)
    {
        return base.VisitIdentifier(context);
    }

    public override AstNode VisitIfStatement([NotNull] TinyCellParser.IfStatementContext context)
    {
        return base.VisitIfStatement(context);
    }

    public override AstNode VisitInitialDeclaration([NotNull] TinyCellParser.InitialDeclarationContext context)
    {
        return base.VisitInitialDeclaration(context);
    }

    public override AstNode VisitJumpStatement([NotNull] TinyCellParser.JumpStatementContext context)
    {
        return base.VisitJumpStatement(context);
    }

    public override AstNode VisitLoopStatement([NotNull] TinyCellParser.LoopStatementContext context)
    {
        return base.VisitLoopStatement(context);
    }

    public override AstNode VisitMultiplicativeExpression([NotNull] TinyCellParser.MultiplicativeExpressionContext context)
    {
        if (context.unaryExpression() is not null)
        {
            return Visit(context.unaryExpression());
        }
        return base.VisitMultiplicativeExpression(context);
    }

    public override AstNode VisitOrExpression([NotNull] TinyCellParser.OrExpressionContext context)
    {
        if (context.andExpression() is not null)
        {
            return Visit(context.andExpression());
        }
        return base.VisitOrExpression(context);
    }

    public override AstNode VisitParameter([NotNull] TinyCellParser.ParameterContext context)
    {
        return base.VisitParameter(context);
    }

    public override AstNode VisitParameterList([NotNull] TinyCellParser.ParameterListContext context)
    {
        return base.VisitParameterList(context);
    }

    public override AstNode VisitPinExpression([NotNull] TinyCellParser.PinExpressionContext context)
    {
        if (context.ternaryExpression() is not null)
        {
            return Visit(context.ternaryExpression());
        }
        return base.VisitPinExpression(context);
    }

    public override AstNode VisitPinVoltage([NotNull] TinyCellParser.PinVoltageContext context)
    {
        return base.VisitPinVoltage(context);
    }

    public override AstNode VisitPrimitiveExpression([NotNull] TinyCellParser.PrimitiveExpressionContext context)
    {
        return base.VisitPrimitiveExpression(context);
    }

    public override AstNode VisitSetupDefinition([NotNull] TinyCellParser.SetupDefinitionContext context)
    {
        return new FunctionDefinitionNode();
    }

    public override AstNode VisitStatement([NotNull] TinyCellParser.StatementContext context)
    {
        return base.VisitStatement(context);
    }

    public override AstNode VisitTerminal(ITerminalNode node)
    {
        return base.VisitTerminal(node);
    }

    public override AstNode VisitTernaryExpression([NotNull] TinyCellParser.TernaryExpressionContext context)
    {
        if (context.orExpression() is not null)
        {
            return Visit(context.orExpression());
        }
        return base.VisitTernaryExpression(context);
    }

    public override AstNode VisitType([NotNull] TinyCellParser.TypeContext context)
    {
        return base.VisitType(context);
    }

    public override AstNode VisitUnaryExpression([NotNull] TinyCellParser.UnaryExpressionContext context)
    {
        return base.VisitUnaryExpression(context);
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
