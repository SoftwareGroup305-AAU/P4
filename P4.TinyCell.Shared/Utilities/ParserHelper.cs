using Antlr4.Runtime;

namespace P4.TinyCell.Shared.Utilities
{
    public class ParserHelper
    {
        public static void PrintTree(ParserRuleContext tree, int indentation = 0)
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

        public class NoErrorListener : BaseErrorListener
        {
            public override void SyntaxError(TextWriter output, IRecognizer recognizer, IToken offendingSymbol, int line, int charPositionInLine, string msg, RecognitionException e)
            {
                throw new Exception($"Syntax error at line {line}:{charPositionInLine} at {offendingSymbol.Text}");
            }

            public override void ReportAmbiguity(Parser recognizer, DFA dfa, int startIndex, int stopIndex, bool exact, BitSet ambigAlts, ATNConfigSet configs)
            {
                throw new Exception($"Ambiguity at {startIndex}:{stopIndex}");
            }

            public override void ReportAttemptingFullContext(Parser recognizer, DFA dfa, int startIndex, int stopIndex, BitSet conflictingAlts, ATNConfigSet configs)
            {
                throw new Exception($"Attempting full context at {startIndex}:{stopIndex}");
            }

            public override void ReportContextSensitivity(Parser recognizer, DFA dfa, int startIndex, int stopIndex, int prediction, ATNConfigSet configs)
            {
                throw new Exception($"Context sensitivity at {startIndex}:{stopIndex}");

            }
        }
    }
}
