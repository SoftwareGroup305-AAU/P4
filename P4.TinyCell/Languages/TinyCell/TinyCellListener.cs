//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.13.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from P4.TinyCell/Languages/TinyCell/TinyCell.g4 by ANTLR 4.13.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="TinyCellParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.1")]
[System.CLSCompliant(false)]
public interface ITinyCellListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="TinyCellParser.document"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDocument([NotNull] TinyCellParser.DocumentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TinyCellParser.document"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDocument([NotNull] TinyCellParser.DocumentContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TinyCellParser.generalDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGeneralDeclaration([NotNull] TinyCellParser.GeneralDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TinyCellParser.generalDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGeneralDeclaration([NotNull] TinyCellParser.GeneralDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TinyCellParser.setupDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSetupDefinition([NotNull] TinyCellParser.SetupDefinitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TinyCellParser.setupDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSetupDefinition([NotNull] TinyCellParser.SetupDefinitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TinyCellParser.updateDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUpdateDefinition([NotNull] TinyCellParser.UpdateDefinitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TinyCellParser.updateDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUpdateDefinition([NotNull] TinyCellParser.UpdateDefinitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TinyCellParser.functionDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionDefinition([NotNull] TinyCellParser.FunctionDefinitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TinyCellParser.functionDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionDefinition([NotNull] TinyCellParser.FunctionDefinitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TinyCellParser.type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterType([NotNull] TinyCellParser.TypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TinyCellParser.type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitType([NotNull] TinyCellParser.TypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TinyCellParser.parameterList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParameterList([NotNull] TinyCellParser.ParameterListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TinyCellParser.parameterList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParameterList([NotNull] TinyCellParser.ParameterListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TinyCellParser.parameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParameter([NotNull] TinyCellParser.ParameterContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TinyCellParser.parameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParameter([NotNull] TinyCellParser.ParameterContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TinyCellParser.declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeclaration([NotNull] TinyCellParser.DeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TinyCellParser.declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeclaration([NotNull] TinyCellParser.DeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TinyCellParser.initialDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInitialDeclaration([NotNull] TinyCellParser.InitialDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TinyCellParser.initialDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInitialDeclaration([NotNull] TinyCellParser.InitialDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TinyCellParser.compoundStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCompoundStatement([NotNull] TinyCellParser.CompoundStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TinyCellParser.compoundStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCompoundStatement([NotNull] TinyCellParser.CompoundStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TinyCellParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatement([NotNull] TinyCellParser.StatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TinyCellParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatement([NotNull] TinyCellParser.StatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TinyCellParser.ifStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIfStatement([NotNull] TinyCellParser.IfStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TinyCellParser.ifStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIfStatement([NotNull] TinyCellParser.IfStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TinyCellParser.loopStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLoopStatement([NotNull] TinyCellParser.LoopStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TinyCellParser.loopStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLoopStatement([NotNull] TinyCellParser.LoopStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TinyCellParser.jumpStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterJumpStatement([NotNull] TinyCellParser.JumpStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TinyCellParser.jumpStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitJumpStatement([NotNull] TinyCellParser.JumpStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TinyCellParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpression([NotNull] TinyCellParser.ExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TinyCellParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpression([NotNull] TinyCellParser.ExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TinyCellParser.assignmentExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssignmentExpression([NotNull] TinyCellParser.AssignmentExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TinyCellParser.assignmentExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssignmentExpression([NotNull] TinyCellParser.AssignmentExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TinyCellParser.ternaryExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTernaryExpression([NotNull] TinyCellParser.TernaryExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TinyCellParser.ternaryExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTernaryExpression([NotNull] TinyCellParser.TernaryExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TinyCellParser.orExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOrExpression([NotNull] TinyCellParser.OrExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TinyCellParser.orExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOrExpression([NotNull] TinyCellParser.OrExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TinyCellParser.andExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAndExpression([NotNull] TinyCellParser.AndExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TinyCellParser.andExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAndExpression([NotNull] TinyCellParser.AndExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TinyCellParser.equalityExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEqualityExpression([NotNull] TinyCellParser.EqualityExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TinyCellParser.equalityExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEqualityExpression([NotNull] TinyCellParser.EqualityExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TinyCellParser.comparisonExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterComparisonExpression([NotNull] TinyCellParser.ComparisonExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TinyCellParser.comparisonExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitComparisonExpression([NotNull] TinyCellParser.ComparisonExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TinyCellParser.bitshiftExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBitshiftExpression([NotNull] TinyCellParser.BitshiftExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TinyCellParser.bitshiftExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBitshiftExpression([NotNull] TinyCellParser.BitshiftExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TinyCellParser.additiveExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAdditiveExpression([NotNull] TinyCellParser.AdditiveExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TinyCellParser.additiveExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAdditiveExpression([NotNull] TinyCellParser.AdditiveExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TinyCellParser.multiplicativeExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMultiplicativeExpression([NotNull] TinyCellParser.MultiplicativeExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TinyCellParser.multiplicativeExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMultiplicativeExpression([NotNull] TinyCellParser.MultiplicativeExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TinyCellParser.unaryExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnaryExpression([NotNull] TinyCellParser.UnaryExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TinyCellParser.unaryExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnaryExpression([NotNull] TinyCellParser.UnaryExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TinyCellParser.primitiveExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrimitiveExpression([NotNull] TinyCellParser.PrimitiveExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TinyCellParser.primitiveExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrimitiveExpression([NotNull] TinyCellParser.PrimitiveExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TinyCellParser.pinExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPinExpression([NotNull] TinyCellParser.PinExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TinyCellParser.pinExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPinExpression([NotNull] TinyCellParser.PinExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TinyCellParser.identifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIdentifier([NotNull] TinyCellParser.IdentifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TinyCellParser.identifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIdentifier([NotNull] TinyCellParser.IdentifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TinyCellParser.assignmentOperator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssignmentOperator([NotNull] TinyCellParser.AssignmentOperatorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TinyCellParser.assignmentOperator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssignmentOperator([NotNull] TinyCellParser.AssignmentOperatorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TinyCellParser.pinVoltage"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPinVoltage([NotNull] TinyCellParser.PinVoltageContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TinyCellParser.pinVoltage"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPinVoltage([NotNull] TinyCellParser.PinVoltageContext context);
}
