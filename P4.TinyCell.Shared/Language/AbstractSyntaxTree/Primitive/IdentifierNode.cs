namespace P4.TinyCell.Shared.Language.AbstractSyntaxTree.Primitive;
public class IdentifierNode(string value) : PrimitveExprNode<string>(value)
{
    public override T Accept<T>(IAstVisitor<T> visitor)
    {
        return visitor.VisitIdentifierNode(this);
    }
}
