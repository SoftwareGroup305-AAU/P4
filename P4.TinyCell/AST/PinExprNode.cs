using P4.TinyCell.AST.Primitive;

namespace P4.TinyCell.AST;
public class PinExprNode(IdentifierNode identifier, AstNode value): PrimitveExprNode<AstNode>(value)
{
    public IdentifierNode Identifier { get; set; } = identifier;
}
