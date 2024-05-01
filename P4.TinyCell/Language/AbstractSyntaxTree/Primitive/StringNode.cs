namespace P4.TinyCell.Language.AbstractSyntaxTree.Primitive;

public class StringNode(string value) : PrimitveExprNode<string>(value, Type.STRING)
{
}
