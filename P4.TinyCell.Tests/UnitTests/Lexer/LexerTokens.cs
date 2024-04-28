using static P4.TinyCell.Tests.Utility;
using System.ComponentModel;

namespace P4.TinyCell.Tests;

public class LexerTokens
{
    // Eof
    [Fact]
    [Description("Can handle an empty string.")]
    public void LexerEmptyStringTest()
    {
        var input = "";
        var tokenTypes = GetTokenTypesFromInput(input);

        Assert.Equal(TinyCellLexer.Eof, tokenTypes[0]);
    }

    // Whitespace
    [Fact]
    [Description("Can handle a string with only whitespace.")]
    public void LexerWhitespaceTest()
    {
        var input = "    ";
        var tokenTypes = GetTokenTypesFromInput(input);

        var expectedTokenTypes = new List<int>
        {
            TinyCellLexer.Whitespace,
            TinyCellLexer.Eof
        };

        Assert.Equal(expectedTokenTypes, tokenTypes);
    }

    // LineComment
    [Fact]
    [Description("Can handle a string with only comments.")]
    public void LexerCommentTest()
    {
        var input = "// This is a comment";
        var tokenTypes = GetTokenTypesFromInput(input);

        var expectedTokenTypes = new List<int>
        {
            TinyCellLexer.LineComment,
            TinyCellLexer.Eof
        };

        Assert.Equal(expectedTokenTypes, tokenTypes);
    }

    // Setup
    [Fact]
    [Description("Can detect the correct token type for a setup.")]
    public void LexerSetupTest()
    {
        var input = "setup";
        var tokenTypes = GetTokenTypesFromInput(input);

        Assert.Equal(TinyCellLexer.SETUP, tokenTypes[0]);
    }

    // Identifier
    [Fact]
    [Description("Can detect the correct token type for an identifier.")]
    public void LexerIdentifierTest()
    {
        var input = "x";
        var tokenTypes = GetTokenTypesFromInput(input);

        Assert.Equal(TinyCellLexer.Identifier, tokenTypes[0]);
    }

    // Bool
    [Fact]
    [Description("Can detect the correct token type for a boolean.")]
    public void LexerBoolTest()
    {
        var input = "true";
        var tokenTypes = GetTokenTypesFromInput(input);

        Assert.Equal(TinyCellLexer.Bool, tokenTypes[0]);
    }

    // Newline
    [Fact]
    [Description("Can detect the correct token type for a newline.")]
    public void LexerNewlineTest()
    {
        var input = "\n";
        var tokenTypes = GetTokenTypesFromInput(input);

        Assert.Equal(TinyCellLexer.Whitespace, tokenTypes[0]);
    }

    // VOLHIGH
    [Fact]
    [Description("Can detect the correct token type for a VOLHIGH.")]
    public void LexerVOLHIGHTest()
    {
        var input = "HIGH";
        var tokenTypes = GetTokenTypesFromInput(input);

        Assert.Equal(TinyCellLexer.VOLHIGH, tokenTypes[0]);
    }

    // VOLLOW
    [Fact]
    [Description("Can detect the correct token type for a VOLLOW.")]
    public void LexerVOLLOWTest()
    {
        var input = "LOW";
        var tokenTypes = GetTokenTypesFromInput(input);

        Assert.Equal(TinyCellLexer.VOLLOW, tokenTypes[0]);
    }

    // PININ
    [Fact]
    [Description("Can detect the correct token type for a PININ.")]
    public void LexerPININTest()
    {
        var input = "INPUT";
        var tokenTypes = GetTokenTypesFromInput(input);

        Assert.Equal(TinyCellLexer.PININ, tokenTypes[0]);
    }

    // PINOUT
    [Fact]
    [Description("Can detect the correct token type for a PINOUT.")]
    public void LexerPINOUTTest()
    {
        var input = "OUTPUT";
        var tokenTypes = GetTokenTypesFromInput(input);

        Assert.Equal(TinyCellLexer.PINOUT, tokenTypes[0]);
    }

    // PIN
    [Fact]
    [Description("Can detect the correct token type for a PIN.")]
    public void LexerPINTest()
    {
        var input = "pin";
        var tokenTypes = GetTokenTypesFromInput(input);

        Assert.Equal(TinyCellLexer.PIN, tokenTypes[0]);
    }

