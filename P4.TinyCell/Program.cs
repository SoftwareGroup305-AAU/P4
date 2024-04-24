
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

                // Parse the input (assuming "document" is the name of the start rule)
                var tree = parser.document();

                LivenessAnalysisListener listener = new LivenessAnalysisListener();
                ParseTreeWalker.Default.Walk(listener, tree);
  
                var list = listener.instructions;

                Console.WriteLine("\n=================================================\n");
                Console.WriteLine("Tokens:");

                foreach (var token in tokenStream.GetTokens())
                {
                        Console.WriteLine(token);
                }

                Console.WriteLine("\n=================================================\n");
                Console.WriteLine("Parse Tree:");
                var ParserHelper = new ParserHelper();
                ParserHelper.PrintTree(tree);
        }
}