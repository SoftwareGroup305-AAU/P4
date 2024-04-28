using static P4.TinyCell.Tests.Utility;
using System.ComponentModel;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

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

    [Fact]
    [Description("Validates the structure of the parse tree for the setup rule")]
    public void ParserSetupStructureTest()
    {
        var tokens = new List<IToken>
        {
            new TestToken("setup", TinyCellLexer.SETUP),
            new TestToken("{", TinyCellLexer.LCURLY),
            new TestToken("}", TinyCellLexer.RCURLY),
            new TestToken("", TinyCellLexer.Eof),
        };

        var parser = CreateParserNoError(tokens);
        var setup = parser.setupDefinition();

        Assert.NotNull(setup);

        Assert.Equal(2, setup.ChildCount);

        Assert.IsType<TinyCellParser.SetupDefinitionContext>(setup);
    }

    [Fact]
    [Description("Validates the structure of the parse tree for the update rule")]
    public void ParserUpdateStructureTest()
    {
        var tokens = new List<IToken>
        {
            new TestToken("update", TinyCellLexer.UPDATE),
            new TestToken("{", TinyCellLexer.LCURLY),
            new TestToken("}", TinyCellLexer.RCURLY),
            new TestToken("", TinyCellLexer.Eof),
        };

        var parser = CreateParserNoError(tokens);
        var update = parser.updateDefinition();

        Assert.NotNull(update);

        Assert.Equal(2, update.ChildCount);

        Assert.IsType<TinyCellParser.UpdateDefinitionContext>(update);
    }

    // Validates the structure of the parse tree for an if statement
    [Fact]
    [Description("Validates the structure of the parse tree for an if statement")]
    public void ParserIfStatementStructureTest()
    {
        var tokens = new List<IToken>
        {
            new TestToken("if", TinyCellLexer.IF),
            new TestToken("(", TinyCellLexer.LPAR),
            new TestToken("x", TinyCellLexer.Identifier),
            new TestToken("==", TinyCellLexer.EQ),
            new TestToken("5", TinyCellLexer.Numeral),
            new TestToken(")", TinyCellLexer.RPAR),
            new TestToken("{", TinyCellLexer.LCURLY),
            new TestToken("x", TinyCellLexer.Identifier),
            new TestToken("=", TinyCellLexer.ASSIGN),
            new TestToken("6", TinyCellLexer.Numeral),
            new TestToken(";", TinyCellLexer.SEMI),
            new TestToken("}", TinyCellLexer.RCURLY),
            new TestToken("", TinyCellLexer.Eof),
        };

        var parser = CreateParserNoError(tokens);
        var ifStatement = parser.ifStatement();

        Assert.NotNull(ifStatement);

        Assert.Equal(5, ifStatement.ChildCount);

        Assert.IsType<TerminalNodeImpl>(ifStatement.GetChild(0));
        Assert.IsType<TerminalNodeImpl>(ifStatement.GetChild(1));
        Assert.IsType<TinyCellParser.ExpressionContext>(ifStatement.GetChild(2));
        Assert.IsType<TerminalNodeImpl>(ifStatement.GetChild(3));
        Assert.IsType<TinyCellParser.CompoundStatementContext>(ifStatement.GetChild(4));
    }

    // Validates the structure of the parse tree for a if-else statement
    [Fact]
    [Description("Validates the structure of the parse tree for an if-else statement")]
    public void ParserIfElseStatementStructureTest()
    {
        var tokens = new List<IToken>
        {
            new TestToken("if", TinyCellLexer.IF),
            new TestToken("(", TinyCellLexer.LPAR),
            new TestToken("x", TinyCellLexer.Identifier),
            new TestToken("==", TinyCellLexer.EQ),
            new TestToken("5", TinyCellLexer.Numeral),
            new TestToken(")", TinyCellLexer.RPAR),
            new TestToken("{", TinyCellLexer.LCURLY),
            new TestToken("x", TinyCellLexer.Identifier),
            new TestToken("=", TinyCellLexer.ASSIGN),
            new TestToken("6", TinyCellLexer.Numeral),
            new TestToken(";", TinyCellLexer.SEMI),
            new TestToken("}", TinyCellLexer.RCURLY),
            new TestToken("else", TinyCellLexer.ELSE),
            new TestToken("{", TinyCellLexer.LCURLY),
            new TestToken("x", TinyCellLexer.Identifier),
            new TestToken("=", TinyCellLexer.ASSIGN),
            new TestToken("7", TinyCellLexer.Numeral),
            new TestToken(";", TinyCellLexer.SEMI),
            new TestToken("}", TinyCellLexer.RCURLY),
            new TestToken("", TinyCellLexer.Eof),
        };

        var parser = CreateParserNoError(tokens);
        var ifElseStatement = parser.ifStatement();

        Assert.NotNull(ifElseStatement);

        Assert.Equal(7, ifElseStatement.ChildCount);

        Assert.IsType<TerminalNodeImpl>(ifElseStatement.GetChild(0));
        Assert.IsType<TerminalNodeImpl>(ifElseStatement.GetChild(1));
        Assert.IsType<TinyCellParser.ExpressionContext>(ifElseStatement.GetChild(2));
        Assert.IsType<TerminalNodeImpl>(ifElseStatement.GetChild(3));
        Assert.IsType<TinyCellParser.CompoundStatementContext>(ifElseStatement.GetChild(4));
        Assert.IsType<TerminalNodeImpl>(ifElseStatement.GetChild(5));
        Assert.IsType<TinyCellParser.CompoundStatementContext>(ifElseStatement.GetChild(6));
    }

    // Validates the structure of the parse tree for a while statement
    [Fact]
    [Description("Validates the structure of the parse tree for a while statement")]
    public void ParserWhileStatementStructureTest()
    {
        var tokens = new List<IToken>
        {
            new TestToken("while", TinyCellLexer.WHILE),
            new TestToken("(", TinyCellLexer.LPAR),
            new TestToken("x", TinyCellLexer.Identifier),
            new TestToken("==", TinyCellLexer.EQ),
            new TestToken("5", TinyCellLexer.Numeral),
            new TestToken(")", TinyCellLexer.RPAR),
            new TestToken("{", TinyCellLexer.LCURLY),
            new TestToken("x", TinyCellLexer.Identifier),
            new TestToken("=", TinyCellLexer.ASSIGN),
            new TestToken("6", TinyCellLexer.Numeral),
            new TestToken(";", TinyCellLexer.SEMI),
            new TestToken("}", TinyCellLexer.RCURLY),
            new TestToken("", TinyCellLexer.Eof),
        };

        var parser = CreateParserNoError(tokens);
        var whileStatement = parser.loopStatement();

        Assert.NotNull(whileStatement);

        Assert.Equal(5, whileStatement.ChildCount);

        Assert.IsType<TerminalNodeImpl>(whileStatement.GetChild(0));
        Assert.IsType<TerminalNodeImpl>(whileStatement.GetChild(1));
        Assert.IsType<TinyCellParser.ExpressionContext>(whileStatement.GetChild(2));
        Assert.IsType<TerminalNodeImpl>(whileStatement.GetChild(3));
        Assert.IsType<TinyCellParser.CompoundStatementContext>(whileStatement.GetChild(4));
    }

    // Validates the structure of the parse tree for a for statement
    [Fact]
    [Description("Validates the structure of the parse tree for a for statement")]
    public void ParserForStatementStructureTest()
    {
        var tokens = new List<IToken>
        {
            new TestToken("for", TinyCellLexer.FOR),
            new TestToken("(", TinyCellLexer.LPAR),
            new TestToken("int", TinyCellLexer.INT),
            new TestToken("x", TinyCellLexer.Identifier),
            new TestToken("=", TinyCellLexer.ASSIGN),
            new TestToken("0", TinyCellLexer.Numeral),
            new TestToken(";", TinyCellLexer.SEMI),
            new TestToken("x", TinyCellLexer.Identifier),
            new TestToken("<", TinyCellLexer.LT),
            new TestToken("5", TinyCellLexer.Numeral),
            new TestToken(";", TinyCellLexer.SEMI),
            new TestToken("x", TinyCellLexer.Identifier),
            new TestToken("++", TinyCellLexer.UNARYPLUS),
            new TestToken(")", TinyCellLexer.RPAR),
            new TestToken("{", TinyCellLexer.LCURLY),
            new TestToken("x", TinyCellLexer.Identifier),
            new TestToken("=", TinyCellLexer.ASSIGN),
            new TestToken("6", TinyCellLexer.Numeral),
            new TestToken(";", TinyCellLexer.SEMI),
            new TestToken("}", TinyCellLexer.RCURLY),
            new TestToken("", TinyCellLexer.Eof),
        };

        var parser = CreateParserNoError(tokens);
        var forStatement = parser.loopStatement();

        Assert.NotNull(forStatement);

        Assert.Equal(9, forStatement.ChildCount);

        Assert.IsType<TerminalNodeImpl>(forStatement.GetChild(0));
        Assert.IsType<TerminalNodeImpl>(forStatement.GetChild(1));
        Assert.IsType<TinyCellParser.DeclarationContext>(forStatement.GetChild(2));
        Assert.IsType<TerminalNodeImpl>(forStatement.GetChild(3));
        Assert.IsType<TinyCellParser.ExpressionContext>(forStatement.GetChild(4));
        Assert.IsType<TerminalNodeImpl>(forStatement.GetChild(5));
        Assert.IsType<TinyCellParser.ExpressionContext>(forStatement.GetChild(6));
        Assert.IsType<TerminalNodeImpl>(forStatement.GetChild(7));
        Assert.IsType<TinyCellParser.CompoundStatementContext>(forStatement.GetChild(8));
    }

    // Validates the structure of the parse tree for arithmetic operators
    [Fact]
    [Description("Validates the structure of the parse tree for arithmetic operators")]
    public void ParserArithmeticOperatorsStructureTest()
    {
        var tokens = new List<IToken>
            {
                new TestToken("x", TinyCellLexer.Identifier),
                new TestToken("=", TinyCellLexer.ASSIGN),
                new TestToken("5", TinyCellLexer.Numeral),
                new TestToken("+", TinyCellLexer.PLUS),
                new TestToken("5", TinyCellLexer.Numeral),
                new TestToken("-", TinyCellLexer.MINUS),
                new TestToken("5", TinyCellLexer.Numeral),
                new TestToken("*", TinyCellLexer.MULT),
                new TestToken("5", TinyCellLexer.Numeral),
                new TestToken("/", TinyCellLexer.DIV),
                new TestToken("5", TinyCellLexer.Numeral),
                new TestToken(";", TinyCellLexer.SEMI),
                new TestToken("", TinyCellLexer.Eof),
            };

        var parser = CreateParserNoError(tokens);
        var expression = parser.expression();

        Assert.NotNull(expression);

        Assert.Equal(7, expression.ChildCount);

        Assert.IsType<TinyCellParser.ExpressionContext>(expression.GetChild(0));
        Assert.IsType<TerminalNodeImpl>(expression.GetChild(1));
        Assert.IsType<TinyCellParser.ExpressionContext>(expression.GetChild(2));
        Assert.IsType<TerminalNodeImpl>(expression.GetChild(3));
        Assert.IsType<TinyCellParser.ExpressionContext>(expression.GetChild(4));
        Assert.IsType<TerminalNodeImpl>(expression.GetChild(5));
        Assert.IsType<TinyCellParser.ExpressionContext>(expression.GetChild(6));
    }

    /*
        - comparison operators
        - assignment operators
        - function calls with no arguments
        - function calls with arguments
        - numeral assignment
        - string assignment
        - boolean assignment
        - function assignment
        - expression assignment
        - unary expression assignment
        - multiplicative expression assignment
        - additive expression assignment
        - bitshift expression assignment
    */
}
