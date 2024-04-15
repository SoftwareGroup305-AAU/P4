using Antlr4.Runtime;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        using var fs = new StreamReader("Test.tc");

        AntlrInputStream antlrInputStream = new AntlrInputStream(fs);

        TinyCellLexer lexer = new TinyCellLexer(antlrInputStream);

        var tokenStream = new CommonTokenStream(lexer);
        
        TinyCellParser parser = new TinyCellParser(tokenStream);

        var tree = parser.document();

        Console.WriteLine(tree.ToStringTree(parser));

        // var a = lexer.GetAllTokens();

        // foreach (var token in a)
        // {
        //     Console.WriteLine(token);   
        // }

    }
}