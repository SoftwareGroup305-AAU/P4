namespace P4.TinyCell.Language.AbstractSyntaxTree.Types;
public class PinTypeNode : TypeNode
{
    public override T Accept<T>(IAstVisitor<T> visitor)
    {
        return visitor.VisitPinTypeNode(this);
    }
}
