namespace P4.TinyCell.AST;

public abstract class BinExprNode : AstNode
{
    public BinExprNode(AstNode left, AstNode right)
    {
        ArgumentNullException.ThrowIfNull(left);
        ArgumentNullException.ThrowIfNull(right);

        children.Add(left);
        children.Add(right);
    }
}
