using static P4.TinyCell.Tests.Utility;
using System.ComponentModel;
using Antlr4.Runtime;

namespace P4.TinyCell.Tests;

public class ParserTests
{

    [Fact]
    [Description("Test a simple document")]
    public void TestDocument()
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

        Assert.Equal(TinyCellParser.RULE_setupDefinition, doc.setupDefinition().RuleIndex);

        Assert.Equal(TinyCellParser.RULE_updateDefinition, doc.updateDefinition().RuleIndex);

        Assert.Equal("setup", doc.GetChild(0).GetText());
        Assert.Equal("{", doc.GetChild(1).GetText());
        Assert.Equal("}", doc.GetChild(2).GetText());
        Assert.Equal("update", doc.GetChild(3).GetText());
        Assert.Equal("{", doc.GetChild(4).GetText());
        Assert.Equal("}", doc.GetChild(5).GetText());
    }
}
