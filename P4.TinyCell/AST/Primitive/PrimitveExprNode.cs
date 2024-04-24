namespace P4.TinyCell.AST.Primitive;

public class PrimitveExprNode<T> : AstNode
{
    public T? Value { get; set; }
    public Type Type { get; set; }
    public PrimitveExprNode(T value)
    {
        ArgumentNullException.ThrowIfNull(value);
        Value = value;
    }

    public PrimitveExprNode(Type type)
    {
        ArgumentNullException.ThrowIfNull(type);
        Type = type;
    }

    public PrimitveExprNode(T value, Type type)
    {
        ArgumentNullException.ThrowIfNull(value);
        Value = value;
        Type = type;
    }
}
