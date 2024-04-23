// Generated from c:/Users/scarp/OneDrive - Aalborg Universitet/Documents/GitHub repositories/P4/P4.TinyCell/Languages/TinyCell/TinyCell.g4 by ANTLR 4.13.1
import org.antlr.v4.runtime.atn.*;
import org.antlr.v4.runtime.dfa.DFA;
import org.antlr.v4.runtime.*;
import org.antlr.v4.runtime.misc.*;
import org.antlr.v4.runtime.tree.*;
import java.util.List;
import java.util.Iterator;
import java.util.ArrayList;

@SuppressWarnings({"all", "warnings", "unchecked", "unused", "cast", "CheckReturnValue"})
public class TinyCellParser extends Parser {
	static { RuntimeMetaData.checkVersion("4.13.1", RuntimeMetaData.VERSION); }

	protected static final DFA[] _decisionToDFA;
	protected static final PredictionContextCache _sharedContextCache =
		new PredictionContextCache();
	public static final int
		Bool=1, Whitespace=2, VOLHIGH=3, VOLLOW=4, PIN=5, INT=6, FLOAT=7, STRING=8, 
		BOOL=9, VOID=10, CHAR=11, UPDATE=12, SETUP=13, SET=14, TO=15, IF=16, ELSE=17, 
		WHILE=18, FOR=19, CONTINUE=20, BREAK=21, RETURN=22, QUESTION=23, LPAR=24, 
		RPAR=25, LCURLY=26, RCURLY=27, LBRACKET=28, RBRACKET=29, SEMI=30, DOT=31, 
		COMMA=32, COLON=33, TRUE=34, FALSE=35, NEWLINE=36, ASSIGN=37, PLUSASSIGN=38, 
		MULTASSIGN=39, DIVASSIGN=40, MODASSIGN=41, MINUSASSIGN=42, QUOTE=43, MULT=44, 
		DIV=45, PLUS=46, MINUS=47, MOD=48, AND=49, OR=50, EQ=51, NEQ=52, GT=53, 
		LT=54, GTE=55, LTE=56, NOT=57, BITSHIFTL=58, BITSHIFTR=59, UNARYPLUS=60, 
		UNARYMINUS=61, Identifier=62, String=63, Numeral=64, Newline=65;
	public static final int
		RULE_document = 0, RULE_generalDeclaration = 1, RULE_setupDefinition = 2, 
		RULE_updateDefinition = 3, RULE_functionDefinition = 4, RULE_type = 5, 
		RULE_parameterList = 6, RULE_parameter = 7, RULE_argumentList = 8, RULE_argument = 9, 
		RULE_declaration = 10, RULE_initialDeclaration = 11, RULE_compoundStatement = 12, 
		RULE_statement = 13, RULE_ifStatement = 14, RULE_loopStatement = 15, RULE_jumpStatement = 16, 
		RULE_assignment = 17, RULE_functionCall = 18, RULE_primitiveExpression = 19, 
		RULE_unaryExpression = 20, RULE_multiplicativeExpression = 21, RULE_additiveExpression = 22, 
		RULE_bitshiftExpression = 23, RULE_comparisonExpression = 24, RULE_equalityExpression = 25, 
		RULE_andExpression = 26, RULE_orExpression = 27, RULE_ternaryExpression = 28, 
		RULE_pinExpression = 29, RULE_expression = 30, RULE_identifier = 31, RULE_assignmentOperator = 32, 
		RULE_pinVoltage = 33;
	private static String[] makeRuleNames() {
		return new String[] {
			"document", "generalDeclaration", "setupDefinition", "updateDefinition", 
			"functionDefinition", "type", "parameterList", "parameter", "argumentList", 
			"argument", "declaration", "initialDeclaration", "compoundStatement", 
			"statement", "ifStatement", "loopStatement", "jumpStatement", "assignment", 
			"functionCall", "primitiveExpression", "unaryExpression", "multiplicativeExpression", 
			"additiveExpression", "bitshiftExpression", "comparisonExpression", "equalityExpression", 
			"andExpression", "orExpression", "ternaryExpression", "pinExpression", 
			"expression", "identifier", "assignmentOperator", "pinVoltage"
		};
	}
	public static final String[] ruleNames = makeRuleNames();

	private static String[] makeLiteralNames() {
		return new String[] {
			null, null, null, "'high'", "'low'", "'pin'", "'int'", "'float'", "'string'", 
			"'bool'", "'void'", "'char'", "'update'", "'setup'", "'set'", "'to'", 
			"'if'", "'else'", "'while'", "'for'", "'continue'", "'break'", "'return'", 
			"'?'", "'('", "')'", "'{'", "'}'", "'['", "']'", "';'", "'.'", "','", 
			"':'", "'true'", "'false'", "'\\n'", "'='", "'+='", "'*='", "'/='", "'%='", 
			"'-='", "'\"'", "'*'", "'/'", "'+'", "'-'", "'%'", "'&&'", "'||'", "'=='", 
			"'!='", "'>'", "'<'", "'>='", "'<='", "'!'", "'<<'", "'>>'", "'++'", 
			"'--'"
		};
	}
	private static final String[] _LITERAL_NAMES = makeLiteralNames();
	private static String[] makeSymbolicNames() {
		return new String[] {
			null, "Bool", "Whitespace", "VOLHIGH", "VOLLOW", "PIN", "INT", "FLOAT", 
			"STRING", "BOOL", "VOID", "CHAR", "UPDATE", "SETUP", "SET", "TO", "IF", 
			"ELSE", "WHILE", "FOR", "CONTINUE", "BREAK", "RETURN", "QUESTION", "LPAR", 
			"RPAR", "LCURLY", "RCURLY", "LBRACKET", "RBRACKET", "SEMI", "DOT", "COMMA", 
			"COLON", "TRUE", "FALSE", "NEWLINE", "ASSIGN", "PLUSASSIGN", "MULTASSIGN", 
			"DIVASSIGN", "MODASSIGN", "MINUSASSIGN", "QUOTE", "MULT", "DIV", "PLUS", 
			"MINUS", "MOD", "AND", "OR", "EQ", "NEQ", "GT", "LT", "GTE", "LTE", "NOT", 
			"BITSHIFTL", "BITSHIFTR", "UNARYPLUS", "UNARYMINUS", "Identifier", "String", 
			"Numeral", "Newline"
		};
	}
	private static final String[] _SYMBOLIC_NAMES = makeSymbolicNames();
	public static final Vocabulary VOCABULARY = new VocabularyImpl(_LITERAL_NAMES, _SYMBOLIC_NAMES);

	/**
	 * @deprecated Use {@link #VOCABULARY} instead.
	 */
	@Deprecated
	public static final String[] tokenNames;
	static {
		tokenNames = new String[_SYMBOLIC_NAMES.length];
		for (int i = 0; i < tokenNames.length; i++) {
			tokenNames[i] = VOCABULARY.getLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = VOCABULARY.getSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}
	}

	@Override
	@Deprecated
	public String[] getTokenNames() {
		return tokenNames;
	}

	@Override

	public Vocabulary getVocabulary() {
		return VOCABULARY;
	}

	@Override
	public String getGrammarFileName() { return "TinyCell.g4"; }

	@Override
	public String[] getRuleNames() { return ruleNames; }

	@Override
	public String getSerializedATN() { return _serializedATN; }

	@Override
	public ATN getATN() { return _ATN; }

	public TinyCellParser(TokenStream input) {
		super(input);
		_interp = new ParserATNSimulator(this,_ATN,_decisionToDFA,_sharedContextCache);
	}

