using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using P4.TinyCell.AST.NumExpr;
using P4.TinyCell.AST.Primitive;
using P4.TinyCell.AST.StatementExpr;
using P4.TinyCell.AST.UnaryExpr;
using System.Globalization;
using System.Reflection.Metadata;

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
        AstNode node = new();
        foreach (var child in context.children)
        {
            AstNode childNode = Visit(child);
            node.AddChild(childNode);
        }
        return node;
        if (context.multiplicativeExpression() is not null)
        {
            return Visit(context.multiplicativeExpression());
        }
        return new AddExprNode(new AstNode(), new AstNode());
    }

    public override AstNode VisitAndExpression([NotNull] TinyCellParser.AndExpressionContext context)
    {
        AstNode node = new();
        foreach (var child in context.children)
        {
            AstNode childNode = Visit(child);
            node.AddChild(childNode);
        }
        return node;
        if (context.equalityExpression() is not null)
        {
            return Visit(context.equalityExpression());
        }
        return base.VisitAndExpression(context);
    }

    public override AstNode VisitArgument([NotNull] TinyCellParser.ArgumentContext context)
    {
        AstNode node = new();
        foreach (var child in context.children)
        {
            AstNode childNode = Visit(child);
            node.AddChild(childNode);
        }
        return node;
        return base.VisitArgument(context);
    }

    public override AstNode VisitArgumentList([NotNull] TinyCellParser.ArgumentListContext context)
    {
        AstNode node = new();
        foreach (var child in context.children)
        {
            AstNode childNode = Visit(child);
            node.AddChild(childNode);
        }
        return node;
        return base.VisitArgumentList(context);
    }

    public override AstNode VisitAssignment([NotNull] TinyCellParser.AssignmentContext context)
    {
        AstNode node = new();
        foreach (var child in context.children)
        {
            AstNode childNode = Visit(child);
            node.AddChild(childNode);
        }
        return node;
        return base.VisitAssignment(context);
    }

    public override AstNode VisitAssignmentOperator([NotNull] TinyCellParser.AssignmentOperatorContext context)
    {
        AstNode node = new();
        foreach (var child in context.children)
        {
            AstNode childNode = Visit(child);
            node.AddChild(childNode);
        }
        return node;
        return base.VisitAssignmentOperator(context);
    }

    public override AstNode VisitBitshiftExpression([NotNull] TinyCellParser.BitshiftExpressionContext context)
    {
        AstNode node = new();
        foreach (var child in context.children)
        {
            AstNode childNode = Visit(child);
            node.AddChild(childNode);
        }
        return node;
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
        AstNode node = new();
        foreach (var child in context.children)
        {
            AstNode childNode = Visit(child);
            node.AddChild(childNode);
        }
        return node;
        if (context.bitshiftExpression() is not null)
        {
            return Visit(context.bitshiftExpression());
        }

        return base.VisitComparisonExpression(context);
    }

    public override AstNode VisitCompoundStatement([NotNull] TinyCellParser.CompoundStatementContext context)
    {
        AstNode node = new();
        foreach (var child in context.children)
        {
            AstNode childNode = Visit(child);
            node.AddChild(childNode);
        }
        return node;
        return base.VisitCompoundStatement(context);
    }

    public override AstNode VisitDeclaration([NotNull] TinyCellParser.DeclarationContext context)
    {
        AstNode node = new();
        foreach (var child in context.children)
        {
            AstNode childNode = Visit(child);
            node.AddChild(childNode);
        }
        return node;
        return base.VisitDeclaration(context);
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
        AstNode node = new();
        foreach (var child in context.children)
        {
            AstNode childNode = Visit(child);
            node.AddChild(childNode);
        }
        return node;
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
        AstNode node = new();
        foreach (var child in context.children)
        {
            AstNode childNode = Visit(child);
            node.AddChild(childNode);
        }
        return node;
        return Visit(context.pinExpression());
    }

    public override AstNode VisitFunctionCall([NotNull] TinyCellParser.FunctionCallContext context)
    {
        AstNode node = new();
        foreach (var child in context.children)
        {
            AstNode childNode = Visit(child);
            node.AddChild(childNode);
        }
        return node;
        return base.VisitFunctionCall(context);
    }

    public override AstNode VisitFunctionDefinition([NotNull] TinyCellParser.FunctionDefinitionContext context)
    {
        AstNode node = new();
        foreach (var child in context.children)
        {
            AstNode childNode = Visit(child);
            node.AddChild(childNode);
        }
        return node;
        return base.VisitFunctionDefinition(context);
    }

    public override AstNode VisitGeneralDeclaration([NotNull] TinyCellParser.GeneralDeclarationContext context)
    {
        AstNode node = new();
        foreach (var child in context.children)
        {
            AstNode childNode = Visit(child);
            node.AddChild(childNode);
        }
        return node;
        return base.VisitGeneralDeclaration(context);
    }

    public override StringNode VisitIdentifier([NotNull] TinyCellParser.IdentifierContext context)
    {
        return new StringNode(context.GetText());
    }

    public override AstNode VisitIfStatement([NotNull] TinyCellParser.IfStatementContext context)
    {
        AstNode node = new();
        foreach (var child in context.children)
        {
            AstNode childNode = Visit(child);
            node.AddChild(childNode);
        }
        return node;
        return base.VisitIfStatement(context);
    }

    public override AstNode VisitInitialDeclaration([NotNull] TinyCellParser.InitialDeclarationContext context)
    {
        AstNode node = new();
        foreach (var child in context.children)
        {
            AstNode childNode = Visit(child);
            node.AddChild(childNode);
        }
        return node;
        return base.VisitInitialDeclaration(context);
    }

    public override AstNode VisitJumpStatement([NotNull] TinyCellParser.JumpStatementContext context)
    {
        AstNode node = new();
        foreach (var child in context.children)
        {
            AstNode childNode = Visit(child);
            node.AddChild(childNode);
        }
        return node;
        return base.VisitJumpStatement(context);
    }

    public override AstNode VisitLoopStatement([NotNull] TinyCellParser.LoopStatementContext context)
    {
        AstNode node = new();
        foreach (var child in context.children)
        {
            AstNode childNode = Visit(child);
            node.AddChild(childNode);
        }
        return node;
        return base.VisitLoopStatement(context);
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
        AstNode node = new();
        foreach (var child in context.children)
        {
            AstNode childNode = Visit(child);
            node.AddChild(childNode);
        }
        return node;
        if (context.andExpression() is not null)
        {
            return Visit(context.andExpression());
        }
        return base.VisitOrExpression(context);
    }

    public override AstNode VisitParameter([NotNull] TinyCellParser.ParameterContext context)
    {
        AstNode node = new();
        foreach (var child in context.children)
        {
            AstNode childNode = Visit(child);
            node.AddChild(childNode);
        }
        return node;
        return base.VisitParameter(context);
    }

    public override AstNode VisitParameterList([NotNull] TinyCellParser.ParameterListContext context)
    {
        AstNode node = new();
        foreach (var child in context.children)
        {
            AstNode childNode = Visit(child);
            node.AddChild(childNode);
        }
        return node;
        return base.VisitParameterList(context);
    }

    public override AstNode VisitPinExpression([NotNull] TinyCellParser.PinExpressionContext context)
    {
        if (context.identifier() is not null && context.pinVoltage() is not null)
        {
            return new PinExprNode((IdentifierNode)Visit(context.identifier()), (VoltageNode)Visit(context.pinVoltage()));
        }
        return Visit(context.ternaryExpression());
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

        return base.VisitPrimitiveExpression(context);
    }

    public override AstNode VisitSetupDefinition([NotNull] TinyCellParser.SetupDefinitionContext context)
    {
        AstNode node = new();
        foreach (var child in context.children)
        {
            AstNode childNode = Visit(child);
            node.AddChild(childNode);
        }
        return node;
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
        return base.VisitTerminal(node);
    }

    public override AstNode VisitTernaryExpression([NotNull] TinyCellParser.TernaryExpressionContext context)
    {
        if (context.ternaryExpression() is not null)
        {
            return new IfStatementNode(Visit(context.ternaryExpression()), Visit(context.children[2]), Visit(context.children[4]));
        }
        return Visit(context.orExpression());
    }

    //public override AstNode VisitType([NotNull] TinyCellParser.TypeContext context)
    //{
    //    return base.VisitType(context);
    //}

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
