namespace P4.TinyCell.Shared.Language.AbstractSyntaxTree.Expression;
public class InitialDeclerationNode : AstNode
{
    public AstNode Identifier { get; set; }
    public AstNode? Action { get; set; }

    public InitialDeclerationNode(AstNode identifier, AstNode action)
    {
        Identifier = identifier;
        Action = action;
    }
    public InitialDeclerationNode(AstNode identifier)
    {
        Identifier = identifier;
    }

    public override T Accept<T>(IAstVisitor<T> visitor)
    {
        throw new NotImplementedException();
    }
}
