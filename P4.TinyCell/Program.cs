using Antlr4.Runtime;
using P4.TinyCell.Language.AbstractSyntaxTree;
using P4.TinyCell.Utilities;

internal class Program
{
    private static void Main(string[] args)
    {
        string fileContent = File.ReadAllText("/home/benj1/Documents/GitHub/P4-main/P4.TinyCell/test.tc");

        var antlrInputStream = new AntlrInputStream(fileContent);

        var lexer = new TinyCellLexer(antlrInputStream);

        var tokenStream = new CommonTokenStream(lexer);

        var parser = new TinyCellParser(tokenStream);

        var tree = parser.document();
        tokenStream.Fill();

        var tokens = tokenStream.GetTokens();

        // LivenessAnalysisListener listener = new LivenessAnalysisListener();
        // ParseTreeWalker.Default.Walk(listener, tree);
        // listener.FixedPointAnalysis();
        // var list = listener.scopes;
        // var graphs = new Dictionary<string, Graph<string>>();
        // var graphGenerator = new LivenessGraphGenerator();
        // foreach (var scope in list)
        // {
        //     var graph = graphGenerator.generateGraph(scope.Value);
        //     graphs.Add(scope.Key, graph);
        // }
        // var allocatedScopes = new Dictionary<string, Dictionary<string, string>>();
        // var registerAllocator = new StaticRegisterAllocator();
        // foreach (var scope in graphs)
        // {
        //     var graph = scope.Value;
        //     var groupings = registerAllocator.AllocateRegisters(graph.adjacencyList, 3);
        //     allocatedScopes.Add(scope.Key, groupings);
        // }

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

        AstBuilderVisitor astBuilderVisitor = new();
        AstNode abcd = astBuilderVisitor.Visit(tree);

        Console.WriteLine(abcd.ToString());


        //TestAstVisitor test = new();
        //test.VisitRootNode((RootNode)abcd);
    }
}