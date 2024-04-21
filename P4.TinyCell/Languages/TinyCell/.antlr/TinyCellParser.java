// Generated from c://Users//Rasmus//Documents//GitHub//P4//P4.TinyCell//Languages//TinyCell//TinyCell.g4 by ANTLR 4.13.1
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
		VOLHIGH=1, VOLLOW=2, PIN=3, INT=4, FLOAT=5, STRING=6, BOOL=7, VOID=8, 
		CHAR=9, UPDATE=10, SETUP=11, SET=12, TO=13, IF=14, ELSE=15, WHILE=16, 
		FOR=17, CONTINUE=18, BREAK=19, RETURN=20, QUESTION=21, LPAR=22, RPAR=23, 
		LCURLY=24, RCURLY=25, LBRACKET=26, RBRACKET=27, SEMI=28, DOT=29, COMMA=30, 
		COLON=31, NEWLINE=32, ASSIGN=33, PLUSASSIGN=34, MULTASSIGN=35, DIVASSIGN=36, 
		MODASSIGN=37, MINUSASSIGN=38, QUOTE=39, MULT=40, DIV=41, PLUS=42, MINUS=43, 
		MOD=44, AND=45, OR=46, EQ=47, NEQ=48, GT=49, LT=50, GTE=51, LTE=52, NOT=53, 
		BITSHIFTL=54, BITSHIFTR=55, UNARYPLUS=56, UNARYMINUS=57, Identifier=58, 
		String=59, Numeral=60, Whitespace=61, Newline=62;
	public static final int
		RULE_document = 0, RULE_generalDeclaration = 1, RULE_setupDefinition = 2, 
		RULE_updateDefinition = 3, RULE_functionDefinition = 4, RULE_type = 5, 
		RULE_parameterList = 6, RULE_parameter = 7, RULE_declaration = 8, RULE_initialDeclaration = 9, 
		RULE_compoundStatement = 10, RULE_statement = 11, RULE_ifStatement = 12, 
		RULE_loopStatement = 13, RULE_jumpStatement = 14, RULE_expression = 15, 
		RULE_assignmentExpression = 16, RULE_assignment = 17, RULE_ternaryExpression = 18, 
		RULE_orExpression = 19, RULE_andExpression = 20, RULE_equalityExpression = 21, 
		RULE_comparisonExpression = 22, RULE_bitshiftExpression = 23, RULE_additiveExpression = 24, 
		RULE_multiplicativeExpression = 25, RULE_unaryExpression = 26, RULE_primitiveExpression = 27, 
		RULE_pinExpression = 28, RULE_identifier = 29, RULE_assignmentOperator = 30, 
		RULE_pinVoltage = 31;
	private static String[] makeRuleNames() {
		return new String[] {
			"document", "generalDeclaration", "setupDefinition", "updateDefinition", 
			"functionDefinition", "type", "parameterList", "parameter", "declaration", 
			"initialDeclaration", "compoundStatement", "statement", "ifStatement", 
			"loopStatement", "jumpStatement", "expression", "assignmentExpression", 
			"assignment", "ternaryExpression", "orExpression", "andExpression", "equalityExpression", 
			"comparisonExpression", "bitshiftExpression", "additiveExpression", "multiplicativeExpression", 
			"unaryExpression", "primitiveExpression", "pinExpression", "identifier", 
			"assignmentOperator", "pinVoltage"
		};
	}
	public static final String[] ruleNames = makeRuleNames();

	private static String[] makeLiteralNames() {
		return new String[] {
			null, "'high'", "'low'", "'pin'", "'int'", "'float'", "'string'", "'bool'", 
			"'void'", "'char'", "'update'", "'setup'", "'set'", "'to'", "'if'", "'else'", 
			"'while'", "'for'", "'continue'", "'break'", "'return'", "'?'", "'('", 
			"')'", "'{'", "'}'", "'['", "']'", "';'", "'.'", "','", "':'", "'\\n'", 
			"'='", "'+='", "'*='", "'/='", "'%='", "'-='", "'\"'", "'*'", "'/'", 
			"'+'", "'-'", "'%'", "'&&'", "'||'", "'=='", "'!='", "'>'", "'<'", "'>='", 
			"'<='", "'!'", "'<<'", "'>>'", "'++'", "'--'"
		};
	}
	private static final String[] _LITERAL_NAMES = makeLiteralNames();
	private static String[] makeSymbolicNames() {
		return new String[] {
			null, "VOLHIGH", "VOLLOW", "PIN", "INT", "FLOAT", "STRING", "BOOL", "VOID", 
			"CHAR", "UPDATE", "SETUP", "SET", "TO", "IF", "ELSE", "WHILE", "FOR", 
			"CONTINUE", "BREAK", "RETURN", "QUESTION", "LPAR", "RPAR", "LCURLY", 
			"RCURLY", "LBRACKET", "RBRACKET", "SEMI", "DOT", "COMMA", "COLON", "NEWLINE", 
			"ASSIGN", "PLUSASSIGN", "MULTASSIGN", "DIVASSIGN", "MODASSIGN", "MINUSASSIGN", 
			"QUOTE", "MULT", "DIV", "PLUS", "MINUS", "MOD", "AND", "OR", "EQ", "NEQ", 
			"GT", "LT", "GTE", "LTE", "NOT", "BITSHIFTL", "BITSHIFTR", "UNARYPLUS", 
			"UNARYMINUS", "Identifier", "String", "Numeral", "Whitespace", "Newline"
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
			setState(64);
			setupDefinition();
			setState(65);
			updateDefinition();
			setState(69);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & 952L) != 0)) {
				{
				{
				setState(66);
				generalDeclaration();
				}
				}
				setState(71);
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
			setState(74);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,1,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(72);
				functionDefinition();
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(73);
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
			setState(76);
			match(SETUP);
			setState(77);
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
			setState(79);
			match(UPDATE);
			setState(80);
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
			setState(82);
			type();
			setState(83);
			identifier();
			setState(84);
			match(LPAR);
			setState(88);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & 952L) != 0)) {
				{
				{
				setState(85);
				parameterList(0);
				}
				}
				setState(90);
				_errHandler.sync(this);
				_la = _input.LA(1);
			}
			setState(91);
			match(RPAR);
			setState(92);
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
			setState(94);
			_la = _input.LA(1);
			if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & 952L) != 0)) ) {
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
			setState(97);
			parameter();
			}
			_ctx.stop = _input.LT(-1);
			setState(104);
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
					setState(99);
					if (!(precpred(_ctx, 1))) throw new FailedPredicateException(this, "precpred(_ctx, 1)");
					setState(100);
					match(COMMA);
					setState(101);
					parameter();
					}
					} 
				}
				setState(106);
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
			setState(107);
			type();
			setState(108);
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
		public TerminalNode SEMI() { return getToken(TinyCellParser.SEMI, 0); }
		public DeclarationContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_declaration; }
	}

	public final DeclarationContext declaration() throws RecognitionException {
		DeclarationContext _localctx = new DeclarationContext(_ctx, getState());
		enterRule(_localctx, 16, RULE_declaration);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(110);
			type();
			setState(111);
			initialDeclaration();
			setState(112);
			match(SEMI);
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
		public InitialDeclarationContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_initialDeclaration; }
	}

	public final InitialDeclarationContext initialDeclaration() throws RecognitionException {
		InitialDeclarationContext _localctx = new InitialDeclarationContext(_ctx, getState());
		enterRule(_localctx, 18, RULE_initialDeclaration);
		try {
			setState(119);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,4,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(114);
				identifier();
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(115);
				identifier();
				setState(116);
				match(ASSIGN);
				setState(117);
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
		enterRule(_localctx, 20, RULE_compoundStatement);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(121);
			match(LCURLY);
			setState(125);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & 288230376153760696L) != 0)) {
				{
				{
				setState(122);
				statement();
				}
				}
				setState(127);
				_errHandler.sync(this);
				_la = _input.LA(1);
			}
			setState(128);
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
		public AssignmentContext assignment() {
			return getRuleContext(AssignmentContext.class,0);
		}
		public StatementContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_statement; }
	}

	public final StatementContext statement() throws RecognitionException {
		StatementContext _localctx = new StatementContext(_ctx, getState());
		enterRule(_localctx, 22, RULE_statement);
		try {
			setState(135);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case IF:
				enterOuterAlt(_localctx, 1);
				{
				setState(130);
				ifStatement();
				}
				break;
			case WHILE:
			case FOR:
				enterOuterAlt(_localctx, 2);
				{
				setState(131);
				loopStatement();
				}
				break;
			case CONTINUE:
			case BREAK:
			case RETURN:
				enterOuterAlt(_localctx, 3);
				{
				setState(132);
				jumpStatement();
				}
				break;
			case PIN:
			case INT:
			case FLOAT:
			case BOOL:
			case VOID:
			case CHAR:
				enterOuterAlt(_localctx, 4);
				{
				setState(133);
				declaration();
				}
				break;
			case Identifier:
				enterOuterAlt(_localctx, 5);
				{
				setState(134);
				assignment();
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
		enterRule(_localctx, 24, RULE_ifStatement);
		try {
			setState(151);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,7,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(137);
				match(IF);
				setState(138);
				match(LPAR);
				setState(139);
				expression();
				setState(140);
				match(RPAR);
				setState(141);
				compoundStatement();
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(143);
				match(IF);
				setState(144);
				match(LPAR);
				setState(145);
				expression();
				setState(146);
				match(RPAR);
				setState(147);
				compoundStatement();
				setState(148);
				match(ELSE);
				setState(149);
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
		public LoopStatementContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_loopStatement; }
	}

	public final LoopStatementContext loopStatement() throws RecognitionException {
		LoopStatementContext _localctx = new LoopStatementContext(_ctx, getState());
		enterRule(_localctx, 26, RULE_loopStatement);
		try {
			setState(169);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case WHILE:
				enterOuterAlt(_localctx, 1);
				{
				setState(153);
				match(WHILE);
				setState(154);
				match(LPAR);
				setState(155);
				expression();
				setState(156);
				match(RPAR);
				setState(157);
				compoundStatement();
				}
				break;
			case FOR:
				enterOuterAlt(_localctx, 2);
				{
				setState(159);
				match(FOR);
				setState(160);
				match(LPAR);
				setState(161);
				expression();
				setState(162);
				match(SEMI);
				setState(163);
				expression();
				setState(164);
				match(SEMI);
				setState(165);
				expression();
				setState(166);
				match(RPAR);
				setState(167);
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
		enterRule(_localctx, 28, RULE_jumpStatement);
		try {
			setState(179);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case CONTINUE:
				enterOuterAlt(_localctx, 1);
				{
				setState(171);
				match(CONTINUE);
				setState(172);
				match(SEMI);
				}
				break;
			case BREAK:
				enterOuterAlt(_localctx, 2);
				{
				setState(173);
				match(BREAK);
				setState(174);
				match(SEMI);
				}
				break;
			case RETURN:
				enterOuterAlt(_localctx, 3);
				{
				setState(175);
				match(RETURN);
				setState(176);
				expression();
				setState(177);
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
	public static class ExpressionContext extends ParserRuleContext {
		public PinExpressionContext pinExpression() {
			return getRuleContext(PinExpressionContext.class,0);
		}
		public TerminalNode SEMI() { return getToken(TinyCellParser.SEMI, 0); }
		public TernaryExpressionContext ternaryExpression() {
			return getRuleContext(TernaryExpressionContext.class,0);
		}
		public ExpressionContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_expression; }
	}

	public final ExpressionContext expression() throws RecognitionException {
		ExpressionContext _localctx = new ExpressionContext(_ctx, getState());
		enterRule(_localctx, 30, RULE_expression);
		try {
			setState(187);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case SET:
				enterOuterAlt(_localctx, 1);
				{
				setState(181);
				pinExpression();
				setState(182);
				match(SEMI);
				}
				break;
			case UNARYPLUS:
			case UNARYMINUS:
			case String:
			case Numeral:
				enterOuterAlt(_localctx, 2);
				{
				setState(184);
				ternaryExpression();
				setState(185);
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
	public static class AssignmentExpressionContext extends ParserRuleContext {
		public TernaryExpressionContext ternaryExpression() {
			return getRuleContext(TernaryExpressionContext.class,0);
		}
		public AssignmentOperatorContext assignmentOperator() {
			return getRuleContext(AssignmentOperatorContext.class,0);
		}
		public AssignmentExpressionContext assignmentExpression() {
			return getRuleContext(AssignmentExpressionContext.class,0);
		}
		public UnaryExpressionContext unaryExpression() {
			return getRuleContext(UnaryExpressionContext.class,0);
		}
		public IdentifierContext identifier() {
			return getRuleContext(IdentifierContext.class,0);
		}
		public AssignmentExpressionContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_assignmentExpression; }
	}

	public final AssignmentExpressionContext assignmentExpression() throws RecognitionException {
		AssignmentExpressionContext _localctx = new AssignmentExpressionContext(_ctx, getState());
		enterRule(_localctx, 32, RULE_assignmentExpression);
		try {
			setState(197);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,12,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(189);
				ternaryExpression();
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(192);
				_errHandler.sync(this);
				switch (_input.LA(1)) {
				case UNARYPLUS:
				case UNARYMINUS:
				case String:
				case Numeral:
					{
					setState(190);
					unaryExpression();
					}
					break;
				case Identifier:
					{
					setState(191);
					identifier();
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				setState(194);
				assignmentOperator();
				setState(195);
				assignmentExpression();
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
		public TerminalNode SEMI() { return getToken(TinyCellParser.SEMI, 0); }
		public AssignmentContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_assignment; }
	}

	public final AssignmentContext assignment() throws RecognitionException {
		AssignmentContext _localctx = new AssignmentContext(_ctx, getState());
		enterRule(_localctx, 34, RULE_assignment);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(199);
			identifier();
			setState(200);
			assignmentOperator();
			setState(201);
			expression();
			setState(202);
			match(SEMI);
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
		enterRule(_localctx, 36, RULE_ternaryExpression);
		try {
			setState(211);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,13,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(204);
				orExpression(0);
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(205);
				orExpression(0);
				setState(206);
				match(QUESTION);
				setState(207);
				expression();
				setState(208);
				match(COLON);
				setState(209);
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
		int _startState = 38;
		enterRecursionRule(_localctx, 38, RULE_orExpression, _p);
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			{
			setState(214);
			andExpression(0);
			}
			_ctx.stop = _input.LT(-1);
			setState(221);
			_errHandler.sync(this);
			_alt = getInterpreter().adaptivePredict(_input,14,_ctx);
			while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( _parseListeners!=null ) triggerExitRuleEvent();
					_prevctx = _localctx;
					{
					{
					_localctx = new OrExpressionContext(_parentctx, _parentState);
					pushNewRecursionContext(_localctx, _startState, RULE_orExpression);
					setState(216);
					if (!(precpred(_ctx, 1))) throw new FailedPredicateException(this, "precpred(_ctx, 1)");
					setState(217);
					match(OR);
					setState(218);
					andExpression(0);
					}
					} 
				}
				setState(223);
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,14,_ctx);
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
		int _startState = 40;
		enterRecursionRule(_localctx, 40, RULE_andExpression, _p);
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			{
			setState(225);
			equalityExpression(0);
			}
			_ctx.stop = _input.LT(-1);
			setState(232);
			_errHandler.sync(this);
			_alt = getInterpreter().adaptivePredict(_input,15,_ctx);
			while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( _parseListeners!=null ) triggerExitRuleEvent();
					_prevctx = _localctx;
					{
					{
					_localctx = new AndExpressionContext(_parentctx, _parentState);
					pushNewRecursionContext(_localctx, _startState, RULE_andExpression);
					setState(227);
					if (!(precpred(_ctx, 1))) throw new FailedPredicateException(this, "precpred(_ctx, 1)");
					setState(228);
					match(AND);
					setState(229);
					equalityExpression(0);
					}
					} 
				}
				setState(234);
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,15,_ctx);
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
		int _startState = 42;
		enterRecursionRule(_localctx, 42, RULE_equalityExpression, _p);
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			{
			setState(236);
			comparisonExpression(0);
			}
			_ctx.stop = _input.LT(-1);
			setState(246);
			_errHandler.sync(this);
			_alt = getInterpreter().adaptivePredict(_input,17,_ctx);
			while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( _parseListeners!=null ) triggerExitRuleEvent();
					_prevctx = _localctx;
					{
					setState(244);
					_errHandler.sync(this);
					switch ( getInterpreter().adaptivePredict(_input,16,_ctx) ) {
					case 1:
						{
						_localctx = new EqualityExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_equalityExpression);
						setState(238);
						if (!(precpred(_ctx, 2))) throw new FailedPredicateException(this, "precpred(_ctx, 2)");
						setState(239);
						match(EQ);
						setState(240);
						comparisonExpression(0);
						}
						break;
					case 2:
						{
						_localctx = new EqualityExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_equalityExpression);
						setState(241);
						if (!(precpred(_ctx, 1))) throw new FailedPredicateException(this, "precpred(_ctx, 1)");
						setState(242);
						match(NEQ);
						setState(243);
						comparisonExpression(0);
						}
						break;
					}
					} 
				}
				setState(248);
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,17,_ctx);
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
		int _startState = 44;
		enterRecursionRule(_localctx, 44, RULE_comparisonExpression, _p);
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			{
			setState(250);
			bitshiftExpression(0);
			}
			_ctx.stop = _input.LT(-1);
			setState(266);
			_errHandler.sync(this);
			_alt = getInterpreter().adaptivePredict(_input,19,_ctx);
			while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( _parseListeners!=null ) triggerExitRuleEvent();
					_prevctx = _localctx;
					{
					setState(264);
					_errHandler.sync(this);
					switch ( getInterpreter().adaptivePredict(_input,18,_ctx) ) {
					case 1:
						{
						_localctx = new ComparisonExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_comparisonExpression);
						setState(252);
						if (!(precpred(_ctx, 4))) throw new FailedPredicateException(this, "precpred(_ctx, 4)");
						setState(253);
						match(LT);
						setState(254);
						bitshiftExpression(0);
						}
						break;
					case 2:
						{
						_localctx = new ComparisonExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_comparisonExpression);
						setState(255);
						if (!(precpred(_ctx, 3))) throw new FailedPredicateException(this, "precpred(_ctx, 3)");
						setState(256);
						match(GT);
						setState(257);
						bitshiftExpression(0);
						}
						break;
					case 3:
						{
						_localctx = new ComparisonExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_comparisonExpression);
						setState(258);
						if (!(precpred(_ctx, 2))) throw new FailedPredicateException(this, "precpred(_ctx, 2)");
						setState(259);
						match(LTE);
						setState(260);
						bitshiftExpression(0);
						}
						break;
					case 4:
						{
						_localctx = new ComparisonExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_comparisonExpression);
						setState(261);
						if (!(precpred(_ctx, 1))) throw new FailedPredicateException(this, "precpred(_ctx, 1)");
						setState(262);
						match(GTE);
						setState(263);
						bitshiftExpression(0);
						}
						break;
					}
					} 
				}
				setState(268);
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,19,_ctx);
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
			setState(270);
			additiveExpression(0);
			}
			_ctx.stop = _input.LT(-1);
			setState(280);
			_errHandler.sync(this);
			_alt = getInterpreter().adaptivePredict(_input,21,_ctx);
			while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( _parseListeners!=null ) triggerExitRuleEvent();
					_prevctx = _localctx;
					{
					setState(278);
					_errHandler.sync(this);
					switch ( getInterpreter().adaptivePredict(_input,20,_ctx) ) {
					case 1:
						{
						_localctx = new BitshiftExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_bitshiftExpression);
						setState(272);
						if (!(precpred(_ctx, 2))) throw new FailedPredicateException(this, "precpred(_ctx, 2)");
						setState(273);
						match(BITSHIFTL);
						setState(274);
						additiveExpression(0);
						}
						break;
					case 2:
						{
						_localctx = new BitshiftExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_bitshiftExpression);
						setState(275);
						if (!(precpred(_ctx, 1))) throw new FailedPredicateException(this, "precpred(_ctx, 1)");
						setState(276);
						match(BITSHIFTR);
						setState(277);
						additiveExpression(0);
						}
						break;
					}
					} 
				}
				setState(282);
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,21,_ctx);
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
		int _startState = 48;
		enterRecursionRule(_localctx, 48, RULE_additiveExpression, _p);
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			{
			setState(284);
			multiplicativeExpression(0);
			}
			_ctx.stop = _input.LT(-1);
			setState(294);
			_errHandler.sync(this);
			_alt = getInterpreter().adaptivePredict(_input,23,_ctx);
			while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( _parseListeners!=null ) triggerExitRuleEvent();
					_prevctx = _localctx;
					{
					setState(292);
					_errHandler.sync(this);
					switch ( getInterpreter().adaptivePredict(_input,22,_ctx) ) {
					case 1:
						{
						_localctx = new AdditiveExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_additiveExpression);
						setState(286);
						if (!(precpred(_ctx, 2))) throw new FailedPredicateException(this, "precpred(_ctx, 2)");
						setState(287);
						match(PLUS);
						setState(288);
						multiplicativeExpression(0);
						}
						break;
					case 2:
						{
						_localctx = new AdditiveExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_additiveExpression);
						setState(289);
						if (!(precpred(_ctx, 1))) throw new FailedPredicateException(this, "precpred(_ctx, 1)");
						setState(290);
						match(MINUS);
						setState(291);
						multiplicativeExpression(0);
						}
						break;
					}
					} 
				}
				setState(296);
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,23,_ctx);
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
		int _startState = 50;
		enterRecursionRule(_localctx, 50, RULE_multiplicativeExpression, _p);
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			{
			setState(298);
			unaryExpression();
			}
			_ctx.stop = _input.LT(-1);
			setState(311);
			_errHandler.sync(this);
			_alt = getInterpreter().adaptivePredict(_input,25,_ctx);
			while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( _parseListeners!=null ) triggerExitRuleEvent();
					_prevctx = _localctx;
					{
					setState(309);
					_errHandler.sync(this);
					switch ( getInterpreter().adaptivePredict(_input,24,_ctx) ) {
					case 1:
						{
						_localctx = new MultiplicativeExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_multiplicativeExpression);
						setState(300);
						if (!(precpred(_ctx, 3))) throw new FailedPredicateException(this, "precpred(_ctx, 3)");
						setState(301);
						match(MULT);
						setState(302);
						primitiveExpression();
						}
						break;
					case 2:
						{
						_localctx = new MultiplicativeExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_multiplicativeExpression);
						setState(303);
						if (!(precpred(_ctx, 2))) throw new FailedPredicateException(this, "precpred(_ctx, 2)");
						setState(304);
						match(DIV);
						setState(305);
						primitiveExpression();
						}
						break;
					case 3:
						{
						_localctx = new MultiplicativeExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_multiplicativeExpression);
						setState(306);
						if (!(precpred(_ctx, 1))) throw new FailedPredicateException(this, "precpred(_ctx, 1)");
						setState(307);
						match(MOD);
						setState(308);
						primitiveExpression();
						}
						break;
					}
					} 
				}
				setState(313);
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,25,_ctx);
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
	public static class UnaryExpressionContext extends ParserRuleContext {
		public PrimitiveExpressionContext primitiveExpression() {
			return getRuleContext(PrimitiveExpressionContext.class,0);
		}
		public TerminalNode UNARYPLUS() { return getToken(TinyCellParser.UNARYPLUS, 0); }
		public TerminalNode UNARYMINUS() { return getToken(TinyCellParser.UNARYMINUS, 0); }
		public UnaryExpressionContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_unaryExpression; }
	}

	public final UnaryExpressionContext unaryExpression() throws RecognitionException {
		UnaryExpressionContext _localctx = new UnaryExpressionContext(_ctx, getState());
		enterRule(_localctx, 52, RULE_unaryExpression);
		try {
			setState(325);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,26,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(314);
				primitiveExpression();
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(315);
				primitiveExpression();
				setState(316);
				match(UNARYPLUS);
				}
				break;
			case 3:
				enterOuterAlt(_localctx, 3);
				{
				setState(318);
				primitiveExpression();
				setState(319);
				match(UNARYMINUS);
				}
				break;
			case 4:
				enterOuterAlt(_localctx, 4);
				{
				setState(321);
				match(UNARYPLUS);
				setState(322);
				primitiveExpression();
				}
				break;
			case 5:
				enterOuterAlt(_localctx, 5);
				{
				setState(323);
				match(UNARYMINUS);
				setState(324);
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
	public static class PrimitiveExpressionContext extends ParserRuleContext {
		public TerminalNode Numeral() { return getToken(TinyCellParser.Numeral, 0); }
		public TerminalNode String() { return getToken(TinyCellParser.String, 0); }
		public PrimitiveExpressionContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_primitiveExpression; }
	}

	public final PrimitiveExpressionContext primitiveExpression() throws RecognitionException {
		PrimitiveExpressionContext _localctx = new PrimitiveExpressionContext(_ctx, getState());
		enterRule(_localctx, 54, RULE_primitiveExpression);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(327);
			_la = _input.LA(1);
			if ( !(_la==String || _la==Numeral) ) {
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
	public static class PinExpressionContext extends ParserRuleContext {
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
		enterRule(_localctx, 56, RULE_pinExpression);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(329);
			match(SET);
			setState(330);
			identifier();
			setState(331);
			match(TO);
			setState(332);
			pinVoltage();
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
		enterRule(_localctx, 58, RULE_identifier);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(334);
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
		enterRule(_localctx, 60, RULE_assignmentOperator);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(336);
			_la = _input.LA(1);
			if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & 541165879296L) != 0)) ) {
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
		enterRule(_localctx, 62, RULE_pinVoltage);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(338);
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
		case 19:
			return orExpression_sempred((OrExpressionContext)_localctx, predIndex);
		case 20:
			return andExpression_sempred((AndExpressionContext)_localctx, predIndex);
		case 21:
			return equalityExpression_sempred((EqualityExpressionContext)_localctx, predIndex);
		case 22:
			return comparisonExpression_sempred((ComparisonExpressionContext)_localctx, predIndex);
		case 23:
			return bitshiftExpression_sempred((BitshiftExpressionContext)_localctx, predIndex);
		case 24:
			return additiveExpression_sempred((AdditiveExpressionContext)_localctx, predIndex);
		case 25:
			return multiplicativeExpression_sempred((MultiplicativeExpressionContext)_localctx, predIndex);
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
	private boolean orExpression_sempred(OrExpressionContext _localctx, int predIndex) {
		switch (predIndex) {
		case 1:
			return precpred(_ctx, 1);
		}
		return true;
	}
	private boolean andExpression_sempred(AndExpressionContext _localctx, int predIndex) {
		switch (predIndex) {
		case 2:
			return precpred(_ctx, 1);
		}
		return true;
	}
	private boolean equalityExpression_sempred(EqualityExpressionContext _localctx, int predIndex) {
		switch (predIndex) {
		case 3:
			return precpred(_ctx, 2);
		case 4:
			return precpred(_ctx, 1);
		}
		return true;
	}
	private boolean comparisonExpression_sempred(ComparisonExpressionContext _localctx, int predIndex) {
		switch (predIndex) {
		case 5:
			return precpred(_ctx, 4);
		case 6:
			return precpred(_ctx, 3);
		case 7:
			return precpred(_ctx, 2);
		case 8:
			return precpred(_ctx, 1);
		}
		return true;
	}
	private boolean bitshiftExpression_sempred(BitshiftExpressionContext _localctx, int predIndex) {
		switch (predIndex) {
		case 9:
			return precpred(_ctx, 2);
		case 10:
			return precpred(_ctx, 1);
		}
		return true;
	}
	private boolean additiveExpression_sempred(AdditiveExpressionContext _localctx, int predIndex) {
		switch (predIndex) {
		case 11:
			return precpred(_ctx, 2);
		case 12:
			return precpred(_ctx, 1);
		}
		return true;
	}
	private boolean multiplicativeExpression_sempred(MultiplicativeExpressionContext _localctx, int predIndex) {
		switch (predIndex) {
		case 13:
			return precpred(_ctx, 3);
		case 14:
			return precpred(_ctx, 2);
		case 15:
			return precpred(_ctx, 1);
		}
		return true;
	}

	public static final String _serializedATN =
		"\u0004\u0001>\u0155\u0002\u0000\u0007\u0000\u0002\u0001\u0007\u0001\u0002"+
		"\u0002\u0007\u0002\u0002\u0003\u0007\u0003\u0002\u0004\u0007\u0004\u0002"+
		"\u0005\u0007\u0005\u0002\u0006\u0007\u0006\u0002\u0007\u0007\u0007\u0002"+
		"\b\u0007\b\u0002\t\u0007\t\u0002\n\u0007\n\u0002\u000b\u0007\u000b\u0002"+
		"\f\u0007\f\u0002\r\u0007\r\u0002\u000e\u0007\u000e\u0002\u000f\u0007\u000f"+
		"\u0002\u0010\u0007\u0010\u0002\u0011\u0007\u0011\u0002\u0012\u0007\u0012"+
		"\u0002\u0013\u0007\u0013\u0002\u0014\u0007\u0014\u0002\u0015\u0007\u0015"+
		"\u0002\u0016\u0007\u0016\u0002\u0017\u0007\u0017\u0002\u0018\u0007\u0018"+
		"\u0002\u0019\u0007\u0019\u0002\u001a\u0007\u001a\u0002\u001b\u0007\u001b"+
		"\u0002\u001c\u0007\u001c\u0002\u001d\u0007\u001d\u0002\u001e\u0007\u001e"+
		"\u0002\u001f\u0007\u001f\u0001\u0000\u0001\u0000\u0001\u0000\u0005\u0000"+
		"D\b\u0000\n\u0000\f\u0000G\t\u0000\u0001\u0001\u0001\u0001\u0003\u0001"+
		"K\b\u0001\u0001\u0002\u0001\u0002\u0001\u0002\u0001\u0003\u0001\u0003"+
		"\u0001\u0003\u0001\u0004\u0001\u0004\u0001\u0004\u0001\u0004\u0005\u0004"+
		"W\b\u0004\n\u0004\f\u0004Z\t\u0004\u0001\u0004\u0001\u0004\u0001\u0004"+
		"\u0001\u0005\u0001\u0005\u0001\u0006\u0001\u0006\u0001\u0006\u0001\u0006"+
		"\u0001\u0006\u0001\u0006\u0005\u0006g\b\u0006\n\u0006\f\u0006j\t\u0006"+
		"\u0001\u0007\u0001\u0007\u0001\u0007\u0001\b\u0001\b\u0001\b\u0001\b\u0001"+
		"\t\u0001\t\u0001\t\u0001\t\u0001\t\u0003\tx\b\t\u0001\n\u0001\n\u0005"+
		"\n|\b\n\n\n\f\n\u007f\t\n\u0001\n\u0001\n\u0001\u000b\u0001\u000b\u0001"+
		"\u000b\u0001\u000b\u0001\u000b\u0003\u000b\u0088\b\u000b\u0001\f\u0001"+
		"\f\u0001\f\u0001\f\u0001\f\u0001\f\u0001\f\u0001\f\u0001\f\u0001\f\u0001"+
		"\f\u0001\f\u0001\f\u0001\f\u0003\f\u0098\b\f\u0001\r\u0001\r\u0001\r\u0001"+
		"\r\u0001\r\u0001\r\u0001\r\u0001\r\u0001\r\u0001\r\u0001\r\u0001\r\u0001"+
		"\r\u0001\r\u0001\r\u0001\r\u0003\r\u00aa\b\r\u0001\u000e\u0001\u000e\u0001"+
		"\u000e\u0001\u000e\u0001\u000e\u0001\u000e\u0001\u000e\u0001\u000e\u0003"+
		"\u000e\u00b4\b\u000e\u0001\u000f\u0001\u000f\u0001\u000f\u0001\u000f\u0001"+
		"\u000f\u0001\u000f\u0003\u000f\u00bc\b\u000f\u0001\u0010\u0001\u0010\u0001"+
		"\u0010\u0003\u0010\u00c1\b\u0010\u0001\u0010\u0001\u0010\u0001\u0010\u0003"+
		"\u0010\u00c6\b\u0010\u0001\u0011\u0001\u0011\u0001\u0011\u0001\u0011\u0001"+
		"\u0011\u0001\u0012\u0001\u0012\u0001\u0012\u0001\u0012\u0001\u0012\u0001"+
		"\u0012\u0001\u0012\u0003\u0012\u00d4\b\u0012\u0001\u0013\u0001\u0013\u0001"+
		"\u0013\u0001\u0013\u0001\u0013\u0001\u0013\u0005\u0013\u00dc\b\u0013\n"+
		"\u0013\f\u0013\u00df\t\u0013\u0001\u0014\u0001\u0014\u0001\u0014\u0001"+
		"\u0014\u0001\u0014\u0001\u0014\u0005\u0014\u00e7\b\u0014\n\u0014\f\u0014"+
		"\u00ea\t\u0014\u0001\u0015\u0001\u0015\u0001\u0015\u0001\u0015\u0001\u0015"+
		"\u0001\u0015\u0001\u0015\u0001\u0015\u0001\u0015\u0005\u0015\u00f5\b\u0015"+
		"\n\u0015\f\u0015\u00f8\t\u0015\u0001\u0016\u0001\u0016\u0001\u0016\u0001"+
		"\u0016\u0001\u0016\u0001\u0016\u0001\u0016\u0001\u0016\u0001\u0016\u0001"+
		"\u0016\u0001\u0016\u0001\u0016\u0001\u0016\u0001\u0016\u0001\u0016\u0005"+
		"\u0016\u0109\b\u0016\n\u0016\f\u0016\u010c\t\u0016\u0001\u0017\u0001\u0017"+
		"\u0001\u0017\u0001\u0017\u0001\u0017\u0001\u0017\u0001\u0017\u0001\u0017"+
		"\u0001\u0017\u0005\u0017\u0117\b\u0017\n\u0017\f\u0017\u011a\t\u0017\u0001"+
		"\u0018\u0001\u0018\u0001\u0018\u0001\u0018\u0001\u0018\u0001\u0018\u0001"+
		"\u0018\u0001\u0018\u0001\u0018\u0005\u0018\u0125\b\u0018\n\u0018\f\u0018"+
		"\u0128\t\u0018\u0001\u0019\u0001\u0019\u0001\u0019\u0001\u0019\u0001\u0019"+
		"\u0001\u0019\u0001\u0019\u0001\u0019\u0001\u0019\u0001\u0019\u0001\u0019"+
		"\u0001\u0019\u0005\u0019\u0136\b\u0019\n\u0019\f\u0019\u0139\t\u0019\u0001"+
		"\u001a\u0001\u001a\u0001\u001a\u0001\u001a\u0001\u001a\u0001\u001a\u0001"+
		"\u001a\u0001\u001a\u0001\u001a\u0001\u001a\u0001\u001a\u0003\u001a\u0146"+
		"\b\u001a\u0001\u001b\u0001\u001b\u0001\u001c\u0001\u001c\u0001\u001c\u0001"+
		"\u001c\u0001\u001c\u0001\u001d\u0001\u001d\u0001\u001e\u0001\u001e\u0001"+
		"\u001f\u0001\u001f\u0001\u001f\u0000\b\f&(*,.02 \u0000\u0002\u0004\u0006"+
		"\b\n\f\u000e\u0010\u0012\u0014\u0016\u0018\u001a\u001c\u001e \"$&(*,."+
		"02468:<>\u0000\u0004\u0002\u0000\u0003\u0005\u0007\t\u0001\u0000;<\u0001"+
		"\u0000!&\u0001\u0000\u0001\u0002\u0159\u0000@\u0001\u0000\u0000\u0000"+
		"\u0002J\u0001\u0000\u0000\u0000\u0004L\u0001\u0000\u0000\u0000\u0006O"+
		"\u0001\u0000\u0000\u0000\bR\u0001\u0000\u0000\u0000\n^\u0001\u0000\u0000"+
		"\u0000\f`\u0001\u0000\u0000\u0000\u000ek\u0001\u0000\u0000\u0000\u0010"+
		"n\u0001\u0000\u0000\u0000\u0012w\u0001\u0000\u0000\u0000\u0014y\u0001"+
		"\u0000\u0000\u0000\u0016\u0087\u0001\u0000\u0000\u0000\u0018\u0097\u0001"+
		"\u0000\u0000\u0000\u001a\u00a9\u0001\u0000\u0000\u0000\u001c\u00b3\u0001"+
		"\u0000\u0000\u0000\u001e\u00bb\u0001\u0000\u0000\u0000 \u00c5\u0001\u0000"+
		"\u0000\u0000\"\u00c7\u0001\u0000\u0000\u0000$\u00d3\u0001\u0000\u0000"+
		"\u0000&\u00d5\u0001\u0000\u0000\u0000(\u00e0\u0001\u0000\u0000\u0000*"+
		"\u00eb\u0001\u0000\u0000\u0000,\u00f9\u0001\u0000\u0000\u0000.\u010d\u0001"+
		"\u0000\u0000\u00000\u011b\u0001\u0000\u0000\u00002\u0129\u0001\u0000\u0000"+
		"\u00004\u0145\u0001\u0000\u0000\u00006\u0147\u0001\u0000\u0000\u00008"+
		"\u0149\u0001\u0000\u0000\u0000:\u014e\u0001\u0000\u0000\u0000<\u0150\u0001"+
		"\u0000\u0000\u0000>\u0152\u0001\u0000\u0000\u0000@A\u0003\u0004\u0002"+
		"\u0000AE\u0003\u0006\u0003\u0000BD\u0003\u0002\u0001\u0000CB\u0001\u0000"+
		"\u0000\u0000DG\u0001\u0000\u0000\u0000EC\u0001\u0000\u0000\u0000EF\u0001"+
		"\u0000\u0000\u0000F\u0001\u0001\u0000\u0000\u0000GE\u0001\u0000\u0000"+
		"\u0000HK\u0003\b\u0004\u0000IK\u0003\u0010\b\u0000JH\u0001\u0000\u0000"+
		"\u0000JI\u0001\u0000\u0000\u0000K\u0003\u0001\u0000\u0000\u0000LM\u0005"+
		"\u000b\u0000\u0000MN\u0003\u0014\n\u0000N\u0005\u0001\u0000\u0000\u0000"+
		"OP\u0005\n\u0000\u0000PQ\u0003\u0014\n\u0000Q\u0007\u0001\u0000\u0000"+
		"\u0000RS\u0003\n\u0005\u0000ST\u0003:\u001d\u0000TX\u0005\u0016\u0000"+
		"\u0000UW\u0003\f\u0006\u0000VU\u0001\u0000\u0000\u0000WZ\u0001\u0000\u0000"+
		"\u0000XV\u0001\u0000\u0000\u0000XY\u0001\u0000\u0000\u0000Y[\u0001\u0000"+
		"\u0000\u0000ZX\u0001\u0000\u0000\u0000[\\\u0005\u0017\u0000\u0000\\]\u0003"+
		"\u0014\n\u0000]\t\u0001\u0000\u0000\u0000^_\u0007\u0000\u0000\u0000_\u000b"+
		"\u0001\u0000\u0000\u0000`a\u0006\u0006\uffff\uffff\u0000ab\u0003\u000e"+
		"\u0007\u0000bh\u0001\u0000\u0000\u0000cd\n\u0001\u0000\u0000de\u0005\u001e"+
		"\u0000\u0000eg\u0003\u000e\u0007\u0000fc\u0001\u0000\u0000\u0000gj\u0001"+
		"\u0000\u0000\u0000hf\u0001\u0000\u0000\u0000hi\u0001\u0000\u0000\u0000"+
		"i\r\u0001\u0000\u0000\u0000jh\u0001\u0000\u0000\u0000kl\u0003\n\u0005"+
		"\u0000lm\u0003:\u001d\u0000m\u000f\u0001\u0000\u0000\u0000no\u0003\n\u0005"+
		"\u0000op\u0003\u0012\t\u0000pq\u0005\u001c\u0000\u0000q\u0011\u0001\u0000"+
		"\u0000\u0000rx\u0003:\u001d\u0000st\u0003:\u001d\u0000tu\u0005!\u0000"+
		"\u0000uv\u0003\u001e\u000f\u0000vx\u0001\u0000\u0000\u0000wr\u0001\u0000"+
		"\u0000\u0000ws\u0001\u0000\u0000\u0000x\u0013\u0001\u0000\u0000\u0000"+
		"y}\u0005\u0018\u0000\u0000z|\u0003\u0016\u000b\u0000{z\u0001\u0000\u0000"+
		"\u0000|\u007f\u0001\u0000\u0000\u0000}{\u0001\u0000\u0000\u0000}~\u0001"+
		"\u0000\u0000\u0000~\u0080\u0001\u0000\u0000\u0000\u007f}\u0001\u0000\u0000"+
		"\u0000\u0080\u0081\u0005\u0019\u0000\u0000\u0081\u0015\u0001\u0000\u0000"+
		"\u0000\u0082\u0088\u0003\u0018\f\u0000\u0083\u0088\u0003\u001a\r\u0000"+
		"\u0084\u0088\u0003\u001c\u000e\u0000\u0085\u0088\u0003\u0010\b\u0000\u0086"+
		"\u0088\u0003\"\u0011\u0000\u0087\u0082\u0001\u0000\u0000\u0000\u0087\u0083"+
		"\u0001\u0000\u0000\u0000\u0087\u0084\u0001\u0000\u0000\u0000\u0087\u0085"+
		"\u0001\u0000\u0000\u0000\u0087\u0086\u0001\u0000\u0000\u0000\u0088\u0017"+
		"\u0001\u0000\u0000\u0000\u0089\u008a\u0005\u000e\u0000\u0000\u008a\u008b"+
		"\u0005\u0016\u0000\u0000\u008b\u008c\u0003\u001e\u000f\u0000\u008c\u008d"+
		"\u0005\u0017\u0000\u0000\u008d\u008e\u0003\u0014\n\u0000\u008e\u0098\u0001"+
		"\u0000\u0000\u0000\u008f\u0090\u0005\u000e\u0000\u0000\u0090\u0091\u0005"+
		"\u0016\u0000\u0000\u0091\u0092\u0003\u001e\u000f\u0000\u0092\u0093\u0005"+
		"\u0017\u0000\u0000\u0093\u0094\u0003\u0014\n\u0000\u0094\u0095\u0005\u000f"+
		"\u0000\u0000\u0095\u0096\u0003\u0014\n\u0000\u0096\u0098\u0001\u0000\u0000"+
		"\u0000\u0097\u0089\u0001\u0000\u0000\u0000\u0097\u008f\u0001\u0000\u0000"+
		"\u0000\u0098\u0019\u0001\u0000\u0000\u0000\u0099\u009a\u0005\u0010\u0000"+
		"\u0000\u009a\u009b\u0005\u0016\u0000\u0000\u009b\u009c\u0003\u001e\u000f"+
		"\u0000\u009c\u009d\u0005\u0017\u0000\u0000\u009d\u009e\u0003\u0014\n\u0000"+
		"\u009e\u00aa\u0001\u0000\u0000\u0000\u009f\u00a0\u0005\u0011\u0000\u0000"+
		"\u00a0\u00a1\u0005\u0016\u0000\u0000\u00a1\u00a2\u0003\u001e\u000f\u0000"+
		"\u00a2\u00a3\u0005\u001c\u0000\u0000\u00a3\u00a4\u0003\u001e\u000f\u0000"+
		"\u00a4\u00a5\u0005\u001c\u0000\u0000\u00a5\u00a6\u0003\u001e\u000f\u0000"+
		"\u00a6\u00a7\u0005\u0017\u0000\u0000\u00a7\u00a8\u0003\u0014\n\u0000\u00a8"+
		"\u00aa\u0001\u0000\u0000\u0000\u00a9\u0099\u0001\u0000\u0000\u0000\u00a9"+
		"\u009f\u0001\u0000\u0000\u0000\u00aa\u001b\u0001\u0000\u0000\u0000\u00ab"+
		"\u00ac\u0005\u0012\u0000\u0000\u00ac\u00b4\u0005\u001c\u0000\u0000\u00ad"+
		"\u00ae\u0005\u0013\u0000\u0000\u00ae\u00b4\u0005\u001c\u0000\u0000\u00af"+
		"\u00b0\u0005\u0014\u0000\u0000\u00b0\u00b1\u0003\u001e\u000f\u0000\u00b1"+
		"\u00b2\u0005\u001c\u0000\u0000\u00b2\u00b4\u0001\u0000\u0000\u0000\u00b3"+
		"\u00ab\u0001\u0000\u0000\u0000\u00b3\u00ad\u0001\u0000\u0000\u0000\u00b3"+
		"\u00af\u0001\u0000\u0000\u0000\u00b4\u001d\u0001\u0000\u0000\u0000\u00b5"+
		"\u00b6\u00038\u001c\u0000\u00b6\u00b7\u0005\u001c\u0000\u0000\u00b7\u00bc"+
		"\u0001\u0000\u0000\u0000\u00b8\u00b9\u0003$\u0012\u0000\u00b9\u00ba\u0005"+
		"\u001c\u0000\u0000\u00ba\u00bc\u0001\u0000\u0000\u0000\u00bb\u00b5\u0001"+
		"\u0000\u0000\u0000\u00bb\u00b8\u0001\u0000\u0000\u0000\u00bc\u001f\u0001"+
		"\u0000\u0000\u0000\u00bd\u00c6\u0003$\u0012\u0000\u00be\u00c1\u00034\u001a"+
		"\u0000\u00bf\u00c1\u0003:\u001d\u0000\u00c0\u00be\u0001\u0000\u0000\u0000"+
		"\u00c0\u00bf\u0001\u0000\u0000\u0000\u00c1\u00c2\u0001\u0000\u0000\u0000"+
		"\u00c2\u00c3\u0003<\u001e\u0000\u00c3\u00c4\u0003 \u0010\u0000\u00c4\u00c6"+
		"\u0001\u0000\u0000\u0000\u00c5\u00bd\u0001\u0000\u0000\u0000\u00c5\u00c0"+
		"\u0001\u0000\u0000\u0000\u00c6!\u0001\u0000\u0000\u0000\u00c7\u00c8\u0003"+
		":\u001d\u0000\u00c8\u00c9\u0003<\u001e\u0000\u00c9\u00ca\u0003\u001e\u000f"+
		"\u0000\u00ca\u00cb\u0005\u001c\u0000\u0000\u00cb#\u0001\u0000\u0000\u0000"+
		"\u00cc\u00d4\u0003&\u0013\u0000\u00cd\u00ce\u0003&\u0013\u0000\u00ce\u00cf"+
		"\u0005\u0015\u0000\u0000\u00cf\u00d0\u0003\u001e\u000f\u0000\u00d0\u00d1"+
		"\u0005\u001f\u0000\u0000\u00d1\u00d2\u0003\u001e\u000f\u0000\u00d2\u00d4"+
		"\u0001\u0000\u0000\u0000\u00d3\u00cc\u0001\u0000\u0000\u0000\u00d3\u00cd"+
		"\u0001\u0000\u0000\u0000\u00d4%\u0001\u0000\u0000\u0000\u00d5\u00d6\u0006"+
		"\u0013\uffff\uffff\u0000\u00d6\u00d7\u0003(\u0014\u0000\u00d7\u00dd\u0001"+
		"\u0000\u0000\u0000\u00d8\u00d9\n\u0001\u0000\u0000\u00d9\u00da\u0005."+
		"\u0000\u0000\u00da\u00dc\u0003(\u0014\u0000\u00db\u00d8\u0001\u0000\u0000"+
		"\u0000\u00dc\u00df\u0001\u0000\u0000\u0000\u00dd\u00db\u0001\u0000\u0000"+
		"\u0000\u00dd\u00de\u0001\u0000\u0000\u0000\u00de\'\u0001\u0000\u0000\u0000"+
		"\u00df\u00dd\u0001\u0000\u0000\u0000\u00e0\u00e1\u0006\u0014\uffff\uffff"+
		"\u0000\u00e1\u00e2\u0003*\u0015\u0000\u00e2\u00e8\u0001\u0000\u0000\u0000"+
		"\u00e3\u00e4\n\u0001\u0000\u0000\u00e4\u00e5\u0005-\u0000\u0000\u00e5"+
		"\u00e7\u0003*\u0015\u0000\u00e6\u00e3\u0001\u0000\u0000\u0000\u00e7\u00ea"+
		"\u0001\u0000\u0000\u0000\u00e8\u00e6\u0001\u0000\u0000\u0000\u00e8\u00e9"+
		"\u0001\u0000\u0000\u0000\u00e9)\u0001\u0000\u0000\u0000\u00ea\u00e8\u0001"+
		"\u0000\u0000\u0000\u00eb\u00ec\u0006\u0015\uffff\uffff\u0000\u00ec\u00ed"+
		"\u0003,\u0016\u0000\u00ed\u00f6\u0001\u0000\u0000\u0000\u00ee\u00ef\n"+
		"\u0002\u0000\u0000\u00ef\u00f0\u0005/\u0000\u0000\u00f0\u00f5\u0003,\u0016"+
		"\u0000\u00f1\u00f2\n\u0001\u0000\u0000\u00f2\u00f3\u00050\u0000\u0000"+
		"\u00f3\u00f5\u0003,\u0016\u0000\u00f4\u00ee\u0001\u0000\u0000\u0000\u00f4"+
		"\u00f1\u0001\u0000\u0000\u0000\u00f5\u00f8\u0001\u0000\u0000\u0000\u00f6"+
		"\u00f4\u0001\u0000\u0000\u0000\u00f6\u00f7\u0001\u0000\u0000\u0000\u00f7"+
		"+\u0001\u0000\u0000\u0000\u00f8\u00f6\u0001\u0000\u0000\u0000\u00f9\u00fa"+
		"\u0006\u0016\uffff\uffff\u0000\u00fa\u00fb\u0003.\u0017\u0000\u00fb\u010a"+
		"\u0001\u0000\u0000\u0000\u00fc\u00fd\n\u0004\u0000\u0000\u00fd\u00fe\u0005"+
		"2\u0000\u0000\u00fe\u0109\u0003.\u0017\u0000\u00ff\u0100\n\u0003\u0000"+
		"\u0000\u0100\u0101\u00051\u0000\u0000\u0101\u0109\u0003.\u0017\u0000\u0102"+
		"\u0103\n\u0002\u0000\u0000\u0103\u0104\u00054\u0000\u0000\u0104\u0109"+
		"\u0003.\u0017\u0000\u0105\u0106\n\u0001\u0000\u0000\u0106\u0107\u0005"+
		"3\u0000\u0000\u0107\u0109\u0003.\u0017\u0000\u0108\u00fc\u0001\u0000\u0000"+
		"\u0000\u0108\u00ff\u0001\u0000\u0000\u0000\u0108\u0102\u0001\u0000\u0000"+
		"\u0000\u0108\u0105\u0001\u0000\u0000\u0000\u0109\u010c\u0001\u0000\u0000"+
		"\u0000\u010a\u0108\u0001\u0000\u0000\u0000\u010a\u010b\u0001\u0000\u0000"+
		"\u0000\u010b-\u0001\u0000\u0000\u0000\u010c\u010a\u0001\u0000\u0000\u0000"+
		"\u010d\u010e\u0006\u0017\uffff\uffff\u0000\u010e\u010f\u00030\u0018\u0000"+
		"\u010f\u0118\u0001\u0000\u0000\u0000\u0110\u0111\n\u0002\u0000\u0000\u0111"+
		"\u0112\u00056\u0000\u0000\u0112\u0117\u00030\u0018\u0000\u0113\u0114\n"+
		"\u0001\u0000\u0000\u0114\u0115\u00057\u0000\u0000\u0115\u0117\u00030\u0018"+
		"\u0000\u0116\u0110\u0001\u0000\u0000\u0000\u0116\u0113\u0001\u0000\u0000"+
		"\u0000\u0117\u011a\u0001\u0000\u0000\u0000\u0118\u0116\u0001\u0000\u0000"+
		"\u0000\u0118\u0119\u0001\u0000\u0000\u0000\u0119/\u0001\u0000\u0000\u0000"+
		"\u011a\u0118\u0001\u0000\u0000\u0000\u011b\u011c\u0006\u0018\uffff\uffff"+
		"\u0000\u011c\u011d\u00032\u0019\u0000\u011d\u0126\u0001\u0000\u0000\u0000"+
		"\u011e\u011f\n\u0002\u0000\u0000\u011f\u0120\u0005*\u0000\u0000\u0120"+
		"\u0125\u00032\u0019\u0000\u0121\u0122\n\u0001\u0000\u0000\u0122\u0123"+
		"\u0005+\u0000\u0000\u0123\u0125\u00032\u0019\u0000\u0124\u011e\u0001\u0000"+
		"\u0000\u0000\u0124\u0121\u0001\u0000\u0000\u0000\u0125\u0128\u0001\u0000"+
		"\u0000\u0000\u0126\u0124\u0001\u0000\u0000\u0000\u0126\u0127\u0001\u0000"+
		"\u0000\u0000\u01271\u0001\u0000\u0000\u0000\u0128\u0126\u0001\u0000\u0000"+
		"\u0000\u0129\u012a\u0006\u0019\uffff\uffff\u0000\u012a\u012b\u00034\u001a"+
		"\u0000\u012b\u0137\u0001\u0000\u0000\u0000\u012c\u012d\n\u0003\u0000\u0000"+
		"\u012d\u012e\u0005(\u0000\u0000\u012e\u0136\u00036\u001b\u0000\u012f\u0130"+
		"\n\u0002\u0000\u0000\u0130\u0131\u0005)\u0000\u0000\u0131\u0136\u0003"+
		"6\u001b\u0000\u0132\u0133\n\u0001\u0000\u0000\u0133\u0134\u0005,\u0000"+
		"\u0000\u0134\u0136\u00036\u001b\u0000\u0135\u012c\u0001\u0000\u0000\u0000"+
		"\u0135\u012f\u0001\u0000\u0000\u0000\u0135\u0132\u0001\u0000\u0000\u0000"+
		"\u0136\u0139\u0001\u0000\u0000\u0000\u0137\u0135\u0001\u0000\u0000\u0000"+
		"\u0137\u0138\u0001\u0000\u0000\u0000\u01383\u0001\u0000\u0000\u0000\u0139"+
		"\u0137\u0001\u0000\u0000\u0000\u013a\u0146\u00036\u001b\u0000\u013b\u013c"+
		"\u00036\u001b\u0000\u013c\u013d\u00058\u0000\u0000\u013d\u0146\u0001\u0000"+
		"\u0000\u0000\u013e\u013f\u00036\u001b\u0000\u013f\u0140\u00059\u0000\u0000"+
		"\u0140\u0146\u0001\u0000\u0000\u0000\u0141\u0142\u00058\u0000\u0000\u0142"+
		"\u0146\u00036\u001b\u0000\u0143\u0144\u00059\u0000\u0000\u0144\u0146\u0003"+
		"6\u001b\u0000\u0145\u013a\u0001\u0000\u0000\u0000\u0145\u013b\u0001\u0000"+
		"\u0000\u0000\u0145\u013e\u0001\u0000\u0000\u0000\u0145\u0141\u0001\u0000"+
		"\u0000\u0000\u0145\u0143\u0001\u0000\u0000\u0000\u01465\u0001\u0000\u0000"+
		"\u0000\u0147\u0148\u0007\u0001\u0000\u0000\u01487\u0001\u0000\u0000\u0000"+
		"\u0149\u014a\u0005\f\u0000\u0000\u014a\u014b\u0003:\u001d\u0000\u014b"+
		"\u014c\u0005\r\u0000\u0000\u014c\u014d\u0003>\u001f\u0000\u014d9\u0001"+
		"\u0000\u0000\u0000\u014e\u014f\u0005:\u0000\u0000\u014f;\u0001\u0000\u0000"+
		"\u0000\u0150\u0151\u0007\u0002\u0000\u0000\u0151=\u0001\u0000\u0000\u0000"+
		"\u0152\u0153\u0007\u0003\u0000\u0000\u0153?\u0001\u0000\u0000\u0000\u001b"+
		"EJXhw}\u0087\u0097\u00a9\u00b3\u00bb\u00c0\u00c5\u00d3\u00dd\u00e8\u00f4"+
		"\u00f6\u0108\u010a\u0116\u0118\u0124\u0126\u0135\u0137\u0145";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}