namespace P4.TinyCell.Language.AbstractSyntaxTree.Types;
public class StringTypeNode : TypeNode
{
    public override T Accept<T>(IAstVisitor<T> visitor)
    {
        return visitor.VisitStringTypeNode(this);
    }
}
