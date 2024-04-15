using Antlr4.Runtime;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        using var fs = new StreamReader("Languages/TinyCell/test.tc");

        AntlrInputStream antlrInputStream = new AntlrInputStream(fs);

        Lexer lexer = new TinyCellLexer(antlrInputStream);

        var tokenStream = new CommonTokenStream(lexer);

        Parser parser = new TinyCellParser(tokenStream);

        var a = lexer.GetAllTokens();
        Console.WriteLine("a");
    }
}