using P4.TinyCell.Shared.Language.AbstractSyntaxTree;
using P4.TinyCell.Shared.Language.AbstractSyntaxTree.Assignment;
using P4.TinyCell.Shared.Language.AbstractSyntaxTree.BitwiseExpr;
using P4.TinyCell.Shared.Language.AbstractSyntaxTree.CompExpr;
using P4.TinyCell.Shared.Language.AbstractSyntaxTree.Expression;
using P4.TinyCell.Shared.Language.AbstractSyntaxTree.Function;
using P4.TinyCell.Shared.Language.AbstractSyntaxTree.NumExpr;
using P4.TinyCell.Shared.Language.AbstractSyntaxTree.ParameterNodes;
using P4.TinyCell.Shared.Language.AbstractSyntaxTree.PinExpr;
using P4.TinyCell.Shared.Language.AbstractSyntaxTree.Primitive;
using P4.TinyCell.Shared.Language.AbstractSyntaxTree.Statement;
using P4.TinyCell.Shared.Language.AbstractSyntaxTree.UnaryExpr;

namespace P4.TinyCell.Shared.Language.CodeGen;

public class AsmGeneratorVisitor : AstBaseVisitor<object>
{
    public override object VisitNotEqualExprNode(NotEqualExprNode notEqualExprNode)
    {
        
        return base.VisitNotEqualExprNode(notEqualExprNode);
    }

    public override object VisitNotExprNode(NotExprNode notExprNode)
    {
        return base.VisitNotExprNode(notExprNode);
    }

    public override object VisitUnaryMinusExprNode(UnaryMinusExprNode unaryMinusExprNode)
    {
        return base.VisitUnaryMinusExprNode(unaryMinusExprNode);
    }

    public override object VisitUnaryPlusExprNode(UnaryPlusExprNode unaryPlusExprNode)
    {
        return base.VisitUnaryPlusExprNode(unaryPlusExprNode);
    }

    public override object VisitVoidNode(VoidNode voidNode)
    {
        return base.VisitVoidNode(voidNode);
    }

    public override object VisitVolHighNode(VolHighNode volHighNode)
    {
        return base.VisitVolHighNode(volHighNode);
    }

    public override object VisitVolLowNode(VolLowNode volLowNode)
    {
        return base.VisitVolLowNode(volLowNode);
    }

    public override object VisitWhileStatementNode(WhileStatementNode whileStatementNode)
    {
        whileStatementNode.Condition.ToString();
        whileStatementNode.CompoundStatement.
        return base.VisitWhileStatementNode(whileStatementNode);
    }

    public override object VisitOrExprNode(OrExprNode orExprNode)
    {
        return base.VisitOrExprNode(orExprNode);
    }

    public override object VisitSubExprNode(SubExprNode subExprNode)
    {
        return base.VisitSubExprNode(subExprNode);
    }

    public override object VisitParameterListNode(ParameterListNode parameterListNode)
    {
        return base.VisitParameterListNode(parameterListNode);
    }

    public override object VisitParameterNode(ParameterNode parameterNode)
    {
        return base.VisitParameterNode(parameterNode);
    }

    public override object VisitPinWriteExprNode(PinWriteExprNode pinWriteExprNode)
    {
        return base.VisitPinWriteExprNode(pinWriteExprNode);
    }

    public override object VisitPinOutNode(PinOutNode pinOutNode)
    {
        return base.VisitPinOutNode(pinOutNode);
    }

    public override object VisitPinInNode(PinInNode pinInNode)
    {
        return base.VisitPinInNode(pinInNode);
    }

    public override object VisitPlusAssignNode(PlusAssignNode plusAssignNode)
    {
        return base.VisitPlusAssignNode(plusAssignNode);
    }

    public override object VisitReturnNode(ReturnNode returnNode)
    {
        return base.VisitReturnNode(returnNode);
    }

    public override object VisitRootNode(RootNode rootNode)
    {
        return base.VisitRootNode(rootNode);
    }

    public override object VisitStatementCollectionNode(StatementCollectionNode statementCollectionNode)
    {
        return base.VisitStatementCollectionNode(statementCollectionNode);
    }

    public override object VisitStringNode(StringNode stringNode)
    {
        return base.VisitStringNode(stringNode);
    }

    public override object VisitPinModeExprNode(PinModeExprNode pinModeExprNode)
    {
        return base.VisitPinModeExprNode(pinModeExprNode);
    }

    public override object VisitPinReadExprNode(PinReadExprNode pinReadExprNode)
    {
        return base.VisitPinReadExprNode(pinReadExprNode);
    }

    public override object VisitDeclarationNode(DeclarationNode declarationNode)
    {
        return base.VisitDeclarationNode(declarationNode);
    }

