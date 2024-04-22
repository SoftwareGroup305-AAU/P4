// Generated from /home/rasmus/Documents/GitHub/P4/P4.TinyCell/Languages/TinyCell/TinyCell.g4 by ANTLR 4.13.1
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
		RULE_assignmentExpression = 16, RULE_functionCall = 17, RULE_assignment = 18, 
		RULE_pinExpression = 19, RULE_ternaryExpression = 20, RULE_orExpression = 21, 
		RULE_andExpression = 22, RULE_equalityExpression = 23, RULE_comparisonExpression = 24, 
		RULE_bitshiftExpression = 25, RULE_additiveExpression = 26, RULE_multiplicativeExpression = 27, 
		RULE_unaryExpression = 28, RULE_primitiveExpression = 29, RULE_identifier = 30, 
		RULE_assignmentOperator = 31, RULE_pinVoltage = 32;
	private static String[] makeRuleNames() {
		return new String[] {
			"document", "generalDeclaration", "setupDefinition", "updateDefinition", 
			"functionDefinition", "type", "parameterList", "parameter", "declaration", 
			"initialDeclaration", "compoundStatement", "statement", "ifStatement", 
			"loopStatement", "jumpStatement", "expression", "assignmentExpression", 
			"functionCall", "assignment", "pinExpression", "ternaryExpression", "orExpression", 
			"andExpression", "equalityExpression", "comparisonExpression", "bitshiftExpression", 
			"additiveExpression", "multiplicativeExpression", "unaryExpression", 
			"primitiveExpression", "identifier", "assignmentOperator", "pinVoltage"
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
			setState(66);
			setupDefinition();
			setState(67);
			updateDefinition();
			setState(71);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & 952L) != 0)) {
				{
				{
				setState(68);
				generalDeclaration();
				}
				}
				setState(73);
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
			setState(76);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,1,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(74);
				functionDefinition();
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(75);
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
			setState(78);
			match(SETUP);
			setState(79);
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
			setState(81);
			match(UPDATE);
			setState(82);
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
			setState(84);
			type();
			setState(85);
			identifier();
			setState(86);
			match(LPAR);
			setState(90);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & 952L) != 0)) {
				{
				{
				setState(87);
				parameterList(0);
				}
				}
				setState(92);
				_errHandler.sync(this);
				_la = _input.LA(1);
			}
			setState(93);
			match(RPAR);
			setState(94);
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
			setState(96);
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
			setState(99);
			parameter();
			}
			_ctx.stop = _input.LT(-1);
			setState(106);
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
					setState(101);
					if (!(precpred(_ctx, 1))) throw new FailedPredicateException(this, "precpred(_ctx, 1)");
					setState(102);
					match(COMMA);
					setState(103);
					parameter();
					}
					} 
				}
				setState(108);
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
			setState(109);
			type();
			setState(110);
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
			setState(112);
			type();
			setState(113);
			initialDeclaration();
			setState(114);
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
			setState(121);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,4,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(116);
				identifier();
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(117);
				identifier();
				setState(118);
				match(ASSIGN);
				setState(119);
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
			setState(123);
			match(LCURLY);
			setState(127);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & 2233785415177819064L) != 0)) {
				{
				{
				setState(124);
				statement();
				}
				}
				setState(129);
				_errHandler.sync(this);
				_la = _input.LA(1);
			}
			setState(130);
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
		public FunctionCallContext functionCall() {
			return getRuleContext(FunctionCallContext.class,0);
		}
		public AssignmentContext assignment() {
			return getRuleContext(AssignmentContext.class,0);
		}
		public ExpressionContext expression() {
			return getRuleContext(ExpressionContext.class,0);
		}
		public TerminalNode SEMI() { return getToken(TinyCellParser.SEMI, 0); }
		public StatementContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_statement; }
	}

	public final StatementContext statement() throws RecognitionException {
		StatementContext _localctx = new StatementContext(_ctx, getState());
		enterRule(_localctx, 22, RULE_statement);
		try {
			setState(141);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,6,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(132);
				ifStatement();
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(133);
				loopStatement();
				}
				break;
			case 3:
				enterOuterAlt(_localctx, 3);
				{
				setState(134);
				jumpStatement();
				}
				break;
			case 4:
				enterOuterAlt(_localctx, 4);
				{
				setState(135);
				declaration();
				}
				break;
			case 5:
				enterOuterAlt(_localctx, 5);
				{
				setState(136);
				functionCall();
				}
				break;
			case 6:
				enterOuterAlt(_localctx, 6);
				{
				setState(137);
				assignment();
				}
				break;
			case 7:
				enterOuterAlt(_localctx, 7);
				{
				setState(138);
				expression();
				setState(139);
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
		enterRule(_localctx, 24, RULE_ifStatement);
		try {
			setState(157);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,7,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
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
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(149);
				match(IF);
				setState(150);
				match(LPAR);
				setState(151);
				expression();
				setState(152);
				match(RPAR);
				setState(153);
				compoundStatement();
				setState(154);
				match(ELSE);
				setState(155);
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
			setState(175);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case WHILE:
				enterOuterAlt(_localctx, 1);
				{
				setState(159);
				match(WHILE);
				setState(160);
				match(LPAR);
				setState(161);
				expression();
				setState(162);
				match(RPAR);
				setState(163);
				compoundStatement();
				}
				break;
			case FOR:
				enterOuterAlt(_localctx, 2);
				{
				setState(165);
				match(FOR);
				setState(166);
				match(LPAR);
				setState(167);
				expression();
				setState(168);
				match(SEMI);
				setState(169);
				expression();
				setState(170);
				match(SEMI);
				setState(171);
				expression();
				setState(172);
				match(RPAR);
				setState(173);
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
			setState(185);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case CONTINUE:
				enterOuterAlt(_localctx, 1);
				{
				setState(177);
				match(CONTINUE);
				setState(178);
				match(SEMI);
				}
				break;
			case BREAK:
				enterOuterAlt(_localctx, 2);
				{
				setState(179);
				match(BREAK);
				setState(180);
				match(SEMI);
				}
				break;
			case RETURN:
				enterOuterAlt(_localctx, 3);
				{
				setState(181);
				match(RETURN);
				setState(182);
				expression();
				setState(183);
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
		public ExpressionContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_expression; }
	}

	public final ExpressionContext expression() throws RecognitionException {
		ExpressionContext _localctx = new ExpressionContext(_ctx, getState());
		enterRule(_localctx, 30, RULE_expression);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(187);
			pinExpression();
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
			switch ( getInterpreter().adaptivePredict(_input,11,_ctx) ) {
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
	public static class FunctionCallContext extends ParserRuleContext {
		public IdentifierContext identifier() {
			return getRuleContext(IdentifierContext.class,0);
		}
		public TerminalNode LPAR() { return getToken(TinyCellParser.LPAR, 0); }
		public TerminalNode RPAR() { return getToken(TinyCellParser.RPAR, 0); }
		public TerminalNode SEMI() { return getToken(TinyCellParser.SEMI, 0); }
		public List<ParameterListContext> parameterList() {
			return getRuleContexts(ParameterListContext.class);
		}
		public ParameterListContext parameterList(int i) {
			return getRuleContext(ParameterListContext.class,i);
		}
		public FunctionCallContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_functionCall; }
	}

	public final FunctionCallContext functionCall() throws RecognitionException {
		FunctionCallContext _localctx = new FunctionCallContext(_ctx, getState());
		enterRule(_localctx, 34, RULE_functionCall);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(199);
			identifier();
			setState(200);
			match(LPAR);
			setState(204);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & 952L) != 0)) {
				{
				{
				setState(201);
				parameterList(0);
				}
				}
				setState(206);
				_errHandler.sync(this);
				_la = _input.LA(1);
			}
			setState(207);
			match(RPAR);
			setState(208);
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
		enterRule(_localctx, 36, RULE_assignment);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(210);
			identifier();
			setState(211);
			assignmentOperator();
			setState(212);
			expression();
			setState(213);
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
		enterRule(_localctx, 38, RULE_pinExpression);
		try {
			setState(221);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case UNARYPLUS:
			case UNARYMINUS:
			case String:
			case Numeral:
				enterOuterAlt(_localctx, 1);
				{
				setState(215);
				ternaryExpression();
				}
				break;
			case SET:
				enterOuterAlt(_localctx, 2);
				{
				setState(216);
				match(SET);
				setState(217);
				identifier();
				setState(218);
				match(TO);
				setState(219);
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
		enterRule(_localctx, 40, RULE_ternaryExpression);
		try {
			setState(230);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,14,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(223);
				orExpression(0);
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(224);
				orExpression(0);
				setState(225);
				match(QUESTION);
				setState(226);
				expression();
				setState(227);
				match(COLON);
				setState(228);
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
		int _startState = 42;
		enterRecursionRule(_localctx, 42, RULE_orExpression, _p);
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			{
			setState(233);
			andExpression(0);
			}
			_ctx.stop = _input.LT(-1);
			setState(240);
			_errHandler.sync(this);
			_alt = getInterpreter().adaptivePredict(_input,15,_ctx);
			while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( _parseListeners!=null ) triggerExitRuleEvent();
					_prevctx = _localctx;
					{
					{
					_localctx = new OrExpressionContext(_parentctx, _parentState);
					pushNewRecursionContext(_localctx, _startState, RULE_orExpression);
					setState(235);
					if (!(precpred(_ctx, 1))) throw new FailedPredicateException(this, "precpred(_ctx, 1)");
					setState(236);
					match(OR);
					setState(237);
					andExpression(0);
					}
					} 
				}
				setState(242);
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
		int _startState = 44;
		enterRecursionRule(_localctx, 44, RULE_andExpression, _p);
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			{
			setState(244);
			equalityExpression(0);
			}
			_ctx.stop = _input.LT(-1);
			setState(251);
			_errHandler.sync(this);
			_alt = getInterpreter().adaptivePredict(_input,16,_ctx);
			while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( _parseListeners!=null ) triggerExitRuleEvent();
					_prevctx = _localctx;
					{
					{
					_localctx = new AndExpressionContext(_parentctx, _parentState);
					pushNewRecursionContext(_localctx, _startState, RULE_andExpression);
					setState(246);
					if (!(precpred(_ctx, 1))) throw new FailedPredicateException(this, "precpred(_ctx, 1)");
					setState(247);
					match(AND);
					setState(248);
					equalityExpression(0);
					}
					} 
				}
				setState(253);
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,16,_ctx);
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
		int _startState = 46;
		enterRecursionRule(_localctx, 46, RULE_equalityExpression, _p);
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			{
			setState(255);
			comparisonExpression(0);
			}
			_ctx.stop = _input.LT(-1);
			setState(265);
			_errHandler.sync(this);
			_alt = getInterpreter().adaptivePredict(_input,18,_ctx);
			while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( _parseListeners!=null ) triggerExitRuleEvent();
					_prevctx = _localctx;
					{
					setState(263);
					_errHandler.sync(this);
					switch ( getInterpreter().adaptivePredict(_input,17,_ctx) ) {
					case 1:
						{
						_localctx = new EqualityExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_equalityExpression);
						setState(257);
						if (!(precpred(_ctx, 2))) throw new FailedPredicateException(this, "precpred(_ctx, 2)");
						setState(258);
						match(EQ);
						setState(259);
						comparisonExpression(0);
						}
						break;
					case 2:
						{
						_localctx = new EqualityExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_equalityExpression);
						setState(260);
						if (!(precpred(_ctx, 1))) throw new FailedPredicateException(this, "precpred(_ctx, 1)");
						setState(261);
						match(NEQ);
						setState(262);
						comparisonExpression(0);
						}
						break;
					}
					} 
				}
				setState(267);
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
			setState(269);
			bitshiftExpression(0);
			}
			_ctx.stop = _input.LT(-1);
			setState(285);
			_errHandler.sync(this);
			_alt = getInterpreter().adaptivePredict(_input,20,_ctx);
			while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( _parseListeners!=null ) triggerExitRuleEvent();
					_prevctx = _localctx;
					{
					setState(283);
					_errHandler.sync(this);
					switch ( getInterpreter().adaptivePredict(_input,19,_ctx) ) {
					case 1:
						{
						_localctx = new ComparisonExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_comparisonExpression);
						setState(271);
						if (!(precpred(_ctx, 4))) throw new FailedPredicateException(this, "precpred(_ctx, 4)");
						setState(272);
						match(LT);
						setState(273);
						bitshiftExpression(0);
						}
						break;
					case 2:
						{
						_localctx = new ComparisonExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_comparisonExpression);
						setState(274);
						if (!(precpred(_ctx, 3))) throw new FailedPredicateException(this, "precpred(_ctx, 3)");
						setState(275);
						match(GT);
						setState(276);
						bitshiftExpression(0);
						}
						break;
					case 3:
						{
						_localctx = new ComparisonExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_comparisonExpression);
						setState(277);
						if (!(precpred(_ctx, 2))) throw new FailedPredicateException(this, "precpred(_ctx, 2)");
						setState(278);
						match(LTE);
						setState(279);
						bitshiftExpression(0);
						}
						break;
					case 4:
						{
						_localctx = new ComparisonExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_comparisonExpression);
						setState(280);
						if (!(precpred(_ctx, 1))) throw new FailedPredicateException(this, "precpred(_ctx, 1)");
						setState(281);
						match(GTE);
						setState(282);
						bitshiftExpression(0);
						}
						break;
					}
					} 
				}
				setState(287);
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
		int _startState = 50;
		enterRecursionRule(_localctx, 50, RULE_bitshiftExpression, _p);
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			{
			setState(289);
			additiveExpression(0);
			}
			_ctx.stop = _input.LT(-1);
			setState(299);
			_errHandler.sync(this);
			_alt = getInterpreter().adaptivePredict(_input,22,_ctx);
			while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( _parseListeners!=null ) triggerExitRuleEvent();
					_prevctx = _localctx;
					{
					setState(297);
					_errHandler.sync(this);
					switch ( getInterpreter().adaptivePredict(_input,21,_ctx) ) {
					case 1:
						{
						_localctx = new BitshiftExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_bitshiftExpression);
						setState(291);
						if (!(precpred(_ctx, 2))) throw new FailedPredicateException(this, "precpred(_ctx, 2)");
						setState(292);
						match(BITSHIFTL);
						setState(293);
						additiveExpression(0);
						}
						break;
					case 2:
						{
						_localctx = new BitshiftExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_bitshiftExpression);
						setState(294);
						if (!(precpred(_ctx, 1))) throw new FailedPredicateException(this, "precpred(_ctx, 1)");
						setState(295);
						match(BITSHIFTR);
						setState(296);
						additiveExpression(0);
						}
						break;
					}
					} 
				}
				setState(301);
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
		int _startState = 52;
		enterRecursionRule(_localctx, 52, RULE_additiveExpression, _p);
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			{
			setState(303);
			multiplicativeExpression(0);
			}
			_ctx.stop = _input.LT(-1);
			setState(313);
			_errHandler.sync(this);
			_alt = getInterpreter().adaptivePredict(_input,24,_ctx);
			while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( _parseListeners!=null ) triggerExitRuleEvent();
					_prevctx = _localctx;
					{
					setState(311);
					_errHandler.sync(this);
					switch ( getInterpreter().adaptivePredict(_input,23,_ctx) ) {
					case 1:
						{
						_localctx = new AdditiveExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_additiveExpression);
						setState(305);
						if (!(precpred(_ctx, 2))) throw new FailedPredicateException(this, "precpred(_ctx, 2)");
						setState(306);
						match(PLUS);
						setState(307);
						multiplicativeExpression(0);
						}
						break;
					case 2:
						{
						_localctx = new AdditiveExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_additiveExpression);
						setState(308);
						if (!(precpred(_ctx, 1))) throw new FailedPredicateException(this, "precpred(_ctx, 1)");
						setState(309);
						match(MINUS);
						setState(310);
						multiplicativeExpression(0);
						}
						break;
					}
					} 
				}
				setState(315);
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
		int _startState = 54;
		enterRecursionRule(_localctx, 54, RULE_multiplicativeExpression, _p);
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			{
			setState(317);
			unaryExpression();
			}
			_ctx.stop = _input.LT(-1);
			setState(330);
			_errHandler.sync(this);
			_alt = getInterpreter().adaptivePredict(_input,26,_ctx);
			while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( _parseListeners!=null ) triggerExitRuleEvent();
					_prevctx = _localctx;
					{
					setState(328);
					_errHandler.sync(this);
					switch ( getInterpreter().adaptivePredict(_input,25,_ctx) ) {
					case 1:
						{
						_localctx = new MultiplicativeExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_multiplicativeExpression);
						setState(319);
						if (!(precpred(_ctx, 3))) throw new FailedPredicateException(this, "precpred(_ctx, 3)");
						setState(320);
						match(MULT);
						setState(321);
						primitiveExpression();
						}
						break;
					case 2:
						{
						_localctx = new MultiplicativeExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_multiplicativeExpression);
						setState(322);
						if (!(precpred(_ctx, 2))) throw new FailedPredicateException(this, "precpred(_ctx, 2)");
						setState(323);
						match(DIV);
						setState(324);
						primitiveExpression();
						}
						break;
					case 3:
						{
						_localctx = new MultiplicativeExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_multiplicativeExpression);
						setState(325);
						if (!(precpred(_ctx, 1))) throw new FailedPredicateException(this, "precpred(_ctx, 1)");
						setState(326);
						match(MOD);
						setState(327);
						primitiveExpression();
						}
						break;
					}
					} 
				}
				setState(332);
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
		enterRule(_localctx, 56, RULE_unaryExpression);
		try {
			setState(344);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,27,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(333);
				primitiveExpression();
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(334);
				primitiveExpression();
				setState(335);
				match(UNARYPLUS);
				}
				break;
			case 3:
				enterOuterAlt(_localctx, 3);
				{
				setState(337);
				primitiveExpression();
				setState(338);
				match(UNARYMINUS);
				}
				break;
			case 4:
				enterOuterAlt(_localctx, 4);
				{
				setState(340);
				match(UNARYPLUS);
				setState(341);
				primitiveExpression();
				}
				break;
			case 5:
				enterOuterAlt(_localctx, 5);
				{
				setState(342);
				match(UNARYMINUS);
				setState(343);
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
		enterRule(_localctx, 58, RULE_primitiveExpression);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(346);
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
	public static class IdentifierContext extends ParserRuleContext {
		public TerminalNode Identifier() { return getToken(TinyCellParser.Identifier, 0); }
		public IdentifierContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_identifier; }
	}

	public final IdentifierContext identifier() throws RecognitionException {
		IdentifierContext _localctx = new IdentifierContext(_ctx, getState());
		enterRule(_localctx, 60, RULE_identifier);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(348);
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
		enterRule(_localctx, 62, RULE_assignmentOperator);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(350);
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
		enterRule(_localctx, 64, RULE_pinVoltage);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(352);
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
		case 21:
			return orExpression_sempred((OrExpressionContext)_localctx, predIndex);
		case 22:
			return andExpression_sempred((AndExpressionContext)_localctx, predIndex);
		case 23:
			return equalityExpression_sempred((EqualityExpressionContext)_localctx, predIndex);
		case 24:
			return comparisonExpression_sempred((ComparisonExpressionContext)_localctx, predIndex);
		case 25:
			return bitshiftExpression_sempred((BitshiftExpressionContext)_localctx, predIndex);
		case 26:
			return additiveExpression_sempred((AdditiveExpressionContext)_localctx, predIndex);
		case 27:
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
		"\u0004\u0001>\u0163\u0002\u0000\u0007\u0000\u0002\u0001\u0007\u0001\u0002"+
		"\u0002\u0007\u0002\u0002\u0003\u0007\u0003\u0002\u0004\u0007\u0004\u0002"+
		"\u0005\u0007\u0005\u0002\u0006\u0007\u0006\u0002\u0007\u0007\u0007\u0002"+
		"\b\u0007\b\u0002\t\u0007\t\u0002\n\u0007\n\u0002\u000b\u0007\u000b\u0002"+
		"\f\u0007\f\u0002\r\u0007\r\u0002\u000e\u0007\u000e\u0002\u000f\u0007\u000f"+
		"\u0002\u0010\u0007\u0010\u0002\u0011\u0007\u0011\u0002\u0012\u0007\u0012"+
		"\u0002\u0013\u0007\u0013\u0002\u0014\u0007\u0014\u0002\u0015\u0007\u0015"+
		"\u0002\u0016\u0007\u0016\u0002\u0017\u0007\u0017\u0002\u0018\u0007\u0018"+
		"\u0002\u0019\u0007\u0019\u0002\u001a\u0007\u001a\u0002\u001b\u0007\u001b"+
		"\u0002\u001c\u0007\u001c\u0002\u001d\u0007\u001d\u0002\u001e\u0007\u001e"+
		"\u0002\u001f\u0007\u001f\u0002 \u0007 \u0001\u0000\u0001\u0000\u0001\u0000"+
		"\u0005\u0000F\b\u0000\n\u0000\f\u0000I\t\u0000\u0001\u0001\u0001\u0001"+
		"\u0003\u0001M\b\u0001\u0001\u0002\u0001\u0002\u0001\u0002\u0001\u0003"+
		"\u0001\u0003\u0001\u0003\u0001\u0004\u0001\u0004\u0001\u0004\u0001\u0004"+
		"\u0005\u0004Y\b\u0004\n\u0004\f\u0004\\\t\u0004\u0001\u0004\u0001\u0004"+
		"\u0001\u0004\u0001\u0005\u0001\u0005\u0001\u0006\u0001\u0006\u0001\u0006"+
		"\u0001\u0006\u0001\u0006\u0001\u0006\u0005\u0006i\b\u0006\n\u0006\f\u0006"+
		"l\t\u0006\u0001\u0007\u0001\u0007\u0001\u0007\u0001\b\u0001\b\u0001\b"+
		"\u0001\b\u0001\t\u0001\t\u0001\t\u0001\t\u0001\t\u0003\tz\b\t\u0001\n"+
		"\u0001\n\u0005\n~\b\n\n\n\f\n\u0081\t\n\u0001\n\u0001\n\u0001\u000b\u0001"+
		"\u000b\u0001\u000b\u0001\u000b\u0001\u000b\u0001\u000b\u0001\u000b\u0001"+
		"\u000b\u0001\u000b\u0003\u000b\u008e\b\u000b\u0001\f\u0001\f\u0001\f\u0001"+
		"\f\u0001\f\u0001\f\u0001\f\u0001\f\u0001\f\u0001\f\u0001\f\u0001\f\u0001"+
		"\f\u0001\f\u0003\f\u009e\b\f\u0001\r\u0001\r\u0001\r\u0001\r\u0001\r\u0001"+
		"\r\u0001\r\u0001\r\u0001\r\u0001\r\u0001\r\u0001\r\u0001\r\u0001\r\u0001"+
		"\r\u0001\r\u0003\r\u00b0\b\r\u0001\u000e\u0001\u000e\u0001\u000e\u0001"+
		"\u000e\u0001\u000e\u0001\u000e\u0001\u000e\u0001\u000e\u0003\u000e\u00ba"+
		"\b\u000e\u0001\u000f\u0001\u000f\u0001\u0010\u0001\u0010\u0001\u0010\u0003"+
		"\u0010\u00c1\b\u0010\u0001\u0010\u0001\u0010\u0001\u0010\u0003\u0010\u00c6"+
		"\b\u0010\u0001\u0011\u0001\u0011\u0001\u0011\u0005\u0011\u00cb\b\u0011"+
		"\n\u0011\f\u0011\u00ce\t\u0011\u0001\u0011\u0001\u0011\u0001\u0011\u0001"+
		"\u0012\u0001\u0012\u0001\u0012\u0001\u0012\u0001\u0012\u0001\u0013\u0001"+
		"\u0013\u0001\u0013\u0001\u0013\u0001\u0013\u0001\u0013\u0003\u0013\u00de"+
		"\b\u0013\u0001\u0014\u0001\u0014\u0001\u0014\u0001\u0014\u0001\u0014\u0001"+
		"\u0014\u0001\u0014\u0003\u0014\u00e7\b\u0014\u0001\u0015\u0001\u0015\u0001"+
		"\u0015\u0001\u0015\u0001\u0015\u0001\u0015\u0005\u0015\u00ef\b\u0015\n"+
		"\u0015\f\u0015\u00f2\t\u0015\u0001\u0016\u0001\u0016\u0001\u0016\u0001"+
		"\u0016\u0001\u0016\u0001\u0016\u0005\u0016\u00fa\b\u0016\n\u0016\f\u0016"+
		"\u00fd\t\u0016\u0001\u0017\u0001\u0017\u0001\u0017\u0001\u0017\u0001\u0017"+
		"\u0001\u0017\u0001\u0017\u0001\u0017\u0001\u0017\u0005\u0017\u0108\b\u0017"+
		"\n\u0017\f\u0017\u010b\t\u0017\u0001\u0018\u0001\u0018\u0001\u0018\u0001"+
		"\u0018\u0001\u0018\u0001\u0018\u0001\u0018\u0001\u0018\u0001\u0018\u0001"+
		"\u0018\u0001\u0018\u0001\u0018\u0001\u0018\u0001\u0018\u0001\u0018\u0005"+
		"\u0018\u011c\b\u0018\n\u0018\f\u0018\u011f\t\u0018\u0001\u0019\u0001\u0019"+
		"\u0001\u0019\u0001\u0019\u0001\u0019\u0001\u0019\u0001\u0019\u0001\u0019"+
		"\u0001\u0019\u0005\u0019\u012a\b\u0019\n\u0019\f\u0019\u012d\t\u0019\u0001"+
		"\u001a\u0001\u001a\u0001\u001a\u0001\u001a\u0001\u001a\u0001\u001a\u0001"+
		"\u001a\u0001\u001a\u0001\u001a\u0005\u001a\u0138\b\u001a\n\u001a\f\u001a"+
		"\u013b\t\u001a\u0001\u001b\u0001\u001b\u0001\u001b\u0001\u001b\u0001\u001b"+
		"\u0001\u001b\u0001\u001b\u0001\u001b\u0001\u001b\u0001\u001b\u0001\u001b"+
		"\u0001\u001b\u0005\u001b\u0149\b\u001b\n\u001b\f\u001b\u014c\t\u001b\u0001"+
		"\u001c\u0001\u001c\u0001\u001c\u0001\u001c\u0001\u001c\u0001\u001c\u0001"+
		"\u001c\u0001\u001c\u0001\u001c\u0001\u001c\u0001\u001c\u0003\u001c\u0159"+
		"\b\u001c\u0001\u001d\u0001\u001d\u0001\u001e\u0001\u001e\u0001\u001f\u0001"+
		"\u001f\u0001 \u0001 \u0001 \u0000\b\f*,.0246!\u0000\u0002\u0004\u0006"+
		"\b\n\f\u000e\u0010\u0012\u0014\u0016\u0018\u001a\u001c\u001e \"$&(*,."+
		"02468:<>@\u0000\u0004\u0002\u0000\u0003\u0005\u0007\t\u0001\u0000;<\u0001"+
		"\u0000!&\u0001\u0000\u0001\u0002\u0169\u0000B\u0001\u0000\u0000\u0000"+
		"\u0002L\u0001\u0000\u0000\u0000\u0004N\u0001\u0000\u0000\u0000\u0006Q"+
		"\u0001\u0000\u0000\u0000\bT\u0001\u0000\u0000\u0000\n`\u0001\u0000\u0000"+
		"\u0000\fb\u0001\u0000\u0000\u0000\u000em\u0001\u0000\u0000\u0000\u0010"+
		"p\u0001\u0000\u0000\u0000\u0012y\u0001\u0000\u0000\u0000\u0014{\u0001"+
		"\u0000\u0000\u0000\u0016\u008d\u0001\u0000\u0000\u0000\u0018\u009d\u0001"+
		"\u0000\u0000\u0000\u001a\u00af\u0001\u0000\u0000\u0000\u001c\u00b9\u0001"+
		"\u0000\u0000\u0000\u001e\u00bb\u0001\u0000\u0000\u0000 \u00c5\u0001\u0000"+
		"\u0000\u0000\"\u00c7\u0001\u0000\u0000\u0000$\u00d2\u0001\u0000\u0000"+
		"\u0000&\u00dd\u0001\u0000\u0000\u0000(\u00e6\u0001\u0000\u0000\u0000*"+
		"\u00e8\u0001\u0000\u0000\u0000,\u00f3\u0001\u0000\u0000\u0000.\u00fe\u0001"+
		"\u0000\u0000\u00000\u010c\u0001\u0000\u0000\u00002\u0120\u0001\u0000\u0000"+
		"\u00004\u012e\u0001\u0000\u0000\u00006\u013c\u0001\u0000\u0000\u00008"+
		"\u0158\u0001\u0000\u0000\u0000:\u015a\u0001\u0000\u0000\u0000<\u015c\u0001"+
		"\u0000\u0000\u0000>\u015e\u0001\u0000\u0000\u0000@\u0160\u0001\u0000\u0000"+
		"\u0000BC\u0003\u0004\u0002\u0000CG\u0003\u0006\u0003\u0000DF\u0003\u0002"+
		"\u0001\u0000ED\u0001\u0000\u0000\u0000FI\u0001\u0000\u0000\u0000GE\u0001"+
		"\u0000\u0000\u0000GH\u0001\u0000\u0000\u0000H\u0001\u0001\u0000\u0000"+
		"\u0000IG\u0001\u0000\u0000\u0000JM\u0003\b\u0004\u0000KM\u0003\u0010\b"+
		"\u0000LJ\u0001\u0000\u0000\u0000LK\u0001\u0000\u0000\u0000M\u0003\u0001"+
		"\u0000\u0000\u0000NO\u0005\u000b\u0000\u0000OP\u0003\u0014\n\u0000P\u0005"+
		"\u0001\u0000\u0000\u0000QR\u0005\n\u0000\u0000RS\u0003\u0014\n\u0000S"+
		"\u0007\u0001\u0000\u0000\u0000TU\u0003\n\u0005\u0000UV\u0003<\u001e\u0000"+
		"VZ\u0005\u0016\u0000\u0000WY\u0003\f\u0006\u0000XW\u0001\u0000\u0000\u0000"+
		"Y\\\u0001\u0000\u0000\u0000ZX\u0001\u0000\u0000\u0000Z[\u0001\u0000\u0000"+
		"\u0000[]\u0001\u0000\u0000\u0000\\Z\u0001\u0000\u0000\u0000]^\u0005\u0017"+
		"\u0000\u0000^_\u0003\u0014\n\u0000_\t\u0001\u0000\u0000\u0000`a\u0007"+
		"\u0000\u0000\u0000a\u000b\u0001\u0000\u0000\u0000bc\u0006\u0006\uffff"+
		"\uffff\u0000cd\u0003\u000e\u0007\u0000dj\u0001\u0000\u0000\u0000ef\n\u0001"+
		"\u0000\u0000fg\u0005\u001e\u0000\u0000gi\u0003\u000e\u0007\u0000he\u0001"+
		"\u0000\u0000\u0000il\u0001\u0000\u0000\u0000jh\u0001\u0000\u0000\u0000"+
		"jk\u0001\u0000\u0000\u0000k\r\u0001\u0000\u0000\u0000lj\u0001\u0000\u0000"+
		"\u0000mn\u0003\n\u0005\u0000no\u0003<\u001e\u0000o\u000f\u0001\u0000\u0000"+
		"\u0000pq\u0003\n\u0005\u0000qr\u0003\u0012\t\u0000rs\u0005\u001c\u0000"+
		"\u0000s\u0011\u0001\u0000\u0000\u0000tz\u0003<\u001e\u0000uv\u0003<\u001e"+
		"\u0000vw\u0005!\u0000\u0000wx\u0003\u001e\u000f\u0000xz\u0001\u0000\u0000"+
		"\u0000yt\u0001\u0000\u0000\u0000yu\u0001\u0000\u0000\u0000z\u0013\u0001"+
		"\u0000\u0000\u0000{\u007f\u0005\u0018\u0000\u0000|~\u0003\u0016\u000b"+
		"\u0000}|\u0001\u0000\u0000\u0000~\u0081\u0001\u0000\u0000\u0000\u007f"+
		"}\u0001\u0000\u0000\u0000\u007f\u0080\u0001\u0000\u0000\u0000\u0080\u0082"+
		"\u0001\u0000\u0000\u0000\u0081\u007f\u0001\u0000\u0000\u0000\u0082\u0083"+
		"\u0005\u0019\u0000\u0000\u0083\u0015\u0001\u0000\u0000\u0000\u0084\u008e"+
		"\u0003\u0018\f\u0000\u0085\u008e\u0003\u001a\r\u0000\u0086\u008e\u0003"+
		"\u001c\u000e\u0000\u0087\u008e\u0003\u0010\b\u0000\u0088\u008e\u0003\""+
		"\u0011\u0000\u0089\u008e\u0003$\u0012\u0000\u008a\u008b\u0003\u001e\u000f"+
		"\u0000\u008b\u008c\u0005\u001c\u0000\u0000\u008c\u008e\u0001\u0000\u0000"+
		"\u0000\u008d\u0084\u0001\u0000\u0000\u0000\u008d\u0085\u0001\u0000\u0000"+
		"\u0000\u008d\u0086\u0001\u0000\u0000\u0000\u008d\u0087\u0001\u0000\u0000"+
		"\u0000\u008d\u0088\u0001\u0000\u0000\u0000\u008d\u0089\u0001\u0000\u0000"+
		"\u0000\u008d\u008a\u0001\u0000\u0000\u0000\u008e\u0017\u0001\u0000\u0000"+
		"\u0000\u008f\u0090\u0005\u000e\u0000\u0000\u0090\u0091\u0005\u0016\u0000"+
		"\u0000\u0091\u0092\u0003\u001e\u000f\u0000\u0092\u0093\u0005\u0017\u0000"+
		"\u0000\u0093\u0094\u0003\u0014\n\u0000\u0094\u009e\u0001\u0000\u0000\u0000"+
		"\u0095\u0096\u0005\u000e\u0000\u0000\u0096\u0097\u0005\u0016\u0000\u0000"+
		"\u0097\u0098\u0003\u001e\u000f\u0000\u0098\u0099\u0005\u0017\u0000\u0000"+
		"\u0099\u009a\u0003\u0014\n\u0000\u009a\u009b\u0005\u000f\u0000\u0000\u009b"+
		"\u009c\u0003\u0014\n\u0000\u009c\u009e\u0001\u0000\u0000\u0000\u009d\u008f"+
		"\u0001\u0000\u0000\u0000\u009d\u0095\u0001\u0000\u0000\u0000\u009e\u0019"+
		"\u0001\u0000\u0000\u0000\u009f\u00a0\u0005\u0010\u0000\u0000\u00a0\u00a1"+
		"\u0005\u0016\u0000\u0000\u00a1\u00a2\u0003\u001e\u000f\u0000\u00a2\u00a3"+
		"\u0005\u0017\u0000\u0000\u00a3\u00a4\u0003\u0014\n\u0000\u00a4\u00b0\u0001"+
		"\u0000\u0000\u0000\u00a5\u00a6\u0005\u0011\u0000\u0000\u00a6\u00a7\u0005"+
		"\u0016\u0000\u0000\u00a7\u00a8\u0003\u001e\u000f\u0000\u00a8\u00a9\u0005"+
		"\u001c\u0000\u0000\u00a9\u00aa\u0003\u001e\u000f\u0000\u00aa\u00ab\u0005"+
		"\u001c\u0000\u0000\u00ab\u00ac\u0003\u001e\u000f\u0000\u00ac\u00ad\u0005"+
		"\u0017\u0000\u0000\u00ad\u00ae\u0003\u0014\n\u0000\u00ae\u00b0\u0001\u0000"+
		"\u0000\u0000\u00af\u009f\u0001\u0000\u0000\u0000\u00af\u00a5\u0001\u0000"+
		"\u0000\u0000\u00b0\u001b\u0001\u0000\u0000\u0000\u00b1\u00b2\u0005\u0012"+
		"\u0000\u0000\u00b2\u00ba\u0005\u001c\u0000\u0000\u00b3\u00b4\u0005\u0013"+
		"\u0000\u0000\u00b4\u00ba\u0005\u001c\u0000\u0000\u00b5\u00b6\u0005\u0014"+
		"\u0000\u0000\u00b6\u00b7\u0003\u001e\u000f\u0000\u00b7\u00b8\u0005\u001c"+
		"\u0000\u0000\u00b8\u00ba\u0001\u0000\u0000\u0000\u00b9\u00b1\u0001\u0000"+
		"\u0000\u0000\u00b9\u00b3\u0001\u0000\u0000\u0000\u00b9\u00b5\u0001\u0000"+
		"\u0000\u0000\u00ba\u001d\u0001\u0000\u0000\u0000\u00bb\u00bc\u0003&\u0013"+
		"\u0000\u00bc\u001f\u0001\u0000\u0000\u0000\u00bd\u00c6\u0003(\u0014\u0000"+
		"\u00be\u00c1\u00038\u001c\u0000\u00bf\u00c1\u0003<\u001e\u0000\u00c0\u00be"+
		"\u0001\u0000\u0000\u0000\u00c0\u00bf\u0001\u0000\u0000\u0000\u00c1\u00c2"+
		"\u0001\u0000\u0000\u0000\u00c2\u00c3\u0003>\u001f\u0000\u00c3\u00c4\u0003"+
		" \u0010\u0000\u00c4\u00c6\u0001\u0000\u0000\u0000\u00c5\u00bd\u0001\u0000"+
		"\u0000\u0000\u00c5\u00c0\u0001\u0000\u0000\u0000\u00c6!\u0001\u0000\u0000"+
		"\u0000\u00c7\u00c8\u0003<\u001e\u0000\u00c8\u00cc\u0005\u0016\u0000\u0000"+
		"\u00c9\u00cb\u0003\f\u0006\u0000\u00ca\u00c9\u0001\u0000\u0000\u0000\u00cb"+
		"\u00ce\u0001\u0000\u0000\u0000\u00cc\u00ca\u0001\u0000\u0000\u0000\u00cc"+
		"\u00cd\u0001\u0000\u0000\u0000\u00cd\u00cf\u0001\u0000\u0000\u0000\u00ce"+
		"\u00cc\u0001\u0000\u0000\u0000\u00cf\u00d0\u0005\u0017\u0000\u0000\u00d0"+
		"\u00d1\u0005\u001c\u0000\u0000\u00d1#\u0001\u0000\u0000\u0000\u00d2\u00d3"+
		"\u0003<\u001e\u0000\u00d3\u00d4\u0003>\u001f\u0000\u00d4\u00d5\u0003\u001e"+
		"\u000f\u0000\u00d5\u00d6\u0005\u001c\u0000\u0000\u00d6%\u0001\u0000\u0000"+
		"\u0000\u00d7\u00de\u0003(\u0014\u0000\u00d8\u00d9\u0005\f\u0000\u0000"+
		"\u00d9\u00da\u0003<\u001e\u0000\u00da\u00db\u0005\r\u0000\u0000\u00db"+
		"\u00dc\u0003@ \u0000\u00dc\u00de\u0001\u0000\u0000\u0000\u00dd\u00d7\u0001"+
		"\u0000\u0000\u0000\u00dd\u00d8\u0001\u0000\u0000\u0000\u00de\'\u0001\u0000"+
		"\u0000\u0000\u00df\u00e7\u0003*\u0015\u0000\u00e0\u00e1\u0003*\u0015\u0000"+
		"\u00e1\u00e2\u0005\u0015\u0000\u0000\u00e2\u00e3\u0003\u001e\u000f\u0000"+
		"\u00e3\u00e4\u0005\u001f\u0000\u0000\u00e4\u00e5\u0003\u001e\u000f\u0000"+
		"\u00e5\u00e7\u0001\u0000\u0000\u0000\u00e6\u00df\u0001\u0000\u0000\u0000"+
		"\u00e6\u00e0\u0001\u0000\u0000\u0000\u00e7)\u0001\u0000\u0000\u0000\u00e8"+
		"\u00e9\u0006\u0015\uffff\uffff\u0000\u00e9\u00ea\u0003,\u0016\u0000\u00ea"+
		"\u00f0\u0001\u0000\u0000\u0000\u00eb\u00ec\n\u0001\u0000\u0000\u00ec\u00ed"+
		"\u0005.\u0000\u0000\u00ed\u00ef\u0003,\u0016\u0000\u00ee\u00eb\u0001\u0000"+
		"\u0000\u0000\u00ef\u00f2\u0001\u0000\u0000\u0000\u00f0\u00ee\u0001\u0000"+
		"\u0000\u0000\u00f0\u00f1\u0001\u0000\u0000\u0000\u00f1+\u0001\u0000\u0000"+
		"\u0000\u00f2\u00f0\u0001\u0000\u0000\u0000\u00f3\u00f4\u0006\u0016\uffff"+
		"\uffff\u0000\u00f4\u00f5\u0003.\u0017\u0000\u00f5\u00fb\u0001\u0000\u0000"+
		"\u0000\u00f6\u00f7\n\u0001\u0000\u0000\u00f7\u00f8\u0005-\u0000\u0000"+
		"\u00f8\u00fa\u0003.\u0017\u0000\u00f9\u00f6\u0001\u0000\u0000\u0000\u00fa"+
		"\u00fd\u0001\u0000\u0000\u0000\u00fb\u00f9\u0001\u0000\u0000\u0000\u00fb"+
		"\u00fc\u0001\u0000\u0000\u0000\u00fc-\u0001\u0000\u0000\u0000\u00fd\u00fb"+
		"\u0001\u0000\u0000\u0000\u00fe\u00ff\u0006\u0017\uffff\uffff\u0000\u00ff"+
		"\u0100\u00030\u0018\u0000\u0100\u0109\u0001\u0000\u0000\u0000\u0101\u0102"+
		"\n\u0002\u0000\u0000\u0102\u0103\u0005/\u0000\u0000\u0103\u0108\u0003"+
		"0\u0018\u0000\u0104\u0105\n\u0001\u0000\u0000\u0105\u0106\u00050\u0000"+
		"\u0000\u0106\u0108\u00030\u0018\u0000\u0107\u0101\u0001\u0000\u0000\u0000"+
		"\u0107\u0104\u0001\u0000\u0000\u0000\u0108\u010b\u0001\u0000\u0000\u0000"+
		"\u0109\u0107\u0001\u0000\u0000\u0000\u0109\u010a\u0001\u0000\u0000\u0000"+
		"\u010a/\u0001\u0000\u0000\u0000\u010b\u0109\u0001\u0000\u0000\u0000\u010c"+
		"\u010d\u0006\u0018\uffff\uffff\u0000\u010d\u010e\u00032\u0019\u0000\u010e"+
		"\u011d\u0001\u0000\u0000\u0000\u010f\u0110\n\u0004\u0000\u0000\u0110\u0111"+
		"\u00052\u0000\u0000\u0111\u011c\u00032\u0019\u0000\u0112\u0113\n\u0003"+
		"\u0000\u0000\u0113\u0114\u00051\u0000\u0000\u0114\u011c\u00032\u0019\u0000"+
		"\u0115\u0116\n\u0002\u0000\u0000\u0116\u0117\u00054\u0000\u0000\u0117"+
		"\u011c\u00032\u0019\u0000\u0118\u0119\n\u0001\u0000\u0000\u0119\u011a"+
		"\u00053\u0000\u0000\u011a\u011c\u00032\u0019\u0000\u011b\u010f\u0001\u0000"+
		"\u0000\u0000\u011b\u0112\u0001\u0000\u0000\u0000\u011b\u0115\u0001\u0000"+
		"\u0000\u0000\u011b\u0118\u0001\u0000\u0000\u0000\u011c\u011f\u0001\u0000"+
		"\u0000\u0000\u011d\u011b\u0001\u0000\u0000\u0000\u011d\u011e\u0001\u0000"+
		"\u0000\u0000\u011e1\u0001\u0000\u0000\u0000\u011f\u011d\u0001\u0000\u0000"+
		"\u0000\u0120\u0121\u0006\u0019\uffff\uffff\u0000\u0121\u0122\u00034\u001a"+
		"\u0000\u0122\u012b\u0001\u0000\u0000\u0000\u0123\u0124\n\u0002\u0000\u0000"+
		"\u0124\u0125\u00056\u0000\u0000\u0125\u012a\u00034\u001a\u0000\u0126\u0127"+
		"\n\u0001\u0000\u0000\u0127\u0128\u00057\u0000\u0000\u0128\u012a\u0003"+
		"4\u001a\u0000\u0129\u0123\u0001\u0000\u0000\u0000\u0129\u0126\u0001\u0000"+
		"\u0000\u0000\u012a\u012d\u0001\u0000\u0000\u0000\u012b\u0129\u0001\u0000"+
		"\u0000\u0000\u012b\u012c\u0001\u0000\u0000\u0000\u012c3\u0001\u0000\u0000"+
		"\u0000\u012d\u012b\u0001\u0000\u0000\u0000\u012e\u012f\u0006\u001a\uffff"+
		"\uffff\u0000\u012f\u0130\u00036\u001b\u0000\u0130\u0139\u0001\u0000\u0000"+
		"\u0000\u0131\u0132\n\u0002\u0000\u0000\u0132\u0133\u0005*\u0000\u0000"+
		"\u0133\u0138\u00036\u001b\u0000\u0134\u0135\n\u0001\u0000\u0000\u0135"+
		"\u0136\u0005+\u0000\u0000\u0136\u0138\u00036\u001b\u0000\u0137\u0131\u0001"+
		"\u0000\u0000\u0000\u0137\u0134\u0001\u0000\u0000\u0000\u0138\u013b\u0001"+
		"\u0000\u0000\u0000\u0139\u0137\u0001\u0000\u0000\u0000\u0139\u013a\u0001"+
		"\u0000\u0000\u0000\u013a5\u0001\u0000\u0000\u0000\u013b\u0139\u0001\u0000"+
		"\u0000\u0000\u013c\u013d\u0006\u001b\uffff\uffff\u0000\u013d\u013e\u0003"+
		"8\u001c\u0000\u013e\u014a\u0001\u0000\u0000\u0000\u013f\u0140\n\u0003"+
		"\u0000\u0000\u0140\u0141\u0005(\u0000\u0000\u0141\u0149\u0003:\u001d\u0000"+
		"\u0142\u0143\n\u0002\u0000\u0000\u0143\u0144\u0005)\u0000\u0000\u0144"+
		"\u0149\u0003:\u001d\u0000\u0145\u0146\n\u0001\u0000\u0000\u0146\u0147"+
		"\u0005,\u0000\u0000\u0147\u0149\u0003:\u001d\u0000\u0148\u013f\u0001\u0000"+
		"\u0000\u0000\u0148\u0142\u0001\u0000\u0000\u0000\u0148\u0145\u0001\u0000"+
		"\u0000\u0000\u0149\u014c\u0001\u0000\u0000\u0000\u014a\u0148\u0001\u0000"+
		"\u0000\u0000\u014a\u014b\u0001\u0000\u0000\u0000\u014b7\u0001\u0000\u0000"+
		"\u0000\u014c\u014a\u0001\u0000\u0000\u0000\u014d\u0159\u0003:\u001d\u0000"+
		"\u014e\u014f\u0003:\u001d\u0000\u014f\u0150\u00058\u0000\u0000\u0150\u0159"+
		"\u0001\u0000\u0000\u0000\u0151\u0152\u0003:\u001d\u0000\u0152\u0153\u0005"+
		"9\u0000\u0000\u0153\u0159\u0001\u0000\u0000\u0000\u0154\u0155\u00058\u0000"+
		"\u0000\u0155\u0159\u0003:\u001d\u0000\u0156\u0157\u00059\u0000\u0000\u0157"+
		"\u0159\u0003:\u001d\u0000\u0158\u014d\u0001\u0000\u0000\u0000\u0158\u014e"+
		"\u0001\u0000\u0000\u0000\u0158\u0151\u0001\u0000\u0000\u0000\u0158\u0154"+
		"\u0001\u0000\u0000\u0000\u0158\u0156\u0001\u0000\u0000\u0000\u01599\u0001"+
		"\u0000\u0000\u0000\u015a\u015b\u0007\u0001\u0000\u0000\u015b;\u0001\u0000"+
		"\u0000\u0000\u015c\u015d\u0005:\u0000\u0000\u015d=\u0001\u0000\u0000\u0000"+
		"\u015e\u015f\u0007\u0002\u0000\u0000\u015f?\u0001\u0000\u0000\u0000\u0160"+
		"\u0161\u0007\u0003\u0000\u0000\u0161A\u0001\u0000\u0000\u0000\u001cGL"+
		"Zjy\u007f\u008d\u009d\u00af\u00b9\u00c0\u00c5\u00cc\u00dd\u00e6\u00f0"+
		"\u00fb\u0107\u0109\u011b\u011d\u0129\u012b\u0137\u0139\u0148\u014a\u0158";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}
