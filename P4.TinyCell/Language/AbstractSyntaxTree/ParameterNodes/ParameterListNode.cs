namespace P4.TinyCell.Language.AbstractSyntaxTree.ParameterNodes;
public class ParameterListNode : AstNode
{
    public AstNode[] Parameters { get; }

    public ParameterListNode(AstNode[] parameters)
    {
        Parameters = parameters;

        foreach (AstNode parameter in parameters)
        {
            AddChild(parameter);
        }
    }

    public override T Accept<T>(IAstVisitor<T> visitor)
    {
        return visitor.VisitParameterListNode(this);
    }
}
