namespace P4.TinyCell.Language.AbstractSyntaxTree.Types;
public class VoidTypeNode : TypeNode
{
    public override T Accept<T>(IAstVisitor<T> visitor)
    {
        return visitor.VisitVoidTypeNode(this);
    }
}
