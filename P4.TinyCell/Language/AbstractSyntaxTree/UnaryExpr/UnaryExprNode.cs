namespace P4.TinyCell.AST.UnaryExpr;

public class UnaryExprNode : AstNode
{
    public UnaryExprNode(AstNode node)
    {
        children.Add(node);
    }
}
