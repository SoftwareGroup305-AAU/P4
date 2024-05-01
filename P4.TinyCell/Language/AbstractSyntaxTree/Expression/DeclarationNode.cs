namespace P4.TinyCell.Language.AbstractSyntaxTree.Expression;
public class DeclarationNode : AstNode
{
    public DeclarationNode(AstNode type, AstNode identifier)
    {
        AddChild(type);
        AddChild(identifier);
    }

    public DeclarationNode(AstNode type, AstNode identifier, AstNode action)
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