    // INT
    [Fact]
    [Description("Can detect the correct token type for an INT.")]
    public void LexerINTTest()
    {
        var input = "int";
        var tokenTypes = GetTokenTypesFromInput(input);

        Assert.Equal(TinyCellLexer.INT, tokenTypes[0]);
    }

    // FLOAT
    [Fact]
    [Description("Can detect the correct token type for a FLOAT.")]
    public void LexerFLOATTest()
    {
        var input = "float";
        var tokenTypes = GetTokenTypesFromInput(input);

        Assert.Equal(TinyCellLexer.FLOAT, tokenTypes[0]);
    }

    // STRING
    [Fact]
    [Description("Can detect the correct token type for a STRING.")]
    public void LexerSTRINGTest()
    {
        var input = "string";
        var tokenTypes = GetTokenTypesFromInput(input);

        Assert.Equal(TinyCellLexer.STRING, tokenTypes[0]);
    }

    // BOOL
    [Fact]
    [Description("Can detect the correct token type for a BOOL.")]
    public void LexerBOOLTest()
    {
        var input = "bool";
        var tokenTypes = GetTokenTypesFromInput(input);

        Assert.Equal(TinyCellLexer.BOOL, tokenTypes[0]);
    }

    // VOID
    [Fact]
    [Description("Can detect the correct token type for a VOID.")]
    public void LexerVOIDTest()
    {
        var input = "void";
        var tokenTypes = GetTokenTypesFromInput(input);

        Assert.Equal(TinyCellLexer.VOID, tokenTypes[0]);
    }

    // CHAR
    [Fact]
    [Description("Can detect the correct token type for a CHAR.")]
    public void LexerCHARTest()
    {
        var input = "char";
        var tokenTypes = GetTokenTypesFromInput(input);

        Assert.Equal(TinyCellLexer.CHAR, tokenTypes[0]);
    }

    // UPDATE
    [Fact]
    [Description("Can detect the correct token type for an UPDATE.")]
    public void LexerUPDATETest()
    {
        var input = "update";
        var tokenTypes = GetTokenTypesFromInput(input);

        Assert.Equal(TinyCellLexer.UPDATE, tokenTypes[0]);
    }

    // SETUP
    [Fact]
    [Description("Can detect the correct token type for a SETUP.")]
    public void LexerSETUPTest()
    {
        var input = "setup";
        var tokenTypes = GetTokenTypesFromInput(input);

        Assert.Equal(TinyCellLexer.SETUP, tokenTypes[0]);
    }

    // SET
    [Fact]
    [Description("Can detect the correct token type for a SET.")]
    public void LexerSETTest()
    {
        var input = "set";
        var tokenTypes = GetTokenTypesFromInput(input);

        Assert.Equal(TinyCellLexer.SET, tokenTypes[0]);
    }

    // TO
    [Fact]
    [Description("Can detect the correct token type for a TO.")]
    public void LexerTOTest()
    {
        var input = "to";
        var tokenTypes = GetTokenTypesFromInput(input);

        Assert.Equal(TinyCellLexer.TO, tokenTypes[0]);
    }

    // READ
    [Fact]
    [Description("Can detect the correct token type for a READ.")]
    public void LexerREADTest()
    {
        var input = "read";
        var tokenTypes = GetTokenTypesFromInput(input);

        Assert.Equal(TinyCellLexer.READ, tokenTypes[0]);
    }

    // WRITE
    [Fact]
    [Description("Can detect the correct token type for a WRITE.")]
    public void LexerWRITETest()
    {
        var input = "write";
        var tokenTypes = GetTokenTypesFromInput(input);

        Assert.Equal(TinyCellLexer.WRITE, tokenTypes[0]);
    }

    // IF
    [Fact]
    [Description("Can detect the correct token type for an IF.")]
    public void LexerIFTest()
    {
        var input = "if";
        var tokenTypes = GetTokenTypesFromInput(input);

        Assert.Equal(TinyCellLexer.IF, tokenTypes[0]);
    }

    // ELSE
    [Fact]
    [Description("Can detect the correct token type for an ELSE.")]
    public void LexerELSETest()
    {
        var input = "else";
        var tokenTypes = GetTokenTypesFromInput(input);

        Assert.Equal(TinyCellLexer.ELSE, tokenTypes[0]);
    }

