namespace P4.TinyCell.AST.StatementExpr;

public class IfStatementNode(AstNode condition, AstNode trueExpr, AstNode falseExpr) : AstNode
{
    public AstNode Condition { get; set; } = condition;
    public AstNode TrueExpr { get; set; } = trueExpr;
    public AstNode FalseExpr { get; set; } = falseExpr;
}
