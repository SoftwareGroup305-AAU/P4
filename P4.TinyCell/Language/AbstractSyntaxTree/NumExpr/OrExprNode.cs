namespace P4.TinyCell.Language.AbstractSyntaxTree.NumExpr;

public class OrExprNode(AstNode left, AstNode right) : BinExprNode(left, right)
{
    public override T Accept<T>(IAstVisitor<T> visitor)
    {
        return visitor.VisitOrExprNode(this);
    }
}
