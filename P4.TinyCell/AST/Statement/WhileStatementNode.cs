namespace P4.TinyCell.AST.Statement;
public class WhileStatementNode(AstNode condition, AstNode compoundStatement) : AstNode
{
    public AstNode Condition { get; set; } = condition;
    public AstNode CompoundStatement { get; set; } = compoundStatement;
}
