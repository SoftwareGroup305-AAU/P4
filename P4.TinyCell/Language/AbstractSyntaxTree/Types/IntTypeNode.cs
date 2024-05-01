namespace P4.TinyCell.Language.AbstractSyntaxTree.Types;
public class IntTypeNode : TypeNode
{
    public override T Accept<T>(IAstVisitor<T> visitor)
    {
        return visitor.VisitIntTypeNode(this);
    }
}
