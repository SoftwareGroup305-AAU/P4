using Antlr4.Runtime;

namespace Utilities
{
    public class ParserHelper
    {
        public void PrintTree(ParserRuleContext tree, int indentation = 0)
        {
            var indent = new string(' ', indentation * 2);
            Console.WriteLine($"{indent}{tree.GetType().Name}");

            for (int i = 0; i < tree.ChildCount; i++)
            {
                var child = tree.GetChild(i);
                if (child is ParserRuleContext ruleContext)
                {
                    PrintTree(ruleContext, indentation + 1);
                }
            }
        }
    }
}