    // WHILE
    [Fact]
    [Description("Can detect the correct token type for a WHILE.")]
    public void LexerWHILETest()
    {
        var input = "while";
        var tokenTypes = GetTokenTypesFromInput(input);

        Assert.Equal(TinyCellLexer.WHILE, tokenTypes[0]);
    }

    // FOR
    [Fact]
    [Description("Can detect the correct token type for a FOR.")]
    public void LexerFORTest()
    {
        var input = "for";
        var tokenTypes = GetTokenTypesFromInput(input);

        Assert.Equal(TinyCellLexer.FOR, tokenTypes[0]);
    }

    // CONTINUE
    [Fact]
    [Description("Can detect the correct token type for a CONTINUE.")]
    public void LexerCONTINUETest()
    {
        var input = "continue";
        var tokenTypes = GetTokenTypesFromInput(input);

        Assert.Equal(TinyCellLexer.CONTINUE, tokenTypes[0]);
    }

    // BREAK
    [Fact]
    [Description("Can detect the correct token type for a BREAK.")]
    public void LexerBREAKTest()
    {
        var input = "break";
        var tokenTypes = GetTokenTypesFromInput(input);

        Assert.Equal(TinyCellLexer.BREAK, tokenTypes[0]);
    }

    // RETURN
    [Fact]
    [Description("Can detect the correct token type for a RETURN.")]
    public void LexerRETURNTest()
    {
        var input = "return";
        var tokenTypes = GetTokenTypesFromInput(input);

        Assert.Equal(TinyCellLexer.RETURN, tokenTypes[0]);
    }

    // QUESTION
    [Fact]
    [Description("Can detect the correct token type for a QUESTION.")]
    public void LexerQUESTIONTest()
    {
        var input = "?";
        var tokenTypes = GetTokenTypesFromInput(input);

        Assert.Equal(TinyCellLexer.QUESTION, tokenTypes[0]);
    }

    // LPAR
    [Fact]
    [Description("Can detect the correct token type for a LPAR.")]
    public void LexerLPARTest()
    {
        var input = "(";
        var tokenTypes = GetTokenTypesFromInput(input);

        Assert.Equal(TinyCellLexer.LPAR, tokenTypes[0]);
    }

    // RPAR
    [Fact]
    [Description("Can detect the correct token type for a RPAR.")]
    public void LexerRPARTest()
    {
        var input = ")";
        var tokenTypes = GetTokenTypesFromInput(input);

        Assert.Equal(TinyCellLexer.RPAR, tokenTypes[0]);
    }

    // LCURLY
    [Fact]
    [Description("Can detect the correct token type for a LCURVY.")]
    public void LexerLCURVYTest()
    {
        var input = "{";
        var tokenTypes = GetTokenTypesFromInput(input);

        Assert.Equal(TinyCellLexer.LCURLY, tokenTypes[0]);
    }

    // RCURLY
    [Fact]
    [Description("Can detect the correct token type for a RCURLY.")]
    public void LexerRCURLYTest()
    {
        var input = "}";
        var tokenTypes = GetTokenTypesFromInput(input);

        Assert.Equal(TinyCellLexer.RCURLY, tokenTypes[0]);
    }

    // LBRACKET
    [Fact]
    [Description("Can detect the correct token type for a LBRACKET.")]
    public void LexerLBRACKETTest()
    {
        var input = "[";
        var tokenTypes = GetTokenTypesFromInput(input);

        Assert.Equal(TinyCellLexer.LBRACKET, tokenTypes[0]);
    }

    // RBRACKET
    [Fact]
    [Description("Can detect the correct token type for a RBRACKET.")]
    public void LexerRBRACKETTest()
    {
        var input = "]";
        var tokenTypes = GetTokenTypesFromInput(input);

        Assert.Equal(TinyCellLexer.RBRACKET, tokenTypes[0]);
    }

    // SEMI
    [Fact]
    [Description("Can detect the correct token type for a SEMI.")]
    public void LexerSEMITest()
    {
        var input = ";";
        var tokenTypes = GetTokenTypesFromInput(input);

        Assert.Equal(TinyCellLexer.SEMI, tokenTypes[0]);
    }

    // DOT
    [Fact]
    [Description("Can detect the correct token type for a DOT.")]
    public void LexerDOTTest()
    {
        var input = ".";
        var tokenTypes = GetTokenTypesFromInput(input);

        Assert.Equal(TinyCellLexer.DOT, tokenTypes[0]);
    }

