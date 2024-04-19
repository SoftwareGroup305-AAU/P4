using Antlr4.Runtime;
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

        var tree = parser.document();

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