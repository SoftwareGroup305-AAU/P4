using static P4.TinyCell.Tests.Utility;
using System.ComponentModel;
using Antlr4.Runtime;

namespace P4.TinyCell.Tests;

public class ParserTreeStructure
{
    [Fact]
    [Description("Validates the structure of the parse tree for the document rule")]
    public void ParserDocumentStructureTest()
    {
        var tokens = new List<IToken>
        {
            new TestToken("setup", TinyCellLexer.SETUP),
            new TestToken("{", TinyCellLexer.LCURLY),
            new TestToken("}", TinyCellLexer.RCURLY),
            new TestToken("update", TinyCellLexer.UPDATE),
            new TestToken("{", TinyCellLexer.LCURLY),
            new TestToken("}", TinyCellLexer.RCURLY),
            new TestToken("", TinyCellLexer.Eof),
        };

        var parser = CreateParserNoError(tokens);
        var doc = parser.document();

        Assert.NotNull(doc);

        Assert.Equal(2, doc.ChildCount);

        Assert.IsType<TinyCellParser.SetupDefinitionContext>(doc.GetChild(0));
        Assert.IsType<TinyCellParser.UpdateDefinitionContext>(doc.GetChild(1));
    }
}
