using Antlr4.Runtime;

namespace P4.TinyCell.Language.AbstractSyntaxTree;

public abstract class AstNode : ParserRuleContext
{
    public AstNode()
    {
        children = [];
    }

    public virtual void Accept(IAstVisitor visitor) { }

    public override string ToString()
    {
        return ToString(0);
    }

    public string ToString(int indentation)
    {
        var indent = new string(' ', indentation * 2);
        string str = $"{indent}{GetType().Name}";

        foreach (AstNode child in children.Where(s => s is not null))
        {
            str += $"\n{child.ToString(indentation + 1)}";
        }

        return str;
    }

    public void AddChild(AstNode node)
    {
        children.Add(node);
    }
}
