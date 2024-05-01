namespace P4.TinyCell.Language.AbstractSyntaxTree.UnaryExpr;

public class NotExprNode(AstNode operand) : UnaryExprNode(operand)
{
    public override T Accept<T>(IAstVisitor<T> visitor)
    {
        return visitor.VisitNotExprNode(this);
    }
}
