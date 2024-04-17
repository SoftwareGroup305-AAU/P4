using Antlr4.Runtime;
using System.IO;

public class PrettyPrintVisitor : TinyCellaseVisitor<int>
{
    private int indentLevel = 0;

    public override int Visit(IParseTree tree)
    {
        for (int i = 0; i < indentLevel; i++)
            Console.Write("  ");

        Console.WriteLine(tree.GetType().Name);

        indentLevel++;
        int result = base.Visit(tree);
        indentLevel--;

        return result;
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        //using var fs = new StreamReader("Test.tc");
        string fileContent = File.ReadAllText("Test.tc");

        AntlrInputStream antlrInputStream = new AntlrInputStream(fileContent);

        // Create a lexer with the input stream
        var lexer = new TinyCellLexer(antlrInputStream);

        // Create a token stream from the lexer
        var tokenStream = new CommonTokenStream(lexer);

        // Create a parser with the token stream
        var parser = new TinyCellParser(tokenStream);

        // Parse the input (assuming "document" is the name of the start rule)
        var tree = parser.document();

        Console.WriteLine("=================================================\n");
        Console.WriteLine("Tokens: \n");
        // Print the tokens (for debugging purposes)
        foreach (var token in tokenStream.GetTokens())
        {
            Console.WriteLine(token);
        }
        Console.WriteLine("=================================================\n");

        // Print the parse tree (for debugging purposes)
        // Console.WriteLine("Parse Tree: \n" + tree.ToStringTree(parser));
        var visitor = new PrettyPrintVisitor();
        visitor.Visit(tree);
        Console.WriteLine("=================================================\n");

    }
}