    // COMMA
    [Fact]
    [Description("Can detect the correct token type for a COMMA.")]
    public void LexerCOMMATest()
    {
        var input = ",";
        var tokenTypes = GetTokenTypesFromInput(input);

        Assert.Equal(TinyCellLexer.COMMA, tokenTypes[0]);
    }

    // COLON
    [Fact]
    [Description("Can detect the correct token type for a COLON.")]
    public void LexerCOLONTest()
    {
        var input = ":";
        var tokenTypes = GetTokenTypesFromInput(input);

        Assert.Equal(TinyCellLexer.COLON, tokenTypes[0]);
    }

    // ASSIGN
    [Fact]
    [Description("Can detect the correct token type for an ASSIGN.")]
    public void LexerASSIGNTest()
    {
        var input = "=";
        var tokenTypes = GetTokenTypesFromInput(input);

        Assert.Equal(TinyCellLexer.ASSIGN, tokenTypes[0]);
    }

    // PLUSASSIGN
    [Fact]
    [Description("Can detect the correct token type for a PLUSASSIGN.")]
    public void LexerPLUSASSIGNTest()
    {
        var input = "+=";
        var tokenTypes = GetTokenTypesFromInput(input);

        Assert.Equal(TinyCellLexer.PLUSASSIGN, tokenTypes[0]);
    }

    // MULTASSIGN
    [Fact]
    [Description("Can detect the correct token type for a MULTASSIGN.")]
    public void LexerMULTASSIGNTest()
    {
        var input = "*=";
        var tokenTypes = GetTokenTypesFromInput(input);

        Assert.Equal(TinyCellLexer.MULTASSIGN, tokenTypes[0]);
    }

    // DIVASSIGN
    [Fact]
    [Description("Can detect the correct token type for a DIVASSIGN.")]
    public void LexerDIVASSIGNTest()
    {
        var input = "/=";
        var tokenTypes = GetTokenTypesFromInput(input);

        Assert.Equal(TinyCellLexer.DIVASSIGN, tokenTypes[0]);
    }

    // MODASSIGN
    [Fact]
    [Description("Can detect the correct token type for a MODASSIGN.")]
    public void LexerMODASSIGNTest()
    {
        var input = "%=";
        var tokenTypes = GetTokenTypesFromInput(input);

        Assert.Equal(TinyCellLexer.MODASSIGN, tokenTypes[0]);
    }

    // MINUSASSIGN
    [Fact]
    [Description("Can detect the correct token type for a MINUSASSIGN.")]
    public void LexerMINUSASSIGNTest()
    {
        var input = "-=";
        var tokenTypes = GetTokenTypesFromInput(input);

        Assert.Equal(TinyCellLexer.MINUSASSIGN, tokenTypes[0]);
    }

    // QUOTE
    [Fact]
    [Description("Can detect the correct token type for a QUOTE.")]
    public void LexerQUOTETest()
    {
        var input = "\"";
        var tokenTypes = GetTokenTypesFromInput(input);

        Assert.Equal(TinyCellLexer.QUOTE, tokenTypes[0]);
    }

    // MULT
    [Fact]
    [Description("Can detect the correct token type for a MULT.")]
    public void LexerMULTTest()
    {
        var input = "*";
        var tokenTypes = GetTokenTypesFromInput(input);

        Assert.Equal(TinyCellLexer.MULT, tokenTypes[0]);
    }

    // DIV
    [Fact]
    [Description("Can detect the correct token type for a DIV.")]
    public void LexerDIVTest()
    {
        var input = "/";
        var tokenTypes = GetTokenTypesFromInput(input);

        Assert.Equal(TinyCellLexer.DIV, tokenTypes[0]);
    }

    // PLUS
    [Fact]
    [Description("Can detect the correct token type for a PLUS.")]
    public void LexerPLUSTest()
    {
        var input = "+";
        var tokenTypes = GetTokenTypesFromInput(input);

        Assert.Equal(TinyCellLexer.PLUS, tokenTypes[0]);
    }

    // MINUS
    [Fact]
    [Description("Can detect the correct token type for a MINUS.")]
    public void LexerMINUSTest()
    {
        var input = "-";
        var tokenTypes = GetTokenTypesFromInput(input);

        Assert.Equal(TinyCellLexer.MINUS, tokenTypes[0]);
    }

