using System;
using System.IO;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using P4.TinyCell.Language;
using P4.TinyCell.AST;
using P4.TinyCell.Utilities;
using P4.TinyCell.AST;
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
        tokenStream.Fill();

        var tokens = tokenStream.GetTokens();

        // LivenessAnalysisListener listener = new LivenessAnalysisListener();
        // ParseTreeWalker.Default.Walk(listener, tree);
        // var list = listener.instructions;

        Console.WriteLine("\n=================================================\n");
        Console.WriteLine("Tokens:");
        Console.WriteLine("\n=================================================\n");
        Console.WriteLine("Tokens:");

        foreach (var token in tokenStream.GetTokens())
        {
            Console.WriteLine(token);
        }
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

        AstBuilderVisitor astBuilderVisitor = new();
        AstNode abcd = astBuilderVisitor.Visit(tree);

        Console.WriteLine(abcd.ToString());

    }
}