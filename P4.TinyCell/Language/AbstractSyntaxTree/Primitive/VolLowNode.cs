namespace P4.TinyCell.Language.AbstractSyntaxTree.Primitive;

public class VolLowNode : AstNode
{
    public override T Accept<T>(IAstVisitor<T> visitor)
    {
        return visitor.VisitVolLowNode(this);
    }
}
