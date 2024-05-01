namespace P4.TinyCell.Language.AbstractSyntaxTree.UnaryExpr;

public class UnaryPlusExprNode(AstNode operand) : UnaryExprNode(operand)
{
    public override T Accept<T>(IAstVisitor<T> visitor)
    {
        return visitor.VisitUnaryPlusExprNode(this);
    }
}
