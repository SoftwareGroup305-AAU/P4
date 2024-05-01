using P4.TinyCell.Language.AbstractSyntaxTree.Assignment;
using P4.TinyCell.Language.AbstractSyntaxTree.BitwiseExpr;
using P4.TinyCell.Language.AbstractSyntaxTree.CompExpr;
using P4.TinyCell.Language.AbstractSyntaxTree.Expression;
using P4.TinyCell.Language.AbstractSyntaxTree.Function;
using P4.TinyCell.Language.AbstractSyntaxTree.NumExpr;
using P4.TinyCell.Language.AbstractSyntaxTree.ParameterNodes;
using P4.TinyCell.Language.AbstractSyntaxTree.PinExpr;
using P4.TinyCell.Language.AbstractSyntaxTree.Primitive;
using P4.TinyCell.Language.AbstractSyntaxTree.Statement;
using P4.TinyCell.Language.AbstractSyntaxTree.Types;
using P4.TinyCell.Language.AbstractSyntaxTree.UnaryExpr;

namespace P4.TinyCell.Language.AbstractSyntaxTree;

public interface IAstVisitor<Result>
{
    Result VisitRootNode(RootNode rootNode);

    Result VisitAssignNode(AssignNode assignNode);
    Result VisitDivAssignNode(DivAssignNode divAssignNode);
    Result VisitMultAssignNode(MultAssignNode multAssignNode);
    Result VisitModAssignNode(ModAssignNode modAssignNode);
    Result VisitPlusAssignNode(PlusAssignNode plusAssignNode);
    Result VisitMinusAssignNode(MinusAssignNode minusAssignNode);

    Result VisitBitshiftLExprNode(BitshiftLExprNode bitshiftLExprNode);
    Result VisitBitshiftRExprNode(BitshiftRExprNode bitshiftRExprNode);

    Result VisitEqualExprNode(EqualExprNode bitshiftRExprNode);
    Result VisitGreaterThanExprNode(GreaterThanExprNode greaterThanExprNode);
    Result VisitGreaterThanEqualExprNode(GreaterThanEqualExprNode greaterThanOrEqualExprNode);
    Result VisitLessThanExprNode(LessThanExprNode lessThanExprNode);
    Result VisitLessThanEqualExprNode(LessThanEqualExprNode lessThanOrEqualExprNode);
    Result VisitNotEqualExprNode(NotEqualExprNode notEqualExprNode);

    Result VisitDeclarationNode(DeclarationNode declarationNode);

    Result VisitAddExprNode(AddExprNode addExprNode);
    Result VisitAndExprNode(AndExprNode andExprNode);
    Result VisitDivExprNode(DivExprNode divExprNode);
    Result VisitModExprNode(ModExprNode modExprNode);
    Result VisitMultExprNode(MultExprNode multExprNode);
    Result VisitOrExprNode(OrExprNode orExprNode);
    Result VisitSubExprNode(SubExprNode subExprNode);

    Result VisitParameterListNode(ParameterListNode parameterListNode);
    Result VisitParameterNode(ParameterNode parameterNode);

    Result VisitPinWriteExprNode(PinWriteExprNode pinWriteExprNode);
    Result VisitPinReadExprNode(PinReadExprNode pinReadExprNode);
    Result VisitPinModeExprNode(PinModeExprNode pinModeExprNode);

    Result VisitBoolNode(BoolNode boolNode);
    Result VisitFloatNode(FloatNode boolNode);
    Result VisitIntNode(IntNode intNode);
    Result VisitStringNode(StringNode stringNode);
    Result VisitIdentifierNode(IdentifierNode identifierNode);
    Result VisitVoidNode(VoidNode voidNode);
    Result VisitVolHighNode(VolHighNode volHighNode);
    Result VisitVolLowNode(VolLowNode volLowNode);

    Result VisitBreakNode(BreakNode breakNode);
    Result VisitContinueNode(ContinueNode continueNode);
    Result VisitReturnNode(ReturnNode returnNode);
    Result VisitWhileStatementNode(WhileStatementNode whileStatementNode);
    Result VisitIfStatementNode(IfStatementNode ifStatementNode);
    Result VisitForStatementNode(ForStatementNode forStatementNode);
    Result VisitStatementCollectionNode(StatementCollectionNode statementCollectionNode);
    
    Result VisitFunctionCallNode(FunctionCallNode functionCallNode);    
    Result VisitFunctionDeclarationNode(FunctionDefinitionNode functionDefinitionNode);
    Result VisitFunctionParameterListNode(ParameterListNode functionParameterListNode);
    Result VisitFunctionParameterNode(ParameterNode functionParameterNode);
    Result VisitArgumentListNode(ArgumentListNode argumentListNode);
    Result VisitArgumentNode(ArgumentNode argumentNode);

    Result VisitBoolTypeNode(BoolTypeNode boolTypeNode);
    Result VisitFloatTypeNode(FloatTypeNode floatTypeNode);
    Result VisitIntTypeNode(IntTypeNode intTypeNode);
    Result VisitStringTypeNode(StringTypeNode stringTypeNode);
    Result VisitVoidTypeNode(VoidTypeNode voidTypeNode);
    Result VisitPinTypeNode(PinTypeNode pinTypeNode);

    Result VisitNotExprNode(NotExprNode notExprNode);
    Result VisitUnaryMinusExprNode(UnaryMinusExprNode unaryMinusExprNode);
    Result VisitUnaryPlusExprNode(UnaryPlusExprNode unaryPlusExprNode);
}
