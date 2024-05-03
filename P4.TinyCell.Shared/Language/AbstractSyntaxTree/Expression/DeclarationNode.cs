using P4.TinyCell.Shared.Language.AbstractSyntaxTree.Primitive;
using P4.TinyCell.Shared.Language.AbstractSyntaxTree.Types;

namespace P4.TinyCell.Shared.Language.AbstractSyntaxTree.Expression;
public class DeclarationNode : AstNode
{
    public DeclarationNode(TypeNode type, IdentifierNode identifier)
    {
        AddChild(type);
        AddChild(identifier);
    }

    public DeclarationNode(TypeNode type, IdentifierNode identifier, AstNode action)
    {
        AddChild(type);
        AddChild(identifier);
        AddChild(action);
    }

    public override T Accept<T>(IAstVisitor<T> visitor)
    {
        return visitor.VisitDeclarationNode(this);
    }
}
