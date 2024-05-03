using P4.TinyCell.Shared.Language.AbstractSyntaxTree.Primitive;
using P4.TinyCell.Shared.Language.AbstractSyntaxTree.Types;

namespace P4.TinyCell.Shared.Language.AbstractSyntaxTree.ParameterNodes;
public class ParameterNode : AstNode
{
    public TypeNode TypeNode { get; set; }
    public IdentifierNode Identifier { get; set; }

    public ParameterNode(TypeNode type, IdentifierNode identifier)
    {
        TypeNode = type;
        Identifier = identifier;

        AddChild(type);
        AddChild(identifier);
    }

    public override T Accept<T>(IAstVisitor<T> visitor)
    {
        return visitor.VisitParameterNode(this);
    }
}
