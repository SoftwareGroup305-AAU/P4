//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.13.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from P4.TinyCell.Shared/TinyCell.g4 by ANTLR 4.13.1

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
		FOR=24, CONTINUE=25, BREAK=26, RETURN=27, QUESTION=28, LPAR=29, RPAR=30, 
		LCURLY=31, RCURLY=32, LBRACKET=33, RBRACKET=34, SEMI=35, DOT=36, COMMA=37, 
		COLON=38, TRUE=39, FALSE=40, NEWLINE=41, ASSIGN=42, PLUSASSIGN=43, MULTASSIGN=44, 
		DIVASSIGN=45, MODASSIGN=46, MINUSASSIGN=47, QUOTE=48, MULT=49, DIV=50, 
		PLUS=51, MINUS=52, MOD=53, AND=54, OR=55, EQ=56, NEQ=57, GT=58, LT=59, 
		GTE=60, LTE=61, NOT=62, BITSHIFTL=63, BITSHIFTR=64, UNARYPLUS=65, UNARYMINUS=66, 
		Identifier=67, String=68, Numeral=69, BlockComment=70, LineComment=71, 
		Newline=72;
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
		"BREAK", "RETURN", "QUESTION", "LPAR", "RPAR", "LCURLY", "RCURLY", "LBRACKET", 
		"RBRACKET", "SEMI", "DOT", "COMMA", "COLON", "TRUE", "FALSE", "NEWLINE", 
		"ASSIGN", "PLUSASSIGN", "MULTASSIGN", "DIVASSIGN", "MODASSIGN", "MINUSASSIGN", 
		"QUOTE", "MULT", "DIV", "PLUS", "MINUS", "MOD", "AND", "OR", "EQ", "NEQ", 
		"GT", "LT", "GTE", "LTE", "NOT", "BITSHIFTL", "BITSHIFTR", "UNARYPLUS", 
		"UNARYMINUS", "Identifier", "String", "Numeral", "BlockComment", "LineComment", 
		"Newline"
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
		"'while'", "'for'", "'continue'", "'break'", "'return'", "'?'", "'('", 
		"')'", "'{'", "'}'", "'['", "']'", "';'", "'.'", "','", "':'", "'true'", 
		"'false'", "'\\n'", "'='", "'+='", "'*='", "'/='", "'%='", "'-='", "'\"'", 
		"'*'", "'/'", "'+'", "'-'", "'%'", "'&&'", "'||'", "'=='", "'!='", "'>'", 
		"'<'", "'>='", "'<='", "'!'", "'<<'", "'>>'", "'++'", "'--'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "Bool", "Whitespace", "VOLHIGH", "VOLLOW", "PININ", "PINOUT", "DPIN", 
		"APIN", "INT", "FLOAT", "STRING", "BOOL", "VOID", "CHAR", "UPDATE", "SETUP", 
		"SET", "TO", "READ", "WRITE", "IF", "ELSE", "WHILE", "FOR", "CONTINUE", 
		"BREAK", "RETURN", "QUESTION", "LPAR", "RPAR", "LCURLY", "RCURLY", "LBRACKET", 
		"RBRACKET", "SEMI", "DOT", "COMMA", "COLON", "TRUE", "FALSE", "NEWLINE", 
		"ASSIGN", "PLUSASSIGN", "MULTASSIGN", "DIVASSIGN", "MODASSIGN", "MINUSASSIGN", 
		"QUOTE", "MULT", "DIV", "PLUS", "MINUS", "MOD", "AND", "OR", "EQ", "NEQ", 
		"GT", "LT", "GTE", "LTE", "NOT", "BITSHIFTL", "BITSHIFTR", "UNARYPLUS", 
		"UNARYMINUS", "Identifier", "String", "Numeral", "BlockComment", "LineComment", 
		"Newline"
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
		4,0,72,463,6,-1,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,
		6,2,7,7,7,2,8,7,8,2,9,7,9,2,10,7,10,2,11,7,11,2,12,7,12,2,13,7,13,2,14,
		7,14,2,15,7,15,2,16,7,16,2,17,7,17,2,18,7,18,2,19,7,19,2,20,7,20,2,21,
		7,21,2,22,7,22,2,23,7,23,2,24,7,24,2,25,7,25,2,26,7,26,2,27,7,27,2,28,
		7,28,2,29,7,29,2,30,7,30,2,31,7,31,2,32,7,32,2,33,7,33,2,34,7,34,2,35,
		7,35,2,36,7,36,2,37,7,37,2,38,7,38,2,39,7,39,2,40,7,40,2,41,7,41,2,42,
		7,42,2,43,7,43,2,44,7,44,2,45,7,45,2,46,7,46,2,47,7,47,2,48,7,48,2,49,
		7,49,2,50,7,50,2,51,7,51,2,52,7,52,2,53,7,53,2,54,7,54,2,55,7,55,2,56,
		7,56,2,57,7,57,2,58,7,58,2,59,7,59,2,60,7,60,2,61,7,61,2,62,7,62,2,63,
		7,63,2,64,7,64,2,65,7,65,2,66,7,66,2,67,7,67,2,68,7,68,2,69,7,69,2,70,
		7,70,2,71,7,71,1,0,1,0,3,0,148,8,0,1,1,4,1,151,8,1,11,1,12,1,152,1,1,1,
		1,1,2,1,2,1,2,1,2,1,2,1,3,1,3,1,3,1,3,1,4,1,4,1,4,1,4,1,4,1,4,1,5,1,5,
		1,5,1,5,1,5,1,5,1,5,1,6,1,6,1,6,1,6,1,6,1,7,1,7,1,7,1,7,1,7,1,8,1,8,1,
		8,1,8,1,9,1,9,1,9,1,9,1,9,1,9,1,10,1,10,1,10,1,10,1,10,1,10,1,10,1,11,
		1,11,1,11,1,11,1,11,1,12,1,12,1,12,1,12,1,12,1,13,1,13,1,13,1,13,1,13,
		1,14,1,14,1,14,1,14,1,14,1,14,1,14,1,15,1,15,1,15,1,15,1,15,1,15,1,16,
		1,16,1,16,1,16,1,17,1,17,1,17,1,18,1,18,1,18,1,18,1,18,1,19,1,19,1,19,
		1,19,1,19,1,19,1,20,1,20,1,20,1,21,1,21,1,21,1,21,1,21,1,22,1,22,1,22,
		1,22,1,22,1,22,1,23,1,23,1,23,1,23,1,24,1,24,1,24,1,24,1,24,1,24,1,24,
		1,24,1,24,1,25,1,25,1,25,1,25,1,25,1,25,1,26,1,26,1,26,1,26,1,26,1,26,
		1,26,1,27,1,27,1,28,1,28,1,29,1,29,1,30,1,30,1,31,1,31,1,32,1,32,1,33,
		1,33,1,34,1,34,1,35,1,35,1,36,1,36,1,37,1,37,1,38,1,38,1,38,1,38,1,38,
		1,39,1,39,1,39,1,39,1,39,1,39,1,40,1,40,1,41,1,41,1,42,1,42,1,42,1,43,
		1,43,1,43,1,44,1,44,1,44,1,45,1,45,1,45,1,46,1,46,1,46,1,47,1,47,1,48,
		1,48,1,49,1,49,1,50,1,50,1,51,1,51,1,52,1,52,1,53,1,53,1,53,1,54,1,54,
		1,54,1,55,1,55,1,55,1,56,1,56,1,56,1,57,1,57,1,58,1,58,1,59,1,59,1,59,
		1,60,1,60,1,60,1,61,1,61,1,62,1,62,1,62,1,63,1,63,1,63,1,64,1,64,1,64,
		1,65,1,65,1,65,1,66,1,66,5,66,394,8,66,10,66,12,66,397,9,66,1,67,1,67,
		5,67,401,8,67,10,67,12,67,404,9,67,1,67,1,67,1,68,3,68,409,8,68,1,68,3,
		68,412,8,68,1,68,5,68,415,8,68,10,68,12,68,418,9,68,1,68,1,68,4,68,422,
		8,68,11,68,12,68,423,3,68,426,8,68,1,69,1,69,1,69,1,69,5,69,432,8,69,10,
		69,12,69,435,9,69,1,69,1,69,1,69,1,69,1,69,1,70,1,70,1,70,1,70,5,70,446,
		8,70,10,70,12,70,449,9,70,1,70,1,70,1,71,1,71,3,71,455,8,71,1,71,1,71,
		1,71,3,71,460,8,71,1,71,1,71,1,433,0,72,1,1,3,2,5,3,7,4,9,5,11,6,13,7,
		15,8,17,9,19,10,21,11,23,12,25,13,27,14,29,15,31,16,33,17,35,18,37,19,
		39,20,41,21,43,22,45,23,47,24,49,25,51,26,53,27,55,28,57,29,59,30,61,31,
		63,32,65,33,67,34,69,35,71,36,73,37,75,38,77,39,79,40,81,41,83,42,85,43,
		87,44,89,45,91,46,93,47,95,48,97,49,99,50,101,51,103,52,105,53,107,54,
		109,55,111,56,113,57,115,58,117,59,119,60,121,61,123,62,125,63,127,64,
		129,65,131,66,133,67,135,68,137,69,139,70,141,71,143,72,1,0,8,3,0,9,10,
		13,13,32,32,3,0,65,90,95,95,97,122,4,0,48,57,65,90,95,95,97,122,6,0,32,
		33,35,41,44,44,46,90,94,122,126,126,1,0,45,45,1,0,48,57,1,0,46,46,2,0,
		10,10,13,13,475,0,1,1,0,0,0,0,3,1,0,0,0,0,5,1,0,0,0,0,7,1,0,0,0,0,9,1,
		0,0,0,0,11,1,0,0,0,0,13,1,0,0,0,0,15,1,0,0,0,0,17,1,0,0,0,0,19,1,0,0,0,
		0,21,1,0,0,0,0,23,1,0,0,0,0,25,1,0,0,0,0,27,1,0,0,0,0,29,1,0,0,0,0,31,
		1,0,0,0,0,33,1,0,0,0,0,35,1,0,0,0,0,37,1,0,0,0,0,39,1,0,0,0,0,41,1,0,0,
		0,0,43,1,0,0,0,0,45,1,0,0,0,0,47,1,0,0,0,0,49,1,0,0,0,0,51,1,0,0,0,0,53,
		1,0,0,0,0,55,1,0,0,0,0,57,1,0,0,0,0,59,1,0,0,0,0,61,1,0,0,0,0,63,1,0,0,
		0,0,65,1,0,0,0,0,67,1,0,0,0,0,69,1,0,0,0,0,71,1,0,0,0,0,73,1,0,0,0,0,75,
		1,0,0,0,0,77,1,0,0,0,0,79,1,0,0,0,0,81,1,0,0,0,0,83,1,0,0,0,0,85,1,0,0,
		0,0,87,1,0,0,0,0,89,1,0,0,0,0,91,1,0,0,0,0,93,1,0,0,0,0,95,1,0,0,0,0,97,
		1,0,0,0,0,99,1,0,0,0,0,101,1,0,0,0,0,103,1,0,0,0,0,105,1,0,0,0,0,107,1,
		0,0,0,0,109,1,0,0,0,0,111,1,0,0,0,0,113,1,0,0,0,0,115,1,0,0,0,0,117,1,
		0,0,0,0,119,1,0,0,0,0,121,1,0,0,0,0,123,1,0,0,0,0,125,1,0,0,0,0,127,1,
		0,0,0,0,129,1,0,0,0,0,131,1,0,0,0,0,133,1,0,0,0,0,135,1,0,0,0,0,137,1,
		0,0,0,0,139,1,0,0,0,0,141,1,0,0,0,0,143,1,0,0,0,1,147,1,0,0,0,3,150,1,
		0,0,0,5,156,1,0,0,0,7,161,1,0,0,0,9,165,1,0,0,0,11,171,1,0,0,0,13,178,
		1,0,0,0,15,183,1,0,0,0,17,188,1,0,0,0,19,192,1,0,0,0,21,198,1,0,0,0,23,
		205,1,0,0,0,25,210,1,0,0,0,27,215,1,0,0,0,29,220,1,0,0,0,31,227,1,0,0,
		0,33,233,1,0,0,0,35,237,1,0,0,0,37,240,1,0,0,0,39,245,1,0,0,0,41,251,1,
		0,0,0,43,254,1,0,0,0,45,259,1,0,0,0,47,265,1,0,0,0,49,269,1,0,0,0,51,278,
		1,0,0,0,53,284,1,0,0,0,55,291,1,0,0,0,57,293,1,0,0,0,59,295,1,0,0,0,61,
		297,1,0,0,0,63,299,1,0,0,0,65,301,1,0,0,0,67,303,1,0,0,0,69,305,1,0,0,
		0,71,307,1,0,0,0,73,309,1,0,0,0,75,311,1,0,0,0,77,313,1,0,0,0,79,318,1,
		0,0,0,81,324,1,0,0,0,83,326,1,0,0,0,85,328,1,0,0,0,87,331,1,0,0,0,89,334,
		1,0,0,0,91,337,1,0,0,0,93,340,1,0,0,0,95,343,1,0,0,0,97,345,1,0,0,0,99,
		347,1,0,0,0,101,349,1,0,0,0,103,351,1,0,0,0,105,353,1,0,0,0,107,355,1,
		0,0,0,109,358,1,0,0,0,111,361,1,0,0,0,113,364,1,0,0,0,115,367,1,0,0,0,
		117,369,1,0,0,0,119,371,1,0,0,0,121,374,1,0,0,0,123,377,1,0,0,0,125,379,
		1,0,0,0,127,382,1,0,0,0,129,385,1,0,0,0,131,388,1,0,0,0,133,391,1,0,0,
		0,135,398,1,0,0,0,137,408,1,0,0,0,139,427,1,0,0,0,141,441,1,0,0,0,143,
		459,1,0,0,0,145,148,3,77,38,0,146,148,3,79,39,0,147,145,1,0,0,0,147,146,
		1,0,0,0,148,2,1,0,0,0,149,151,7,0,0,0,150,149,1,0,0,0,151,152,1,0,0,0,
		152,150,1,0,0,0,152,153,1,0,0,0,153,154,1,0,0,0,154,155,6,1,0,0,155,4,
		1,0,0,0,156,157,5,72,0,0,157,158,5,73,0,0,158,159,5,71,0,0,159,160,5,72,
		0,0,160,6,1,0,0,0,161,162,5,76,0,0,162,163,5,79,0,0,163,164,5,87,0,0,164,
		8,1,0,0,0,165,166,5,73,0,0,166,167,5,78,0,0,167,168,5,80,0,0,168,169,5,
		85,0,0,169,170,5,84,0,0,170,10,1,0,0,0,171,172,5,79,0,0,172,173,5,85,0,
		0,173,174,5,84,0,0,174,175,5,80,0,0,175,176,5,85,0,0,176,177,5,84,0,0,
		177,12,1,0,0,0,178,179,5,100,0,0,179,180,5,112,0,0,180,181,5,105,0,0,181,
		182,5,110,0,0,182,14,1,0,0,0,183,184,5,97,0,0,184,185,5,112,0,0,185,186,
		5,105,0,0,186,187,5,110,0,0,187,16,1,0,0,0,188,189,5,105,0,0,189,190,5,
		110,0,0,190,191,5,116,0,0,191,18,1,0,0,0,192,193,5,102,0,0,193,194,5,108,
		0,0,194,195,5,111,0,0,195,196,5,97,0,0,196,197,5,116,0,0,197,20,1,0,0,
		0,198,199,5,115,0,0,199,200,5,116,0,0,200,201,5,114,0,0,201,202,5,105,
		0,0,202,203,5,110,0,0,203,204,5,103,0,0,204,22,1,0,0,0,205,206,5,98,0,
		0,206,207,5,111,0,0,207,208,5,111,0,0,208,209,5,108,0,0,209,24,1,0,0,0,
		210,211,5,118,0,0,211,212,5,111,0,0,212,213,5,105,0,0,213,214,5,100,0,
		0,214,26,1,0,0,0,215,216,5,99,0,0,216,217,5,104,0,0,217,218,5,97,0,0,218,
		219,5,114,0,0,219,28,1,0,0,0,220,221,5,117,0,0,221,222,5,112,0,0,222,223,
		5,100,0,0,223,224,5,97,0,0,224,225,5,116,0,0,225,226,5,101,0,0,226,30,
		1,0,0,0,227,228,5,115,0,0,228,229,5,101,0,0,229,230,5,116,0,0,230,231,
		5,117,0,0,231,232,5,112,0,0,232,32,1,0,0,0,233,234,5,115,0,0,234,235,5,
		101,0,0,235,236,5,116,0,0,236,34,1,0,0,0,237,238,5,116,0,0,238,239,5,111,
		0,0,239,36,1,0,0,0,240,241,5,114,0,0,241,242,5,101,0,0,242,243,5,97,0,
		0,243,244,5,100,0,0,244,38,1,0,0,0,245,246,5,119,0,0,246,247,5,114,0,0,
		247,248,5,105,0,0,248,249,5,116,0,0,249,250,5,101,0,0,250,40,1,0,0,0,251,
		252,5,105,0,0,252,253,5,102,0,0,253,42,1,0,0,0,254,255,5,101,0,0,255,256,
		5,108,0,0,256,257,5,115,0,0,257,258,5,101,0,0,258,44,1,0,0,0,259,260,5,
		119,0,0,260,261,5,104,0,0,261,262,5,105,0,0,262,263,5,108,0,0,263,264,
		5,101,0,0,264,46,1,0,0,0,265,266,5,102,0,0,266,267,5,111,0,0,267,268,5,
		114,0,0,268,48,1,0,0,0,269,270,5,99,0,0,270,271,5,111,0,0,271,272,5,110,
		0,0,272,273,5,116,0,0,273,274,5,105,0,0,274,275,5,110,0,0,275,276,5,117,
		0,0,276,277,5,101,0,0,277,50,1,0,0,0,278,279,5,98,0,0,279,280,5,114,0,
		0,280,281,5,101,0,0,281,282,5,97,0,0,282,283,5,107,0,0,283,52,1,0,0,0,
		284,285,5,114,0,0,285,286,5,101,0,0,286,287,5,116,0,0,287,288,5,117,0,
		0,288,289,5,114,0,0,289,290,5,110,0,0,290,54,1,0,0,0,291,292,5,63,0,0,
		292,56,1,0,0,0,293,294,5,40,0,0,294,58,1,0,0,0,295,296,5,41,0,0,296,60,
		1,0,0,0,297,298,5,123,0,0,298,62,1,0,0,0,299,300,5,125,0,0,300,64,1,0,
		0,0,301,302,5,91,0,0,302,66,1,0,0,0,303,304,5,93,0,0,304,68,1,0,0,0,305,
		306,5,59,0,0,306,70,1,0,0,0,307,308,5,46,0,0,308,72,1,0,0,0,309,310,5,
		44,0,0,310,74,1,0,0,0,311,312,5,58,0,0,312,76,1,0,0,0,313,314,5,116,0,
		0,314,315,5,114,0,0,315,316,5,117,0,0,316,317,5,101,0,0,317,78,1,0,0,0,
		318,319,5,102,0,0,319,320,5,97,0,0,320,321,5,108,0,0,321,322,5,115,0,0,
		322,323,5,101,0,0,323,80,1,0,0,0,324,325,5,10,0,0,325,82,1,0,0,0,326,327,
		5,61,0,0,327,84,1,0,0,0,328,329,5,43,0,0,329,330,5,61,0,0,330,86,1,0,0,
		0,331,332,5,42,0,0,332,333,5,61,0,0,333,88,1,0,0,0,334,335,5,47,0,0,335,
		336,5,61,0,0,336,90,1,0,0,0,337,338,5,37,0,0,338,339,5,61,0,0,339,92,1,
		0,0,0,340,341,5,45,0,0,341,342,5,61,0,0,342,94,1,0,0,0,343,344,5,34,0,
		0,344,96,1,0,0,0,345,346,5,42,0,0,346,98,1,0,0,0,347,348,5,47,0,0,348,
		100,1,0,0,0,349,350,5,43,0,0,350,102,1,0,0,0,351,352,5,45,0,0,352,104,
		1,0,0,0,353,354,5,37,0,0,354,106,1,0,0,0,355,356,5,38,0,0,356,357,5,38,
		0,0,357,108,1,0,0,0,358,359,5,124,0,0,359,360,5,124,0,0,360,110,1,0,0,
		0,361,362,5,61,0,0,362,363,5,61,0,0,363,112,1,0,0,0,364,365,5,33,0,0,365,
		366,5,61,0,0,366,114,1,0,0,0,367,368,5,62,0,0,368,116,1,0,0,0,369,370,
		5,60,0,0,370,118,1,0,0,0,371,372,5,62,0,0,372,373,5,61,0,0,373,120,1,0,
		0,0,374,375,5,60,0,0,375,376,5,61,0,0,376,122,1,0,0,0,377,378,5,33,0,0,
		378,124,1,0,0,0,379,380,5,60,0,0,380,381,5,60,0,0,381,126,1,0,0,0,382,
		383,5,62,0,0,383,384,5,62,0,0,384,128,1,0,0,0,385,386,5,43,0,0,386,387,
		5,43,0,0,387,130,1,0,0,0,388,389,5,45,0,0,389,390,5,45,0,0,390,132,1,0,
		0,0,391,395,7,1,0,0,392,394,7,2,0,0,393,392,1,0,0,0,394,397,1,0,0,0,395,
		393,1,0,0,0,395,396,1,0,0,0,396,134,1,0,0,0,397,395,1,0,0,0,398,402,3,
		95,47,0,399,401,7,3,0,0,400,399,1,0,0,0,401,404,1,0,0,0,402,400,1,0,0,
		0,402,403,1,0,0,0,403,405,1,0,0,0,404,402,1,0,0,0,405,406,3,95,47,0,406,
		136,1,0,0,0,407,409,7,4,0,0,408,407,1,0,0,0,408,409,1,0,0,0,409,411,1,
		0,0,0,410,412,2,48,57,0,411,410,1,0,0,0,412,416,1,0,0,0,413,415,7,5,0,
		0,414,413,1,0,0,0,415,418,1,0,0,0,416,414,1,0,0,0,416,417,1,0,0,0,417,
		425,1,0,0,0,418,416,1,0,0,0,419,421,7,6,0,0,420,422,7,5,0,0,421,420,1,
		0,0,0,422,423,1,0,0,0,423,421,1,0,0,0,423,424,1,0,0,0,424,426,1,0,0,0,
		425,419,1,0,0,0,425,426,1,0,0,0,426,138,1,0,0,0,427,428,5,47,0,0,428,429,
		5,42,0,0,429,433,1,0,0,0,430,432,9,0,0,0,431,430,1,0,0,0,432,435,1,0,0,
		0,433,434,1,0,0,0,433,431,1,0,0,0,434,436,1,0,0,0,435,433,1,0,0,0,436,
		437,5,42,0,0,437,438,5,47,0,0,438,439,1,0,0,0,439,440,6,69,0,0,440,140,
		1,0,0,0,441,442,5,47,0,0,442,443,5,47,0,0,443,447,1,0,0,0,444,446,8,7,
		0,0,445,444,1,0,0,0,446,449,1,0,0,0,447,445,1,0,0,0,447,448,1,0,0,0,448,
		450,1,0,0,0,449,447,1,0,0,0,450,451,6,70,0,0,451,142,1,0,0,0,452,454,5,
		13,0,0,453,455,5,10,0,0,454,453,1,0,0,0,454,455,1,0,0,0,455,460,1,0,0,
		0,456,460,5,10,0,0,457,458,5,92,0,0,458,460,5,110,0,0,459,452,1,0,0,0,
		459,456,1,0,0,0,459,457,1,0,0,0,460,461,1,0,0,0,461,462,6,71,0,0,462,144,
		1,0,0,0,14,0,147,152,395,402,408,411,416,423,425,433,447,454,459,1,0,1,
		0
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
