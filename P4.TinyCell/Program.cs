
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using P4.TinyCell.Languages.TinyCell;
using Utilities;

internal class Program
{
        private static void Main(string[] args)
        {
                string fileContent = File.ReadAllText("Test.tc");

                var antlrInputStream = new AntlrInputStream(fileContent);

                var lexer = new TinyCellLexer(antlrInputStream);

                var tokenStream = new CommonTokenStream(lexer);

                var parser = new TinyCellParser(tokenStream);

                tokenStream.Fill();

                var tokens = tokenStream.GetTokens();

                var tree = parser.document();

                LivenessAnalysisListener listener = new LivenessAnalysisListener();
                ParseTreeWalker.Default.Walk(listener, tree);
                var instructions = listener.Instructions;
        listener.LivenessGraph();
 

                Console.WriteLine("\n=================================================\n");
                Console.WriteLine("Tokens:");

                foreach (var token in tokens)
                {
                        int tokenType = token.Type - 1;
                        string ruleName = tokenType >= 0 && tokenType < TinyCellLexer.ruleNames.Length ? TinyCellLexer.ruleNames[tokenType] : "Unknown";
                        Console.WriteLine(token + " | " + ruleName + " | " + token.Text);
                }

                Console.WriteLine("\n=================================================\n");
                Console.WriteLine("Parse Tree:");
                var ParserHelper = new ParserHelper();
                ParserHelper.PrintTree(tree);
        }
}