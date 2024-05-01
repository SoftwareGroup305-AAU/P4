namespace P4.TinyCell.Language.AbstractSyntaxTree.NumExpr;

public class DivExprNode(AstNode left, AstNode right) : BinExprNode(left, right)
{
    public override T Accept<T>(IAstVisitor<T> visitor)
    {
        return visitor.VisitDivExprNode(this);
    }
}
