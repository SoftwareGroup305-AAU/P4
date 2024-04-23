using System.ComponentModel;
using Xunit;

namespace P4.TinyCell.Tests;

public class LexerUnitTests
{
    /// <summary>
    /// Can handle a string with only a single identifier.
    /// <example> 
    /// <code> Example input: "x" </code>
    /// /// <code> Expected output: [IDENTIFIER] </code>
    /// </example>
    /// </summary>
    [Fact]
    [Description("Can handle a string with only a single identifier.")]
    public void LexerIdentifierTest()
    {

    }

    /// <summary>
    /// Can convert a string to a list of tokens.
    /// <example> 
    /// <code> Example input: "x = 5" </code>
    /// <code> Expected output: [IDENTIFIER, EQUALS, NUMBER] </code>
    /// </example>
    /// </summary>
    [Fact]
    [Description("Can convert a string to a list of tokens.")]
    public void LexerTokenizerTest()
    {
    }

    /// <summary>
    /// Can handle an empty string.
    /// <example> 
    /// <code> Example input: "" </code>
    /// <code> Expected output: [] </code>
    /// </example>
    /// </summary>
    [Fact]
    [Description("Can handle an empty string.")]
    public void LexerEmptyStringTest()
    {
    }

    /// <summary>
    /// Can handle a string with only whitespace.
    /// <example>
    /// <code> Example input: "    " </code>
    /// <code> Expected output: [] </code>
    /// </example>
    /// </summary>
    [Fact]
    [Description("Can handle a string with only whitespace.")]
    public void LexerWhitespaceTest()
    {
    }

    /// <summary>
    /// Can handle a string with only comments.
    /// <example>
    /// <code> Example input: "// This is a comment" </code>
    /// <code> Expected output: [] </code>
    /// </example>
    /// </summary>
    [Fact]
    [Description("Can handle a string with only comments.")]
    public void LexerCommentTest()
    {
    }
}
