namespace P4.TinyCell.Language.AbstractSyntaxTree.Types;
public class TypeNode(Type type) : AstNode
{
    Type Type { get; set; } = type;

    public override T Accept<T>(IAstVisitor<T> visitor)
    {
        return visitor.VisitTypeNode(this);
    }
}
