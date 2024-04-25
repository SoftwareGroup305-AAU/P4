using Antlr4.Runtime;

namespace P4.TinyCell.Tests;

public class Utility
{
    public static List<int> GetTokenTypesFromInput(string input)
    {
        var antlrInputStream = new AntlrInputStream(input);
        var lexer = new TinyCellLexer(antlrInputStream);
        var tokenStream = new CommonTokenStream(lexer);
        tokenStream.Fill();
        var tokens = tokenStream.GetTokens();

        var tokenTypes = tokens.Select(token => token.Type).ToList();

        return tokenTypes;
    }
}
