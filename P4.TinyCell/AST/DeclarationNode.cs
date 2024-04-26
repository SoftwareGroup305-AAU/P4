namespace P4.TinyCell.AST;
public class DeclarationNode : AstNode
{
    public DeclarationNode(AstNode type, AstNode identifier)
    {
        children.Add(type);
        children.Add(identifier);
    }

    public DeclarationNode(AstNode type, AstNode identifier, AstNode action)
    {
        children.Add(type);
        children.Add(identifier);
        children.Add(action);
    }
}
