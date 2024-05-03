namespace P4.TinyCell.Language.AbstractSyntaxTree.Statement;
public class ReturnNode : AstNode
{
    public ReturnNode(AstNode returnExpression)
    {
        AddChild(returnExpression);
    }
    public ReturnNode()
    {
    }

    public override T Accept<T>(IAstVisitor<T> visitor)
    {
        return visitor.VisitReturnNode(this);
    }
}
