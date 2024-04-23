using Antlr4.Runtime;

namespace P4.TinyCell.AST
{
    public class AstNode
    {
        public List<AstNode> Children = [];

        public override string ToString()
        {
            string str = $"{GetType().Name}";
            foreach (AstNode child in Children)
            {
                str += $"{child.ToString(0)}";
            }

            return str;
        }

        public string ToString(int indentation)
        {
            var indent = new string(' ', indentation * 2);
            string str = $"{indent}{GetType().Name}";

            foreach (AstNode child in Children)
            {
                str += $"{child.ToString(indentation + 1)}";

            }

            return str;
        }

        public void AddChild(AstNode node)
        {
            Children.Add(node);
        }
    }
}
