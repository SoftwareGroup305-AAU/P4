namespace P4.TinyCell.Language.AbstractSyntaxTree.Statement;
public class WhileStatementNode : AstNode
{
    public AstNode Condition { get; set; }
    public AstNode CompoundStatement { get; set; }

    public WhileStatementNode(AstNode condition, AstNode compoundStatement)
    {
        Condition = condition;
        CompoundStatement = compoundStatement;

        AddChild(Condition);
        AddChild(CompoundStatement);
    }
}
