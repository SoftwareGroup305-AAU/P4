﻿
using System;
using System.IO;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using P4.TinyCell.Language;
using P4.TinyCell.Languages.TinyCell;
using P4.TinyCell.Utilities;
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

                tokenStream.Fill();

                var tokens = tokenStream.GetTokens();

                var tree = parser.document();

                LivenessAnalysisListener listener = new LivenessAnalysisListener();
                ParseTreeWalker.Default.Walk(listener, tree);
                listener.FixedPointAnalysis();
                var list = listener.scopes;
                var graphs = new Dictionary<string, Graph<string>>();
                 var graphGenerator = new LivenessGraphGenerator();  
                foreach ( var scope in list )
                    {
                         var graph = graphGenerator.generateGraph(scope.Value);
                         graphs.Add(scope.Key, graph);
                    }
                var allocatedScopes = new Dictionary<string, Dictionary<string, string>>();
                var registerAllocator = new StaticRegisterAllocator();
                foreach (var scope in graphs)
                {
                    var graph = scope.Value;
                    var groupings = registerAllocator.AllocateRegisters(graph.adjacencyList, 3);
                    allocatedScopes.Add(scope.Key, groupings);
                }
                //use allocatedScopes from here
                


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
        }
}