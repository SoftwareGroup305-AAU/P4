namespace P4.TinyCell.AST.Function;
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
