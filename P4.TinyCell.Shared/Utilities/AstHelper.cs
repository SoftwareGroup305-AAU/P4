using Antlr4.Runtime;
using P4.TinyCell.Shared.Language.AbstractSyntaxTree;

namespace P4.TinyCell.Shared.Utilities;
public static class AstHelper
{
    public static AstNode GetAstFromFile(string path)
    {
        string fileContent = File.ReadAllText(path);
        var antlrInputStream = new AntlrInputStream(fileContent);
        var lexer = new TinyCellLexer(antlrInputStream);
        var tokenStream = new CommonTokenStream(lexer);
        var parser = new TinyCellParser(tokenStream);
        AstBuilderVisitor astBuilderVisitor = new();
        var tree = parser.document();
        return astBuilderVisitor.Visit(tree);
    }
}
