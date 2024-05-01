namespace P4.TinyCell.Language.AbstractSyntaxTree.UnaryExpr;

public abstract class UnaryExprNode : AstNode
{
    public UnaryExprNode(AstNode operand)
    {
        AddChild(operand);
    }
}
