namespace P4.TinyCell.Language.AbstractSyntaxTree.Types;
public class BoolTypeNode : TypeNode
{
    public override T Accept<T>(IAstVisitor<T> visitor)
    {
        return visitor.VisitBoolTypeNode(this);
    }
}
