namespace P4.TinyCell.Shared.Language.AbstractSyntaxTree.Statement;
public class StatementCollectionNode : AstNode
{
    public StatementCollectionNode(AstNode[] statements)
    {
        foreach (AstNode statement in statements)
        {
            AddChild(statement);
        }
    }

    public override T Accept<T>(IAstVisitor<T> visitor)
    {
        return visitor.VisitStatementCollectionNode(this);
    }
}
