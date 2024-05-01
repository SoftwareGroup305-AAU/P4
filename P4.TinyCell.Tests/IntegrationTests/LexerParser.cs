using static P4.TinyCell.Tests.Utility;
using System.ComponentModel;
using Antlr4.Runtime;

namespace P4.TinyCell.Tests;

public class LexerParser
{
    // Below are control flow tests with lexer and parser combined

    // If-else control flow test
    [Fact]
    [Description("If-else control flow test")]
    public void TestControlFlow()
    {
        var input = @"
        setup{
            if (true) {
                print(1);
            } else {
                print(2);
            }  
        }
        update{}
        ";

        var antlrInputStream = new AntlrInputStream(input);
        var lexer = new TinyCellLexer(antlrInputStream);
        var tokenStream = new CommonTokenStream(lexer);
        var parser = new TinyCellParser(tokenStream);
        tokenStream.Fill();
        var tokens = tokenStream.GetTokens();
        var tree = parser.document();

        var expectedTokenTypes = new List<int>
        {
            TinyCellLexer.Whitespace,
            TinyCellLexer.SETUP,
            TinyCellLexer.LCURLY,
            TinyCellLexer.Whitespace,
            TinyCellLexer.IF,
            TinyCellLexer.Whitespace,
            TinyCellLexer.LPAR,
            TinyCellLexer.Bool,
            TinyCellLexer.RPAR,
            TinyCellLexer.Whitespace,
            TinyCellLexer.LCURLY,
            TinyCellLexer.Whitespace,
            TinyCellLexer.Identifier,
            TinyCellLexer.LPAR,
            TinyCellLexer.Numeral,
            TinyCellLexer.RPAR,
            TinyCellLexer.SEMI,
            TinyCellLexer.Whitespace,
            TinyCellLexer.RCURLY,
            TinyCellLexer.Whitespace,
            TinyCellLexer.ELSE,
            TinyCellLexer.Whitespace,
            TinyCellLexer.LCURLY,
            TinyCellLexer.Whitespace,
            TinyCellLexer.Identifier,
            TinyCellLexer.LPAR,
            TinyCellLexer.Numeral,
            TinyCellLexer.RPAR,
            TinyCellLexer.SEMI,
            TinyCellLexer.Whitespace,
            TinyCellLexer.RCURLY,
            TinyCellLexer.Whitespace,
            TinyCellLexer.RCURLY,
            TinyCellLexer.Whitespace,
            TinyCellLexer.UPDATE,
            TinyCellLexer.LCURLY,
            TinyCellLexer.RCURLY,
            TinyCellLexer.Whitespace,
            TinyCellLexer.Eof
        };

        // Assert that the token types are as expected
        Assert.Equal(expectedTokenTypes, tokens.Select(t => t.Type).ToList());

        // Assert that the parse tree is not null
        Assert.NotNull(tree);

        // Assert that the parse tree has the expected number of children
        Assert.Equal(2, tree.ChildCount);

        // Assert that the parse tree has the correct structure
        Assert.Equal("DocumentContext", tree.GetType().Name);

        var setup = tree.GetChild(0);
        Assert.Equal("SetupDefinitionContext", setup.GetType().Name);

        var update = tree.GetChild(1);
        Assert.Equal("UpdateDefinitionContext", update.GetType().Name);
    }
}
