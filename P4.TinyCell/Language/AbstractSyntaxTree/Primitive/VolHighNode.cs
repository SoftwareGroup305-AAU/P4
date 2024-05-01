namespace P4.TinyCell.Language.AbstractSyntaxTree.Primitive;

public class VolHighNode : AstNode
{
    public override T Accept<T>(IAstVisitor<T> visitor)
    {
        return visitor.VisitVolHighNode(this);
    }
}
