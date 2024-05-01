namespace P4.TinyCell.Language.AbstractSyntaxTree.Primitive;

public class StringNode(string value) : PrimitveExprNode<string>(value, TcType.STRING)
{
    public override T Accept<T>(IAstVisitor<T> visitor)
    {
        return visitor.VisitStringNode(this);
    }
}
