namespace P4.TinyCell.Language.AbstractSyntaxTree.Primitive;

public class FloatNode(float value) : PrimitveExprNode<float>(value, Type.FLOAT)
{
}
