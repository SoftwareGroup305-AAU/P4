using P4.TinyCell.Shared.Language.AbstractSyntaxTree.Primitive;

namespace P4.TinyCell.Shared.Language.AbstractSyntaxTree.Assignment;
public class IncludeNode : AstNode
{
    public IdentifierNode FileName { get; set; }

    public IncludeNode(IdentifierNode fileName)
    {
        FileName = fileName;
        AddChild(fileName);
    }

    public override T Accept<T>(IAstVisitor<T> visitor)
    {
        return visitor.VisitIncludeNode(this);
    }
}
