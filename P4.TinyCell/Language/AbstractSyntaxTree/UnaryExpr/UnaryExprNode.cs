namespace P4.TinyCell.AST.UnaryExpr
{
    public class UnaryExprNode : AstNode
    {
        public UnaryExprNode(AstNode node)
        {
            ArgumentNullException.ThrowIfNull(node);

            children.Add(node);
        }
    }
}
