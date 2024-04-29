namespace P4.TinyCell.AST.StatementExpr;

public class IfStatementNode(AstNode condition, AstNode trueExpr, AstNode? elseExpr) : AstNode
{
    public AstNode Condition { get; set; } = condition;
    public AstNode TrueExpr { get; set; } = trueExpr;
    public AstNode? ElseExpr { get; set; } = elseExpr;
}