    // MOD
    [Fact]
    [Description("Can detect the correct token type for a MOD.")]
    public void LexerMODTest()
    {
        var input = "%";
        var tokenTypes = GetTokenTypesFromInput(input);

        Assert.Equal(TinyCellLexer.MOD, tokenTypes[0]);
    }

    // EQ
    [Fact]
    [Description("Can detect the correct token type for an EQ.")]
    public void LexerEQTest()
    {
        var input = "==";
        var tokenTypes = GetTokenTypesFromInput(input);

        Assert.Equal(TinyCellLexer.EQ, tokenTypes[0]);
    }

    // NEQ
    [Fact]
    [Description("Can detect the correct token type for a NEQ.")]
    public void LexerNEQTest()
    {
        var input = "!=";
        var tokenTypes = GetTokenTypesFromInput(input);

        Assert.Equal(TinyCellLexer.NEQ, tokenTypes[0]);
    }

    // GT
    [Fact]
    [Description("Can detect the correct token type for a GT.")]
    public void LexerGTTest()
    {
        var input = ">";
        var tokenTypes = GetTokenTypesFromInput(input);

        Assert.Equal(TinyCellLexer.GT, tokenTypes[0]);
    }

    // GTE
    [Fact]
    [Description("Can detect the correct token type for a GTE.")]
    public void LexerGTETest()
    {
        var input = ">=";
        var tokenTypes = GetTokenTypesFromInput(input);

        Assert.Equal(TinyCellLexer.GTE, tokenTypes[0]);
    }

    // LT
    [Fact]
    [Description("Can detect the correct token type for a LT.")]
    public void LexerLTTest()
    {
        var input = "<";
        var tokenTypes = GetTokenTypesFromInput(input);

        Assert.Equal(TinyCellLexer.LT, tokenTypes[0]);
    }

    // LTE
    [Fact]
    [Description("Can detect the correct token type for a LTE.")]
    public void LexerLTETest()
    {
        var input = "<=";
        var tokenTypes = GetTokenTypesFromInput(input);

        Assert.Equal(TinyCellLexer.LTE, tokenTypes[0]);
    }

    // AND
    [Fact]
    [Description("Can detect the correct token type for an AND.")]
    public void LexerANDTest()
    {
        var input = "&&";
        var tokenTypes = GetTokenTypesFromInput(input);

        Assert.Equal(TinyCellLexer.AND, tokenTypes[0]);
    }

    // OR
    [Fact]
    [Description("Can detect the correct token type for an OR.")]
    public void LexerORTest()
    {
        var input = "||";
        var tokenTypes = GetTokenTypesFromInput(input);

        Assert.Equal(TinyCellLexer.OR, tokenTypes[0]);
    }

    // NOT
    [Fact]
    [Description("Can detect the correct token type for a NOT.")]
    public void LexerNOTTest()
    {
        var input = "!";
        var tokenTypes = GetTokenTypesFromInput(input);

        Assert.Equal(TinyCellLexer.NOT, tokenTypes[0]);
    }

    // BITSHIFTL
    [Fact]
    [Description("Can detect the correct token type for a BITSHIFTL.")]
    public void LexerBITSHIFTLTest()
    {
        var input = "<<";
        var tokenTypes = GetTokenTypesFromInput(input);

        Assert.Equal(TinyCellLexer.BITSHIFTL, tokenTypes[0]);
    }

    // BITSHIFTR
    [Fact]
    [Description("Can detect the correct token type for a BITSHIFTR.")]
    public void LexerBITSHIFTRTest()
    {
        var input = ">>";
        var tokenTypes = GetTokenTypesFromInput(input);

        Assert.Equal(TinyCellLexer.BITSHIFTR, tokenTypes[0]);
    }

    // UNARYPLUS
    [Fact]
    [Description("Can detect the correct token type for a UNARYPLUS.")]
    public void LexerUNARYPLUSTest()
    {
        var input = "++";
        var tokenTypes = GetTokenTypesFromInput(input);

        Assert.Equal(TinyCellLexer.UNARYPLUS, tokenTypes[0]);
    }

    // UNARYMINUS
    [Fact]
    [Description("Can detect the correct token type for a UNARYMINUS.")]
    public void LexerUNARYMINUSTest()
    {
        var input = "--";
        var tokenTypes = GetTokenTypesFromInput(input);

        Assert.Equal(TinyCellLexer.UNARYMINUS, tokenTypes[0]);
    }
}
