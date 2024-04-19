﻿using Antlr4.Runtime;
using Utilities;

internal class Program
{
    private static void Main(string[] args)
    {
        //using var fs = new StreamReader("Test.tc");
        string fileContent = File.ReadAllText("Test.tc");

        var antlrInputStream = new AntlrInputStream(fileContent);

        // Create a lexer with the input stream
        var lexer = new TinyCellLexer(antlrInputStream);

        // Create a token stream from the lexer
        var tokenStream = new CommonTokenStream(lexer);

        // Create a parser with the token stream
        var parser = new TinyCellParser(tokenStream);

        // Parse the input (assuming "document" is the name of the start rule)
        var tree = parser.document();

        Console.WriteLine("\n=================================================\n");
        Console.WriteLine("Tokens:");

        foreach (var token in tokenStream.GetTokens())
        {
            Console.WriteLine(token);
        }

        Console.WriteLine("\n=================================================\n");
        var ParserHelper = new ParserHelper();
        ParserHelper.PrintTree(tree);
    }
}