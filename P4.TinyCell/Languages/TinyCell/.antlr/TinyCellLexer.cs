//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.13.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from /Users/emilpriv/Desktop/Git-Clones/P4/P4.TinyCell/Languages/TinyCell/TinyCell.g4 by ANTLR 4.13.1

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
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, T__12=13, T__13=14, T__14=15, T__15=16, T__16=17, 
		T__17=18, T__18=19, T__19=20, T__20=21, T__21=22, T__22=23, T__23=24, 
		T__24=25, T__25=26, T__26=27, T__27=28, T__28=29, T__29=30, T__30=31, 
		T__31=32, T__32=33, T__33=34, T__34=35, T__35=36, T__36=37, T__37=38, 
		T__38=39, T__39=40, T__40=41, T__41=42, T__42=43, T__43=44, T__44=45, 
		T__45=46, T__46=47, T__47=48, T__48=49, T__49=50, Identifier=51, String=52, 
		Numeral=53, Whitespace=54, Newline=55;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "T__8", 
		"T__9", "T__10", "T__11", "T__12", "T__13", "T__14", "T__15", "T__16", 
		"T__17", "T__18", "T__19", "T__20", "T__21", "T__22", "T__23", "T__24", 
		"T__25", "T__26", "T__27", "T__28", "T__29", "T__30", "T__31", "T__32", 
		"T__33", "T__34", "T__35", "T__36", "T__37", "T__38", "T__39", "T__40", 
		"T__41", "T__42", "T__43", "T__44", "T__45", "T__46", "T__47", "T__48", 
		"T__49", "Identifier", "String", "Numeral", "Whitespace", "Newline"
	};


	public TinyCellLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public TinyCellLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'setup'", "'update'", "'('", "')'", "'void'", "'char'", "'int'", 
		"'float'", "'bool'", "'pin'", "','", "';'", "'='", "'{'", "'}'", "'if'", 
		"'else'", "'while'", "'for'", "'continue'", "'break'", "'return'", "'?'", 
		"':'", "'||'", "'&&'", "'=='", "'!='", "'<'", "'>'", "'<='", "'>='", "'<<'", 
		"'>>'", "'+'", "'-'", "'*'", "'/'", "'%'", "'++'", "'--'", "'set'", "'to'", 
		"'*='", "'/='", "'%='", "'+='", "'-='", "'high'", "'low'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, "Identifier", "String", "Numeral", "Whitespace", "Newline"
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
		4,0,55,333,6,-1,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,
		6,2,7,7,7,2,8,7,8,2,9,7,9,2,10,7,10,2,11,7,11,2,12,7,12,2,13,7,13,2,14,
		7,14,2,15,7,15,2,16,7,16,2,17,7,17,2,18,7,18,2,19,7,19,2,20,7,20,2,21,
		7,21,2,22,7,22,2,23,7,23,2,24,7,24,2,25,7,25,2,26,7,26,2,27,7,27,2,28,
		7,28,2,29,7,29,2,30,7,30,2,31,7,31,2,32,7,32,2,33,7,33,2,34,7,34,2,35,
		7,35,2,36,7,36,2,37,7,37,2,38,7,38,2,39,7,39,2,40,7,40,2,41,7,41,2,42,
		7,42,2,43,7,43,2,44,7,44,2,45,7,45,2,46,7,46,2,47,7,47,2,48,7,48,2,49,
		7,49,2,50,7,50,2,51,7,51,2,52,7,52,2,53,7,53,2,54,7,54,1,0,1,0,1,0,1,0,
		1,0,1,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,2,1,2,1,3,1,3,1,4,1,4,1,4,1,4,1,
		4,1,5,1,5,1,5,1,5,1,5,1,6,1,6,1,6,1,6,1,7,1,7,1,7,1,7,1,7,1,7,1,8,1,8,
		1,8,1,8,1,8,1,9,1,9,1,9,1,9,1,10,1,10,1,11,1,11,1,12,1,12,1,13,1,13,1,
		14,1,14,1,15,1,15,1,15,1,16,1,16,1,16,1,16,1,16,1,17,1,17,1,17,1,17,1,
		17,1,17,1,18,1,18,1,18,1,18,1,19,1,19,1,19,1,19,1,19,1,19,1,19,1,19,1,
		19,1,20,1,20,1,20,1,20,1,20,1,20,1,21,1,21,1,21,1,21,1,21,1,21,1,21,1,
		22,1,22,1,23,1,23,1,24,1,24,1,24,1,25,1,25,1,25,1,26,1,26,1,26,1,27,1,
		27,1,27,1,28,1,28,1,29,1,29,1,30,1,30,1,30,1,31,1,31,1,31,1,32,1,32,1,
		32,1,33,1,33,1,33,1,34,1,34,1,35,1,35,1,36,1,36,1,37,1,37,1,38,1,38,1,
		39,1,39,1,39,1,40,1,40,1,40,1,41,1,41,1,41,1,41,1,42,1,42,1,42,1,43,1,
		43,1,43,1,44,1,44,1,44,1,45,1,45,1,45,1,46,1,46,1,46,1,47,1,47,1,47,1,
		48,1,48,1,48,1,48,1,48,1,49,1,49,1,49,1,49,1,50,1,50,5,50,289,8,50,10,
		50,12,50,292,9,50,1,51,1,51,1,51,1,51,1,52,3,52,299,8,52,1,52,3,52,302,
		8,52,1,52,5,52,305,8,52,10,52,12,52,308,9,52,1,52,1,52,4,52,312,8,52,11,
		52,12,52,313,3,52,316,8,52,1,53,4,53,319,8,53,11,53,12,53,320,1,53,1,53,
		1,54,1,54,3,54,327,8,54,1,54,3,54,330,8,54,1,54,1,54,0,0,55,1,1,3,2,5,
		3,7,4,9,5,11,6,13,7,15,8,17,9,19,10,21,11,23,12,25,13,27,14,29,15,31,16,
		33,17,35,18,37,19,39,20,41,21,43,22,45,23,47,24,49,25,51,26,53,27,55,28,
		57,29,59,30,61,31,63,32,65,33,67,34,69,35,71,36,73,37,75,38,77,39,79,40,
		81,41,83,42,85,43,87,44,89,45,91,46,93,47,95,48,97,49,99,50,101,51,103,
		52,105,53,107,54,109,55,1,0,6,3,0,65,90,95,95,97,122,4,0,48,57,65,90,95,
		95,97,122,6,0,33,33,35,41,44,44,46,90,94,122,126,126,1,0,45,45,1,0,48,
		57,2,0,9,9,32,32,340,0,1,1,0,0,0,0,3,1,0,0,0,0,5,1,0,0,0,0,7,1,0,0,0,0,
		9,1,0,0,0,0,11,1,0,0,0,0,13,1,0,0,0,0,15,1,0,0,0,0,17,1,0,0,0,0,19,1,0,
		0,0,0,21,1,0,0,0,0,23,1,0,0,0,0,25,1,0,0,0,0,27,1,0,0,0,0,29,1,0,0,0,0,
		31,1,0,0,0,0,33,1,0,0,0,0,35,1,0,0,0,0,37,1,0,0,0,0,39,1,0,0,0,0,41,1,
		0,0,0,0,43,1,0,0,0,0,45,1,0,0,0,0,47,1,0,0,0,0,49,1,0,0,0,0,51,1,0,0,0,
		0,53,1,0,0,0,0,55,1,0,0,0,0,57,1,0,0,0,0,59,1,0,0,0,0,61,1,0,0,0,0,63,
		1,0,0,0,0,65,1,0,0,0,0,67,1,0,0,0,0,69,1,0,0,0,0,71,1,0,0,0,0,73,1,0,0,
		0,0,75,1,0,0,0,0,77,1,0,0,0,0,79,1,0,0,0,0,81,1,0,0,0,0,83,1,0,0,0,0,85,
		1,0,0,0,0,87,1,0,0,0,0,89,1,0,0,0,0,91,1,0,0,0,0,93,1,0,0,0,0,95,1,0,0,
		0,0,97,1,0,0,0,0,99,1,0,0,0,0,101,1,0,0,0,0,103,1,0,0,0,0,105,1,0,0,0,
		0,107,1,0,0,0,0,109,1,0,0,0,1,111,1,0,0,0,3,117,1,0,0,0,5,124,1,0,0,0,
		7,126,1,0,0,0,9,128,1,0,0,0,11,133,1,0,0,0,13,138,1,0,0,0,15,142,1,0,0,
		0,17,148,1,0,0,0,19,153,1,0,0,0,21,157,1,0,0,0,23,159,1,0,0,0,25,161,1,
		0,0,0,27,163,1,0,0,0,29,165,1,0,0,0,31,167,1,0,0,0,33,170,1,0,0,0,35,175,
		1,0,0,0,37,181,1,0,0,0,39,185,1,0,0,0,41,194,1,0,0,0,43,200,1,0,0,0,45,
		207,1,0,0,0,47,209,1,0,0,0,49,211,1,0,0,0,51,214,1,0,0,0,53,217,1,0,0,
		0,55,220,1,0,0,0,57,223,1,0,0,0,59,225,1,0,0,0,61,227,1,0,0,0,63,230,1,
		0,0,0,65,233,1,0,0,0,67,236,1,0,0,0,69,239,1,0,0,0,71,241,1,0,0,0,73,243,
		1,0,0,0,75,245,1,0,0,0,77,247,1,0,0,0,79,249,1,0,0,0,81,252,1,0,0,0,83,
		255,1,0,0,0,85,259,1,0,0,0,87,262,1,0,0,0,89,265,1,0,0,0,91,268,1,0,0,
		0,93,271,1,0,0,0,95,274,1,0,0,0,97,277,1,0,0,0,99,282,1,0,0,0,101,286,
		1,0,0,0,103,293,1,0,0,0,105,298,1,0,0,0,107,318,1,0,0,0,109,329,1,0,0,
		0,111,112,5,115,0,0,112,113,5,101,0,0,113,114,5,116,0,0,114,115,5,117,
		0,0,115,116,5,112,0,0,116,2,1,0,0,0,117,118,5,117,0,0,118,119,5,112,0,
		0,119,120,5,100,0,0,120,121,5,97,0,0,121,122,5,116,0,0,122,123,5,101,0,
		0,123,4,1,0,0,0,124,125,5,40,0,0,125,6,1,0,0,0,126,127,5,41,0,0,127,8,
		1,0,0,0,128,129,5,118,0,0,129,130,5,111,0,0,130,131,5,105,0,0,131,132,
		5,100,0,0,132,10,1,0,0,0,133,134,5,99,0,0,134,135,5,104,0,0,135,136,5,
		97,0,0,136,137,5,114,0,0,137,12,1,0,0,0,138,139,5,105,0,0,139,140,5,110,
		0,0,140,141,5,116,0,0,141,14,1,0,0,0,142,143,5,102,0,0,143,144,5,108,0,
		0,144,145,5,111,0,0,145,146,5,97,0,0,146,147,5,116,0,0,147,16,1,0,0,0,
		148,149,5,98,0,0,149,150,5,111,0,0,150,151,5,111,0,0,151,152,5,108,0,0,
		152,18,1,0,0,0,153,154,5,112,0,0,154,155,5,105,0,0,155,156,5,110,0,0,156,
		20,1,0,0,0,157,158,5,44,0,0,158,22,1,0,0,0,159,160,5,59,0,0,160,24,1,0,
		0,0,161,162,5,61,0,0,162,26,1,0,0,0,163,164,5,123,0,0,164,28,1,0,0,0,165,
		166,5,125,0,0,166,30,1,0,0,0,167,168,5,105,0,0,168,169,5,102,0,0,169,32,
		1,0,0,0,170,171,5,101,0,0,171,172,5,108,0,0,172,173,5,115,0,0,173,174,
		5,101,0,0,174,34,1,0,0,0,175,176,5,119,0,0,176,177,5,104,0,0,177,178,5,
		105,0,0,178,179,5,108,0,0,179,180,5,101,0,0,180,36,1,0,0,0,181,182,5,102,
		0,0,182,183,5,111,0,0,183,184,5,114,0,0,184,38,1,0,0,0,185,186,5,99,0,
		0,186,187,5,111,0,0,187,188,5,110,0,0,188,189,5,116,0,0,189,190,5,105,
		0,0,190,191,5,110,0,0,191,192,5,117,0,0,192,193,5,101,0,0,193,40,1,0,0,
		0,194,195,5,98,0,0,195,196,5,114,0,0,196,197,5,101,0,0,197,198,5,97,0,
		0,198,199,5,107,0,0,199,42,1,0,0,0,200,201,5,114,0,0,201,202,5,101,0,0,
		202,203,5,116,0,0,203,204,5,117,0,0,204,205,5,114,0,0,205,206,5,110,0,
		0,206,44,1,0,0,0,207,208,5,63,0,0,208,46,1,0,0,0,209,210,5,58,0,0,210,
		48,1,0,0,0,211,212,5,124,0,0,212,213,5,124,0,0,213,50,1,0,0,0,214,215,
		5,38,0,0,215,216,5,38,0,0,216,52,1,0,0,0,217,218,5,61,0,0,218,219,5,61,
		0,0,219,54,1,0,0,0,220,221,5,33,0,0,221,222,5,61,0,0,222,56,1,0,0,0,223,
		224,5,60,0,0,224,58,1,0,0,0,225,226,5,62,0,0,226,60,1,0,0,0,227,228,5,
		60,0,0,228,229,5,61,0,0,229,62,1,0,0,0,230,231,5,62,0,0,231,232,5,61,0,
		0,232,64,1,0,0,0,233,234,5,60,0,0,234,235,5,60,0,0,235,66,1,0,0,0,236,
		237,5,62,0,0,237,238,5,62,0,0,238,68,1,0,0,0,239,240,5,43,0,0,240,70,1,
		0,0,0,241,242,5,45,0,0,242,72,1,0,0,0,243,244,5,42,0,0,244,74,1,0,0,0,
		245,246,5,47,0,0,246,76,1,0,0,0,247,248,5,37,0,0,248,78,1,0,0,0,249,250,
		5,43,0,0,250,251,5,43,0,0,251,80,1,0,0,0,252,253,5,45,0,0,253,254,5,45,
		0,0,254,82,1,0,0,0,255,256,5,115,0,0,256,257,5,101,0,0,257,258,5,116,0,
		0,258,84,1,0,0,0,259,260,5,116,0,0,260,261,5,111,0,0,261,86,1,0,0,0,262,
		263,5,42,0,0,263,264,5,61,0,0,264,88,1,0,0,0,265,266,5,47,0,0,266,267,
		5,61,0,0,267,90,1,0,0,0,268,269,5,37,0,0,269,270,5,61,0,0,270,92,1,0,0,
		0,271,272,5,43,0,0,272,273,5,61,0,0,273,94,1,0,0,0,274,275,5,45,0,0,275,
		276,5,61,0,0,276,96,1,0,0,0,277,278,5,104,0,0,278,279,5,105,0,0,279,280,
		5,103,0,0,280,281,5,104,0,0,281,98,1,0,0,0,282,283,5,108,0,0,283,284,5,
		111,0,0,284,285,5,119,0,0,285,100,1,0,0,0,286,290,7,0,0,0,287,289,7,1,
		0,0,288,287,1,0,0,0,289,292,1,0,0,0,290,288,1,0,0,0,290,291,1,0,0,0,291,
		102,1,0,0,0,292,290,1,0,0,0,293,294,5,34,0,0,294,295,7,2,0,0,295,296,5,
		34,0,0,296,104,1,0,0,0,297,299,7,3,0,0,298,297,1,0,0,0,298,299,1,0,0,0,
		299,301,1,0,0,0,300,302,2,48,57,0,301,300,1,0,0,0,302,306,1,0,0,0,303,
		305,7,4,0,0,304,303,1,0,0,0,305,308,1,0,0,0,306,304,1,0,0,0,306,307,1,
		0,0,0,307,315,1,0,0,0,308,306,1,0,0,0,309,311,9,0,0,0,310,312,7,4,0,0,
		311,310,1,0,0,0,312,313,1,0,0,0,313,311,1,0,0,0,313,314,1,0,0,0,314,316,
		1,0,0,0,315,309,1,0,0,0,315,316,1,0,0,0,316,106,1,0,0,0,317,319,7,5,0,
		0,318,317,1,0,0,0,319,320,1,0,0,0,320,318,1,0,0,0,320,321,1,0,0,0,321,
		322,1,0,0,0,322,323,6,53,0,0,323,108,1,0,0,0,324,326,5,13,0,0,325,327,
		5,10,0,0,326,325,1,0,0,0,326,327,1,0,0,0,327,330,1,0,0,0,328,330,5,10,
		0,0,329,324,1,0,0,0,329,328,1,0,0,0,330,331,1,0,0,0,331,332,6,54,0,0,332,
		110,1,0,0,0,10,0,290,298,301,306,313,315,320,326,329,1,0,1,0
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}