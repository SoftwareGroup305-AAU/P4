namespace P4.TinyCell.Language.AbstractSyntaxTree.UnaryExpr;

public class UnaryExprNode : AstNode
{
    public UnaryExprNode(AstNode node)
    {
        AddChild(node);
    }
}
