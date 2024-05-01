using P4.TinyCell.Language.AbstractSyntaxTree.Primitive;

namespace P4.TinyCell.Language.AbstractSyntaxTree.PinExpr;
public class PinModeExprNode : AstNode
{
    public IdentifierNode Identifier { get; set; }
    public PinModeNode Value { get; set; }

    public PinModeExprNode(IdentifierNode identifier, PinModeNode value)
    {
        Identifier = identifier;
        Value = value;

        AddChild(identifier);
        AddChild(value);
    }
}
