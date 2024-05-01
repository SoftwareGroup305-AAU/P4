namespace P4.TinyCell.Language.AbstractSyntaxTree.Primitive;

public class BoolNode(bool value) : PrimitveExprNode<bool>(value, Type.BOOL)
{
}
