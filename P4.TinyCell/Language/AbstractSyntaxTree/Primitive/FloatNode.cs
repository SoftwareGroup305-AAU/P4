namespace P4.TinyCell.Language.AbstractSyntaxTree.Primitive;

public class FloatNode(float value) : PrimitveExprNode<float>(value, Type.FLOAT)
{
    public override T Accept<T>(IAstVisitor<T> visitor)
    {
        return visitor.VisitFloatNode(this);
    }
}
