using P4.TinyCell.Shared.Language.AbstractSyntaxTree;
using P4.TinyCell.Shared.Language.AbstractSyntaxTree.Array;
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
using P4.TinyCell.Shared.Language.AbstractSyntaxTree.Types;
using P4.TinyCell.Shared.Language.AbstractSyntaxTree.UnaryExpr;

namespace P4.TinyCell.Shared.Language.CodeGen;
public class CGeneratorVisitor : AstBaseVisitor<string>
{
    private IDictionary<IdentifierNode, TcType> pinTable = new Dictionary<IdentifierNode, TcType>();

    public override string VisitAddExprNode(AddExprNode addExprNode)
    {
        return $"{Visit(addExprNode.Left)} + {Visit(addExprNode.Right)}";
    }

    public override string VisitAndExprNode(AndExprNode andExprNode)
    {
        return $"{Visit(andExprNode.Left)} && {Visit(andExprNode.Right)}";
    }

    public override string VisitArgumentListNode(ArgumentListNode argumentListNode)
    {
        IEnumerable<string> arguments = argumentListNode.Arguments.Select(Visit);
        return $"({string.Join(", ", arguments)})";
    }

    public override string VisitArgumentNode(ArgumentNode argumentNode)
    {
        return Visit(argumentNode.Node);
    }

    public override string VisitAssignNode(AssignNode assignNode)
    {
        return $"{Visit(assignNode.Identifier)} = {Visit(assignNode.Expression)}";
    }

    public override string VisitBitshiftLExprNode(BitshiftLExprNode bitshiftLExprNode)
    {
        return $"{Visit(bitshiftLExprNode.Left)} << {Visit(bitshiftLExprNode.Right)}";
    }

    public override string VisitBitshiftRExprNode(BitshiftRExprNode bitshiftRExprNode)
    {
        return $"{Visit(bitshiftRExprNode.Left)} >> {Visit(bitshiftRExprNode.Right)}";
    }

    public override string VisitBoolNode(BoolNode boolNode)
    {
        return boolNode.Value.ToString().ToLower();
    }

    public override string VisitBreakNode(BreakNode breakNode)
    {
        return "break;";
    }

    public override string VisitContinueNode(ContinueNode continueNode)
    {
        return "continue;";
    }

    public override string VisitDeclarationNode(DeclarationNode declarationNode)
    {
        string action = declarationNode.Action is null ? string.Empty : $" = {Visit(declarationNode.Action)}";
        if (declarationNode.Type.Type == TcType.DPIN || declarationNode.Type.Type == TcType.APIN)
        {
            pinTable.Add(declarationNode.Identifier, declarationNode.Type.Type);
        }
        return $"{Visit(declarationNode.Type)} {Visit(declarationNode.Identifier)}{action};"; 
    }

    public override string VisitDivAssignNode(DivAssignNode divAssignNode)
    {
        return $"{Visit(divAssignNode.Identifier)} /= {Visit(divAssignNode.Expression)}";
    }

    public override string VisitDivExprNode(DivExprNode divExprNode)
    {
        return $"{Visit(divExprNode.Left)} / {Visit(divExprNode.Right)}";
    }

    public override string VisitEqualExprNode(EqualExprNode equalExprNode)
    {
        return $"{Visit(equalExprNode.Left)} == {Visit(equalExprNode.Right)}";
    }

    public override string VisitFloatNode(FloatNode floatNode)
    {
        return floatNode.Value.ToString();
    }

    public override string VisitForStatementNode(ForStatementNode forStatementNode)
    {
        return $"for({Visit(forStatementNode.Variable)}; {Visit(forStatementNode.Condition)}; {Visit(forStatementNode.Expression)}) {Visit(forStatementNode.CompoundStatement)}";
    }

    public override string VisitFunctionCallNode(FunctionCallNode functionCallNode)
    {
        string arguments = Visit(functionCallNode.ArgumentList);
        return $"{Visit(functionCallNode.Identifier)}{arguments}";
    }

