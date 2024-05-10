using P4.TinyCell.Shared.Language.AbstractSyntaxTree.Primitive;

namespace P4.TinyCell.Shared.Language.AbstractSyntaxTree.Expression;
public class InitialDeclerationNode : AstNode
{
    public IdentifierNode Identifier { get; set; }
    public AstNode? ArrayIndex { get; set; }
    public AstNode? Action { get; set; }

    public InitialDeclerationNode(IdentifierNode identifier, AstNode action)
    {
        Identifier = identifier;
        Action = action;
    }

    public InitialDeclerationNode(IdentifierNode identifier, IdentifierNode arrayIndex)
    {
        Identifier = identifier;
        ArrayIndex = arrayIndex;
    }

    public InitialDeclerationNode(IdentifierNode identifier, IntNode arrayIndex)
    {
        Identifier = identifier;
        ArrayIndex = arrayIndex;
    }

    public InitialDeclerationNode(IdentifierNode identifier, IdentifierNode arrayIndex, AstNode action)
    {
        Identifier = identifier;
        ArrayIndex = arrayIndex;
        Action = action;
    }

    public InitialDeclerationNode(IdentifierNode identifier, IntNode arrayIndex, AstNode action)
    {
        Identifier = identifier;
        ArrayIndex = arrayIndex;
        Action = action;
    }

    public InitialDeclerationNode(IdentifierNode identifier)
    {
        Identifier = identifier;
    }

    public override T Accept<T>(IAstVisitor<T> visitor)
    {
        throw new NotImplementedException();
    }
}