    public override object VisitDivAssignNode(DivAssignNode divAssignNode)
    {
        return base.VisitDivAssignNode(divAssignNode);
    }

    public override object VisitMultAssignNode(MultAssignNode multAssignNode)
    {
        return base.VisitMultAssignNode(multAssignNode);
    }

    public override object VisitMultExprNode(MultExprNode multExprNode)
    {
        return base.VisitMultExprNode(multExprNode);
    }

    public override object VisitDivExprNode(DivExprNode divExprNode)
    {
        return base.VisitDivExprNode(divExprNode);
    }

    public override object VisitModExprNode(ModExprNode modExprNode)
    {
        return base.VisitModExprNode(modExprNode);
    }

    public override object VisitEqualExprNode(EqualExprNode bitshiftRExprNode)
    {
        return base.VisitEqualExprNode(bitshiftRExprNode);
    }

    public override object VisitGreaterThanExprNode(GreaterThanExprNode greaterThanExprNode)
    {
        return base.VisitGreaterThanExprNode(greaterThanExprNode);
    }

    public override object VisitIdentifierNode(IdentifierNode identifierNode)
    {
        return base.VisitIdentifierNode(identifierNode);
    }

    public override object VisitIfStatementNode(IfStatementNode ifStatementNode)
    {
        return base.VisitIfStatementNode(ifStatementNode);
    }

    public override object VisitIntNode(IntNode intNode)
    {
        return base.VisitIntNode(intNode);
    }

    public override object VisitLessThanEqualExprNode(LessThanEqualExprNode lessThanOrEqualExprNode)
    {
        return base.VisitLessThanEqualExprNode(lessThanOrEqualExprNode);
    }

    public override object VisitLessThanExprNode(LessThanExprNode lessThanExprNode)
    {
        return base.VisitLessThanExprNode(lessThanExprNode);
    }

    public override object VisitMinusAssignNode(MinusAssignNode minusAssignNode)
    {
        return base.VisitMinusAssignNode(minusAssignNode);
    }

    public override object VisitModAssignNode(ModAssignNode modAssignNode)
    {
        return base.VisitModAssignNode(modAssignNode);
    }

    public override object VisitFloatNode(FloatNode boolNode)
    {
        return base.VisitFloatNode(boolNode);
    }

    public override object VisitForStatementNode(ForStatementNode forStatementNode)
    {
        return base.VisitForStatementNode(forStatementNode);
    }

    public override object VisitFunctionCallNode(FunctionCallNode functionCallNode)
    {
        return base.VisitFunctionCallNode(functionCallNode);
    }

    public override object VisitFunctionDefinitionNode(FunctionDefinitionNode functionDefinitionNode)
    {
        return base.VisitFunctionDefinitionNode(functionDefinitionNode);
    }

    public override object VisitFunctionParameterListNode(ParameterListNode functionParameterListNode)
    {
        return base.VisitFunctionParameterListNode(functionParameterListNode);
    }

    public override object VisitFunctionParameterNode(ParameterNode functionParameterNode)
    {
        return base.VisitFunctionParameterNode(functionParameterNode);
    }

    public override object VisitGreaterThanEqualExprNode(GreaterThanEqualExprNode greaterThanOrEqualExprNode)
    {
        return base.VisitGreaterThanEqualExprNode(greaterThanOrEqualExprNode);
    }

    public override object VisitAddExprNode(AddExprNode addExprNode)
    {
        return base.VisitAddExprNode(addExprNode);
    }

    public override object VisitAndExprNode(AndExprNode andExprNode)
    {
        return base.VisitAndExprNode(andExprNode);
    }

    public override object VisitArgumentListNode(ArgumentListNode argumentListNode)
    {
        return base.VisitArgumentListNode(argumentListNode);
    }

    public override object VisitArgumentNode(ArgumentNode argumentNode)
    {
        return base.VisitArgumentNode(argumentNode);
    }

    public override object VisitAssignNode(AssignNode assignNode)
    {
        return base.VisitAssignNode(assignNode);
    }

    public override object VisitBitshiftLExprNode(BitshiftLExprNode bitshiftLExprNode)
    {
        return base.VisitBitshiftLExprNode(bitshiftLExprNode);
    }

    public override object VisitBitshiftRExprNode(BitshiftRExprNode bitshiftRExprNode)
    {
        return base.VisitBitshiftRExprNode(bitshiftRExprNode);
    }

    public override object VisitBoolNode(BoolNode boolNode)
    {
        return base.VisitBoolNode(boolNode);
    }

    public override object VisitBreakNode(BreakNode breakNode)
    {
        return base.VisitBreakNode(breakNode);
    }

    public override object VisitContinueNode(ContinueNode continueNode)
    {
        return base.VisitContinueNode(continueNode);
    }
}