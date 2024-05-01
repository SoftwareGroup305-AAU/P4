namespace P4.TinyCell.Language.AbstractSyntaxTree.Primitive;

public class IntNode(int value) : PrimitveExprNode<int>(value, Type.INT)
{
    public override T Accept<T>(IAstVisitor<T> visitor)
    {
        return visitor.VisitIntNode(this);
    }
}
