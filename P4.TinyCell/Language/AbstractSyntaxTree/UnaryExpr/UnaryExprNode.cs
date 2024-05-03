namespace P4.TinyCell.Language.AbstractSyntaxTree.UnaryExpr;

public abstract class UnaryExprNode : AstNode
{
    public AstNode Operand { get; set; }
    public UnaryExprNode(AstNode operand)
    {
        Operand = operand;
        AddChild(operand);
    }
}
