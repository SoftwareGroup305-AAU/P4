namespace P4.TinyCell.Language.AbstractSyntaxTree.Statement;
public class StatementCollectionNode : AstNode
{
    public StatementCollectionNode(AstNode[] statements)
    {
        foreach (AstNode statement in statements)
        {
            AddChild(statement);
        }
    }
}
