namespace P4.TinyCell.Language.AbstractSyntaxTree.UnaryExpr;

public class UnaryMinusExprNode(AstNode operand) : UnaryExprNode(operand)
{
    public override T Accept<T>(IAstVisitor<T> visitor)
    {
        return visitor.VisitUnaryMinusExprNode(this);
    }
}