    public override string VisitFunctionDefinitionNode(FunctionDefinitionNode functionDefinitionNode)
    {
        string parameters = Visit(functionDefinitionNode.ParameterList);
        return $"{Visit(functionDefinitionNode.Type)} {Visit(functionDefinitionNode.Identifier)}{parameters} {Visit(functionDefinitionNode.CompoundStatement)}";
    }

    public override string VisitGreaterThanEqualExprNode(GreaterThanEqualExprNode greaterThanOrEqualExprNode)
    {
        return $"{Visit(greaterThanOrEqualExprNode.Left)} >= {Visit(greaterThanOrEqualExprNode.Right)}";
    }

    public override string VisitGreaterThanExprNode(GreaterThanExprNode greaterThanExprNode)
    {
        return $"{Visit(greaterThanExprNode.Left)} > {Visit(greaterThanExprNode.Right)}";
    }

    public override string VisitIdentifierNode(IdentifierNode identifierNode)
    {
        return identifierNode.Value;
    }

    public override string VisitIfStatementNode(IfStatementNode ifStatementNode)
    {
        string elseStatement = ifStatementNode.ElseExpr is null ? string.Empty : $" else {Visit(ifStatementNode.ElseExpr)}";
        return $"if({Visit(ifStatementNode.Condition)}) {Visit(ifStatementNode.TrueExpr)}{elseStatement}";
    }

    public override string VisitIntNode(IntNode intNode)
    {
        return intNode.Value.ToString();
    }

    public override string VisitLessThanEqualExprNode(LessThanEqualExprNode lessThanOrEqualExprNode)
    {
        return $"{Visit(lessThanOrEqualExprNode.Left)} <= {Visit(lessThanOrEqualExprNode.Right)}";
    }

    public override string VisitLessThanExprNode(LessThanExprNode lessThanExprNode)
    {
        return $"{Visit(lessThanExprNode.Left)} < {Visit(lessThanExprNode.Right)}";
    }

    public override string VisitMinusAssignNode(MinusAssignNode minusAssignNode)
    {
        return $"{Visit(minusAssignNode.Identifier)} -= {Visit(minusAssignNode.Expression)}";
    }

    public override string VisitModAssignNode(ModAssignNode modAssignNode)
    {
        return $"{Visit(modAssignNode.Identifier)} %= {Visit(modAssignNode.Expression)}";
    }

    public override string VisitModExprNode(ModExprNode modExprNode)
    {
        return $"{Visit(modExprNode.Left)} % {Visit(modExprNode.Right)}";
    }

    public override string VisitMultAssignNode(MultAssignNode multAssignNode)
    {
        return $"{Visit(multAssignNode.Identifier)} *= {Visit(multAssignNode.Expression)}";
    }

    public override string VisitMultExprNode(MultExprNode multExprNode)
    {
        return $"{Visit(multExprNode.Left)} * {Visit(multExprNode.Right)}";
    }

    public override string VisitNotEqualExprNode(NotEqualExprNode notEqualExprNode)
    {
        return $"{Visit(notEqualExprNode.Left)} != {Visit(notEqualExprNode.Right)}";
    }

    public override string VisitNotExprNode(NotExprNode notExprNode)
    {
        return $"!{Visit(notExprNode.Operand)}";
    }

    public override string VisitOrExprNode(OrExprNode orExprNode)
    {
        return $"{Visit(orExprNode.Left)} || {Visit(orExprNode.Right)}";
    }

    public override string VisitParameterListNode(ParameterListNode parameterListNode)
    {
        IEnumerable<string> parameters = parameterListNode.Parameters.Select(Visit);
        return $"({string.Join(", ", parameters)})";
    }

    public override string VisitParameterNode(ParameterNode parameterNode)
    {
        return $"{Visit(parameterNode.TypeNode)} {Visit(parameterNode.Identifier)}";
    }

    public override string VisitPinInNode(PinInNode pinInNode)
    {
        return base.VisitPinInNode(pinInNode);
    }

