namespace P4.TinyCell.Language.AbstractSyntaxTree.Function;
public class ArgumentListNode : AstNode
{
    public ArgumentNode[] Arguments { get; }

    public ArgumentListNode(ArgumentNode[] arguments)
    {
        Arguments = arguments;

        foreach (ArgumentNode argument in arguments)
        {
            AddChild(argument);
        }
    }
}
