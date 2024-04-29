using P4.TinyCell.AST.Primitive;

namespace P4.TinyCell.AST;
public class PinExprNode : AstNode
{
    public AstNode From { get; set; }
    public AstNode To { get; set; }

    public PinExprNode(AstNode from, AstNode to)
    {
        From = from;
        To = to;

        AddChild(from);
        AddChild(to);
    }
}
