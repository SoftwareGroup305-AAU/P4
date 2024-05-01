namespace P4.TinyCell.Language.AbstractSyntaxTree.NumExpr;

public abstract class BinExprNode : AstNode
{
    public BinExprNode(AstNode left, AstNode right)
    {
        children.Add(left);
        children.Add(right);
    }
}
