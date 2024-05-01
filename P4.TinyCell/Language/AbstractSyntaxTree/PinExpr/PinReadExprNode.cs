namespace P4.TinyCell.Language.AbstractSyntaxTree.PinExpr;
public class PinReadExprNode(AstNode from, AstNode to) : PinExprNode(from, to)
{
    public override T Accept<T>(IAstVisitor<T> visitor)
    {
        return visitor.VisitPinReadExprNode(this);
    }
}
