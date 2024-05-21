using Antlr4.Runtime;
using P4.TinyCell.Shared.Language.AbstractSyntaxTree;
using P4.TinyCell.Shared.Language.CodeGen;
using P4.TinyCell.Shared.Language.Typechecking;
using P4.TinyCell.Shared.Utilities;


internal class Program
{
    private static void Main(string[] args)
    {
        string workingDirectory = Environment.CurrentDirectory;
        string projectDirectory = new DirectoryInfo(workingDirectory).FullName;
        TcDirector.ParseArgs(args);

        string fileContent = File.ReadAllText(ArgsConfiguration.sourceFile);

        var antlrInputStream = new AntlrInputStream(fileContent);

        var lexer = new TinyCellLexer(antlrInputStream);

        var tokenStream = new CommonTokenStream(lexer);

        tokenStream.Fill();

        var tokens = tokenStream.GetTokens();

        foreach (var token in tokens)
        {
            int tokenType = token.Type - 1;
            string ruleName = tokenType >= 0 && tokenType < TinyCellLexer.ruleNames.Length ? TinyCellLexer.ruleNames[tokenType] : "Unknown";
            Console.WriteLine(token + " | " + ruleName + " | " + token.Text);
        }

        var parser = new TinyCellParser(tokenStream);

        parser.AddErrorListener(new ParserHelper.NoErrorListener());

        var tree = parser.document();

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

        ParserHelper.PrintTree(tree);

        AstBuilderVisitor astBuilderVisitor = new();
        AstNode abcd = astBuilderVisitor.Visit(tree);

        Console.WriteLine(abcd.ToString());

        var typeChecker = new TypeCheckerVisitor();
        typeChecker.Visit(abcd);

        TestAstVisitor test = new();
        test.VisitRootNode((RootNode)abcd);

        CGeneratorVisitor cGeneratorVisitor = new();
        string ccode = cGeneratorVisitor.Visit(abcd);

        if (!Directory.Exists("Arduino"))
        {
            Directory.CreateDirectory("Arduino");
        }

        using StreamWriter sw = File.CreateText($"Arduino/{ArgsConfiguration.outputFile}.ino");
        sw.Write(ccode);
        Console.WriteLine(ccode);
    }
}