	@SuppressWarnings("CheckReturnValue")
	public static class DocumentContext extends ParserRuleContext {
		public SetupDefinitionContext setupDefinition() {
			return getRuleContext(SetupDefinitionContext.class,0);
		}
		public UpdateDefinitionContext updateDefinition() {
			return getRuleContext(UpdateDefinitionContext.class,0);
		}
		public List<GeneralDeclarationContext> generalDeclaration() {
			return getRuleContexts(GeneralDeclarationContext.class);
		}
		public GeneralDeclarationContext generalDeclaration(int i) {
			return getRuleContext(GeneralDeclarationContext.class,i);
		}
		public DocumentContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_document; }
	}

	public final DocumentContext document() throws RecognitionException {
		DocumentContext _localctx = new DocumentContext(_ctx, getState());
		enterRule(_localctx, 0, RULE_document);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(68);
			setupDefinition();
			setState(69);
			updateDefinition();
			setState(73);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & 3808L) != 0)) {
				{
				{
				setState(70);
				generalDeclaration();
				}
				}
				setState(75);
				_errHandler.sync(this);
				_la = _input.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class GeneralDeclarationContext extends ParserRuleContext {
		public FunctionDefinitionContext functionDefinition() {
			return getRuleContext(FunctionDefinitionContext.class,0);
		}
		public DeclarationContext declaration() {
			return getRuleContext(DeclarationContext.class,0);
		}
		public GeneralDeclarationContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_generalDeclaration; }
	}

	public final GeneralDeclarationContext generalDeclaration() throws RecognitionException {
		GeneralDeclarationContext _localctx = new GeneralDeclarationContext(_ctx, getState());
		enterRule(_localctx, 2, RULE_generalDeclaration);
		try {
			setState(78);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,1,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(76);
				functionDefinition();
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(77);
				declaration();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class SetupDefinitionContext extends ParserRuleContext {
		public TerminalNode SETUP() { return getToken(TinyCellParser.SETUP, 0); }
		public CompoundStatementContext compoundStatement() {
			return getRuleContext(CompoundStatementContext.class,0);
		}
		public SetupDefinitionContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_setupDefinition; }
	}

	public final SetupDefinitionContext setupDefinition() throws RecognitionException {
		SetupDefinitionContext _localctx = new SetupDefinitionContext(_ctx, getState());
		enterRule(_localctx, 4, RULE_setupDefinition);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(80);
			match(SETUP);
			setState(81);
			compoundStatement();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class UpdateDefinitionContext extends ParserRuleContext {
		public TerminalNode UPDATE() { return getToken(TinyCellParser.UPDATE, 0); }
		public CompoundStatementContext compoundStatement() {
			return getRuleContext(CompoundStatementContext.class,0);
		}
		public UpdateDefinitionContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_updateDefinition; }
	}

	public final UpdateDefinitionContext updateDefinition() throws RecognitionException {
		UpdateDefinitionContext _localctx = new UpdateDefinitionContext(_ctx, getState());
		enterRule(_localctx, 6, RULE_updateDefinition);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(83);
			match(UPDATE);
			setState(84);
			compoundStatement();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class FunctionDefinitionContext extends ParserRuleContext {
		public TypeContext type() {
			return getRuleContext(TypeContext.class,0);
		}
		public IdentifierContext identifier() {
			return getRuleContext(IdentifierContext.class,0);
		}
		public TerminalNode LPAR() { return getToken(TinyCellParser.LPAR, 0); }
		public TerminalNode RPAR() { return getToken(TinyCellParser.RPAR, 0); }
		public CompoundStatementContext compoundStatement() {
			return getRuleContext(CompoundStatementContext.class,0);
		}
		public List<ParameterListContext> parameterList() {
			return getRuleContexts(ParameterListContext.class);
		}
		public ParameterListContext parameterList(int i) {
			return getRuleContext(ParameterListContext.class,i);
		}
		public FunctionDefinitionContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_functionDefinition; }
	}

	public final FunctionDefinitionContext functionDefinition() throws RecognitionException {
		FunctionDefinitionContext _localctx = new FunctionDefinitionContext(_ctx, getState());
		enterRule(_localctx, 8, RULE_functionDefinition);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(86);
			type();
			setState(87);
			identifier();
			setState(88);
			match(LPAR);
			setState(92);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & 3808L) != 0)) {
				{
				{
				setState(89);
				parameterList(0);
				}
				}
				setState(94);
				_errHandler.sync(this);
				_la = _input.LA(1);
			}
			setState(95);
			match(RPAR);
			setState(96);
			compoundStatement();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class TypeContext extends ParserRuleContext {
		public TerminalNode VOID() { return getToken(TinyCellParser.VOID, 0); }
		public TerminalNode CHAR() { return getToken(TinyCellParser.CHAR, 0); }
		public TerminalNode INT() { return getToken(TinyCellParser.INT, 0); }
		public TerminalNode FLOAT() { return getToken(TinyCellParser.FLOAT, 0); }
		public TerminalNode BOOL() { return getToken(TinyCellParser.BOOL, 0); }
		public TerminalNode PIN() { return getToken(TinyCellParser.PIN, 0); }
		public TypeContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_type; }
	}

	public final TypeContext type() throws RecognitionException {
		TypeContext _localctx = new TypeContext(_ctx, getState());
		enterRule(_localctx, 10, RULE_type);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(98);
			_la = _input.LA(1);
			if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & 3808L) != 0)) ) {
			_errHandler.recoverInline(this);
			}
			else {
				if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
				_errHandler.reportMatch(this);
				consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class ParameterListContext extends ParserRuleContext {
		public ParameterContext parameter() {
			return getRuleContext(ParameterContext.class,0);
		}
		public ParameterListContext parameterList() {
			return getRuleContext(ParameterListContext.class,0);
		}
		public TerminalNode COMMA() { return getToken(TinyCellParser.COMMA, 0); }
		public ParameterListContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_parameterList; }
	}

	public final ParameterListContext parameterList() throws RecognitionException {
		return parameterList(0);
	}

	private ParameterListContext parameterList(int _p) throws RecognitionException {
		ParserRuleContext _parentctx = _ctx;
		int _parentState = getState();
		ParameterListContext _localctx = new ParameterListContext(_ctx, _parentState);
		ParameterListContext _prevctx = _localctx;
		int _startState = 12;
		enterRecursionRule(_localctx, 12, RULE_parameterList, _p);
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			{
			setState(101);
			parameter();
			}
			_ctx.stop = _input.LT(-1);
			setState(108);
			_errHandler.sync(this);
			_alt = getInterpreter().adaptivePredict(_input,3,_ctx);
			while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( _parseListeners!=null ) triggerExitRuleEvent();
					_prevctx = _localctx;
					{
					{
					_localctx = new ParameterListContext(_parentctx, _parentState);
					pushNewRecursionContext(_localctx, _startState, RULE_parameterList);
					setState(103);
					if (!(precpred(_ctx, 1))) throw new FailedPredicateException(this, "precpred(_ctx, 1)");
					setState(104);
					match(COMMA);
					setState(105);
					parameter();
					}
					} 
				}
				setState(110);
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,3,_ctx);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			unrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class ParameterContext extends ParserRuleContext {
		public TypeContext type() {
			return getRuleContext(TypeContext.class,0);
		}
		public IdentifierContext identifier() {
			return getRuleContext(IdentifierContext.class,0);
		}
		public ParameterContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_parameter; }
	}

	public final ParameterContext parameter() throws RecognitionException {
		ParameterContext _localctx = new ParameterContext(_ctx, getState());
		enterRule(_localctx, 14, RULE_parameter);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(111);
			type();
			setState(112);
			identifier();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class ArgumentListContext extends ParserRuleContext {
		public ArgumentContext argument() {
			return getRuleContext(ArgumentContext.class,0);
		}
		public ArgumentListContext argumentList() {
			return getRuleContext(ArgumentListContext.class,0);
		}
		public TerminalNode COMMA() { return getToken(TinyCellParser.COMMA, 0); }
		public ArgumentListContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_argumentList; }
	}

	public final ArgumentListContext argumentList() throws RecognitionException {
		return argumentList(0);
	}

	private ArgumentListContext argumentList(int _p) throws RecognitionException {
		ParserRuleContext _parentctx = _ctx;
		int _parentState = getState();
		ArgumentListContext _localctx = new ArgumentListContext(_ctx, _parentState);
		ArgumentListContext _prevctx = _localctx;
		int _startState = 16;
		enterRecursionRule(_localctx, 16, RULE_argumentList, _p);
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			{
			setState(115);
			argument();
			}
			_ctx.stop = _input.LT(-1);
			setState(122);
			_errHandler.sync(this);
			_alt = getInterpreter().adaptivePredict(_input,4,_ctx);
			while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( _parseListeners!=null ) triggerExitRuleEvent();
					_prevctx = _localctx;
					{
					{
					_localctx = new ArgumentListContext(_parentctx, _parentState);
					pushNewRecursionContext(_localctx, _startState, RULE_argumentList);
					setState(117);
					if (!(precpred(_ctx, 1))) throw new FailedPredicateException(this, "precpred(_ctx, 1)");
					setState(118);
					match(COMMA);
					setState(119);
					argument();
					}
					} 
				}
				setState(124);
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,4,_ctx);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			unrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class ArgumentContext extends ParserRuleContext {
		public IdentifierContext identifier() {
			return getRuleContext(IdentifierContext.class,0);
		}
		public ArgumentContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_argument; }
	}

	public final ArgumentContext argument() throws RecognitionException {
		ArgumentContext _localctx = new ArgumentContext(_ctx, getState());
		enterRule(_localctx, 18, RULE_argument);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(125);
			identifier();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class DeclarationContext extends ParserRuleContext {
		public TypeContext type() {
			return getRuleContext(TypeContext.class,0);
		}
		public InitialDeclarationContext initialDeclaration() {
			return getRuleContext(InitialDeclarationContext.class,0);
		}
		public DeclarationContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_declaration; }
	}

	public final DeclarationContext declaration() throws RecognitionException {
		DeclarationContext _localctx = new DeclarationContext(_ctx, getState());
		enterRule(_localctx, 20, RULE_declaration);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(127);
			type();
			setState(128);
			initialDeclaration();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class InitialDeclarationContext extends ParserRuleContext {
		public IdentifierContext identifier() {
			return getRuleContext(IdentifierContext.class,0);
		}
		public TerminalNode ASSIGN() { return getToken(TinyCellParser.ASSIGN, 0); }
		public ExpressionContext expression() {
			return getRuleContext(ExpressionContext.class,0);
		}
		public FunctionCallContext functionCall() {
			return getRuleContext(FunctionCallContext.class,0);
		}
		public InitialDeclarationContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_initialDeclaration; }
	}

	public final InitialDeclarationContext initialDeclaration() throws RecognitionException {
		InitialDeclarationContext _localctx = new InitialDeclarationContext(_ctx, getState());
		enterRule(_localctx, 22, RULE_initialDeclaration);
		try {
			setState(137);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,6,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(130);
				identifier();
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(131);
				identifier();
				setState(132);
				match(ASSIGN);
				setState(135);
				_errHandler.sync(this);
				switch ( getInterpreter().adaptivePredict(_input,5,_ctx) ) {
				case 1:
					{
					setState(133);
					expression();
					}
					break;
				case 2:
					{
					setState(134);
					functionCall();
					}
					break;
				}
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class CompoundStatementContext extends ParserRuleContext {
		public TerminalNode LCURLY() { return getToken(TinyCellParser.LCURLY, 0); }
		public TerminalNode RCURLY() { return getToken(TinyCellParser.RCURLY, 0); }
		public List<StatementContext> statement() {
			return getRuleContexts(StatementContext.class);
		}
		public StatementContext statement(int i) {
			return getRuleContext(StatementContext.class,i);
		}
		public CompoundStatementContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_compoundStatement; }
	}

	public final CompoundStatementContext compoundStatement() throws RecognitionException {
		CompoundStatementContext _localctx = new CompoundStatementContext(_ctx, getState());
		enterRule(_localctx, 24, RULE_compoundStatement);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(139);
			match(LCURLY);
			setState(143);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while (((((_la - 1)) & ~0x3f) == 0 && ((1L << (_la - 1)) & -504403158253000847L) != 0)) {
				{
				{
				setState(140);
				statement();
				}
				}
				setState(145);
				_errHandler.sync(this);
				_la = _input.LA(1);
			}
			setState(146);
			match(RCURLY);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class StatementContext extends ParserRuleContext {
		public IfStatementContext ifStatement() {
			return getRuleContext(IfStatementContext.class,0);
		}
		public LoopStatementContext loopStatement() {
			return getRuleContext(LoopStatementContext.class,0);
		}
		public JumpStatementContext jumpStatement() {
			return getRuleContext(JumpStatementContext.class,0);
		}
		public DeclarationContext declaration() {
			return getRuleContext(DeclarationContext.class,0);
		}
		public TerminalNode SEMI() { return getToken(TinyCellParser.SEMI, 0); }
		public FunctionCallContext functionCall() {
			return getRuleContext(FunctionCallContext.class,0);
		}
		public AssignmentContext assignment() {
			return getRuleContext(AssignmentContext.class,0);
		}
		public ExpressionContext expression() {
			return getRuleContext(ExpressionContext.class,0);
		}
		public StatementContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_statement; }
	}

	public final StatementContext statement() throws RecognitionException {
		StatementContext _localctx = new StatementContext(_ctx, getState());
		enterRule(_localctx, 26, RULE_statement);
		try {
			setState(163);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,8,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(148);
				ifStatement();
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(149);
				loopStatement();
				}
				break;
			case 3:
				enterOuterAlt(_localctx, 3);
				{
				setState(150);
				jumpStatement();
				}
				break;
			case 4:
				enterOuterAlt(_localctx, 4);
				{
				setState(151);
				declaration();
				setState(152);
				match(SEMI);
				}
				break;
			case 5:
				enterOuterAlt(_localctx, 5);
				{
				setState(154);
				functionCall();
				setState(155);
				match(SEMI);
				}
				break;
			case 6:
				enterOuterAlt(_localctx, 6);
				{
				setState(157);
				assignment();
				setState(158);
				match(SEMI);
				}
				break;
			case 7:
				enterOuterAlt(_localctx, 7);
				{
				setState(160);
				expression();
				setState(161);
				match(SEMI);
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class IfStatementContext extends ParserRuleContext {
		public TerminalNode IF() { return getToken(TinyCellParser.IF, 0); }
		public TerminalNode LPAR() { return getToken(TinyCellParser.LPAR, 0); }
		public ExpressionContext expression() {
			return getRuleContext(ExpressionContext.class,0);
		}
		public TerminalNode RPAR() { return getToken(TinyCellParser.RPAR, 0); }
		public List<CompoundStatementContext> compoundStatement() {
			return getRuleContexts(CompoundStatementContext.class);
		}
		public CompoundStatementContext compoundStatement(int i) {
			return getRuleContext(CompoundStatementContext.class,i);
		}
		public TerminalNode ELSE() { return getToken(TinyCellParser.ELSE, 0); }
		public IfStatementContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_ifStatement; }
	}

	public final IfStatementContext ifStatement() throws RecognitionException {
		IfStatementContext _localctx = new IfStatementContext(_ctx, getState());
		enterRule(_localctx, 28, RULE_ifStatement);
		try {
			setState(179);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,9,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(165);
				match(IF);
				setState(166);
				match(LPAR);
				setState(167);
				expression();
				setState(168);
				match(RPAR);
				setState(169);
				compoundStatement();
				setState(170);
				match(ELSE);
				setState(171);
				compoundStatement();
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(173);
				match(IF);
				setState(174);
				match(LPAR);
				setState(175);
				expression();
				setState(176);
				match(RPAR);
				setState(177);
				compoundStatement();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class LoopStatementContext extends ParserRuleContext {
		public TerminalNode WHILE() { return getToken(TinyCellParser.WHILE, 0); }
		public TerminalNode LPAR() { return getToken(TinyCellParser.LPAR, 0); }
		public List<ExpressionContext> expression() {
			return getRuleContexts(ExpressionContext.class);
		}
		public ExpressionContext expression(int i) {
			return getRuleContext(ExpressionContext.class,i);
		}
		public TerminalNode RPAR() { return getToken(TinyCellParser.RPAR, 0); }
		public CompoundStatementContext compoundStatement() {
			return getRuleContext(CompoundStatementContext.class,0);
		}
		public TerminalNode FOR() { return getToken(TinyCellParser.FOR, 0); }
		public List<TerminalNode> SEMI() { return getTokens(TinyCellParser.SEMI); }
		public TerminalNode SEMI(int i) {
			return getToken(TinyCellParser.SEMI, i);
		}
		public DeclarationContext declaration() {
			return getRuleContext(DeclarationContext.class,0);
		}
		public LoopStatementContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_loopStatement; }
	}

	public final LoopStatementContext loopStatement() throws RecognitionException {
		LoopStatementContext _localctx = new LoopStatementContext(_ctx, getState());
		enterRule(_localctx, 30, RULE_loopStatement);
		try {
			setState(200);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case WHILE:
				enterOuterAlt(_localctx, 1);
				{
				setState(181);
				match(WHILE);
				setState(182);
				match(LPAR);
				setState(183);
				expression();
				setState(184);
				match(RPAR);
				setState(185);
				compoundStatement();
				}
				break;
			case FOR:
				enterOuterAlt(_localctx, 2);
				{
				setState(187);
				match(FOR);
				setState(188);
				match(LPAR);
				setState(191);
				_errHandler.sync(this);
				switch (_input.LA(1)) {
				case Bool:
				case SET:
				case LPAR:
				case NOT:
				case UNARYPLUS:
				case UNARYMINUS:
				case Identifier:
				case String:
				case Numeral:
					{
					setState(189);
					expression();
					}
					break;
				case PIN:
				case INT:
				case FLOAT:
				case BOOL:
				case VOID:
				case CHAR:
					{
					setState(190);
					declaration();
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				setState(193);
				match(SEMI);
				setState(194);
				expression();
				setState(195);
				match(SEMI);
				setState(196);
				expression();
				setState(197);
				match(RPAR);
				setState(198);
				compoundStatement();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class JumpStatementContext extends ParserRuleContext {
		public TerminalNode CONTINUE() { return getToken(TinyCellParser.CONTINUE, 0); }
		public TerminalNode SEMI() { return getToken(TinyCellParser.SEMI, 0); }
		public TerminalNode BREAK() { return getToken(TinyCellParser.BREAK, 0); }
		public TerminalNode RETURN() { return getToken(TinyCellParser.RETURN, 0); }
		public ExpressionContext expression() {
			return getRuleContext(ExpressionContext.class,0);
		}
		public JumpStatementContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_jumpStatement; }
	}

	public final JumpStatementContext jumpStatement() throws RecognitionException {
		JumpStatementContext _localctx = new JumpStatementContext(_ctx, getState());
		enterRule(_localctx, 32, RULE_jumpStatement);
		try {
			setState(210);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case CONTINUE:
				enterOuterAlt(_localctx, 1);
				{
				setState(202);
				match(CONTINUE);
				setState(203);
				match(SEMI);
				}
				break;
			case BREAK:
				enterOuterAlt(_localctx, 2);
				{
				setState(204);
				match(BREAK);
				setState(205);
				match(SEMI);
				}
				break;
			case RETURN:
				enterOuterAlt(_localctx, 3);
				{
				setState(206);
				match(RETURN);
				setState(207);
				expression();
				setState(208);
				match(SEMI);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class AssignmentContext extends ParserRuleContext {
		public IdentifierContext identifier() {
			return getRuleContext(IdentifierContext.class,0);
		}
		public AssignmentOperatorContext assignmentOperator() {
			return getRuleContext(AssignmentOperatorContext.class,0);
		}
		public ExpressionContext expression() {
			return getRuleContext(ExpressionContext.class,0);
		}
		public FunctionCallContext functionCall() {
			return getRuleContext(FunctionCallContext.class,0);
		}
		public AssignmentContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_assignment; }
	}

	public final AssignmentContext assignment() throws RecognitionException {
		AssignmentContext _localctx = new AssignmentContext(_ctx, getState());
		enterRule(_localctx, 34, RULE_assignment);
		try {
			setState(220);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,13,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(212);
				identifier();
				setState(213);
				assignmentOperator();
				setState(214);
				expression();
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(216);
				identifier();
				setState(217);
				assignmentOperator();
				setState(218);
				functionCall();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class FunctionCallContext extends ParserRuleContext {
		public IdentifierContext identifier() {
			return getRuleContext(IdentifierContext.class,0);
		}
		public TerminalNode LPAR() { return getToken(TinyCellParser.LPAR, 0); }
		public TerminalNode RPAR() { return getToken(TinyCellParser.RPAR, 0); }
		public List<ArgumentListContext> argumentList() {
			return getRuleContexts(ArgumentListContext.class);
		}
		public ArgumentListContext argumentList(int i) {
			return getRuleContext(ArgumentListContext.class,i);
		}
		public FunctionCallContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_functionCall; }
	}

	public final FunctionCallContext functionCall() throws RecognitionException {
		FunctionCallContext _localctx = new FunctionCallContext(_ctx, getState());
		enterRule(_localctx, 36, RULE_functionCall);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(222);
			identifier();
			setState(223);
			match(LPAR);
			setState(227);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while (_la==Identifier) {
				{
				{
				setState(224);
				argumentList(0);
				}
				}
				setState(229);
				_errHandler.sync(this);
				_la = _input.LA(1);
			}
			setState(230);
			match(RPAR);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class PrimitiveExpressionContext extends ParserRuleContext {
		public TerminalNode Numeral() { return getToken(TinyCellParser.Numeral, 0); }
		public TerminalNode Bool() { return getToken(TinyCellParser.Bool, 0); }
		public TerminalNode String() { return getToken(TinyCellParser.String, 0); }
		public IdentifierContext identifier() {
			return getRuleContext(IdentifierContext.class,0);
		}
		public PrimitiveExpressionContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_primitiveExpression; }
	}

	public final PrimitiveExpressionContext primitiveExpression() throws RecognitionException {
		PrimitiveExpressionContext _localctx = new PrimitiveExpressionContext(_ctx, getState());
		enterRule(_localctx, 38, RULE_primitiveExpression);
		try {
			setState(236);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case Numeral:
				enterOuterAlt(_localctx, 1);
				{
				setState(232);
				match(Numeral);
				}
				break;
			case Bool:
				enterOuterAlt(_localctx, 2);
				{
				setState(233);
				match(Bool);
				}
				break;
			case String:
				enterOuterAlt(_localctx, 3);
				{
				setState(234);
				match(String);
				}
				break;
			case Identifier:
				enterOuterAlt(_localctx, 4);
				{
				setState(235);
				identifier();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class UnaryExpressionContext extends ParserRuleContext {
		public PrimitiveExpressionContext primitiveExpression() {
			return getRuleContext(PrimitiveExpressionContext.class,0);
		}
		public TerminalNode UNARYPLUS() { return getToken(TinyCellParser.UNARYPLUS, 0); }
		public TerminalNode UNARYMINUS() { return getToken(TinyCellParser.UNARYMINUS, 0); }
		public TerminalNode NOT() { return getToken(TinyCellParser.NOT, 0); }
		public UnaryExpressionContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_unaryExpression; }
	}

	public final UnaryExpressionContext unaryExpression() throws RecognitionException {
		UnaryExpressionContext _localctx = new UnaryExpressionContext(_ctx, getState());
		enterRule(_localctx, 40, RULE_unaryExpression);
		try {
			setState(251);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,16,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(238);
				primitiveExpression();
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(239);
				primitiveExpression();
				setState(240);
				match(UNARYPLUS);
				}
				break;
			case 3:
				enterOuterAlt(_localctx, 3);
				{
				setState(242);
				primitiveExpression();
				setState(243);
				match(UNARYMINUS);
				}
				break;
			case 4:
				enterOuterAlt(_localctx, 4);
				{
				setState(245);
				match(UNARYPLUS);
				setState(246);
				primitiveExpression();
				}
				break;
			case 5:
				enterOuterAlt(_localctx, 5);
				{
				setState(247);
				match(UNARYMINUS);
				setState(248);
				primitiveExpression();
				}
				break;
			case 6:
				enterOuterAlt(_localctx, 6);
				{
				setState(249);
				match(NOT);
				setState(250);
				primitiveExpression();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class MultiplicativeExpressionContext extends ParserRuleContext {
		public UnaryExpressionContext unaryExpression() {
			return getRuleContext(UnaryExpressionContext.class,0);
		}
		public MultiplicativeExpressionContext multiplicativeExpression() {
			return getRuleContext(MultiplicativeExpressionContext.class,0);
		}
		public TerminalNode MULT() { return getToken(TinyCellParser.MULT, 0); }
		public PrimitiveExpressionContext primitiveExpression() {
			return getRuleContext(PrimitiveExpressionContext.class,0);
		}
		public TerminalNode DIV() { return getToken(TinyCellParser.DIV, 0); }
		public TerminalNode MOD() { return getToken(TinyCellParser.MOD, 0); }
		public MultiplicativeExpressionContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_multiplicativeExpression; }
	}

	public final MultiplicativeExpressionContext multiplicativeExpression() throws RecognitionException {
		return multiplicativeExpression(0);
	}

	private MultiplicativeExpressionContext multiplicativeExpression(int _p) throws RecognitionException {
		ParserRuleContext _parentctx = _ctx;
		int _parentState = getState();
		MultiplicativeExpressionContext _localctx = new MultiplicativeExpressionContext(_ctx, _parentState);
		MultiplicativeExpressionContext _prevctx = _localctx;
		int _startState = 42;
		enterRecursionRule(_localctx, 42, RULE_multiplicativeExpression, _p);
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			{
			setState(254);
			unaryExpression();
			}
			_ctx.stop = _input.LT(-1);
			setState(267);
			_errHandler.sync(this);
			_alt = getInterpreter().adaptivePredict(_input,18,_ctx);
			while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( _parseListeners!=null ) triggerExitRuleEvent();
					_prevctx = _localctx;
					{
					setState(265);
					_errHandler.sync(this);
					switch ( getInterpreter().adaptivePredict(_input,17,_ctx) ) {
					case 1:
						{
						_localctx = new MultiplicativeExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_multiplicativeExpression);
						setState(256);
						if (!(precpred(_ctx, 3))) throw new FailedPredicateException(this, "precpred(_ctx, 3)");
						setState(257);
						match(MULT);
						setState(258);
						primitiveExpression();
						}
						break;
					case 2:
						{
						_localctx = new MultiplicativeExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_multiplicativeExpression);
						setState(259);
						if (!(precpred(_ctx, 2))) throw new FailedPredicateException(this, "precpred(_ctx, 2)");
						setState(260);
						match(DIV);
						setState(261);
						primitiveExpression();
						}
						break;
					case 3:
						{
						_localctx = new MultiplicativeExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_multiplicativeExpression);
						setState(262);
						if (!(precpred(_ctx, 1))) throw new FailedPredicateException(this, "precpred(_ctx, 1)");
						setState(263);
						match(MOD);
						setState(264);
						primitiveExpression();
						}
						break;
					}
					} 
				}
				setState(269);
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,18,_ctx);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			unrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class AdditiveExpressionContext extends ParserRuleContext {
		public MultiplicativeExpressionContext multiplicativeExpression() {
			return getRuleContext(MultiplicativeExpressionContext.class,0);
		}
		public AdditiveExpressionContext additiveExpression() {
			return getRuleContext(AdditiveExpressionContext.class,0);
		}
		public TerminalNode PLUS() { return getToken(TinyCellParser.PLUS, 0); }
		public TerminalNode MINUS() { return getToken(TinyCellParser.MINUS, 0); }
		public AdditiveExpressionContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_additiveExpression; }
	}

	public final AdditiveExpressionContext additiveExpression() throws RecognitionException {
		return additiveExpression(0);
	}

	private AdditiveExpressionContext additiveExpression(int _p) throws RecognitionException {
		ParserRuleContext _parentctx = _ctx;
		int _parentState = getState();
		AdditiveExpressionContext _localctx = new AdditiveExpressionContext(_ctx, _parentState);
		AdditiveExpressionContext _prevctx = _localctx;
		int _startState = 44;
		enterRecursionRule(_localctx, 44, RULE_additiveExpression, _p);
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			{
			setState(271);
			multiplicativeExpression(0);
			}
			_ctx.stop = _input.LT(-1);
			setState(281);
			_errHandler.sync(this);
			_alt = getInterpreter().adaptivePredict(_input,20,_ctx);
			while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( _parseListeners!=null ) triggerExitRuleEvent();
					_prevctx = _localctx;
					{
					setState(279);
					_errHandler.sync(this);
					switch ( getInterpreter().adaptivePredict(_input,19,_ctx) ) {
					case 1:
						{
						_localctx = new AdditiveExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_additiveExpression);
						setState(273);
						if (!(precpred(_ctx, 2))) throw new FailedPredicateException(this, "precpred(_ctx, 2)");
						setState(274);
						match(PLUS);
						setState(275);
						multiplicativeExpression(0);
						}
						break;
					case 2:
						{
						_localctx = new AdditiveExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_additiveExpression);
						setState(276);
						if (!(precpred(_ctx, 1))) throw new FailedPredicateException(this, "precpred(_ctx, 1)");
						setState(277);
						match(MINUS);
						setState(278);
						multiplicativeExpression(0);
						}
						break;
					}
					} 
				}
				setState(283);
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,20,_ctx);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			unrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class BitshiftExpressionContext extends ParserRuleContext {
		public AdditiveExpressionContext additiveExpression() {
			return getRuleContext(AdditiveExpressionContext.class,0);
		}
		public BitshiftExpressionContext bitshiftExpression() {
			return getRuleContext(BitshiftExpressionContext.class,0);
		}
		public TerminalNode BITSHIFTL() { return getToken(TinyCellParser.BITSHIFTL, 0); }
		public TerminalNode BITSHIFTR() { return getToken(TinyCellParser.BITSHIFTR, 0); }
		public BitshiftExpressionContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_bitshiftExpression; }
	}

	public final BitshiftExpressionContext bitshiftExpression() throws RecognitionException {
		return bitshiftExpression(0);
	}

	private BitshiftExpressionContext bitshiftExpression(int _p) throws RecognitionException {
		ParserRuleContext _parentctx = _ctx;
		int _parentState = getState();
		BitshiftExpressionContext _localctx = new BitshiftExpressionContext(_ctx, _parentState);
		BitshiftExpressionContext _prevctx = _localctx;
		int _startState = 46;
		enterRecursionRule(_localctx, 46, RULE_bitshiftExpression, _p);
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			{
			setState(285);
			additiveExpression(0);
			}
			_ctx.stop = _input.LT(-1);
			setState(295);
			_errHandler.sync(this);
			_alt = getInterpreter().adaptivePredict(_input,22,_ctx);
			while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( _parseListeners!=null ) triggerExitRuleEvent();
					_prevctx = _localctx;
					{
					setState(293);
					_errHandler.sync(this);
					switch ( getInterpreter().adaptivePredict(_input,21,_ctx) ) {
					case 1:
						{
						_localctx = new BitshiftExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_bitshiftExpression);
						setState(287);
						if (!(precpred(_ctx, 2))) throw new FailedPredicateException(this, "precpred(_ctx, 2)");
						setState(288);
						match(BITSHIFTL);
						setState(289);
						additiveExpression(0);
						}
						break;
					case 2:
						{
						_localctx = new BitshiftExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_bitshiftExpression);
						setState(290);
						if (!(precpred(_ctx, 1))) throw new FailedPredicateException(this, "precpred(_ctx, 1)");
						setState(291);
						match(BITSHIFTR);
						setState(292);
						additiveExpression(0);
						}
						break;
					}
					} 
				}
				setState(297);
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,22,_ctx);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			unrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class ComparisonExpressionContext extends ParserRuleContext {
		public BitshiftExpressionContext bitshiftExpression() {
			return getRuleContext(BitshiftExpressionContext.class,0);
		}
		public ComparisonExpressionContext comparisonExpression() {
			return getRuleContext(ComparisonExpressionContext.class,0);
		}
		public TerminalNode LT() { return getToken(TinyCellParser.LT, 0); }
		public TerminalNode GT() { return getToken(TinyCellParser.GT, 0); }
		public TerminalNode LTE() { return getToken(TinyCellParser.LTE, 0); }
		public TerminalNode GTE() { return getToken(TinyCellParser.GTE, 0); }
		public ComparisonExpressionContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_comparisonExpression; }
	}

	public final ComparisonExpressionContext comparisonExpression() throws RecognitionException {
		return comparisonExpression(0);
	}

	private ComparisonExpressionContext comparisonExpression(int _p) throws RecognitionException {
		ParserRuleContext _parentctx = _ctx;
		int _parentState = getState();
		ComparisonExpressionContext _localctx = new ComparisonExpressionContext(_ctx, _parentState);
		ComparisonExpressionContext _prevctx = _localctx;
		int _startState = 48;
		enterRecursionRule(_localctx, 48, RULE_comparisonExpression, _p);
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			{
			setState(299);
			bitshiftExpression(0);
			}
			_ctx.stop = _input.LT(-1);
			setState(315);
			_errHandler.sync(this);
			_alt = getInterpreter().adaptivePredict(_input,24,_ctx);
			while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( _parseListeners!=null ) triggerExitRuleEvent();
					_prevctx = _localctx;
					{
					setState(313);
					_errHandler.sync(this);
					switch ( getInterpreter().adaptivePredict(_input,23,_ctx) ) {
					case 1:
						{
						_localctx = new ComparisonExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_comparisonExpression);
						setState(301);
						if (!(precpred(_ctx, 4))) throw new FailedPredicateException(this, "precpred(_ctx, 4)");
						setState(302);
						match(LT);
						setState(303);
						bitshiftExpression(0);
						}
						break;
					case 2:
						{
						_localctx = new ComparisonExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_comparisonExpression);
						setState(304);
						if (!(precpred(_ctx, 3))) throw new FailedPredicateException(this, "precpred(_ctx, 3)");
						setState(305);
						match(GT);
						setState(306);
						bitshiftExpression(0);
						}
						break;
					case 3:
						{
						_localctx = new ComparisonExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_comparisonExpression);
						setState(307);
						if (!(precpred(_ctx, 2))) throw new FailedPredicateException(this, "precpred(_ctx, 2)");
						setState(308);
						match(LTE);
						setState(309);
						bitshiftExpression(0);
						}
						break;
					case 4:
						{
						_localctx = new ComparisonExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_comparisonExpression);
						setState(310);
						if (!(precpred(_ctx, 1))) throw new FailedPredicateException(this, "precpred(_ctx, 1)");
						setState(311);
						match(GTE);
						setState(312);
						bitshiftExpression(0);
						}
						break;
					}
					} 
				}
				setState(317);
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,24,_ctx);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			unrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class EqualityExpressionContext extends ParserRuleContext {
		public ComparisonExpressionContext comparisonExpression() {
			return getRuleContext(ComparisonExpressionContext.class,0);
		}
		public EqualityExpressionContext equalityExpression() {
			return getRuleContext(EqualityExpressionContext.class,0);
		}
		public TerminalNode EQ() { return getToken(TinyCellParser.EQ, 0); }
		public TerminalNode NEQ() { return getToken(TinyCellParser.NEQ, 0); }
		public EqualityExpressionContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_equalityExpression; }
	}

	public final EqualityExpressionContext equalityExpression() throws RecognitionException {
		return equalityExpression(0);
	}

	private EqualityExpressionContext equalityExpression(int _p) throws RecognitionException {
		ParserRuleContext _parentctx = _ctx;
		int _parentState = getState();
		EqualityExpressionContext _localctx = new EqualityExpressionContext(_ctx, _parentState);
		EqualityExpressionContext _prevctx = _localctx;
		int _startState = 50;
		enterRecursionRule(_localctx, 50, RULE_equalityExpression, _p);
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			{
			setState(319);
			comparisonExpression(0);
			}
			_ctx.stop = _input.LT(-1);
			setState(329);
			_errHandler.sync(this);
			_alt = getInterpreter().adaptivePredict(_input,26,_ctx);
			while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( _parseListeners!=null ) triggerExitRuleEvent();
					_prevctx = _localctx;
					{
					setState(327);
					_errHandler.sync(this);
					switch ( getInterpreter().adaptivePredict(_input,25,_ctx) ) {
					case 1:
						{
						_localctx = new EqualityExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_equalityExpression);
						setState(321);
						if (!(precpred(_ctx, 2))) throw new FailedPredicateException(this, "precpred(_ctx, 2)");
						setState(322);
						match(EQ);
						setState(323);
						comparisonExpression(0);
						}
						break;
					case 2:
						{
						_localctx = new EqualityExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_equalityExpression);
						setState(324);
						if (!(precpred(_ctx, 1))) throw new FailedPredicateException(this, "precpred(_ctx, 1)");
						setState(325);
						match(NEQ);
						setState(326);
						comparisonExpression(0);
						}
						break;
					}
					} 
				}
				setState(331);
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,26,_ctx);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			unrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class AndExpressionContext extends ParserRuleContext {
		public EqualityExpressionContext equalityExpression() {
			return getRuleContext(EqualityExpressionContext.class,0);
		}
		public AndExpressionContext andExpression() {
			return getRuleContext(AndExpressionContext.class,0);
		}
		public TerminalNode AND() { return getToken(TinyCellParser.AND, 0); }
		public AndExpressionContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_andExpression; }
	}

	public final AndExpressionContext andExpression() throws RecognitionException {
		return andExpression(0);
	}

	private AndExpressionContext andExpression(int _p) throws RecognitionException {
		ParserRuleContext _parentctx = _ctx;
		int _parentState = getState();
		AndExpressionContext _localctx = new AndExpressionContext(_ctx, _parentState);
		AndExpressionContext _prevctx = _localctx;
		int _startState = 52;
		enterRecursionRule(_localctx, 52, RULE_andExpression, _p);
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			{
			setState(333);
			equalityExpression(0);
			}
			_ctx.stop = _input.LT(-1);
			setState(340);
			_errHandler.sync(this);
			_alt = getInterpreter().adaptivePredict(_input,27,_ctx);
			while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( _parseListeners!=null ) triggerExitRuleEvent();
					_prevctx = _localctx;
					{
					{
					_localctx = new AndExpressionContext(_parentctx, _parentState);
					pushNewRecursionContext(_localctx, _startState, RULE_andExpression);
					setState(335);
					if (!(precpred(_ctx, 1))) throw new FailedPredicateException(this, "precpred(_ctx, 1)");
					setState(336);
					match(AND);
					setState(337);
					equalityExpression(0);
					}
					} 
				}
				setState(342);
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,27,_ctx);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			unrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class OrExpressionContext extends ParserRuleContext {
		public AndExpressionContext andExpression() {
			return getRuleContext(AndExpressionContext.class,0);
		}
		public OrExpressionContext orExpression() {
			return getRuleContext(OrExpressionContext.class,0);
		}
		public TerminalNode OR() { return getToken(TinyCellParser.OR, 0); }
		public OrExpressionContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_orExpression; }
	}

	public final OrExpressionContext orExpression() throws RecognitionException {
		return orExpression(0);
	}

	private OrExpressionContext orExpression(int _p) throws RecognitionException {
		ParserRuleContext _parentctx = _ctx;
		int _parentState = getState();
		OrExpressionContext _localctx = new OrExpressionContext(_ctx, _parentState);
		OrExpressionContext _prevctx = _localctx;
		int _startState = 54;
		enterRecursionRule(_localctx, 54, RULE_orExpression, _p);
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			{
			setState(344);
			andExpression(0);
			}
			_ctx.stop = _input.LT(-1);
			setState(351);
			_errHandler.sync(this);
			_alt = getInterpreter().adaptivePredict(_input,28,_ctx);
			while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( _parseListeners!=null ) triggerExitRuleEvent();
					_prevctx = _localctx;
					{
					{
					_localctx = new OrExpressionContext(_parentctx, _parentState);
					pushNewRecursionContext(_localctx, _startState, RULE_orExpression);
					setState(346);
					if (!(precpred(_ctx, 1))) throw new FailedPredicateException(this, "precpred(_ctx, 1)");
					setState(347);
					match(OR);
					setState(348);
					andExpression(0);
					}
					} 
				}
				setState(353);
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,28,_ctx);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			unrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class TernaryExpressionContext extends ParserRuleContext {
		public OrExpressionContext orExpression() {
			return getRuleContext(OrExpressionContext.class,0);
		}
		public TerminalNode QUESTION() { return getToken(TinyCellParser.QUESTION, 0); }
		public List<ExpressionContext> expression() {
			return getRuleContexts(ExpressionContext.class);
		}
		public ExpressionContext expression(int i) {
			return getRuleContext(ExpressionContext.class,i);
		}
		public TerminalNode COLON() { return getToken(TinyCellParser.COLON, 0); }
		public TernaryExpressionContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_ternaryExpression; }
	}

	public final TernaryExpressionContext ternaryExpression() throws RecognitionException {
		TernaryExpressionContext _localctx = new TernaryExpressionContext(_ctx, getState());
		enterRule(_localctx, 56, RULE_ternaryExpression);
		try {
			setState(361);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,29,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(354);
				orExpression(0);
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(355);
				orExpression(0);
				setState(356);
				match(QUESTION);
				setState(357);
				expression();
				setState(358);
				match(COLON);
				setState(359);
				expression();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class PinExpressionContext extends ParserRuleContext {
		public TernaryExpressionContext ternaryExpression() {
			return getRuleContext(TernaryExpressionContext.class,0);
		}
		public TerminalNode SET() { return getToken(TinyCellParser.SET, 0); }
		public IdentifierContext identifier() {
			return getRuleContext(IdentifierContext.class,0);
		}
		public TerminalNode TO() { return getToken(TinyCellParser.TO, 0); }
		public PinVoltageContext pinVoltage() {
			return getRuleContext(PinVoltageContext.class,0);
		}
		public PinExpressionContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_pinExpression; }
	}

	public final PinExpressionContext pinExpression() throws RecognitionException {
		PinExpressionContext _localctx = new PinExpressionContext(_ctx, getState());
		enterRule(_localctx, 58, RULE_pinExpression);
		try {
			setState(369);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case Bool:
			case NOT:
			case UNARYPLUS:
			case UNARYMINUS:
			case Identifier:
			case String:
			case Numeral:
				enterOuterAlt(_localctx, 1);
				{
				setState(363);
				ternaryExpression();
				}
				break;
			case SET:
				enterOuterAlt(_localctx, 2);
				{
				setState(364);
				match(SET);
				setState(365);
				identifier();
				setState(366);
				match(TO);
				setState(367);
				pinVoltage();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class ExpressionContext extends ParserRuleContext {
		public PinExpressionContext pinExpression() {
			return getRuleContext(PinExpressionContext.class,0);
		}
		public TerminalNode LPAR() { return getToken(TinyCellParser.LPAR, 0); }
		public ExpressionContext expression() {
			return getRuleContext(ExpressionContext.class,0);
		}
		public TerminalNode RPAR() { return getToken(TinyCellParser.RPAR, 0); }
		public ExpressionContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_expression; }
	}

	public final ExpressionContext expression() throws RecognitionException {
		ExpressionContext _localctx = new ExpressionContext(_ctx, getState());
		enterRule(_localctx, 60, RULE_expression);
		try {
			setState(376);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case Bool:
			case SET:
			case NOT:
			case UNARYPLUS:
			case UNARYMINUS:
			case Identifier:
			case String:
			case Numeral:
				enterOuterAlt(_localctx, 1);
				{
				setState(371);
				pinExpression();
				}
				break;
			case LPAR:
				enterOuterAlt(_localctx, 2);
				{
				setState(372);
				match(LPAR);
				setState(373);
				expression();
				setState(374);
				match(RPAR);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class IdentifierContext extends ParserRuleContext {
		public TerminalNode Identifier() { return getToken(TinyCellParser.Identifier, 0); }
		public IdentifierContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_identifier; }
	}

	public final IdentifierContext identifier() throws RecognitionException {
		IdentifierContext _localctx = new IdentifierContext(_ctx, getState());
		enterRule(_localctx, 62, RULE_identifier);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(378);
			match(Identifier);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class AssignmentOperatorContext extends ParserRuleContext {
		public TerminalNode ASSIGN() { return getToken(TinyCellParser.ASSIGN, 0); }
		public TerminalNode MULTASSIGN() { return getToken(TinyCellParser.MULTASSIGN, 0); }
		public TerminalNode DIVASSIGN() { return getToken(TinyCellParser.DIVASSIGN, 0); }
		public TerminalNode MODASSIGN() { return getToken(TinyCellParser.MODASSIGN, 0); }
		public TerminalNode PLUSASSIGN() { return getToken(TinyCellParser.PLUSASSIGN, 0); }
		public TerminalNode MINUSASSIGN() { return getToken(TinyCellParser.MINUSASSIGN, 0); }
		public AssignmentOperatorContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_assignmentOperator; }
	}

	public final AssignmentOperatorContext assignmentOperator() throws RecognitionException {
		AssignmentOperatorContext _localctx = new AssignmentOperatorContext(_ctx, getState());
		enterRule(_localctx, 64, RULE_assignmentOperator);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(380);
			_la = _input.LA(1);
			if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & 8658654068736L) != 0)) ) {
			_errHandler.recoverInline(this);
			}
			else {
				if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
				_errHandler.reportMatch(this);
				consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class PinVoltageContext extends ParserRuleContext {
		public TerminalNode VOLHIGH() { return getToken(TinyCellParser.VOLHIGH, 0); }
		public TerminalNode VOLLOW() { return getToken(TinyCellParser.VOLLOW, 0); }
		public PinVoltageContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_pinVoltage; }
	}

	public final PinVoltageContext pinVoltage() throws RecognitionException {
		PinVoltageContext _localctx = new PinVoltageContext(_ctx, getState());
		enterRule(_localctx, 66, RULE_pinVoltage);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(382);
			_la = _input.LA(1);
			if ( !(_la==VOLHIGH || _la==VOLLOW) ) {
			_errHandler.recoverInline(this);
			}
			else {
				if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
				_errHandler.reportMatch(this);
				consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public boolean sempred(RuleContext _localctx, int ruleIndex, int predIndex) {
		switch (ruleIndex) {
		case 6:
			return parameterList_sempred((ParameterListContext)_localctx, predIndex);
		case 8:
			return argumentList_sempred((ArgumentListContext)_localctx, predIndex);
		case 21:
			return multiplicativeExpression_sempred((MultiplicativeExpressionContext)_localctx, predIndex);
		case 22:
			return additiveExpression_sempred((AdditiveExpressionContext)_localctx, predIndex);
		case 23:
			return bitshiftExpression_sempred((BitshiftExpressionContext)_localctx, predIndex);
		case 24:
			return comparisonExpression_sempred((ComparisonExpressionContext)_localctx, predIndex);
		case 25:
			return equalityExpression_sempred((EqualityExpressionContext)_localctx, predIndex);
		case 26:
			return andExpression_sempred((AndExpressionContext)_localctx, predIndex);
		case 27:
			return orExpression_sempred((OrExpressionContext)_localctx, predIndex);
		}
		return true;
	}
	private boolean parameterList_sempred(ParameterListContext _localctx, int predIndex) {
		switch (predIndex) {
		case 0:
			return precpred(_ctx, 1);
		}
		return true;
	}
	private boolean argumentList_sempred(ArgumentListContext _localctx, int predIndex) {
		switch (predIndex) {
		case 1:
			return precpred(_ctx, 1);
		}
		return true;
	}
	private boolean multiplicativeExpression_sempred(MultiplicativeExpressionContext _localctx, int predIndex) {
		switch (predIndex) {
		case 2:
			return precpred(_ctx, 3);
		case 3:
			return precpred(_ctx, 2);
		case 4:
			return precpred(_ctx, 1);
		}
		return true;
	}
	private boolean additiveExpression_sempred(AdditiveExpressionContext _localctx, int predIndex) {
		switch (predIndex) {
		case 5:
			return precpred(_ctx, 2);
		case 6:
			return precpred(_ctx, 1);
		}
		return true;
	}
	private boolean bitshiftExpression_sempred(BitshiftExpressionContext _localctx, int predIndex) {
		switch (predIndex) {
		case 7:
			return precpred(_ctx, 2);
		case 8:
			return precpred(_ctx, 1);
		}
		return true;
	}
	private boolean comparisonExpression_sempred(ComparisonExpressionContext _localctx, int predIndex) {
		switch (predIndex) {
		case 9:
			return precpred(_ctx, 4);
		case 10:
			return precpred(_ctx, 3);
		case 11:
			return precpred(_ctx, 2);
		case 12:
			return precpred(_ctx, 1);
		}
		return true;
	}
	private boolean equalityExpression_sempred(EqualityExpressionContext _localctx, int predIndex) {
		switch (predIndex) {
		case 13:
			return precpred(_ctx, 2);
		case 14:
			return precpred(_ctx, 1);
		}
		return true;
	}
	private boolean andExpression_sempred(AndExpressionContext _localctx, int predIndex) {
		switch (predIndex) {
		case 15:
			return precpred(_ctx, 1);
		}
		return true;
	}
	private boolean orExpression_sempred(OrExpressionContext _localctx, int predIndex) {
		switch (predIndex) {
		case 16:
			return precpred(_ctx, 1);
		}
		return true;
	}

	public static final String _serializedATN =
		"\u0004\u0001A\u0181\u0002\u0000\u0007\u0000\u0002\u0001\u0007\u0001\u0002"+
		"\u0002\u0007\u0002\u0002\u0003\u0007\u0003\u0002\u0004\u0007\u0004\u0002"+
		"\u0005\u0007\u0005\u0002\u0006\u0007\u0006\u0002\u0007\u0007\u0007\u0002"+
		"\b\u0007\b\u0002\t\u0007\t\u0002\n\u0007\n\u0002\u000b\u0007\u000b\u0002"+
		"\f\u0007\f\u0002\r\u0007\r\u0002\u000e\u0007\u000e\u0002\u000f\u0007\u000f"+
		"\u0002\u0010\u0007\u0010\u0002\u0011\u0007\u0011\u0002\u0012\u0007\u0012"+
		"\u0002\u0013\u0007\u0013\u0002\u0014\u0007\u0014\u0002\u0015\u0007\u0015"+
		"\u0002\u0016\u0007\u0016\u0002\u0017\u0007\u0017\u0002\u0018\u0007\u0018"+
		"\u0002\u0019\u0007\u0019\u0002\u001a\u0007\u001a\u0002\u001b\u0007\u001b"+
		"\u0002\u001c\u0007\u001c\u0002\u001d\u0007\u001d\u0002\u001e\u0007\u001e"+
		"\u0002\u001f\u0007\u001f\u0002 \u0007 \u0002!\u0007!\u0001\u0000\u0001"+
		"\u0000\u0001\u0000\u0005\u0000H\b\u0000\n\u0000\f\u0000K\t\u0000\u0001"+
		"\u0001\u0001\u0001\u0003\u0001O\b\u0001\u0001\u0002\u0001\u0002\u0001"+
		"\u0002\u0001\u0003\u0001\u0003\u0001\u0003\u0001\u0004\u0001\u0004\u0001"+
		"\u0004\u0001\u0004\u0005\u0004[\b\u0004\n\u0004\f\u0004^\t\u0004\u0001"+
		"\u0004\u0001\u0004\u0001\u0004\u0001\u0005\u0001\u0005\u0001\u0006\u0001"+
		"\u0006\u0001\u0006\u0001\u0006\u0001\u0006\u0001\u0006\u0005\u0006k\b"+
		"\u0006\n\u0006\f\u0006n\t\u0006\u0001\u0007\u0001\u0007\u0001\u0007\u0001"+
		"\b\u0001\b\u0001\b\u0001\b\u0001\b\u0001\b\u0005\by\b\b\n\b\f\b|\t\b\u0001"+
		"\t\u0001\t\u0001\n\u0001\n\u0001\n\u0001\u000b\u0001\u000b\u0001\u000b"+
		"\u0001\u000b\u0001\u000b\u0003\u000b\u0088\b\u000b\u0003\u000b\u008a\b"+
		"\u000b\u0001\f\u0001\f\u0005\f\u008e\b\f\n\f\f\f\u0091\t\f\u0001\f\u0001"+
		"\f\u0001\r\u0001\r\u0001\r\u0001\r\u0001\r\u0001\r\u0001\r\u0001\r\u0001"+
		"\r\u0001\r\u0001\r\u0001\r\u0001\r\u0001\r\u0001\r\u0003\r\u00a4\b\r\u0001"+
		"\u000e\u0001\u000e\u0001\u000e\u0001\u000e\u0001\u000e\u0001\u000e\u0001"+
		"\u000e\u0001\u000e\u0001\u000e\u0001\u000e\u0001\u000e\u0001\u000e\u0001"+
		"\u000e\u0001\u000e\u0003\u000e\u00b4\b\u000e\u0001\u000f\u0001\u000f\u0001"+
		"\u000f\u0001\u000f\u0001\u000f\u0001\u000f\u0001\u000f\u0001\u000f\u0001"+
		"\u000f\u0001\u000f\u0003\u000f\u00c0\b\u000f\u0001\u000f\u0001\u000f\u0001"+
		"\u000f\u0001\u000f\u0001\u000f\u0001\u000f\u0001\u000f\u0003\u000f\u00c9"+
		"\b\u000f\u0001\u0010\u0001\u0010\u0001\u0010\u0001\u0010\u0001\u0010\u0001"+
		"\u0010\u0001\u0010\u0001\u0010\u0003\u0010\u00d3\b\u0010\u0001\u0011\u0001"+
		"\u0011\u0001\u0011\u0001\u0011\u0001\u0011\u0001\u0011\u0001\u0011\u0001"+
		"\u0011\u0003\u0011\u00dd\b\u0011\u0001\u0012\u0001\u0012\u0001\u0012\u0005"+
		"\u0012\u00e2\b\u0012\n\u0012\f\u0012\u00e5\t\u0012\u0001\u0012\u0001\u0012"+
		"\u0001\u0013\u0001\u0013\u0001\u0013\u0001\u0013\u0003\u0013\u00ed\b\u0013"+
		"\u0001\u0014\u0001\u0014\u0001\u0014\u0001\u0014\u0001\u0014\u0001\u0014"+
		"\u0001\u0014\u0001\u0014\u0001\u0014\u0001\u0014\u0001\u0014\u0001\u0014"+
		"\u0001\u0014\u0003\u0014\u00fc\b\u0014\u0001\u0015\u0001\u0015\u0001\u0015"+
		"\u0001\u0015\u0001\u0015\u0001\u0015\u0001\u0015\u0001\u0015\u0001\u0015"+
		"\u0001\u0015\u0001\u0015\u0001\u0015\u0005\u0015\u010a\b\u0015\n\u0015"+
		"\f\u0015\u010d\t\u0015\u0001\u0016\u0001\u0016\u0001\u0016\u0001\u0016"+
		"\u0001\u0016\u0001\u0016\u0001\u0016\u0001\u0016\u0001\u0016\u0005\u0016"+
		"\u0118\b\u0016\n\u0016\f\u0016\u011b\t\u0016\u0001\u0017\u0001\u0017\u0001"+
		"\u0017\u0001\u0017\u0001\u0017\u0001\u0017\u0001\u0017\u0001\u0017\u0001"+
		"\u0017\u0005\u0017\u0126\b\u0017\n\u0017\f\u0017\u0129\t\u0017\u0001\u0018"+
		"\u0001\u0018\u0001\u0018\u0001\u0018\u0001\u0018\u0001\u0018\u0001\u0018"+
		"\u0001\u0018\u0001\u0018\u0001\u0018\u0001\u0018\u0001\u0018\u0001\u0018"+
		"\u0001\u0018\u0001\u0018\u0005\u0018\u013a\b\u0018\n\u0018\f\u0018\u013d"+
		"\t\u0018\u0001\u0019\u0001\u0019\u0001\u0019\u0001\u0019\u0001\u0019\u0001"+
		"\u0019\u0001\u0019\u0001\u0019\u0001\u0019\u0005\u0019\u0148\b\u0019\n"+
		"\u0019\f\u0019\u014b\t\u0019\u0001\u001a\u0001\u001a\u0001\u001a\u0001"+
		"\u001a\u0001\u001a\u0001\u001a\u0005\u001a\u0153\b\u001a\n\u001a\f\u001a"+
		"\u0156\t\u001a\u0001\u001b\u0001\u001b\u0001\u001b\u0001\u001b\u0001\u001b"+
		"\u0001\u001b\u0005\u001b\u015e\b\u001b\n\u001b\f\u001b\u0161\t\u001b\u0001"+
		"\u001c\u0001\u001c\u0001\u001c\u0001\u001c\u0001\u001c\u0001\u001c\u0001"+
		"\u001c\u0003\u001c\u016a\b\u001c\u0001\u001d\u0001\u001d\u0001\u001d\u0001"+
		"\u001d\u0001\u001d\u0001\u001d\u0003\u001d\u0172\b\u001d\u0001\u001e\u0001"+
		"\u001e\u0001\u001e\u0001\u001e\u0001\u001e\u0003\u001e\u0179\b\u001e\u0001"+
		"\u001f\u0001\u001f\u0001 \u0001 \u0001!\u0001!\u0001!\u0000\t\f\u0010"+
		"*,.0246\"\u0000\u0002\u0004\u0006\b\n\f\u000e\u0010\u0012\u0014\u0016"+
		"\u0018\u001a\u001c\u001e \"$&(*,.02468:<>@B\u0000\u0003\u0002\u0000\u0005"+
		"\u0007\t\u000b\u0001\u0000%*\u0001\u0000\u0003\u0004\u018d\u0000D\u0001"+
		"\u0000\u0000\u0000\u0002N\u0001\u0000\u0000\u0000\u0004P\u0001\u0000\u0000"+
		"\u0000\u0006S\u0001\u0000\u0000\u0000\bV\u0001\u0000\u0000\u0000\nb\u0001"+
		"\u0000\u0000\u0000\fd\u0001\u0000\u0000\u0000\u000eo\u0001\u0000\u0000"+
		"\u0000\u0010r\u0001\u0000\u0000\u0000\u0012}\u0001\u0000\u0000\u0000\u0014"+
		"\u007f\u0001\u0000\u0000\u0000\u0016\u0089\u0001\u0000\u0000\u0000\u0018"+
		"\u008b\u0001\u0000\u0000\u0000\u001a\u00a3\u0001\u0000\u0000\u0000\u001c"+
		"\u00b3\u0001\u0000\u0000\u0000\u001e\u00c8\u0001\u0000\u0000\u0000 \u00d2"+
		"\u0001\u0000\u0000\u0000\"\u00dc\u0001\u0000\u0000\u0000$\u00de\u0001"+
		"\u0000\u0000\u0000&\u00ec\u0001\u0000\u0000\u0000(\u00fb\u0001\u0000\u0000"+
		"\u0000*\u00fd\u0001\u0000\u0000\u0000,\u010e\u0001\u0000\u0000\u0000."+
		"\u011c\u0001\u0000\u0000\u00000\u012a\u0001\u0000\u0000\u00002\u013e\u0001"+
		"\u0000\u0000\u00004\u014c\u0001\u0000\u0000\u00006\u0157\u0001\u0000\u0000"+
		"\u00008\u0169\u0001\u0000\u0000\u0000:\u0171\u0001\u0000\u0000\u0000<"+
		"\u0178\u0001\u0000\u0000\u0000>\u017a\u0001\u0000\u0000\u0000@\u017c\u0001"+
		"\u0000\u0000\u0000B\u017e\u0001\u0000\u0000\u0000DE\u0003\u0004\u0002"+
		"\u0000EI\u0003\u0006\u0003\u0000FH\u0003\u0002\u0001\u0000GF\u0001\u0000"+
		"\u0000\u0000HK\u0001\u0000\u0000\u0000IG\u0001\u0000\u0000\u0000IJ\u0001"+
		"\u0000\u0000\u0000J\u0001\u0001\u0000\u0000\u0000KI\u0001\u0000\u0000"+
		"\u0000LO\u0003\b\u0004\u0000MO\u0003\u0014\n\u0000NL\u0001\u0000\u0000"+
		"\u0000NM\u0001\u0000\u0000\u0000O\u0003\u0001\u0000\u0000\u0000PQ\u0005"+
		"\r\u0000\u0000QR\u0003\u0018\f\u0000R\u0005\u0001\u0000\u0000\u0000ST"+
		"\u0005\f\u0000\u0000TU\u0003\u0018\f\u0000U\u0007\u0001\u0000\u0000\u0000"+
		"VW\u0003\n\u0005\u0000WX\u0003>\u001f\u0000X\\\u0005\u0018\u0000\u0000"+
		"Y[\u0003\f\u0006\u0000ZY\u0001\u0000\u0000\u0000[^\u0001\u0000\u0000\u0000"+
		"\\Z\u0001\u0000\u0000\u0000\\]\u0001\u0000\u0000\u0000]_\u0001\u0000\u0000"+
		"\u0000^\\\u0001\u0000\u0000\u0000_`\u0005\u0019\u0000\u0000`a\u0003\u0018"+
		"\f\u0000a\t\u0001\u0000\u0000\u0000bc\u0007\u0000\u0000\u0000c\u000b\u0001"+
		"\u0000\u0000\u0000de\u0006\u0006\uffff\uffff\u0000ef\u0003\u000e\u0007"+
		"\u0000fl\u0001\u0000\u0000\u0000gh\n\u0001\u0000\u0000hi\u0005 \u0000"+
		"\u0000ik\u0003\u000e\u0007\u0000jg\u0001\u0000\u0000\u0000kn\u0001\u0000"+
		"\u0000\u0000lj\u0001\u0000\u0000\u0000lm\u0001\u0000\u0000\u0000m\r\u0001"+
		"\u0000\u0000\u0000nl\u0001\u0000\u0000\u0000op\u0003\n\u0005\u0000pq\u0003"+
		">\u001f\u0000q\u000f\u0001\u0000\u0000\u0000rs\u0006\b\uffff\uffff\u0000"+
		"st\u0003\u0012\t\u0000tz\u0001\u0000\u0000\u0000uv\n\u0001\u0000\u0000"+
		"vw\u0005 \u0000\u0000wy\u0003\u0012\t\u0000xu\u0001\u0000\u0000\u0000"+
		"y|\u0001\u0000\u0000\u0000zx\u0001\u0000\u0000\u0000z{\u0001\u0000\u0000"+
		"\u0000{\u0011\u0001\u0000\u0000\u0000|z\u0001\u0000\u0000\u0000}~\u0003"+
		">\u001f\u0000~\u0013\u0001\u0000\u0000\u0000\u007f\u0080\u0003\n\u0005"+
		"\u0000\u0080\u0081\u0003\u0016\u000b\u0000\u0081\u0015\u0001\u0000\u0000"+
		"\u0000\u0082\u008a\u0003>\u001f\u0000\u0083\u0084\u0003>\u001f\u0000\u0084"+
		"\u0087\u0005%\u0000\u0000\u0085\u0088\u0003<\u001e\u0000\u0086\u0088\u0003"+
		"$\u0012\u0000\u0087\u0085\u0001\u0000\u0000\u0000\u0087\u0086\u0001\u0000"+
		"\u0000\u0000\u0088\u008a\u0001\u0000\u0000\u0000\u0089\u0082\u0001\u0000"+
		"\u0000\u0000\u0089\u0083\u0001\u0000\u0000\u0000\u008a\u0017\u0001\u0000"+
		"\u0000\u0000\u008b\u008f\u0005\u001a\u0000\u0000\u008c\u008e\u0003\u001a"+
		"\r\u0000\u008d\u008c\u0001\u0000\u0000\u0000\u008e\u0091\u0001\u0000\u0000"+
		"\u0000\u008f\u008d\u0001\u0000\u0000\u0000\u008f\u0090\u0001\u0000\u0000"+
		"\u0000\u0090\u0092\u0001\u0000\u0000\u0000\u0091\u008f\u0001\u0000\u0000"+
		"\u0000\u0092\u0093\u0005\u001b\u0000\u0000\u0093\u0019\u0001\u0000\u0000"+
		"\u0000\u0094\u00a4\u0003\u001c\u000e\u0000\u0095\u00a4\u0003\u001e\u000f"+
		"\u0000\u0096\u00a4\u0003 \u0010\u0000\u0097\u0098\u0003\u0014\n\u0000"+
		"\u0098\u0099\u0005\u001e\u0000\u0000\u0099\u00a4\u0001\u0000\u0000\u0000"+
		"\u009a\u009b\u0003$\u0012\u0000\u009b\u009c\u0005\u001e\u0000\u0000\u009c"+
		"\u00a4\u0001\u0000\u0000\u0000\u009d\u009e\u0003\"\u0011\u0000\u009e\u009f"+
		"\u0005\u001e\u0000\u0000\u009f\u00a4\u0001\u0000\u0000\u0000\u00a0\u00a1"+
		"\u0003<\u001e\u0000\u00a1\u00a2\u0005\u001e\u0000\u0000\u00a2\u00a4\u0001"+
		"\u0000\u0000\u0000\u00a3\u0094\u0001\u0000\u0000\u0000\u00a3\u0095\u0001"+
		"\u0000\u0000\u0000\u00a3\u0096\u0001\u0000\u0000\u0000\u00a3\u0097\u0001"+
		"\u0000\u0000\u0000\u00a3\u009a\u0001\u0000\u0000\u0000\u00a3\u009d\u0001"+
		"\u0000\u0000\u0000\u00a3\u00a0\u0001\u0000\u0000\u0000\u00a4\u001b\u0001"+
		"\u0000\u0000\u0000\u00a5\u00a6\u0005\u0010\u0000\u0000\u00a6\u00a7\u0005"+
		"\u0018\u0000\u0000\u00a7\u00a8\u0003<\u001e\u0000\u00a8\u00a9\u0005\u0019"+
		"\u0000\u0000\u00a9\u00aa\u0003\u0018\f\u0000\u00aa\u00ab\u0005\u0011\u0000"+
		"\u0000\u00ab\u00ac\u0003\u0018\f\u0000\u00ac\u00b4\u0001\u0000\u0000\u0000"+
		"\u00ad\u00ae\u0005\u0010\u0000\u0000\u00ae\u00af\u0005\u0018\u0000\u0000"+
		"\u00af\u00b0\u0003<\u001e\u0000\u00b0\u00b1\u0005\u0019\u0000\u0000\u00b1"+
		"\u00b2\u0003\u0018\f\u0000\u00b2\u00b4\u0001\u0000\u0000\u0000\u00b3\u00a5"+
		"\u0001\u0000\u0000\u0000\u00b3\u00ad\u0001\u0000\u0000\u0000\u00b4\u001d"+
		"\u0001\u0000\u0000\u0000\u00b5\u00b6\u0005\u0012\u0000\u0000\u00b6\u00b7"+
		"\u0005\u0018\u0000\u0000\u00b7\u00b8\u0003<\u001e\u0000\u00b8\u00b9\u0005"+
		"\u0019\u0000\u0000\u00b9\u00ba\u0003\u0018\f\u0000\u00ba\u00c9\u0001\u0000"+
		"\u0000\u0000\u00bb\u00bc\u0005\u0013\u0000\u0000\u00bc\u00bf\u0005\u0018"+
		"\u0000\u0000\u00bd\u00c0\u0003<\u001e\u0000\u00be\u00c0\u0003\u0014\n"+
		"\u0000\u00bf\u00bd\u0001\u0000\u0000\u0000\u00bf\u00be\u0001\u0000\u0000"+
		"\u0000\u00c0\u00c1\u0001\u0000\u0000\u0000\u00c1\u00c2\u0005\u001e\u0000"+
		"\u0000\u00c2\u00c3\u0003<\u001e\u0000\u00c3\u00c4\u0005\u001e\u0000\u0000"+
		"\u00c4\u00c5\u0003<\u001e\u0000\u00c5\u00c6\u0005\u0019\u0000\u0000\u00c6"+
		"\u00c7\u0003\u0018\f\u0000\u00c7\u00c9\u0001\u0000\u0000\u0000\u00c8\u00b5"+
		"\u0001\u0000\u0000\u0000\u00c8\u00bb\u0001\u0000\u0000\u0000\u00c9\u001f"+
		"\u0001\u0000\u0000\u0000\u00ca\u00cb\u0005\u0014\u0000\u0000\u00cb\u00d3"+
		"\u0005\u001e\u0000\u0000\u00cc\u00cd\u0005\u0015\u0000\u0000\u00cd\u00d3"+
		"\u0005\u001e\u0000\u0000\u00ce\u00cf\u0005\u0016\u0000\u0000\u00cf\u00d0"+
		"\u0003<\u001e\u0000\u00d0\u00d1\u0005\u001e\u0000\u0000\u00d1\u00d3\u0001"+
		"\u0000\u0000\u0000\u00d2\u00ca\u0001\u0000\u0000\u0000\u00d2\u00cc\u0001"+
		"\u0000\u0000\u0000\u00d2\u00ce\u0001\u0000\u0000\u0000\u00d3!\u0001\u0000"+
		"\u0000\u0000\u00d4\u00d5\u0003>\u001f\u0000\u00d5\u00d6\u0003@ \u0000"+
		"\u00d6\u00d7\u0003<\u001e\u0000\u00d7\u00dd\u0001\u0000\u0000\u0000\u00d8"+
		"\u00d9\u0003>\u001f\u0000\u00d9\u00da\u0003@ \u0000\u00da\u00db\u0003"+
		"$\u0012\u0000\u00db\u00dd\u0001\u0000\u0000\u0000\u00dc\u00d4\u0001\u0000"+
		"\u0000\u0000\u00dc\u00d8\u0001\u0000\u0000\u0000\u00dd#\u0001\u0000\u0000"+
		"\u0000\u00de\u00df\u0003>\u001f\u0000\u00df\u00e3\u0005\u0018\u0000\u0000"+
		"\u00e0\u00e2\u0003\u0010\b\u0000\u00e1\u00e0\u0001\u0000\u0000\u0000\u00e2"+
		"\u00e5\u0001\u0000\u0000\u0000\u00e3\u00e1\u0001\u0000\u0000\u0000\u00e3"+
		"\u00e4\u0001\u0000\u0000\u0000\u00e4\u00e6\u0001\u0000\u0000\u0000\u00e5"+
		"\u00e3\u0001\u0000\u0000\u0000\u00e6\u00e7\u0005\u0019\u0000\u0000\u00e7"+
		"%\u0001\u0000\u0000\u0000\u00e8\u00ed\u0005@\u0000\u0000\u00e9\u00ed\u0005"+
		"\u0001\u0000\u0000\u00ea\u00ed\u0005?\u0000\u0000\u00eb\u00ed\u0003>\u001f"+
		"\u0000\u00ec\u00e8\u0001\u0000\u0000\u0000\u00ec\u00e9\u0001\u0000\u0000"+
		"\u0000\u00ec\u00ea\u0001\u0000\u0000\u0000\u00ec\u00eb\u0001\u0000\u0000"+
		"\u0000\u00ed\'\u0001\u0000\u0000\u0000\u00ee\u00fc\u0003&\u0013\u0000"+
		"\u00ef\u00f0\u0003&\u0013\u0000\u00f0\u00f1\u0005<\u0000\u0000\u00f1\u00fc"+
		"\u0001\u0000\u0000\u0000\u00f2\u00f3\u0003&\u0013\u0000\u00f3\u00f4\u0005"+
		"=\u0000\u0000\u00f4\u00fc\u0001\u0000\u0000\u0000\u00f5\u00f6\u0005<\u0000"+
		"\u0000\u00f6\u00fc\u0003&\u0013\u0000\u00f7\u00f8\u0005=\u0000\u0000\u00f8"+
		"\u00fc\u0003&\u0013\u0000\u00f9\u00fa\u00059\u0000\u0000\u00fa\u00fc\u0003"+
		"&\u0013\u0000\u00fb\u00ee\u0001\u0000\u0000\u0000\u00fb\u00ef\u0001\u0000"+
		"\u0000\u0000\u00fb\u00f2\u0001\u0000\u0000\u0000\u00fb\u00f5\u0001\u0000"+
		"\u0000\u0000\u00fb\u00f7\u0001\u0000\u0000\u0000\u00fb\u00f9\u0001\u0000"+
		"\u0000\u0000\u00fc)\u0001\u0000\u0000\u0000\u00fd\u00fe\u0006\u0015\uffff"+
		"\uffff\u0000\u00fe\u00ff\u0003(\u0014\u0000\u00ff\u010b\u0001\u0000\u0000"+
		"\u0000\u0100\u0101\n\u0003\u0000\u0000\u0101\u0102\u0005,\u0000\u0000"+
		"\u0102\u010a\u0003&\u0013\u0000\u0103\u0104\n\u0002\u0000\u0000\u0104"+
		"\u0105\u0005-\u0000\u0000\u0105\u010a\u0003&\u0013\u0000\u0106\u0107\n"+
		"\u0001\u0000\u0000\u0107\u0108\u00050\u0000\u0000\u0108\u010a\u0003&\u0013"+
		"\u0000\u0109\u0100\u0001\u0000\u0000\u0000\u0109\u0103\u0001\u0000\u0000"+
		"\u0000\u0109\u0106\u0001\u0000\u0000\u0000\u010a\u010d\u0001\u0000\u0000"+
		"\u0000\u010b\u0109\u0001\u0000\u0000\u0000\u010b\u010c\u0001\u0000\u0000"+
		"\u0000\u010c+\u0001\u0000\u0000\u0000\u010d\u010b\u0001\u0000\u0000\u0000"+
		"\u010e\u010f\u0006\u0016\uffff\uffff\u0000\u010f\u0110\u0003*\u0015\u0000"+
		"\u0110\u0119\u0001\u0000\u0000\u0000\u0111\u0112\n\u0002\u0000\u0000\u0112"+
		"\u0113\u0005.\u0000\u0000\u0113\u0118\u0003*\u0015\u0000\u0114\u0115\n"+
		"\u0001\u0000\u0000\u0115\u0116\u0005/\u0000\u0000\u0116\u0118\u0003*\u0015"+
		"\u0000\u0117\u0111\u0001\u0000\u0000\u0000\u0117\u0114\u0001\u0000\u0000"+
		"\u0000\u0118\u011b\u0001\u0000\u0000\u0000\u0119\u0117\u0001\u0000\u0000"+
		"\u0000\u0119\u011a\u0001\u0000\u0000\u0000\u011a-\u0001\u0000\u0000\u0000"+
		"\u011b\u0119\u0001\u0000\u0000\u0000\u011c\u011d\u0006\u0017\uffff\uffff"+
		"\u0000\u011d\u011e\u0003,\u0016\u0000\u011e\u0127\u0001\u0000\u0000\u0000"+
		"\u011f\u0120\n\u0002\u0000\u0000\u0120\u0121\u0005:\u0000\u0000\u0121"+
		"\u0126\u0003,\u0016\u0000\u0122\u0123\n\u0001\u0000\u0000\u0123\u0124"+
		"\u0005;\u0000\u0000\u0124\u0126\u0003,\u0016\u0000\u0125\u011f\u0001\u0000"+
		"\u0000\u0000\u0125\u0122\u0001\u0000\u0000\u0000\u0126\u0129\u0001\u0000"+
		"\u0000\u0000\u0127\u0125\u0001\u0000\u0000\u0000\u0127\u0128\u0001\u0000"+
		"\u0000\u0000\u0128/\u0001\u0000\u0000\u0000\u0129\u0127\u0001\u0000\u0000"+
		"\u0000\u012a\u012b\u0006\u0018\uffff\uffff\u0000\u012b\u012c\u0003.\u0017"+
		"\u0000\u012c\u013b\u0001\u0000\u0000\u0000\u012d\u012e\n\u0004\u0000\u0000"+
		"\u012e\u012f\u00056\u0000\u0000\u012f\u013a\u0003.\u0017\u0000\u0130\u0131"+
		"\n\u0003\u0000\u0000\u0131\u0132\u00055\u0000\u0000\u0132\u013a\u0003"+
		".\u0017\u0000\u0133\u0134\n\u0002\u0000\u0000\u0134\u0135\u00058\u0000"+
		"\u0000\u0135\u013a\u0003.\u0017\u0000\u0136\u0137\n\u0001\u0000\u0000"+
		"\u0137\u0138\u00057\u0000\u0000\u0138\u013a\u0003.\u0017\u0000\u0139\u012d"+
		"\u0001\u0000\u0000\u0000\u0139\u0130\u0001\u0000\u0000\u0000\u0139\u0133"+
		"\u0001\u0000\u0000\u0000\u0139\u0136\u0001\u0000\u0000\u0000\u013a\u013d"+
		"\u0001\u0000\u0000\u0000\u013b\u0139\u0001\u0000\u0000\u0000\u013b\u013c"+
		"\u0001\u0000\u0000\u0000\u013c1\u0001\u0000\u0000\u0000\u013d\u013b\u0001"+
		"\u0000\u0000\u0000\u013e\u013f\u0006\u0019\uffff\uffff\u0000\u013f\u0140"+
		"\u00030\u0018\u0000\u0140\u0149\u0001\u0000\u0000\u0000\u0141\u0142\n"+
		"\u0002\u0000\u0000\u0142\u0143\u00053\u0000\u0000\u0143\u0148\u00030\u0018"+
		"\u0000\u0144\u0145\n\u0001\u0000\u0000\u0145\u0146\u00054\u0000\u0000"+
		"\u0146\u0148\u00030\u0018\u0000\u0147\u0141\u0001\u0000\u0000\u0000\u0147"+
		"\u0144\u0001\u0000\u0000\u0000\u0148\u014b\u0001\u0000\u0000\u0000\u0149"+
		"\u0147\u0001\u0000\u0000\u0000\u0149\u014a\u0001\u0000\u0000\u0000\u014a"+
		"3\u0001\u0000\u0000\u0000\u014b\u0149\u0001\u0000\u0000\u0000\u014c\u014d"+
		"\u0006\u001a\uffff\uffff\u0000\u014d\u014e\u00032\u0019\u0000\u014e\u0154"+
		"\u0001\u0000\u0000\u0000\u014f\u0150\n\u0001\u0000\u0000\u0150\u0151\u0005"+
		"1\u0000\u0000\u0151\u0153\u00032\u0019\u0000\u0152\u014f\u0001\u0000\u0000"+
		"\u0000\u0153\u0156\u0001\u0000\u0000\u0000\u0154\u0152\u0001\u0000\u0000"+
		"\u0000\u0154\u0155\u0001\u0000\u0000\u0000\u01555\u0001\u0000\u0000\u0000"+
		"\u0156\u0154\u0001\u0000\u0000\u0000\u0157\u0158\u0006\u001b\uffff\uffff"+
		"\u0000\u0158\u0159\u00034\u001a\u0000\u0159\u015f\u0001\u0000\u0000\u0000"+
		"\u015a\u015b\n\u0001\u0000\u0000\u015b\u015c\u00052\u0000\u0000\u015c"+
		"\u015e\u00034\u001a\u0000\u015d\u015a\u0001\u0000\u0000\u0000\u015e\u0161"+
		"\u0001\u0000\u0000\u0000\u015f\u015d\u0001\u0000\u0000\u0000\u015f\u0160"+
		"\u0001\u0000\u0000\u0000\u01607\u0001\u0000\u0000\u0000\u0161\u015f\u0001"+
		"\u0000\u0000\u0000\u0162\u016a\u00036\u001b\u0000\u0163\u0164\u00036\u001b"+
		"\u0000\u0164\u0165\u0005\u0017\u0000\u0000\u0165\u0166\u0003<\u001e\u0000"+
		"\u0166\u0167\u0005!\u0000\u0000\u0167\u0168\u0003<\u001e\u0000\u0168\u016a"+
		"\u0001\u0000\u0000\u0000\u0169\u0162\u0001\u0000\u0000\u0000\u0169\u0163"+
		"\u0001\u0000\u0000\u0000\u016a9\u0001\u0000\u0000\u0000\u016b\u0172\u0003"+
		"8\u001c\u0000\u016c\u016d\u0005\u000e\u0000\u0000\u016d\u016e\u0003>\u001f"+
		"\u0000\u016e\u016f\u0005\u000f\u0000\u0000\u016f\u0170\u0003B!\u0000\u0170"+
		"\u0172\u0001\u0000\u0000\u0000\u0171\u016b\u0001\u0000\u0000\u0000\u0171"+
		"\u016c\u0001\u0000\u0000\u0000\u0172;\u0001\u0000\u0000\u0000\u0173\u0179"+
		"\u0003:\u001d\u0000\u0174\u0175\u0005\u0018\u0000\u0000\u0175\u0176\u0003"+
		"<\u001e\u0000\u0176\u0177\u0005\u0019\u0000\u0000\u0177\u0179\u0001\u0000"+
		"\u0000\u0000\u0178\u0173\u0001\u0000\u0000\u0000\u0178\u0174\u0001\u0000"+
		"\u0000\u0000\u0179=\u0001\u0000\u0000\u0000\u017a\u017b\u0005>\u0000\u0000"+
		"\u017b?\u0001\u0000\u0000\u0000\u017c\u017d\u0007\u0001\u0000\u0000\u017d"+
		"A\u0001\u0000\u0000\u0000\u017e\u017f\u0007\u0002\u0000\u0000\u017fC\u0001"+
		"\u0000\u0000\u0000 IN\\lz\u0087\u0089\u008f\u00a3\u00b3\u00bf\u00c8\u00d2"+
		"\u00dc\u00e3\u00ec\u00fb\u0109\u010b\u0117\u0119\u0125\u0127\u0139\u013b"+
		"\u0147\u0149\u0154\u015f\u0169\u0171\u0178";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}