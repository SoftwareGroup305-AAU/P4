namespace P4.TinyCell.Language.AbstractSyntaxTree.Primitive;

public class VoidNode() : PrimitveExprNode<object>(Type.VOID)
{
    public override T Accept<T>(IAstVisitor<T> visitor)
    {
        return visitor.VisitVoidNode(this);
    }
}
