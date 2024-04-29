namespace P4.TinyCell.AST.Primitive;

public class BoolNode(bool value) : PrimitveExprNode<bool>(value, Type.BOOL)
{
}
