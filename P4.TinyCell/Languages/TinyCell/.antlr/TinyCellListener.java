// Generated from /Users/emilpriv/Desktop/Git-Clones/P4/P4.TinyCell/Languages/TinyCell/TinyCell.g4 by ANTLR 4.13.1
import org.antlr.v4.runtime.tree.ParseTreeListener;

/**
 * This interface defines a complete listener for a parse tree produced by
 * {@link TinyCellParser}.
 */
public interface TinyCellListener extends ParseTreeListener {
	/**
	 * Enter a parse tree produced by {@link TinyCellParser#document}.
	 * @param ctx the parse tree
	 */
	void enterDocument(TinyCellParser.DocumentContext ctx);
	/**
	 * Exit a parse tree produced by {@link TinyCellParser#document}.
	 * @param ctx the parse tree
	 */
	void exitDocument(TinyCellParser.DocumentContext ctx);
	/**
	 * Enter a parse tree produced by {@link TinyCellParser#generalDeclaration}.
	 * @param ctx the parse tree
	 */
	void enterGeneralDeclaration(TinyCellParser.GeneralDeclarationContext ctx);
	/**
	 * Exit a parse tree produced by {@link TinyCellParser#generalDeclaration}.
	 * @param ctx the parse tree
	 */
	void exitGeneralDeclaration(TinyCellParser.GeneralDeclarationContext ctx);
	/**
	 * Enter a parse tree produced by {@link TinyCellParser#setupDefinition}.
	 * @param ctx the parse tree
	 */
	void enterSetupDefinition(TinyCellParser.SetupDefinitionContext ctx);
	/**
	 * Exit a parse tree produced by {@link TinyCellParser#setupDefinition}.
	 * @param ctx the parse tree
	 */
	void exitSetupDefinition(TinyCellParser.SetupDefinitionContext ctx);
	/**
	 * Enter a parse tree produced by {@link TinyCellParser#updateDefinition}.
	 * @param ctx the parse tree
	 */
	void enterUpdateDefinition(TinyCellParser.UpdateDefinitionContext ctx);
	/**
	 * Exit a parse tree produced by {@link TinyCellParser#updateDefinition}.
	 * @param ctx the parse tree
	 */
	void exitUpdateDefinition(TinyCellParser.UpdateDefinitionContext ctx);
	/**
	 * Enter a parse tree produced by {@link TinyCellParser#functionDefinition}.
	 * @param ctx the parse tree
	 */
	void enterFunctionDefinition(TinyCellParser.FunctionDefinitionContext ctx);
	/**
	 * Exit a parse tree produced by {@link TinyCellParser#functionDefinition}.
	 * @param ctx the parse tree
	 */
	void exitFunctionDefinition(TinyCellParser.FunctionDefinitionContext ctx);
	/**
	 * Enter a parse tree produced by {@link TinyCellParser#type}.
	 * @param ctx the parse tree
	 */
	void enterType(TinyCellParser.TypeContext ctx);
	/**
	 * Exit a parse tree produced by {@link TinyCellParser#type}.
	 * @param ctx the parse tree
	 */
	void exitType(TinyCellParser.TypeContext ctx);
	/**
	 * Enter a parse tree produced by {@link TinyCellParser#parameterList}.
	 * @param ctx the parse tree
	 */
	void enterParameterList(TinyCellParser.ParameterListContext ctx);
	/**
	 * Exit a parse tree produced by {@link TinyCellParser#parameterList}.
	 * @param ctx the parse tree
	 */
	void exitParameterList(TinyCellParser.ParameterListContext ctx);
	/**
	 * Enter a parse tree produced by {@link TinyCellParser#parameter}.
	 * @param ctx the parse tree
	 */
	void enterParameter(TinyCellParser.ParameterContext ctx);
	/**
	 * Exit a parse tree produced by {@link TinyCellParser#parameter}.
	 * @param ctx the parse tree
	 */
	void exitParameter(TinyCellParser.ParameterContext ctx);
	/**
	 * Enter a parse tree produced by {@link TinyCellParser#declaration}.
	 * @param ctx the parse tree
	 */
	void enterDeclaration(TinyCellParser.DeclarationContext ctx);
	/**
	 * Exit a parse tree produced by {@link TinyCellParser#declaration}.
	 * @param ctx the parse tree
	 */
	void exitDeclaration(TinyCellParser.DeclarationContext ctx);
	/**
	 * Enter a parse tree produced by {@link TinyCellParser#initialDeclaration}.
	 * @param ctx the parse tree
	 */
	void enterInitialDeclaration(TinyCellParser.InitialDeclarationContext ctx);
	/**
	 * Exit a parse tree produced by {@link TinyCellParser#initialDeclaration}.
	 * @param ctx the parse tree
	 */
	void exitInitialDeclaration(TinyCellParser.InitialDeclarationContext ctx);
	/**
	 * Enter a parse tree produced by {@link TinyCellParser#compoundStatement}.
	 * @param ctx the parse tree
	 */
	void enterCompoundStatement(TinyCellParser.CompoundStatementContext ctx);
	/**
	 * Exit a parse tree produced by {@link TinyCellParser#compoundStatement}.
	 * @param ctx the parse tree
	 */
	void exitCompoundStatement(TinyCellParser.CompoundStatementContext ctx);
	/**
	 * Enter a parse tree produced by {@link TinyCellParser#statement}.
	 * @param ctx the parse tree
	 */
	void enterStatement(TinyCellParser.StatementContext ctx);
	/**
	 * Exit a parse tree produced by {@link TinyCellParser#statement}.
	 * @param ctx the parse tree
	 */
	void exitStatement(TinyCellParser.StatementContext ctx);
	/**
	 * Enter a parse tree produced by {@link TinyCellParser#ifStatement}.
	 * @param ctx the parse tree
	 */
	void enterIfStatement(TinyCellParser.IfStatementContext ctx);
	/**
	 * Exit a parse tree produced by {@link TinyCellParser#ifStatement}.
	 * @param ctx the parse tree
	 */
	void exitIfStatement(TinyCellParser.IfStatementContext ctx);
	/**
	 * Enter a parse tree produced by {@link TinyCellParser#loopStatement}.
	 * @param ctx the parse tree
	 */
	void enterLoopStatement(TinyCellParser.LoopStatementContext ctx);
	/**
	 * Exit a parse tree produced by {@link TinyCellParser#loopStatement}.
	 * @param ctx the parse tree
	 */
	void exitLoopStatement(TinyCellParser.LoopStatementContext ctx);
	/**
	 * Enter a parse tree produced by {@link TinyCellParser#jumpStatement}.
	 * @param ctx the parse tree
	 */
	void enterJumpStatement(TinyCellParser.JumpStatementContext ctx);
	/**
	 * Exit a parse tree produced by {@link TinyCellParser#jumpStatement}.
	 * @param ctx the parse tree
	 */
	void exitJumpStatement(TinyCellParser.JumpStatementContext ctx);
	/**
	 * Enter a parse tree produced by {@link TinyCellParser#expression}.
	 * @param ctx the parse tree
	 */
	void enterExpression(TinyCellParser.ExpressionContext ctx);
	/**
	 * Exit a parse tree produced by {@link TinyCellParser#expression}.
	 * @param ctx the parse tree
	 */
	void exitExpression(TinyCellParser.ExpressionContext ctx);
	/**
	 * Enter a parse tree produced by {@link TinyCellParser#assignmentExpression}.
	 * @param ctx the parse tree
	 */
	void enterAssignmentExpression(TinyCellParser.AssignmentExpressionContext ctx);
	/**
	 * Exit a parse tree produced by {@link TinyCellParser#assignmentExpression}.
	 * @param ctx the parse tree
	 */
	void exitAssignmentExpression(TinyCellParser.AssignmentExpressionContext ctx);
	/**
	 * Enter a parse tree produced by {@link TinyCellParser#ternaryExpression}.
	 * @param ctx the parse tree
	 */
	void enterTernaryExpression(TinyCellParser.TernaryExpressionContext ctx);
	/**
	 * Exit a parse tree produced by {@link TinyCellParser#ternaryExpression}.
	 * @param ctx the parse tree
	 */
	void exitTernaryExpression(TinyCellParser.TernaryExpressionContext ctx);
	/**
	 * Enter a parse tree produced by {@link TinyCellParser#orExpression}.
	 * @param ctx the parse tree
	 */
	void enterOrExpression(TinyCellParser.OrExpressionContext ctx);
	/**
	 * Exit a parse tree produced by {@link TinyCellParser#orExpression}.
	 * @param ctx the parse tree
	 */
	void exitOrExpression(TinyCellParser.OrExpressionContext ctx);
	/**
	 * Enter a parse tree produced by {@link TinyCellParser#andExpression}.
	 * @param ctx the parse tree
	 */
	void enterAndExpression(TinyCellParser.AndExpressionContext ctx);
	/**
	 * Exit a parse tree produced by {@link TinyCellParser#andExpression}.
	 * @param ctx the parse tree
	 */
	void exitAndExpression(TinyCellParser.AndExpressionContext ctx);
	/**
	 * Enter a parse tree produced by {@link TinyCellParser#equalityExpression}.
	 * @param ctx the parse tree
	 */
	void enterEqualityExpression(TinyCellParser.EqualityExpressionContext ctx);
	/**
	 * Exit a parse tree produced by {@link TinyCellParser#equalityExpression}.
	 * @param ctx the parse tree
	 */
	void exitEqualityExpression(TinyCellParser.EqualityExpressionContext ctx);
	/**
	 * Enter a parse tree produced by {@link TinyCellParser#comparisonExpression}.
	 * @param ctx the parse tree
	 */
	void enterComparisonExpression(TinyCellParser.ComparisonExpressionContext ctx);
	/**
	 * Exit a parse tree produced by {@link TinyCellParser#comparisonExpression}.
	 * @param ctx the parse tree
	 */
	void exitComparisonExpression(TinyCellParser.ComparisonExpressionContext ctx);
	/**
	 * Enter a parse tree produced by {@link TinyCellParser#bitshiftExpression}.
	 * @param ctx the parse tree
	 */
	void enterBitshiftExpression(TinyCellParser.BitshiftExpressionContext ctx);
	/**
	 * Exit a parse tree produced by {@link TinyCellParser#bitshiftExpression}.
	 * @param ctx the parse tree
	 */
	void exitBitshiftExpression(TinyCellParser.BitshiftExpressionContext ctx);
	/**
	 * Enter a parse tree produced by {@link TinyCellParser#additiveExpression}.
	 * @param ctx the parse tree
	 */
	void enterAdditiveExpression(TinyCellParser.AdditiveExpressionContext ctx);
	/**
	 * Exit a parse tree produced by {@link TinyCellParser#additiveExpression}.
	 * @param ctx the parse tree
	 */
	void exitAdditiveExpression(TinyCellParser.AdditiveExpressionContext ctx);
	/**
	 * Enter a parse tree produced by {@link TinyCellParser#multiplicativeExpression}.
	 * @param ctx the parse tree
	 */
	void enterMultiplicativeExpression(TinyCellParser.MultiplicativeExpressionContext ctx);
	/**
	 * Exit a parse tree produced by {@link TinyCellParser#multiplicativeExpression}.
	 * @param ctx the parse tree
	 */
	void exitMultiplicativeExpression(TinyCellParser.MultiplicativeExpressionContext ctx);
	/**
	 * Enter a parse tree produced by {@link TinyCellParser#unaryExpression}.
	 * @param ctx the parse tree
	 */
	void enterUnaryExpression(TinyCellParser.UnaryExpressionContext ctx);
	/**
	 * Exit a parse tree produced by {@link TinyCellParser#unaryExpression}.
	 * @param ctx the parse tree
	 */
	void exitUnaryExpression(TinyCellParser.UnaryExpressionContext ctx);
	/**
	 * Enter a parse tree produced by {@link TinyCellParser#primitiveExpression}.
	 * @param ctx the parse tree
	 */
	void enterPrimitiveExpression(TinyCellParser.PrimitiveExpressionContext ctx);
	/**
	 * Exit a parse tree produced by {@link TinyCellParser#primitiveExpression}.
	 * @param ctx the parse tree
	 */
	void exitPrimitiveExpression(TinyCellParser.PrimitiveExpressionContext ctx);
	/**
	 * Enter a parse tree produced by {@link TinyCellParser#pinExpression}.
	 * @param ctx the parse tree
	 */
	void enterPinExpression(TinyCellParser.PinExpressionContext ctx);
	/**
	 * Exit a parse tree produced by {@link TinyCellParser#pinExpression}.
	 * @param ctx the parse tree
	 */
	void exitPinExpression(TinyCellParser.PinExpressionContext ctx);
	/**
	 * Enter a parse tree produced by {@link TinyCellParser#identifier}.
	 * @param ctx the parse tree
	 */
	void enterIdentifier(TinyCellParser.IdentifierContext ctx);
	/**
	 * Exit a parse tree produced by {@link TinyCellParser#identifier}.
	 * @param ctx the parse tree
	 */
	void exitIdentifier(TinyCellParser.IdentifierContext ctx);
	/**
	 * Enter a parse tree produced by {@link TinyCellParser#assignmentOperator}.
	 * @param ctx the parse tree
	 */
	void enterAssignmentOperator(TinyCellParser.AssignmentOperatorContext ctx);
	/**
	 * Exit a parse tree produced by {@link TinyCellParser#assignmentOperator}.
	 * @param ctx the parse tree
	 */
	void exitAssignmentOperator(TinyCellParser.AssignmentOperatorContext ctx);
	/**
	 * Enter a parse tree produced by {@link TinyCellParser#pinVoltage}.
	 * @param ctx the parse tree
	 */
	void enterPinVoltage(TinyCellParser.PinVoltageContext ctx);
	/**
	 * Exit a parse tree produced by {@link TinyCellParser#pinVoltage}.
	 * @param ctx the parse tree
	 */
	void exitPinVoltage(TinyCellParser.PinVoltageContext ctx);
}