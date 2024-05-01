namespace P4.TinyCell.Language.AbstractSyntaxTree.Primitive;

public abstract class PrimitveExprNode<T> : AstNode
{
    public T? Value { get; set; }
    public Type Type { get; set; }
    public PrimitveExprNode(T value)
    {
        Value = value;
    }

    public PrimitveExprNode(Type type)
    {
        Type = type;
    }

    public PrimitveExprNode(T value, Type type)
    {
        Value = value;
        Type = type;
    }
}
