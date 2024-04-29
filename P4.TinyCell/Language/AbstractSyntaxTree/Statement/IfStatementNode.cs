namespace P4.TinyCell.AST.StatementExpr;

public class IfStatementNode : AstNode
{
    public AstNode Condition { get; set; }
    public AstNode TrueExpr { get; set; }
    public AstNode? ElseExpr { get; set; }

    public IfStatementNode(AstNode condition, AstNode trueExpr, AstNode? elseExpr)
    {
        Condition = condition;
        TrueExpr = trueExpr;
        ElseExpr = elseExpr;

        AddChild(condition);
        AddChild(trueExpr);
        if (ElseExpr != null)
        {
            AddChild(ElseExpr);
        }
    }
}
