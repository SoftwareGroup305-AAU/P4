namespace P4.TinyCell.Language.AbstractSyntaxTree.Primitive;

public class BoolNode(bool value) : PrimitveExprNode<bool>(value, Type.BOOL)
{
    public override T Accept<T>(IAstVisitor<T> visitor)
    {
        return visitor.VisitBoolNode(this);
    }
}