    public override string VisitPinModeExprNode(PinModeExprNode pinModeExprNode)
    {
        return base.VisitPinModeExprNode(pinModeExprNode);
    }

    public override string VisitPinOutNode(PinOutNode pinOutNode)
    {
        return base.VisitPinOutNode(pinOutNode);
    }

    public override string VisitPinReadExprNode(PinReadExprNode pinReadExprNode)
    {
        return base.VisitPinReadExprNode(pinReadExprNode);
    }

    public override string VisitPinWriteExprNode(PinWriteExprNode pinWriteExprNode)
    {
        if (pinWriteExprNode.To is IdentifierNode)
        {

        }
        return base.VisitPinWriteExprNode(pinWriteExprNode);
    }

    public override string VisitPlusAssignNode(PlusAssignNode plusAssignNode)
    {
        return $"{Visit(plusAssignNode.Identifier)} += {Visit(plusAssignNode.Expression)}";
    }

    public override string VisitReturnNode(ReturnNode returnNode)
    {
        string returnExpression = returnNode.ReturnExpression is null ? string.Empty : $" {Visit(returnNode.ReturnExpression)}";
        return $"return{returnExpression};";
    }

    public override string VisitRootNode(RootNode rootNode)
    {
        string fuck = string.Empty;
        foreach (var child in rootNode.Children)
        {
            fuck += Visit(child);
        }
        return fuck;
    }

    public override string VisitStatementCollectionNode(StatementCollectionNode statementCollectionNode)
    {
        IEnumerable<string> statements = statementCollectionNode.Statements.Select(Visit);
        return $"{{{string.Join(";\n", statements)}}}";
    }

    public override string VisitStringNode(StringNode stringNode)
    {
        return $"{stringNode.Value}";
    }

    public override string VisitSubExprNode(SubExprNode subExprNode)
    {
        return $"{Visit(subExprNode.Left)}-{Visit(subExprNode.Right)}";
    }

    public override string VisitUnaryMinusExprNode(UnaryMinusExprNode unaryMinusExprNode)
    {
        return $"--{unaryMinusExprNode.Operand}";
    }

    public override string VisitUnaryPlusExprNode(UnaryPlusExprNode unaryPlusExprNode)
    {
        return $"--{unaryPlusExprNode.Operand}";
    }

    public override string VisitVoidNode(VoidNode voidNode)
    {
        return "void";
    }

    public override string VisitVolHighNode(VolHighNode volHighNode)
    {
        return "HIGH";
    }

    public override string VisitVolLowNode(VolLowNode volLowNode)
    {
        return "LOW";
    }

    public override string VisitWhileStatementNode(WhileStatementNode whileStatementNode)
    {
        return $"while({Visit(whileStatementNode.Condition)}) {Visit(whileStatementNode.CompoundStatement)}";
    }

    public override string VisitTypeNode(TypeNode typeNode)
    {
        return typeNode.Type.ToString().ToLower();
    }

    public override string VisitArrayDeclarationNode(ArrayDeclarationNode arrayDeclaration)
    {
        return base.VisitArrayDeclarationNode(arrayDeclaration);
    }

    public override string VisitIncludeNode(IncludeNode includeNode)
    {
        return base.VisitIncludeNode(includeNode);
    }

    public override string VisitArrayElementsNode(ArrayElementsNode elements)
    {
        return base.VisitArrayElementsNode(elements);
    }

    public override string VisitArrayElemenetReferenceNode(ArrayElementReferenceNode arrayElementReferenceNode)
    {
        return base.VisitArrayElemenetReferenceNode(arrayElementReferenceNode);
    }

    public override string VisitArrayAssignmentNode(ArrayAssignmentNode arrayAssignmentNode)
    {
        return base.VisitArrayAssignmentNode(arrayAssignmentNode);
    }

    public override string VisitNegativeExpressionNode(NegativeExpressionNode negativeExpressionNode)
    {
        return base.VisitNegativeExpressionNode(negativeExpressionNode);
    }
}