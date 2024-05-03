using System.Diagnostics;
using Antlr4.Runtime;
using P4.TinyCell.Shared.Language.AbstractSyntaxTree;
using P4.TinyCell.Languages.TinyCell;
using P4.TinyCell.Shared.Utilities;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Dfa;
using Antlr4.Runtime.Sharpen;


internal class Program
{
    public class NoErrorListener : BaseErrorListener
    {
        public override void SyntaxError(TextWriter output, IRecognizer recognizer, IToken offendingSymbol, int line, int charPositionInLine, string msg, RecognitionException e)
        {
            throw new Exception($"Syntax error at line {line}:{charPositionInLine} at {offendingSymbol.Text}");
        }

        public override void ReportAmbiguity(Parser recognizer, DFA dfa, int startIndex, int stopIndex, bool exact, BitSet ambigAlts, ATNConfigSet configs)
        {
            throw new Exception($"Ambiguity at {startIndex}:{stopIndex}");
        }

        public override void ReportAttemptingFullContext(Parser recognizer, DFA dfa, int startIndex, int stopIndex, BitSet conflictingAlts, ATNConfigSet configs)
        {
            throw new Exception($"Attempting full context at {startIndex}:{stopIndex}");
        }

        public override void ReportContextSensitivity(Parser recognizer, DFA dfa, int startIndex, int stopIndex, int prediction, ATNConfigSet configs)
        {
            throw new Exception($"Context sensitivity at {startIndex}:{stopIndex}");
        }
    }

    private static void Main(string[] args)
    {
        Process.Start("java", "-jar P4.TinyCell.Shared/Antlr.jar -Dlanguage=CSharp P4.TinyCell.Shared/Antlr/TinyCell.g4 -visitor -listener");
        
        string fileContent = File.ReadAllText("Test.tc");

        var antlrInputStream = new AntlrInputStream(fileContent);

        var lexer = new TinyCellLexer(antlrInputStream);

        var tokenStream = new CommonTokenStream(lexer);

        var parser = new TinyCellParser(tokenStream);

        parser.AddErrorListener(new NoErrorListener());

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

        var typeChecker = new TypeCheckerVisitor();
        typeChecker.Visit(abcd);

        //TestAstVisitor test = new();
        //test.VisitRootNode((RootNode)abcd);
    }
}
