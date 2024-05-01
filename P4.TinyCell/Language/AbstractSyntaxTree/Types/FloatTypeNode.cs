namespace P4.TinyCell.Language.AbstractSyntaxTree.Types;
public class FloatTypeNode : TypeNode
{
    public override T Accept<T>(IAstVisitor<T> visitor)
    {
        return visitor.VisitFloatTypeNode(this);
    }
}
