//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.13.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from ../P4.TinyCell.Shared/TinycellAntlr/TinyCell.g4 by ANTLR 4.13.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.1")]
[System.CLSCompliant(false)]
public partial class TinyCellLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		Bool=1, Whitespace=2, VOLHIGH=3, VOLLOW=4, PININ=5, PINOUT=6, DPIN=7, 
		APIN=8, INT=9, FLOAT=10, STRING=11, BOOL=12, VOID=13, CHAR=14, UPDATE=15, 
		SETUP=16, SET=17, TO=18, READ=19, WRITE=20, IF=21, ELSE=22, WHILE=23, 
		FOR=24, CONTINUE=25, BREAK=26, RETURN=27, INCLUDE=28, QUESTION=29, LPAR=30, 
		RPAR=31, LCURLY=32, RCURLY=33, LBRACKET=34, RBRACKET=35, SEMI=36, DOT=37, 
		COMMA=38, COLON=39, TRUE=40, FALSE=41, NEWLINE=42, ASSIGN=43, PLUSASSIGN=44, 
		MULTASSIGN=45, DIVASSIGN=46, MODASSIGN=47, MINUSASSIGN=48, QUOTE=49, MULT=50, 
		DIV=51, PLUS=52, MINUS=53, MOD=54, AND=55, OR=56, EQ=57, NEQ=58, GT=59, 
		LT=60, GTE=61, LTE=62, NOT=63, BITSHIFTL=64, BITSHIFTR=65, UNARYPLUS=66, 
		UNARYMINUS=67, Identifier=68, LibraryIdent=69, String=70, FloatNumeral=71, 
		IntNumeral=72, BlockComment=73, LineComment=74, Newline=75;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"Bool", "Whitespace", "VOLHIGH", "VOLLOW", "PININ", "PINOUT", "DPIN", 
		"APIN", "INT", "FLOAT", "STRING", "BOOL", "VOID", "CHAR", "UPDATE", "SETUP", 
		"SET", "TO", "READ", "WRITE", "IF", "ELSE", "WHILE", "FOR", "CONTINUE", 
		"BREAK", "RETURN", "INCLUDE", "QUESTION", "LPAR", "RPAR", "LCURLY", "RCURLY", 
		"LBRACKET", "RBRACKET", "SEMI", "DOT", "COMMA", "COLON", "TRUE", "FALSE", 
		"NEWLINE", "ASSIGN", "PLUSASSIGN", "MULTASSIGN", "DIVASSIGN", "MODASSIGN", 
		"MINUSASSIGN", "QUOTE", "MULT", "DIV", "PLUS", "MINUS", "MOD", "AND", 
		"OR", "EQ", "NEQ", "GT", "LT", "GTE", "LTE", "NOT", "BITSHIFTL", "BITSHIFTR", 
		"UNARYPLUS", "UNARYMINUS", "Identifier", "LibraryIdent", "String", "FloatNumeral", 
		"IntNumeral", "BlockComment", "LineComment", "Newline"
	};


	public TinyCellLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public TinyCellLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, null, null, "'HIGH'", "'LOW'", "'INPUT'", "'OUTPUT'", "'dpin'", 
		"'apin'", "'int'", "'float'", "'string'", "'bool'", "'void'", "'char'", 
		"'update'", "'setup'", "'set'", "'to'", "'read'", "'write'", "'if'", "'else'", 
		"'while'", "'for'", "'continue'", "'break'", "'return'", "'include'", 
		"'?'", "'('", "')'", "'{'", "'}'", "'['", "']'", "';'", "'.'", "','", 
		"':'", "'true'", "'false'", "'\\n'", "'='", "'+='", "'*='", "'/='", "'%='", 
		"'-='", "'\"'", "'*'", "'/'", "'+'", "'-'", "'%'", "'&&'", "'||'", "'=='", 
		"'!='", "'>'", "'<'", "'>='", "'<='", "'!'", "'<<'", "'>>'", "'++'", "'--'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "Bool", "Whitespace", "VOLHIGH", "VOLLOW", "PININ", "PINOUT", "DPIN", 
		"APIN", "INT", "FLOAT", "STRING", "BOOL", "VOID", "CHAR", "UPDATE", "SETUP", 
		"SET", "TO", "READ", "WRITE", "IF", "ELSE", "WHILE", "FOR", "CONTINUE", 
		"BREAK", "RETURN", "INCLUDE", "QUESTION", "LPAR", "RPAR", "LCURLY", "RCURLY", 
		"LBRACKET", "RBRACKET", "SEMI", "DOT", "COMMA", "COLON", "TRUE", "FALSE", 
		"NEWLINE", "ASSIGN", "PLUSASSIGN", "MULTASSIGN", "DIVASSIGN", "MODASSIGN", 
		"MINUSASSIGN", "QUOTE", "MULT", "DIV", "PLUS", "MINUS", "MOD", "AND", 
		"OR", "EQ", "NEQ", "GT", "LT", "GTE", "LTE", "NOT", "BITSHIFTL", "BITSHIFTR", 
		"UNARYPLUS", "UNARYMINUS", "Identifier", "LibraryIdent", "String", "FloatNumeral", 
		"IntNumeral", "BlockComment", "LineComment", "Newline"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "TinyCell.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static TinyCellLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static int[] _serializedATN = {
		4,0,75,479,6,-1,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,
		6,2,7,7,7,2,8,7,8,2,9,7,9,2,10,7,10,2,11,7,11,2,12,7,12,2,13,7,13,2,14,
		7,14,2,15,7,15,2,16,7,16,2,17,7,17,2,18,7,18,2,19,7,19,2,20,7,20,2,21,
		7,21,2,22,7,22,2,23,7,23,2,24,7,24,2,25,7,25,2,26,7,26,2,27,7,27,2,28,
		7,28,2,29,7,29,2,30,7,30,2,31,7,31,2,32,7,32,2,33,7,33,2,34,7,34,2,35,
		7,35,2,36,7,36,2,37,7,37,2,38,7,38,2,39,7,39,2,40,7,40,2,41,7,41,2,42,
		7,42,2,43,7,43,2,44,7,44,2,45,7,45,2,46,7,46,2,47,7,47,2,48,7,48,2,49,
		7,49,2,50,7,50,2,51,7,51,2,52,7,52,2,53,7,53,2,54,7,54,2,55,7,55,2,56,
		7,56,2,57,7,57,2,58,7,58,2,59,7,59,2,60,7,60,2,61,7,61,2,62,7,62,2,63,
		7,63,2,64,7,64,2,65,7,65,2,66,7,66,2,67,7,67,2,68,7,68,2,69,7,69,2,70,
		7,70,2,71,7,71,2,72,7,72,2,73,7,73,2,74,7,74,1,0,1,0,3,0,154,8,0,1,1,4,
		1,157,8,1,11,1,12,1,158,1,1,1,1,1,2,1,2,1,2,1,2,1,2,1,3,1,3,1,3,1,3,1,
		4,1,4,1,4,1,4,1,4,1,4,1,5,1,5,1,5,1,5,1,5,1,5,1,5,1,6,1,6,1,6,1,6,1,6,
		1,7,1,7,1,7,1,7,1,7,1,8,1,8,1,8,1,8,1,9,1,9,1,9,1,9,1,9,1,9,1,10,1,10,
		1,10,1,10,1,10,1,10,1,10,1,11,1,11,1,11,1,11,1,11,1,12,1,12,1,12,1,12,
		1,12,1,13,1,13,1,13,1,13,1,13,1,14,1,14,1,14,1,14,1,14,1,14,1,14,1,15,
		1,15,1,15,1,15,1,15,1,15,1,16,1,16,1,16,1,16,1,17,1,17,1,17,1,18,1,18,
		1,18,1,18,1,18,1,19,1,19,1,19,1,19,1,19,1,19,1,20,1,20,1,20,1,21,1,21,
		1,21,1,21,1,21,1,22,1,22,1,22,1,22,1,22,1,22,1,23,1,23,1,23,1,23,1,24,
		1,24,1,24,1,24,1,24,1,24,1,24,1,24,1,24,1,25,1,25,1,25,1,25,1,25,1,25,
		1,26,1,26,1,26,1,26,1,26,1,26,1,26,1,27,1,27,1,27,1,27,1,27,1,27,1,27,
		1,27,1,28,1,28,1,29,1,29,1,30,1,30,1,31,1,31,1,32,1,32,1,33,1,33,1,34,
		1,34,1,35,1,35,1,36,1,36,1,37,1,37,1,38,1,38,1,39,1,39,1,39,1,39,1,39,
		1,40,1,40,1,40,1,40,1,40,1,40,1,41,1,41,1,42,1,42,1,43,1,43,1,43,1,44,
		1,44,1,44,1,45,1,45,1,45,1,46,1,46,1,46,1,47,1,47,1,47,1,48,1,48,1,49,
		1,49,1,50,1,50,1,51,1,51,1,52,1,52,1,53,1,53,1,54,1,54,1,54,1,55,1,55,
		1,55,1,56,1,56,1,56,1,57,1,57,1,57,1,58,1,58,1,59,1,59,1,60,1,60,1,60,
		1,61,1,61,1,61,1,62,1,62,1,63,1,63,1,63,1,64,1,64,1,64,1,65,1,65,1,65,
		1,66,1,66,1,66,1,67,1,67,5,67,408,8,67,10,67,12,67,411,9,67,1,68,1,68,
		1,68,1,68,1,68,1,68,1,69,1,69,5,69,421,8,69,10,69,12,69,424,9,69,1,69,
		1,69,1,70,4,70,429,8,70,11,70,12,70,430,1,70,1,70,4,70,435,8,70,11,70,
		12,70,436,1,71,4,71,440,8,71,11,71,12,71,441,1,72,1,72,1,72,1,72,5,72,
		448,8,72,10,72,12,72,451,9,72,1,72,1,72,1,72,1,72,1,72,1,73,1,73,1,73,
		1,73,5,73,462,8,73,10,73,12,73,465,9,73,1,73,1,73,1,74,1,74,3,74,471,8,
		74,1,74,1,74,1,74,3,74,476,8,74,1,74,1,74,1,449,0,75,1,1,3,2,5,3,7,4,9,
		5,11,6,13,7,15,8,17,9,19,10,21,11,23,12,25,13,27,14,29,15,31,16,33,17,
		35,18,37,19,39,20,41,21,43,22,45,23,47,24,49,25,51,26,53,27,55,28,57,29,
		59,30,61,31,63,32,65,33,67,34,69,35,71,36,73,37,75,38,77,39,79,40,81,41,
		83,42,85,43,87,44,89,45,91,46,93,47,95,48,97,49,99,50,101,51,103,52,105,
		53,107,54,109,55,111,56,113,57,115,58,117,59,119,60,121,61,123,62,125,
		63,127,64,129,65,131,66,133,67,135,68,137,69,139,70,141,71,143,72,145,
		73,147,74,149,75,1,0,7,3,0,9,10,13,13,32,32,3,0,65,90,95,95,97,122,4,0,
		48,57,65,90,95,95,97,122,6,0,32,33,35,41,44,44,46,90,94,122,126,126,1,
		0,48,57,1,0,46,46,2,0,10,10,13,13,490,0,1,1,0,0,0,0,3,1,0,0,0,0,5,1,0,
		0,0,0,7,1,0,0,0,0,9,1,0,0,0,0,11,1,0,0,0,0,13,1,0,0,0,0,15,1,0,0,0,0,17,
		1,0,0,0,0,19,1,0,0,0,0,21,1,0,0,0,0,23,1,0,0,0,0,25,1,0,0,0,0,27,1,0,0,
		0,0,29,1,0,0,0,0,31,1,0,0,0,0,33,1,0,0,0,0,35,1,0,0,0,0,37,1,0,0,0,0,39,
		1,0,0,0,0,41,1,0,0,0,0,43,1,0,0,0,0,45,1,0,0,0,0,47,1,0,0,0,0,49,1,0,0,
		0,0,51,1,0,0,0,0,53,1,0,0,0,0,55,1,0,0,0,0,57,1,0,0,0,0,59,1,0,0,0,0,61,
		1,0,0,0,0,63,1,0,0,0,0,65,1,0,0,0,0,67,1,0,0,0,0,69,1,0,0,0,0,71,1,0,0,
		0,0,73,1,0,0,0,0,75,1,0,0,0,0,77,1,0,0,0,0,79,1,0,0,0,0,81,1,0,0,0,0,83,
		1,0,0,0,0,85,1,0,0,0,0,87,1,0,0,0,0,89,1,0,0,0,0,91,1,0,0,0,0,93,1,0,0,
		0,0,95,1,0,0,0,0,97,1,0,0,0,0,99,1,0,0,0,0,101,1,0,0,0,0,103,1,0,0,0,0,
		105,1,0,0,0,0,107,1,0,0,0,0,109,1,0,0,0,0,111,1,0,0,0,0,113,1,0,0,0,0,
		115,1,0,0,0,0,117,1,0,0,0,0,119,1,0,0,0,0,121,1,0,0,0,0,123,1,0,0,0,0,
		125,1,0,0,0,0,127,1,0,0,0,0,129,1,0,0,0,0,131,1,0,0,0,0,133,1,0,0,0,0,
		135,1,0,0,0,0,137,1,0,0,0,0,139,1,0,0,0,0,141,1,0,0,0,0,143,1,0,0,0,0,
		145,1,0,0,0,0,147,1,0,0,0,0,149,1,0,0,0,1,153,1,0,0,0,3,156,1,0,0,0,5,
		162,1,0,0,0,7,167,1,0,0,0,9,171,1,0,0,0,11,177,1,0,0,0,13,184,1,0,0,0,
		15,189,1,0,0,0,17,194,1,0,0,0,19,198,1,0,0,0,21,204,1,0,0,0,23,211,1,0,
		0,0,25,216,1,0,0,0,27,221,1,0,0,0,29,226,1,0,0,0,31,233,1,0,0,0,33,239,
		1,0,0,0,35,243,1,0,0,0,37,246,1,0,0,0,39,251,1,0,0,0,41,257,1,0,0,0,43,
		260,1,0,0,0,45,265,1,0,0,0,47,271,1,0,0,0,49,275,1,0,0,0,51,284,1,0,0,
		0,53,290,1,0,0,0,55,297,1,0,0,0,57,305,1,0,0,0,59,307,1,0,0,0,61,309,1,
		0,0,0,63,311,1,0,0,0,65,313,1,0,0,0,67,315,1,0,0,0,69,317,1,0,0,0,71,319,
		1,0,0,0,73,321,1,0,0,0,75,323,1,0,0,0,77,325,1,0,0,0,79,327,1,0,0,0,81,
		332,1,0,0,0,83,338,1,0,0,0,85,340,1,0,0,0,87,342,1,0,0,0,89,345,1,0,0,
		0,91,348,1,0,0,0,93,351,1,0,0,0,95,354,1,0,0,0,97,357,1,0,0,0,99,359,1,
		0,0,0,101,361,1,0,0,0,103,363,1,0,0,0,105,365,1,0,0,0,107,367,1,0,0,0,
		109,369,1,0,0,0,111,372,1,0,0,0,113,375,1,0,0,0,115,378,1,0,0,0,117,381,
		1,0,0,0,119,383,1,0,0,0,121,385,1,0,0,0,123,388,1,0,0,0,125,391,1,0,0,
		0,127,393,1,0,0,0,129,396,1,0,0,0,131,399,1,0,0,0,133,402,1,0,0,0,135,
		405,1,0,0,0,137,412,1,0,0,0,139,418,1,0,0,0,141,428,1,0,0,0,143,439,1,
		0,0,0,145,443,1,0,0,0,147,457,1,0,0,0,149,475,1,0,0,0,151,154,3,79,39,
		0,152,154,3,81,40,0,153,151,1,0,0,0,153,152,1,0,0,0,154,2,1,0,0,0,155,
		157,7,0,0,0,156,155,1,0,0,0,157,158,1,0,0,0,158,156,1,0,0,0,158,159,1,
		0,0,0,159,160,1,0,0,0,160,161,6,1,0,0,161,4,1,0,0,0,162,163,5,72,0,0,163,
		164,5,73,0,0,164,165,5,71,0,0,165,166,5,72,0,0,166,6,1,0,0,0,167,168,5,
		76,0,0,168,169,5,79,0,0,169,170,5,87,0,0,170,8,1,0,0,0,171,172,5,73,0,
		0,172,173,5,78,0,0,173,174,5,80,0,0,174,175,5,85,0,0,175,176,5,84,0,0,
		176,10,1,0,0,0,177,178,5,79,0,0,178,179,5,85,0,0,179,180,5,84,0,0,180,
		181,5,80,0,0,181,182,5,85,0,0,182,183,5,84,0,0,183,12,1,0,0,0,184,185,
		5,100,0,0,185,186,5,112,0,0,186,187,5,105,0,0,187,188,5,110,0,0,188,14,
		1,0,0,0,189,190,5,97,0,0,190,191,5,112,0,0,191,192,5,105,0,0,192,193,5,
		110,0,0,193,16,1,0,0,0,194,195,5,105,0,0,195,196,5,110,0,0,196,197,5,116,
		0,0,197,18,1,0,0,0,198,199,5,102,0,0,199,200,5,108,0,0,200,201,5,111,0,
		0,201,202,5,97,0,0,202,203,5,116,0,0,203,20,1,0,0,0,204,205,5,115,0,0,
		205,206,5,116,0,0,206,207,5,114,0,0,207,208,5,105,0,0,208,209,5,110,0,
		0,209,210,5,103,0,0,210,22,1,0,0,0,211,212,5,98,0,0,212,213,5,111,0,0,
		213,214,5,111,0,0,214,215,5,108,0,0,215,24,1,0,0,0,216,217,5,118,0,0,217,
		218,5,111,0,0,218,219,5,105,0,0,219,220,5,100,0,0,220,26,1,0,0,0,221,222,
		5,99,0,0,222,223,5,104,0,0,223,224,5,97,0,0,224,225,5,114,0,0,225,28,1,
		0,0,0,226,227,5,117,0,0,227,228,5,112,0,0,228,229,5,100,0,0,229,230,5,
		97,0,0,230,231,5,116,0,0,231,232,5,101,0,0,232,30,1,0,0,0,233,234,5,115,
		0,0,234,235,5,101,0,0,235,236,5,116,0,0,236,237,5,117,0,0,237,238,5,112,
		0,0,238,32,1,0,0,0,239,240,5,115,0,0,240,241,5,101,0,0,241,242,5,116,0,
		0,242,34,1,0,0,0,243,244,5,116,0,0,244,245,5,111,0,0,245,36,1,0,0,0,246,
		247,5,114,0,0,247,248,5,101,0,0,248,249,5,97,0,0,249,250,5,100,0,0,250,
		38,1,0,0,0,251,252,5,119,0,0,252,253,5,114,0,0,253,254,5,105,0,0,254,255,
		5,116,0,0,255,256,5,101,0,0,256,40,1,0,0,0,257,258,5,105,0,0,258,259,5,
		102,0,0,259,42,1,0,0,0,260,261,5,101,0,0,261,262,5,108,0,0,262,263,5,115,
		0,0,263,264,5,101,0,0,264,44,1,0,0,0,265,266,5,119,0,0,266,267,5,104,0,
		0,267,268,5,105,0,0,268,269,5,108,0,0,269,270,5,101,0,0,270,46,1,0,0,0,
		271,272,5,102,0,0,272,273,5,111,0,0,273,274,5,114,0,0,274,48,1,0,0,0,275,
		276,5,99,0,0,276,277,5,111,0,0,277,278,5,110,0,0,278,279,5,116,0,0,279,
		280,5,105,0,0,280,281,5,110,0,0,281,282,5,117,0,0,282,283,5,101,0,0,283,
		50,1,0,0,0,284,285,5,98,0,0,285,286,5,114,0,0,286,287,5,101,0,0,287,288,
		5,97,0,0,288,289,5,107,0,0,289,52,1,0,0,0,290,291,5,114,0,0,291,292,5,
		101,0,0,292,293,5,116,0,0,293,294,5,117,0,0,294,295,5,114,0,0,295,296,
		5,110,0,0,296,54,1,0,0,0,297,298,5,105,0,0,298,299,5,110,0,0,299,300,5,
		99,0,0,300,301,5,108,0,0,301,302,5,117,0,0,302,303,5,100,0,0,303,304,5,
		101,0,0,304,56,1,0,0,0,305,306,5,63,0,0,306,58,1,0,0,0,307,308,5,40,0,
		0,308,60,1,0,0,0,309,310,5,41,0,0,310,62,1,0,0,0,311,312,5,123,0,0,312,
		64,1,0,0,0,313,314,5,125,0,0,314,66,1,0,0,0,315,316,5,91,0,0,316,68,1,
		0,0,0,317,318,5,93,0,0,318,70,1,0,0,0,319,320,5,59,0,0,320,72,1,0,0,0,
		321,322,5,46,0,0,322,74,1,0,0,0,323,324,5,44,0,0,324,76,1,0,0,0,325,326,
		5,58,0,0,326,78,1,0,0,0,327,328,5,116,0,0,328,329,5,114,0,0,329,330,5,
		117,0,0,330,331,5,101,0,0,331,80,1,0,0,0,332,333,5,102,0,0,333,334,5,97,
		0,0,334,335,5,108,0,0,335,336,5,115,0,0,336,337,5,101,0,0,337,82,1,0,0,
		0,338,339,5,10,0,0,339,84,1,0,0,0,340,341,5,61,0,0,341,86,1,0,0,0,342,
		343,5,43,0,0,343,344,5,61,0,0,344,88,1,0,0,0,345,346,5,42,0,0,346,347,
		5,61,0,0,347,90,1,0,0,0,348,349,5,47,0,0,349,350,5,61,0,0,350,92,1,0,0,
		0,351,352,5,37,0,0,352,353,5,61,0,0,353,94,1,0,0,0,354,355,5,45,0,0,355,
		356,5,61,0,0,356,96,1,0,0,0,357,358,5,34,0,0,358,98,1,0,0,0,359,360,5,
		42,0,0,360,100,1,0,0,0,361,362,5,47,0,0,362,102,1,0,0,0,363,364,5,43,0,
		0,364,104,1,0,0,0,365,366,5,45,0,0,366,106,1,0,0,0,367,368,5,37,0,0,368,
		108,1,0,0,0,369,370,5,38,0,0,370,371,5,38,0,0,371,110,1,0,0,0,372,373,
		5,124,0,0,373,374,5,124,0,0,374,112,1,0,0,0,375,376,5,61,0,0,376,377,5,
		61,0,0,377,114,1,0,0,0,378,379,5,33,0,0,379,380,5,61,0,0,380,116,1,0,0,
		0,381,382,5,62,0,0,382,118,1,0,0,0,383,384,5,60,0,0,384,120,1,0,0,0,385,
		386,5,62,0,0,386,387,5,61,0,0,387,122,1,0,0,0,388,389,5,60,0,0,389,390,
		5,61,0,0,390,124,1,0,0,0,391,392,5,33,0,0,392,126,1,0,0,0,393,394,5,60,
		0,0,394,395,5,60,0,0,395,128,1,0,0,0,396,397,5,62,0,0,397,398,5,62,0,0,
		398,130,1,0,0,0,399,400,5,43,0,0,400,401,5,43,0,0,401,132,1,0,0,0,402,
		403,5,45,0,0,403,404,5,45,0,0,404,134,1,0,0,0,405,409,7,1,0,0,406,408,
		7,2,0,0,407,406,1,0,0,0,408,411,1,0,0,0,409,407,1,0,0,0,409,410,1,0,0,
		0,410,136,1,0,0,0,411,409,1,0,0,0,412,413,3,135,67,0,413,414,3,73,36,0,
		414,415,5,116,0,0,415,416,5,99,0,0,416,417,5,108,0,0,417,138,1,0,0,0,418,
		422,3,97,48,0,419,421,7,3,0,0,420,419,1,0,0,0,421,424,1,0,0,0,422,420,
		1,0,0,0,422,423,1,0,0,0,423,425,1,0,0,0,424,422,1,0,0,0,425,426,3,97,48,
		0,426,140,1,0,0,0,427,429,7,4,0,0,428,427,1,0,0,0,429,430,1,0,0,0,430,
		428,1,0,0,0,430,431,1,0,0,0,431,432,1,0,0,0,432,434,7,5,0,0,433,435,7,
		4,0,0,434,433,1,0,0,0,435,436,1,0,0,0,436,434,1,0,0,0,436,437,1,0,0,0,
		437,142,1,0,0,0,438,440,7,4,0,0,439,438,1,0,0,0,440,441,1,0,0,0,441,439,
		1,0,0,0,441,442,1,0,0,0,442,144,1,0,0,0,443,444,5,47,0,0,444,445,5,42,
		0,0,445,449,1,0,0,0,446,448,9,0,0,0,447,446,1,0,0,0,448,451,1,0,0,0,449,
		450,1,0,0,0,449,447,1,0,0,0,450,452,1,0,0,0,451,449,1,0,0,0,452,453,5,
		42,0,0,453,454,5,47,0,0,454,455,1,0,0,0,455,456,6,72,0,0,456,146,1,0,0,
		0,457,458,5,47,0,0,458,459,5,47,0,0,459,463,1,0,0,0,460,462,8,6,0,0,461,
		460,1,0,0,0,462,465,1,0,0,0,463,461,1,0,0,0,463,464,1,0,0,0,464,466,1,
		0,0,0,465,463,1,0,0,0,466,467,6,73,0,0,467,148,1,0,0,0,468,470,5,13,0,
		0,469,471,5,10,0,0,470,469,1,0,0,0,470,471,1,0,0,0,471,476,1,0,0,0,472,
		476,5,10,0,0,473,474,5,92,0,0,474,476,5,110,0,0,475,468,1,0,0,0,475,472,
		1,0,0,0,475,473,1,0,0,0,476,477,1,0,0,0,477,478,6,74,0,0,478,150,1,0,0,
		0,12,0,153,158,409,422,430,436,441,449,463,470,475,1,0,1,0
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
