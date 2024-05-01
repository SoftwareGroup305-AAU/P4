using P4.TinyCell.Language.AbstractSyntaxTree.Primitive;
using P4.TinyCell.Language.AbstractSyntaxTree.Types;

namespace P4.TinyCell.Language.AbstractSyntaxTree.ParameterNodes;
public class ParameterNode : AstNode
{
    public TypeNode Type { get; set; }
    public IdentifierNode Identifier { get; set; }

    public ParameterNode(TypeNode type, IdentifierNode identifier)
    {
        Type = type;
        Identifier = identifier;

        AddChild(type);
        AddChild(identifier);
    }

    public override T Accept<T>(IAstVisitor<T> visitor)
    {
        throw new NotImplementedException();
    }
}
