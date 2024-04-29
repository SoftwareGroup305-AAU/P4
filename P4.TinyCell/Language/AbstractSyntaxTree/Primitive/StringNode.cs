namespace P4.TinyCell.AST.Primitive;

public class StringNode(string value) : PrimitveExprNode<string>(value, Type.STRING)
{
}
