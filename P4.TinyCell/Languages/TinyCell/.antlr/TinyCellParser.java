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
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, T__12=13, T__13=14, T__14=15, T__15=16, T__16=17, 
		T__17=18, T__18=19, T__19=20, T__20=21, T__21=22, T__22=23, T__23=24, 
		T__24=25, T__25=26, T__26=27, T__27=28, T__28=29, T__29=30, T__30=31, 
		T__31=32, T__32=33, T__33=34, T__34=35, T__35=36, T__36=37, T__37=38, 
		T__38=39, T__39=40, T__40=41, T__41=42, T__42=43, T__43=44, T__44=45, 
		T__45=46, T__46=47, T__47=48, T__48=49, T__49=50, Identifier=51, String=52, 
		Numeral=53, Whitespace=54, Newline=55;
	public static final int
		RULE_document = 0, RULE_generalDeclaration = 1, RULE_setupDefinition = 2, 
		RULE_updateDefinition = 3, RULE_functionDefinition = 4, RULE_type = 5, 
		RULE_parameterList = 6, RULE_parameter = 7, RULE_declaration = 8, RULE_initialDeclaration = 9, 
		RULE_compoundStatement = 10, RULE_statement = 11, RULE_ifStatement = 12, 
		RULE_loopStatement = 13, RULE_jumpStatement = 14, RULE_expression = 15, 
		RULE_assignmentExpression = 16, RULE_ternaryExpression = 17, RULE_orExpression = 18, 
		RULE_andExpression = 19, RULE_equalityExpression = 20, RULE_comparisonExpression = 21, 
		RULE_bitshiftExpression = 22, RULE_additiveExpression = 23, RULE_multiplicativeExpression = 24, 
		RULE_unaryExpression = 25, RULE_primitiveExpression = 26, RULE_pinExpression = 27, 
		RULE_identifier = 28, RULE_assignmentOperator = 29, RULE_pinVoltage = 30;
	private static String[] makeRuleNames() {
		return new String[] {
			"document", "generalDeclaration", "setupDefinition", "updateDefinition", 
			"functionDefinition", "type", "parameterList", "parameter", "declaration", 
			"initialDeclaration", "compoundStatement", "statement", "ifStatement", 
			"loopStatement", "jumpStatement", "expression", "assignmentExpression", 
			"ternaryExpression", "orExpression", "andExpression", "equalityExpression", 
			"comparisonExpression", "bitshiftExpression", "additiveExpression", "multiplicativeExpression", 
			"unaryExpression", "primitiveExpression", "pinExpression", "identifier", 
			"assignmentOperator", "pinVoltage"
		};
	}
	public static final String[] ruleNames = makeRuleNames();

	private static String[] makeLiteralNames() {
		return new String[] {
			null, "'setup'", "'update'", "'('", "')'", "'void'", "'char'", "'int'", 
			"'float'", "'bool'", "'pin'", "','", "'='", "'{'", "'}'", "'if'", "'else'", 
			"'while'", "'for'", "';'", "'continue'", "'break'", "'return'", "'?'", 
			"':'", "'||'", "'&&'", "'=='", "'!='", "'<'", "'>'", "'<='", "'>='", 
			"'<<'", "'>>'", "'+'", "'-'", "'*'", "'/'", "'%'", "'++'", "'--'", "'set'", 
			"'to'", "'*='", "'/='", "'%='", "'+='", "'-='", "'high'", "'low'"
		};
	}
	private static final String[] _LITERAL_NAMES = makeLiteralNames();
	private static String[] makeSymbolicNames() {
		return new String[] {
			null, null, null, null, null, null, null, null, null, null, null, null, 
			null, null, null, null, null, null, null, null, null, null, null, null, 
			null, null, null, null, null, null, null, null, null, null, null, null, 
			null, null, null, null, null, null, null, null, null, null, null, null, 
			null, null, null, "Identifier", "String", "Numeral", "Whitespace", "Newline"
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
			setState(62);
			setupDefinition();
			setState(63);
			updateDefinition();
			setState(67);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & 2016L) != 0)) {
				{
				{
				setState(64);
				generalDeclaration();
				}
				}
				setState(69);
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
			setState(72);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,1,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(70);
				functionDefinition();
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(71);
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
			setState(74);
			match(T__0);
			setState(75);
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
			setState(77);
			match(T__1);
			setState(78);
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
		public ParameterListContext parameterList() {
			return getRuleContext(ParameterListContext.class,0);
		}
		public CompoundStatementContext compoundStatement() {
			return getRuleContext(CompoundStatementContext.class,0);
		}
		public FunctionDefinitionContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_functionDefinition; }
	}

	public final FunctionDefinitionContext functionDefinition() throws RecognitionException {
		FunctionDefinitionContext _localctx = new FunctionDefinitionContext(_ctx, getState());
		enterRule(_localctx, 8, RULE_functionDefinition);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(80);
			type();
			setState(81);
			identifier();
			setState(82);
			match(T__2);
			setState(83);
			parameterList(0);
			setState(84);
			match(T__3);
			setState(85);
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
			setState(87);
			_la = _input.LA(1);
			if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & 2016L) != 0)) ) {
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
			setState(90);
			parameter();
			}
			_ctx.stop = _input.LT(-1);
			setState(97);
			_errHandler.sync(this);
			_alt = getInterpreter().adaptivePredict(_input,2,_ctx);
			while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( _parseListeners!=null ) triggerExitRuleEvent();
					_prevctx = _localctx;
					{
					{
					_localctx = new ParameterListContext(_parentctx, _parentState);
					pushNewRecursionContext(_localctx, _startState, RULE_parameterList);
					setState(92);
					if (!(precpred(_ctx, 1))) throw new FailedPredicateException(this, "precpred(_ctx, 1)");
					setState(93);
					match(T__10);
					setState(94);
					parameter();
					}
					} 
				}
				setState(99);
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,2,_ctx);
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
			setState(100);
			type();
			setState(101);
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
		enterRule(_localctx, 16, RULE_declaration);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(103);
			type();
			setState(104);
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
		public AssignmentExpressionContext assignmentExpression() {
			return getRuleContext(AssignmentExpressionContext.class,0);
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
			setState(111);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,3,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(106);
				identifier();
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(107);
				identifier();
				setState(108);
				match(T__11);
				setState(109);
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
	public static class CompoundStatementContext extends ParserRuleContext {
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
			setState(113);
			match(T__12);
			setState(117);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & 13518495471273952L) != 0)) {
				{
				{
				setState(114);
				statement();
				}
				}
				setState(119);
				_errHandler.sync(this);
				_la = _input.LA(1);
			}
			setState(120);
			match(T__13);
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
		enterRule(_localctx, 22, RULE_statement);
		try {
			setState(127);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case T__14:
				enterOuterAlt(_localctx, 1);
				{
				setState(122);
				ifStatement();
				}
				break;
			case T__16:
			case T__17:
				enterOuterAlt(_localctx, 2);
				{
				setState(123);
				loopStatement();
				}
				break;
			case T__19:
			case T__20:
			case T__21:
				enterOuterAlt(_localctx, 3);
				{
				setState(124);
				jumpStatement();
				}
				break;
			case T__4:
			case T__5:
			case T__6:
			case T__7:
			case T__8:
			case T__9:
				enterOuterAlt(_localctx, 4);
				{
				setState(125);
				declaration();
				}
				break;
			case T__39:
			case T__40:
			case T__41:
			case String:
			case Numeral:
				enterOuterAlt(_localctx, 5);
				{
				setState(126);
				expression();
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
		public ExpressionContext expression() {
			return getRuleContext(ExpressionContext.class,0);
		}
		public List<CompoundStatementContext> compoundStatement() {
			return getRuleContexts(CompoundStatementContext.class);
		}
		public CompoundStatementContext compoundStatement(int i) {
			return getRuleContext(CompoundStatementContext.class,i);
		}
		public IfStatementContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_ifStatement; }
	}

	public final IfStatementContext ifStatement() throws RecognitionException {
		IfStatementContext _localctx = new IfStatementContext(_ctx, getState());
		enterRule(_localctx, 24, RULE_ifStatement);
		try {
			setState(143);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,6,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(129);
				match(T__14);
				setState(130);
				match(T__2);
				setState(131);
				expression();
				setState(132);
				match(T__3);
				setState(133);
				compoundStatement();
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(135);
				match(T__14);
				setState(136);
				match(T__2);
				setState(137);
				expression();
				setState(138);
				match(T__3);
				setState(139);
				compoundStatement();
				setState(140);
				match(T__15);
				setState(141);
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
		public List<ExpressionContext> expression() {
			return getRuleContexts(ExpressionContext.class);
		}
		public ExpressionContext expression(int i) {
			return getRuleContext(ExpressionContext.class,i);
		}
		public CompoundStatementContext compoundStatement() {
			return getRuleContext(CompoundStatementContext.class,0);
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
			setState(161);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case T__16:
				enterOuterAlt(_localctx, 1);
				{
				setState(145);
				match(T__16);
				setState(146);
				match(T__2);
				setState(147);
				expression();
				setState(148);
				match(T__3);
				setState(149);
				compoundStatement();
				}
				break;
			case T__17:
				enterOuterAlt(_localctx, 2);
				{
				setState(151);
				match(T__17);
				setState(152);
				match(T__2);
				setState(153);
				expression();
				setState(154);
				match(T__18);
				setState(155);
				expression();
				setState(156);
				match(T__18);
				setState(157);
				expression();
				setState(158);
				match(T__3);
				setState(159);
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
			setState(171);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case T__19:
				enterOuterAlt(_localctx, 1);
				{
				setState(163);
				match(T__19);
				setState(164);
				match(T__18);
				}
				break;
			case T__20:
				enterOuterAlt(_localctx, 2);
				{
				setState(165);
				match(T__20);
				setState(166);
				match(T__18);
				}
				break;
			case T__21:
				enterOuterAlt(_localctx, 3);
				{
				setState(167);
				match(T__21);
				setState(168);
				expression();
				setState(169);
				match(T__18);
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
		public AssignmentExpressionContext assignmentExpression() {
			return getRuleContext(AssignmentExpressionContext.class,0);
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
			setState(173);
			assignmentExpression();
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
		public PinExpressionContext pinExpression() {
			return getRuleContext(PinExpressionContext.class,0);
		}
		public UnaryExpressionContext unaryExpression() {
			return getRuleContext(UnaryExpressionContext.class,0);
		}
		public AssignmentOperatorContext assignmentOperator() {
			return getRuleContext(AssignmentOperatorContext.class,0);
		}
		public AssignmentExpressionContext assignmentExpression() {
			return getRuleContext(AssignmentExpressionContext.class,0);
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
			setState(181);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,9,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(175);
				ternaryExpression();
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(176);
				pinExpression();
				}
				break;
			case 3:
				enterOuterAlt(_localctx, 3);
				{
				setState(177);
				unaryExpression(0);
				setState(178);
				assignmentOperator();
				setState(179);
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
	public static class TernaryExpressionContext extends ParserRuleContext {
		public OrExpressionContext orExpression() {
			return getRuleContext(OrExpressionContext.class,0);
		}
		public List<ExpressionContext> expression() {
			return getRuleContexts(ExpressionContext.class);
		}
		public ExpressionContext expression(int i) {
			return getRuleContext(ExpressionContext.class,i);
		}
		public TernaryExpressionContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_ternaryExpression; }
	}

	public final TernaryExpressionContext ternaryExpression() throws RecognitionException {
		TernaryExpressionContext _localctx = new TernaryExpressionContext(_ctx, getState());
		enterRule(_localctx, 34, RULE_ternaryExpression);
		try {
			setState(190);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,10,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(183);
				orExpression(0);
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(184);
				orExpression(0);
				setState(185);
				match(T__22);
				setState(186);
				expression();
				setState(187);
				match(T__23);
				setState(188);
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
		int _startState = 36;
		enterRecursionRule(_localctx, 36, RULE_orExpression, _p);
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			{
			setState(193);
			andExpression(0);
			}
			_ctx.stop = _input.LT(-1);
			setState(200);
			_errHandler.sync(this);
			_alt = getInterpreter().adaptivePredict(_input,11,_ctx);
			while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( _parseListeners!=null ) triggerExitRuleEvent();
					_prevctx = _localctx;
					{
					{
					_localctx = new OrExpressionContext(_parentctx, _parentState);
					pushNewRecursionContext(_localctx, _startState, RULE_orExpression);
					setState(195);
					if (!(precpred(_ctx, 1))) throw new FailedPredicateException(this, "precpred(_ctx, 1)");
					setState(196);
					match(T__24);
					setState(197);
					andExpression(0);
					}
					} 
				}
				setState(202);
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,11,_ctx);
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
		int _startState = 38;
		enterRecursionRule(_localctx, 38, RULE_andExpression, _p);
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			{
			setState(204);
			equalityExpression(0);
			}
			_ctx.stop = _input.LT(-1);
			setState(211);
			_errHandler.sync(this);
			_alt = getInterpreter().adaptivePredict(_input,12,_ctx);
			while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( _parseListeners!=null ) triggerExitRuleEvent();
					_prevctx = _localctx;
					{
					{
					_localctx = new AndExpressionContext(_parentctx, _parentState);
					pushNewRecursionContext(_localctx, _startState, RULE_andExpression);
					setState(206);
					if (!(precpred(_ctx, 1))) throw new FailedPredicateException(this, "precpred(_ctx, 1)");
					setState(207);
					match(T__25);
					setState(208);
					equalityExpression(0);
					}
					} 
				}
				setState(213);
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,12,_ctx);
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
		int _startState = 40;
		enterRecursionRule(_localctx, 40, RULE_equalityExpression, _p);
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			{
			setState(215);
			comparisonExpression(0);
			}
			_ctx.stop = _input.LT(-1);
			setState(225);
			_errHandler.sync(this);
			_alt = getInterpreter().adaptivePredict(_input,14,_ctx);
			while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( _parseListeners!=null ) triggerExitRuleEvent();
					_prevctx = _localctx;
					{
					setState(223);
					_errHandler.sync(this);
					switch ( getInterpreter().adaptivePredict(_input,13,_ctx) ) {
					case 1:
						{
						_localctx = new EqualityExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_equalityExpression);
						setState(217);
						if (!(precpred(_ctx, 2))) throw new FailedPredicateException(this, "precpred(_ctx, 2)");
						setState(218);
						match(T__26);
						setState(219);
						comparisonExpression(0);
						}
						break;
					case 2:
						{
						_localctx = new EqualityExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_equalityExpression);
						setState(220);
						if (!(precpred(_ctx, 1))) throw new FailedPredicateException(this, "precpred(_ctx, 1)");
						setState(221);
						match(T__27);
						setState(222);
						comparisonExpression(0);
						}
						break;
					}
					} 
				}
				setState(227);
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
	public static class ComparisonExpressionContext extends ParserRuleContext {
		public BitshiftExpressionContext bitshiftExpression() {
			return getRuleContext(BitshiftExpressionContext.class,0);
		}
		public ComparisonExpressionContext comparisonExpression() {
			return getRuleContext(ComparisonExpressionContext.class,0);
		}
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
		int _startState = 42;
		enterRecursionRule(_localctx, 42, RULE_comparisonExpression, _p);
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			{
			setState(229);
			bitshiftExpression(0);
			}
			_ctx.stop = _input.LT(-1);
			setState(245);
			_errHandler.sync(this);
			_alt = getInterpreter().adaptivePredict(_input,16,_ctx);
			while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( _parseListeners!=null ) triggerExitRuleEvent();
					_prevctx = _localctx;
					{
					setState(243);
					_errHandler.sync(this);
					switch ( getInterpreter().adaptivePredict(_input,15,_ctx) ) {
					case 1:
						{
						_localctx = new ComparisonExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_comparisonExpression);
						setState(231);
						if (!(precpred(_ctx, 4))) throw new FailedPredicateException(this, "precpred(_ctx, 4)");
						setState(232);
						match(T__28);
						setState(233);
						bitshiftExpression(0);
						}
						break;
					case 2:
						{
						_localctx = new ComparisonExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_comparisonExpression);
						setState(234);
						if (!(precpred(_ctx, 3))) throw new FailedPredicateException(this, "precpred(_ctx, 3)");
						setState(235);
						match(T__29);
						setState(236);
						bitshiftExpression(0);
						}
						break;
					case 3:
						{
						_localctx = new ComparisonExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_comparisonExpression);
						setState(237);
						if (!(precpred(_ctx, 2))) throw new FailedPredicateException(this, "precpred(_ctx, 2)");
						setState(238);
						match(T__30);
						setState(239);
						bitshiftExpression(0);
						}
						break;
					case 4:
						{
						_localctx = new ComparisonExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_comparisonExpression);
						setState(240);
						if (!(precpred(_ctx, 1))) throw new FailedPredicateException(this, "precpred(_ctx, 1)");
						setState(241);
						match(T__31);
						setState(242);
						bitshiftExpression(0);
						}
						break;
					}
					} 
				}
				setState(247);
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
	public static class BitshiftExpressionContext extends ParserRuleContext {
		public AdditiveExpressionContext additiveExpression() {
			return getRuleContext(AdditiveExpressionContext.class,0);
		}
		public BitshiftExpressionContext bitshiftExpression() {
			return getRuleContext(BitshiftExpressionContext.class,0);
		}
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
		int _startState = 44;
		enterRecursionRule(_localctx, 44, RULE_bitshiftExpression, _p);
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			{
			setState(249);
			additiveExpression(0);
			}
			_ctx.stop = _input.LT(-1);
			setState(259);
			_errHandler.sync(this);
			_alt = getInterpreter().adaptivePredict(_input,18,_ctx);
			while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( _parseListeners!=null ) triggerExitRuleEvent();
					_prevctx = _localctx;
					{
					setState(257);
					_errHandler.sync(this);
					switch ( getInterpreter().adaptivePredict(_input,17,_ctx) ) {
					case 1:
						{
						_localctx = new BitshiftExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_bitshiftExpression);
						setState(251);
						if (!(precpred(_ctx, 2))) throw new FailedPredicateException(this, "precpred(_ctx, 2)");
						setState(252);
						match(T__32);
						setState(253);
						additiveExpression(0);
						}
						break;
					case 2:
						{
						_localctx = new BitshiftExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_bitshiftExpression);
						setState(254);
						if (!(precpred(_ctx, 1))) throw new FailedPredicateException(this, "precpred(_ctx, 1)");
						setState(255);
						match(T__33);
						setState(256);
						additiveExpression(0);
						}
						break;
					}
					} 
				}
				setState(261);
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
		int _startState = 46;
		enterRecursionRule(_localctx, 46, RULE_additiveExpression, _p);
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			{
			setState(263);
			multiplicativeExpression(0);
			}
			_ctx.stop = _input.LT(-1);
			setState(273);
			_errHandler.sync(this);
			_alt = getInterpreter().adaptivePredict(_input,20,_ctx);
			while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( _parseListeners!=null ) triggerExitRuleEvent();
					_prevctx = _localctx;
					{
					setState(271);
					_errHandler.sync(this);
					switch ( getInterpreter().adaptivePredict(_input,19,_ctx) ) {
					case 1:
						{
						_localctx = new AdditiveExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_additiveExpression);
						setState(265);
						if (!(precpred(_ctx, 2))) throw new FailedPredicateException(this, "precpred(_ctx, 2)");
						setState(266);
						match(T__34);
						setState(267);
						multiplicativeExpression(0);
						}
						break;
					case 2:
						{
						_localctx = new AdditiveExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_additiveExpression);
						setState(268);
						if (!(precpred(_ctx, 1))) throw new FailedPredicateException(this, "precpred(_ctx, 1)");
						setState(269);
						match(T__35);
						setState(270);
						multiplicativeExpression(0);
						}
						break;
					}
					} 
				}
				setState(275);
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
	public static class MultiplicativeExpressionContext extends ParserRuleContext {
		public UnaryExpressionContext unaryExpression() {
			return getRuleContext(UnaryExpressionContext.class,0);
		}
		public MultiplicativeExpressionContext multiplicativeExpression() {
			return getRuleContext(MultiplicativeExpressionContext.class,0);
		}
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
		int _startState = 48;
		enterRecursionRule(_localctx, 48, RULE_multiplicativeExpression, _p);
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			{
			setState(277);
			unaryExpression(0);
			}
			_ctx.stop = _input.LT(-1);
			setState(290);
			_errHandler.sync(this);
			_alt = getInterpreter().adaptivePredict(_input,22,_ctx);
			while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( _parseListeners!=null ) triggerExitRuleEvent();
					_prevctx = _localctx;
					{
					setState(288);
					_errHandler.sync(this);
					switch ( getInterpreter().adaptivePredict(_input,21,_ctx) ) {
					case 1:
						{
						_localctx = new MultiplicativeExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_multiplicativeExpression);
						setState(279);
						if (!(precpred(_ctx, 3))) throw new FailedPredicateException(this, "precpred(_ctx, 3)");
						setState(280);
						match(T__36);
						setState(281);
						unaryExpression(0);
						}
						break;
					case 2:
						{
						_localctx = new MultiplicativeExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_multiplicativeExpression);
						setState(282);
						if (!(precpred(_ctx, 2))) throw new FailedPredicateException(this, "precpred(_ctx, 2)");
						setState(283);
						match(T__37);
						setState(284);
						unaryExpression(0);
						}
						break;
					case 3:
						{
						_localctx = new MultiplicativeExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_multiplicativeExpression);
						setState(285);
						if (!(precpred(_ctx, 1))) throw new FailedPredicateException(this, "precpred(_ctx, 1)");
						setState(286);
						match(T__38);
						setState(287);
						unaryExpression(0);
						}
						break;
					}
					} 
				}
				setState(292);
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
	public static class UnaryExpressionContext extends ParserRuleContext {
		public PrimitiveExpressionContext primitiveExpression() {
			return getRuleContext(PrimitiveExpressionContext.class,0);
		}
		public UnaryExpressionContext unaryExpression() {
			return getRuleContext(UnaryExpressionContext.class,0);
		}
		public UnaryExpressionContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_unaryExpression; }
	}

	public final UnaryExpressionContext unaryExpression() throws RecognitionException {
		return unaryExpression(0);
	}

	private UnaryExpressionContext unaryExpression(int _p) throws RecognitionException {
		ParserRuleContext _parentctx = _ctx;
		int _parentState = getState();
		UnaryExpressionContext _localctx = new UnaryExpressionContext(_ctx, _parentState);
		UnaryExpressionContext _prevctx = _localctx;
		int _startState = 50;
		enterRecursionRule(_localctx, 50, RULE_unaryExpression, _p);
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			setState(299);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case String:
			case Numeral:
				{
				setState(294);
				primitiveExpression();
				}
				break;
			case T__39:
				{
				setState(295);
				match(T__39);
				setState(296);
				unaryExpression(2);
				}
				break;
			case T__40:
				{
				setState(297);
				match(T__40);
				setState(298);
				unaryExpression(1);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
			_ctx.stop = _input.LT(-1);
			setState(307);
			_errHandler.sync(this);
			_alt = getInterpreter().adaptivePredict(_input,25,_ctx);
			while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( _parseListeners!=null ) triggerExitRuleEvent();
					_prevctx = _localctx;
					{
					setState(305);
					_errHandler.sync(this);
					switch ( getInterpreter().adaptivePredict(_input,24,_ctx) ) {
					case 1:
						{
						_localctx = new UnaryExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_unaryExpression);
						setState(301);
						if (!(precpred(_ctx, 4))) throw new FailedPredicateException(this, "precpred(_ctx, 4)");
						setState(302);
						match(T__39);
						}
						break;
					case 2:
						{
						_localctx = new UnaryExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_unaryExpression);
						setState(303);
						if (!(precpred(_ctx, 3))) throw new FailedPredicateException(this, "precpred(_ctx, 3)");
						setState(304);
						match(T__40);
						}
						break;
					}
					} 
				}
				setState(309);
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
		enterRule(_localctx, 52, RULE_primitiveExpression);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(310);
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
		public IdentifierContext identifier() {
			return getRuleContext(IdentifierContext.class,0);
		}
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
		enterRule(_localctx, 54, RULE_pinExpression);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(312);
			match(T__41);
			setState(313);
			identifier();
			setState(314);
			match(T__42);
			setState(315);
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
		enterRule(_localctx, 56, RULE_identifier);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(317);
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
		public AssignmentOperatorContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_assignmentOperator; }
	}

	public final AssignmentOperatorContext assignmentOperator() throws RecognitionException {
		AssignmentOperatorContext _localctx = new AssignmentOperatorContext(_ctx, getState());
		enterRule(_localctx, 58, RULE_assignmentOperator);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(319);
			_la = _input.LA(1);
			if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & 545357767380992L) != 0)) ) {
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
		public PinVoltageContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_pinVoltage; }
	}

	public final PinVoltageContext pinVoltage() throws RecognitionException {
		PinVoltageContext _localctx = new PinVoltageContext(_ctx, getState());
		enterRule(_localctx, 60, RULE_pinVoltage);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(321);
			_la = _input.LA(1);
			if ( !(_la==T__48 || _la==T__49) ) {
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
		case 18:
			return orExpression_sempred((OrExpressionContext)_localctx, predIndex);
		case 19:
			return andExpression_sempred((AndExpressionContext)_localctx, predIndex);
		case 20:
			return equalityExpression_sempred((EqualityExpressionContext)_localctx, predIndex);
		case 21:
			return comparisonExpression_sempred((ComparisonExpressionContext)_localctx, predIndex);
		case 22:
			return bitshiftExpression_sempred((BitshiftExpressionContext)_localctx, predIndex);
		case 23:
			return additiveExpression_sempred((AdditiveExpressionContext)_localctx, predIndex);
		case 24:
			return multiplicativeExpression_sempred((MultiplicativeExpressionContext)_localctx, predIndex);
		case 25:
			return unaryExpression_sempred((UnaryExpressionContext)_localctx, predIndex);
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
	private boolean unaryExpression_sempred(UnaryExpressionContext _localctx, int predIndex) {
		switch (predIndex) {
		case 16:
			return precpred(_ctx, 4);
		case 17:
			return precpred(_ctx, 3);
		}
		return true;
	}

	public static final String _serializedATN =
		"\u0004\u00017\u0144\u0002\u0000\u0007\u0000\u0002\u0001\u0007\u0001\u0002"+
		"\u0002\u0007\u0002\u0002\u0003\u0007\u0003\u0002\u0004\u0007\u0004\u0002"+
		"\u0005\u0007\u0005\u0002\u0006\u0007\u0006\u0002\u0007\u0007\u0007\u0002"+
		"\b\u0007\b\u0002\t\u0007\t\u0002\n\u0007\n\u0002\u000b\u0007\u000b\u0002"+
		"\f\u0007\f\u0002\r\u0007\r\u0002\u000e\u0007\u000e\u0002\u000f\u0007\u000f"+
		"\u0002\u0010\u0007\u0010\u0002\u0011\u0007\u0011\u0002\u0012\u0007\u0012"+
		"\u0002\u0013\u0007\u0013\u0002\u0014\u0007\u0014\u0002\u0015\u0007\u0015"+
		"\u0002\u0016\u0007\u0016\u0002\u0017\u0007\u0017\u0002\u0018\u0007\u0018"+
		"\u0002\u0019\u0007\u0019\u0002\u001a\u0007\u001a\u0002\u001b\u0007\u001b"+
		"\u0002\u001c\u0007\u001c\u0002\u001d\u0007\u001d\u0002\u001e\u0007\u001e"+
		"\u0001\u0000\u0001\u0000\u0001\u0000\u0005\u0000B\b\u0000\n\u0000\f\u0000"+
		"E\t\u0000\u0001\u0001\u0001\u0001\u0003\u0001I\b\u0001\u0001\u0002\u0001"+
		"\u0002\u0001\u0002\u0001\u0003\u0001\u0003\u0001\u0003\u0001\u0004\u0001"+
		"\u0004\u0001\u0004\u0001\u0004\u0001\u0004\u0001\u0004\u0001\u0004\u0001"+
		"\u0005\u0001\u0005\u0001\u0006\u0001\u0006\u0001\u0006\u0001\u0006\u0001"+
		"\u0006\u0001\u0006\u0005\u0006`\b\u0006\n\u0006\f\u0006c\t\u0006\u0001"+
		"\u0007\u0001\u0007\u0001\u0007\u0001\b\u0001\b\u0001\b\u0001\t\u0001\t"+
		"\u0001\t\u0001\t\u0001\t\u0003\tp\b\t\u0001\n\u0001\n\u0005\nt\b\n\n\n"+
		"\f\nw\t\n\u0001\n\u0001\n\u0001\u000b\u0001\u000b\u0001\u000b\u0001\u000b"+
		"\u0001\u000b\u0003\u000b\u0080\b\u000b\u0001\f\u0001\f\u0001\f\u0001\f"+
		"\u0001\f\u0001\f\u0001\f\u0001\f\u0001\f\u0001\f\u0001\f\u0001\f\u0001"+
		"\f\u0001\f\u0003\f\u0090\b\f\u0001\r\u0001\r\u0001\r\u0001\r\u0001\r\u0001"+
		"\r\u0001\r\u0001\r\u0001\r\u0001\r\u0001\r\u0001\r\u0001\r\u0001\r\u0001"+
		"\r\u0001\r\u0003\r\u00a2\b\r\u0001\u000e\u0001\u000e\u0001\u000e\u0001"+
		"\u000e\u0001\u000e\u0001\u000e\u0001\u000e\u0001\u000e\u0003\u000e\u00ac"+
		"\b\u000e\u0001\u000f\u0001\u000f\u0001\u0010\u0001\u0010\u0001\u0010\u0001"+
		"\u0010\u0001\u0010\u0001\u0010\u0003\u0010\u00b6\b\u0010\u0001\u0011\u0001"+
		"\u0011\u0001\u0011\u0001\u0011\u0001\u0011\u0001\u0011\u0001\u0011\u0003"+
		"\u0011\u00bf\b\u0011\u0001\u0012\u0001\u0012\u0001\u0012\u0001\u0012\u0001"+
		"\u0012\u0001\u0012\u0005\u0012\u00c7\b\u0012\n\u0012\f\u0012\u00ca\t\u0012"+
		"\u0001\u0013\u0001\u0013\u0001\u0013\u0001\u0013\u0001\u0013\u0001\u0013"+
		"\u0005\u0013\u00d2\b\u0013\n\u0013\f\u0013\u00d5\t\u0013\u0001\u0014\u0001"+
		"\u0014\u0001\u0014\u0001\u0014\u0001\u0014\u0001\u0014\u0001\u0014\u0001"+
		"\u0014\u0001\u0014\u0005\u0014\u00e0\b\u0014\n\u0014\f\u0014\u00e3\t\u0014"+
		"\u0001\u0015\u0001\u0015\u0001\u0015\u0001\u0015\u0001\u0015\u0001\u0015"+
		"\u0001\u0015\u0001\u0015\u0001\u0015\u0001\u0015\u0001\u0015\u0001\u0015"+
		"\u0001\u0015\u0001\u0015\u0001\u0015\u0005\u0015\u00f4\b\u0015\n\u0015"+
		"\f\u0015\u00f7\t\u0015\u0001\u0016\u0001\u0016\u0001\u0016\u0001\u0016"+
		"\u0001\u0016\u0001\u0016\u0001\u0016\u0001\u0016\u0001\u0016\u0005\u0016"+
		"\u0102\b\u0016\n\u0016\f\u0016\u0105\t\u0016\u0001\u0017\u0001\u0017\u0001"+
		"\u0017\u0001\u0017\u0001\u0017\u0001\u0017\u0001\u0017\u0001\u0017\u0001"+
		"\u0017\u0005\u0017\u0110\b\u0017\n\u0017\f\u0017\u0113\t\u0017\u0001\u0018"+
		"\u0001\u0018\u0001\u0018\u0001\u0018\u0001\u0018\u0001\u0018\u0001\u0018"+
		"\u0001\u0018\u0001\u0018\u0001\u0018\u0001\u0018\u0001\u0018\u0005\u0018"+
		"\u0121\b\u0018\n\u0018\f\u0018\u0124\t\u0018\u0001\u0019\u0001\u0019\u0001"+
		"\u0019\u0001\u0019\u0001\u0019\u0001\u0019\u0003\u0019\u012c\b\u0019\u0001"+
		"\u0019\u0001\u0019\u0001\u0019\u0001\u0019\u0005\u0019\u0132\b\u0019\n"+
		"\u0019\f\u0019\u0135\t\u0019\u0001\u001a\u0001\u001a\u0001\u001b\u0001"+
		"\u001b\u0001\u001b\u0001\u001b\u0001\u001b\u0001\u001c\u0001\u001c\u0001"+
		"\u001d\u0001\u001d\u0001\u001e\u0001\u001e\u0001\u001e\u0000\t\f$&(*,"+
		".02\u001f\u0000\u0002\u0004\u0006\b\n\f\u000e\u0010\u0012\u0014\u0016"+
		"\u0018\u001a\u001c\u001e \"$&(*,.02468:<\u0000\u0004\u0001\u0000\u0005"+
		"\n\u0001\u000045\u0002\u0000\f\f,0\u0001\u000012\u0147\u0000>\u0001\u0000"+
		"\u0000\u0000\u0002H\u0001\u0000\u0000\u0000\u0004J\u0001\u0000\u0000\u0000"+
		"\u0006M\u0001\u0000\u0000\u0000\bP\u0001\u0000\u0000\u0000\nW\u0001\u0000"+
		"\u0000\u0000\fY\u0001\u0000\u0000\u0000\u000ed\u0001\u0000\u0000\u0000"+
		"\u0010g\u0001\u0000\u0000\u0000\u0012o\u0001\u0000\u0000\u0000\u0014q"+
		"\u0001\u0000\u0000\u0000\u0016\u007f\u0001\u0000\u0000\u0000\u0018\u008f"+
		"\u0001\u0000\u0000\u0000\u001a\u00a1\u0001\u0000\u0000\u0000\u001c\u00ab"+
		"\u0001\u0000\u0000\u0000\u001e\u00ad\u0001\u0000\u0000\u0000 \u00b5\u0001"+
		"\u0000\u0000\u0000\"\u00be\u0001\u0000\u0000\u0000$\u00c0\u0001\u0000"+
		"\u0000\u0000&\u00cb\u0001\u0000\u0000\u0000(\u00d6\u0001\u0000\u0000\u0000"+
		"*\u00e4\u0001\u0000\u0000\u0000,\u00f8\u0001\u0000\u0000\u0000.\u0106"+
		"\u0001\u0000\u0000\u00000\u0114\u0001\u0000\u0000\u00002\u012b\u0001\u0000"+
		"\u0000\u00004\u0136\u0001\u0000\u0000\u00006\u0138\u0001\u0000\u0000\u0000"+
		"8\u013d\u0001\u0000\u0000\u0000:\u013f\u0001\u0000\u0000\u0000<\u0141"+
		"\u0001\u0000\u0000\u0000>?\u0003\u0004\u0002\u0000?C\u0003\u0006\u0003"+
		"\u0000@B\u0003\u0002\u0001\u0000A@\u0001\u0000\u0000\u0000BE\u0001\u0000"+
		"\u0000\u0000CA\u0001\u0000\u0000\u0000CD\u0001\u0000\u0000\u0000D\u0001"+
		"\u0001\u0000\u0000\u0000EC\u0001\u0000\u0000\u0000FI\u0003\b\u0004\u0000"+
		"GI\u0003\u0010\b\u0000HF\u0001\u0000\u0000\u0000HG\u0001\u0000\u0000\u0000"+
		"I\u0003\u0001\u0000\u0000\u0000JK\u0005\u0001\u0000\u0000KL\u0003\u0014"+
		"\n\u0000L\u0005\u0001\u0000\u0000\u0000MN\u0005\u0002\u0000\u0000NO\u0003"+
		"\u0014\n\u0000O\u0007\u0001\u0000\u0000\u0000PQ\u0003\n\u0005\u0000QR"+
		"\u00038\u001c\u0000RS\u0005\u0003\u0000\u0000ST\u0003\f\u0006\u0000TU"+
		"\u0005\u0004\u0000\u0000UV\u0003\u0014\n\u0000V\t\u0001\u0000\u0000\u0000"+
		"WX\u0007\u0000\u0000\u0000X\u000b\u0001\u0000\u0000\u0000YZ\u0006\u0006"+
		"\uffff\uffff\u0000Z[\u0003\u000e\u0007\u0000[a\u0001\u0000\u0000\u0000"+
		"\\]\n\u0001\u0000\u0000]^\u0005\u000b\u0000\u0000^`\u0003\u000e\u0007"+
		"\u0000_\\\u0001\u0000\u0000\u0000`c\u0001\u0000\u0000\u0000a_\u0001\u0000"+
		"\u0000\u0000ab\u0001\u0000\u0000\u0000b\r\u0001\u0000\u0000\u0000ca\u0001"+
		"\u0000\u0000\u0000de\u0003\n\u0005\u0000ef\u00038\u001c\u0000f\u000f\u0001"+
		"\u0000\u0000\u0000gh\u0003\n\u0005\u0000hi\u0003\u0012\t\u0000i\u0011"+
		"\u0001\u0000\u0000\u0000jp\u00038\u001c\u0000kl\u00038\u001c\u0000lm\u0005"+
		"\f\u0000\u0000mn\u0003 \u0010\u0000np\u0001\u0000\u0000\u0000oj\u0001"+
		"\u0000\u0000\u0000ok\u0001\u0000\u0000\u0000p\u0013\u0001\u0000\u0000"+
		"\u0000qu\u0005\r\u0000\u0000rt\u0003\u0016\u000b\u0000sr\u0001\u0000\u0000"+
		"\u0000tw\u0001\u0000\u0000\u0000us\u0001\u0000\u0000\u0000uv\u0001\u0000"+
		"\u0000\u0000vx\u0001\u0000\u0000\u0000wu\u0001\u0000\u0000\u0000xy\u0005"+
		"\u000e\u0000\u0000y\u0015\u0001\u0000\u0000\u0000z\u0080\u0003\u0018\f"+
		"\u0000{\u0080\u0003\u001a\r\u0000|\u0080\u0003\u001c\u000e\u0000}\u0080"+
		"\u0003\u0010\b\u0000~\u0080\u0003\u001e\u000f\u0000\u007fz\u0001\u0000"+
		"\u0000\u0000\u007f{\u0001\u0000\u0000\u0000\u007f|\u0001\u0000\u0000\u0000"+
		"\u007f}\u0001\u0000\u0000\u0000\u007f~\u0001\u0000\u0000\u0000\u0080\u0017"+
		"\u0001\u0000\u0000\u0000\u0081\u0082\u0005\u000f\u0000\u0000\u0082\u0083"+
		"\u0005\u0003\u0000\u0000\u0083\u0084\u0003\u001e\u000f\u0000\u0084\u0085"+
		"\u0005\u0004\u0000\u0000\u0085\u0086\u0003\u0014\n\u0000\u0086\u0090\u0001"+
		"\u0000\u0000\u0000\u0087\u0088\u0005\u000f\u0000\u0000\u0088\u0089\u0005"+
		"\u0003\u0000\u0000\u0089\u008a\u0003\u001e\u000f\u0000\u008a\u008b\u0005"+
		"\u0004\u0000\u0000\u008b\u008c\u0003\u0014\n\u0000\u008c\u008d\u0005\u0010"+
		"\u0000\u0000\u008d\u008e\u0003\u0014\n\u0000\u008e\u0090\u0001\u0000\u0000"+
		"\u0000\u008f\u0081\u0001\u0000\u0000\u0000\u008f\u0087\u0001\u0000\u0000"+
		"\u0000\u0090\u0019\u0001\u0000\u0000\u0000\u0091\u0092\u0005\u0011\u0000"+
		"\u0000\u0092\u0093\u0005\u0003\u0000\u0000\u0093\u0094\u0003\u001e\u000f"+
		"\u0000\u0094\u0095\u0005\u0004\u0000\u0000\u0095\u0096\u0003\u0014\n\u0000"+
		"\u0096\u00a2\u0001\u0000\u0000\u0000\u0097\u0098\u0005\u0012\u0000\u0000"+
		"\u0098\u0099\u0005\u0003\u0000\u0000\u0099\u009a\u0003\u001e\u000f\u0000"+
		"\u009a\u009b\u0005\u0013\u0000\u0000\u009b\u009c\u0003\u001e\u000f\u0000"+
		"\u009c\u009d\u0005\u0013\u0000\u0000\u009d\u009e\u0003\u001e\u000f\u0000"+
		"\u009e\u009f\u0005\u0004\u0000\u0000\u009f\u00a0\u0003\u0014\n\u0000\u00a0"+
		"\u00a2\u0001\u0000\u0000\u0000\u00a1\u0091\u0001\u0000\u0000\u0000\u00a1"+
		"\u0097\u0001\u0000\u0000\u0000\u00a2\u001b\u0001\u0000\u0000\u0000\u00a3"+
		"\u00a4\u0005\u0014\u0000\u0000\u00a4\u00ac\u0005\u0013\u0000\u0000\u00a5"+
		"\u00a6\u0005\u0015\u0000\u0000\u00a6\u00ac\u0005\u0013\u0000\u0000\u00a7"+
		"\u00a8\u0005\u0016\u0000\u0000\u00a8\u00a9\u0003\u001e\u000f\u0000\u00a9"+
		"\u00aa\u0005\u0013\u0000\u0000\u00aa\u00ac\u0001\u0000\u0000\u0000\u00ab"+
		"\u00a3\u0001\u0000\u0000\u0000\u00ab\u00a5\u0001\u0000\u0000\u0000\u00ab"+
		"\u00a7\u0001\u0000\u0000\u0000\u00ac\u001d\u0001\u0000\u0000\u0000\u00ad"+
		"\u00ae\u0003 \u0010\u0000\u00ae\u001f\u0001\u0000\u0000\u0000\u00af\u00b6"+
		"\u0003\"\u0011\u0000\u00b0\u00b6\u00036\u001b\u0000\u00b1\u00b2\u0003"+
		"2\u0019\u0000\u00b2\u00b3\u0003:\u001d\u0000\u00b3\u00b4\u0003 \u0010"+
		"\u0000\u00b4\u00b6\u0001\u0000\u0000\u0000\u00b5\u00af\u0001\u0000\u0000"+
		"\u0000\u00b5\u00b0\u0001\u0000\u0000\u0000\u00b5\u00b1\u0001\u0000\u0000"+
		"\u0000\u00b6!\u0001\u0000\u0000\u0000\u00b7\u00bf\u0003$\u0012\u0000\u00b8"+
		"\u00b9\u0003$\u0012\u0000\u00b9\u00ba\u0005\u0017\u0000\u0000\u00ba\u00bb"+
		"\u0003\u001e\u000f\u0000\u00bb\u00bc\u0005\u0018\u0000\u0000\u00bc\u00bd"+
		"\u0003\u001e\u000f\u0000\u00bd\u00bf\u0001\u0000\u0000\u0000\u00be\u00b7"+
		"\u0001\u0000\u0000\u0000\u00be\u00b8\u0001\u0000\u0000\u0000\u00bf#\u0001"+
		"\u0000\u0000\u0000\u00c0\u00c1\u0006\u0012\uffff\uffff\u0000\u00c1\u00c2"+
		"\u0003&\u0013\u0000\u00c2\u00c8\u0001\u0000\u0000\u0000\u00c3\u00c4\n"+
		"\u0001\u0000\u0000\u00c4\u00c5\u0005\u0019\u0000\u0000\u00c5\u00c7\u0003"+
		"&\u0013\u0000\u00c6\u00c3\u0001\u0000\u0000\u0000\u00c7\u00ca\u0001\u0000"+
		"\u0000\u0000\u00c8\u00c6\u0001\u0000\u0000\u0000\u00c8\u00c9\u0001\u0000"+
		"\u0000\u0000\u00c9%\u0001\u0000\u0000\u0000\u00ca\u00c8\u0001\u0000\u0000"+
		"\u0000\u00cb\u00cc\u0006\u0013\uffff\uffff\u0000\u00cc\u00cd\u0003(\u0014"+
		"\u0000\u00cd\u00d3\u0001\u0000\u0000\u0000\u00ce\u00cf\n\u0001\u0000\u0000"+
		"\u00cf\u00d0\u0005\u001a\u0000\u0000\u00d0\u00d2\u0003(\u0014\u0000\u00d1"+
		"\u00ce\u0001\u0000\u0000\u0000\u00d2\u00d5\u0001\u0000\u0000\u0000\u00d3"+
		"\u00d1\u0001\u0000\u0000\u0000\u00d3\u00d4\u0001\u0000\u0000\u0000\u00d4"+
		"\'\u0001\u0000\u0000\u0000\u00d5\u00d3\u0001\u0000\u0000\u0000\u00d6\u00d7"+
		"\u0006\u0014\uffff\uffff\u0000\u00d7\u00d8\u0003*\u0015\u0000\u00d8\u00e1"+
		"\u0001\u0000\u0000\u0000\u00d9\u00da\n\u0002\u0000\u0000\u00da\u00db\u0005"+
		"\u001b\u0000\u0000\u00db\u00e0\u0003*\u0015\u0000\u00dc\u00dd\n\u0001"+
		"\u0000\u0000\u00dd\u00de\u0005\u001c\u0000\u0000\u00de\u00e0\u0003*\u0015"+
		"\u0000\u00df\u00d9\u0001\u0000\u0000\u0000\u00df\u00dc\u0001\u0000\u0000"+
		"\u0000\u00e0\u00e3\u0001\u0000\u0000\u0000\u00e1\u00df\u0001\u0000\u0000"+
		"\u0000\u00e1\u00e2\u0001\u0000\u0000\u0000\u00e2)\u0001\u0000\u0000\u0000"+
		"\u00e3\u00e1\u0001\u0000\u0000\u0000\u00e4\u00e5\u0006\u0015\uffff\uffff"+
		"\u0000\u00e5\u00e6\u0003,\u0016\u0000\u00e6\u00f5\u0001\u0000\u0000\u0000"+
		"\u00e7\u00e8\n\u0004\u0000\u0000\u00e8\u00e9\u0005\u001d\u0000\u0000\u00e9"+
		"\u00f4\u0003,\u0016\u0000\u00ea\u00eb\n\u0003\u0000\u0000\u00eb\u00ec"+
		"\u0005\u001e\u0000\u0000\u00ec\u00f4\u0003,\u0016\u0000\u00ed\u00ee\n"+
		"\u0002\u0000\u0000\u00ee\u00ef\u0005\u001f\u0000\u0000\u00ef\u00f4\u0003"+
		",\u0016\u0000\u00f0\u00f1\n\u0001\u0000\u0000\u00f1\u00f2\u0005 \u0000"+
		"\u0000\u00f2\u00f4\u0003,\u0016\u0000\u00f3\u00e7\u0001\u0000\u0000\u0000"+
		"\u00f3\u00ea\u0001\u0000\u0000\u0000\u00f3\u00ed\u0001\u0000\u0000\u0000"+
		"\u00f3\u00f0\u0001\u0000\u0000\u0000\u00f4\u00f7\u0001\u0000\u0000\u0000"+
		"\u00f5\u00f3\u0001\u0000\u0000\u0000\u00f5\u00f6\u0001\u0000\u0000\u0000"+
		"\u00f6+\u0001\u0000\u0000\u0000\u00f7\u00f5\u0001\u0000\u0000\u0000\u00f8"+
		"\u00f9\u0006\u0016\uffff\uffff\u0000\u00f9\u00fa\u0003.\u0017\u0000\u00fa"+
		"\u0103\u0001\u0000\u0000\u0000\u00fb\u00fc\n\u0002\u0000\u0000\u00fc\u00fd"+
		"\u0005!\u0000\u0000\u00fd\u0102\u0003.\u0017\u0000\u00fe\u00ff\n\u0001"+
		"\u0000\u0000\u00ff\u0100\u0005\"\u0000\u0000\u0100\u0102\u0003.\u0017"+
		"\u0000\u0101\u00fb\u0001\u0000\u0000\u0000\u0101\u00fe\u0001\u0000\u0000"+
		"\u0000\u0102\u0105\u0001\u0000\u0000\u0000\u0103\u0101\u0001\u0000\u0000"+
		"\u0000\u0103\u0104\u0001\u0000\u0000\u0000\u0104-\u0001\u0000\u0000\u0000"+
		"\u0105\u0103\u0001\u0000\u0000\u0000\u0106\u0107\u0006\u0017\uffff\uffff"+
		"\u0000\u0107\u0108\u00030\u0018\u0000\u0108\u0111\u0001\u0000\u0000\u0000"+
		"\u0109\u010a\n\u0002\u0000\u0000\u010a\u010b\u0005#\u0000\u0000\u010b"+
		"\u0110\u00030\u0018\u0000\u010c\u010d\n\u0001\u0000\u0000\u010d\u010e"+
		"\u0005$\u0000\u0000\u010e\u0110\u00030\u0018\u0000\u010f\u0109\u0001\u0000"+
		"\u0000\u0000\u010f\u010c\u0001\u0000\u0000\u0000\u0110\u0113\u0001\u0000"+
		"\u0000\u0000\u0111\u010f\u0001\u0000\u0000\u0000\u0111\u0112\u0001\u0000"+
		"\u0000\u0000\u0112/\u0001\u0000\u0000\u0000\u0113\u0111\u0001\u0000\u0000"+
		"\u0000\u0114\u0115\u0006\u0018\uffff\uffff\u0000\u0115\u0116\u00032\u0019"+
		"\u0000\u0116\u0122\u0001\u0000\u0000\u0000\u0117\u0118\n\u0003\u0000\u0000"+
		"\u0118\u0119\u0005%\u0000\u0000\u0119\u0121\u00032\u0019\u0000\u011a\u011b"+
		"\n\u0002\u0000\u0000\u011b\u011c\u0005&\u0000\u0000\u011c\u0121\u0003"+
		"2\u0019\u0000\u011d\u011e\n\u0001\u0000\u0000\u011e\u011f\u0005\'\u0000"+
		"\u0000\u011f\u0121\u00032\u0019\u0000\u0120\u0117\u0001\u0000\u0000\u0000"+
		"\u0120\u011a\u0001\u0000\u0000\u0000\u0120\u011d\u0001\u0000\u0000\u0000"+
		"\u0121\u0124\u0001\u0000\u0000\u0000\u0122\u0120\u0001\u0000\u0000\u0000"+
		"\u0122\u0123\u0001\u0000\u0000\u0000\u01231\u0001\u0000\u0000\u0000\u0124"+
		"\u0122\u0001\u0000\u0000\u0000\u0125\u0126\u0006\u0019\uffff\uffff\u0000"+
		"\u0126\u012c\u00034\u001a\u0000\u0127\u0128\u0005(\u0000\u0000\u0128\u012c"+
		"\u00032\u0019\u0002\u0129\u012a\u0005)\u0000\u0000\u012a\u012c\u00032"+
		"\u0019\u0001\u012b\u0125\u0001\u0000\u0000\u0000\u012b\u0127\u0001\u0000"+
		"\u0000\u0000\u012b\u0129\u0001\u0000\u0000\u0000\u012c\u0133\u0001\u0000"+
		"\u0000\u0000\u012d\u012e\n\u0004\u0000\u0000\u012e\u0132\u0005(\u0000"+
		"\u0000\u012f\u0130\n\u0003\u0000\u0000\u0130\u0132\u0005)\u0000\u0000"+
		"\u0131\u012d\u0001\u0000\u0000\u0000\u0131\u012f\u0001\u0000\u0000\u0000"+
		"\u0132\u0135\u0001\u0000\u0000\u0000\u0133\u0131\u0001\u0000\u0000\u0000"+
		"\u0133\u0134\u0001\u0000\u0000\u0000\u01343\u0001\u0000\u0000\u0000\u0135"+
		"\u0133\u0001\u0000\u0000\u0000\u0136\u0137\u0007\u0001\u0000\u0000\u0137"+
		"5\u0001\u0000\u0000\u0000\u0138\u0139\u0005*\u0000\u0000\u0139\u013a\u0003"+
		"8\u001c\u0000\u013a\u013b\u0005+\u0000\u0000\u013b\u013c\u0003<\u001e"+
		"\u0000\u013c7\u0001\u0000\u0000\u0000\u013d\u013e\u00053\u0000\u0000\u013e"+
		"9\u0001\u0000\u0000\u0000\u013f\u0140\u0007\u0002\u0000\u0000\u0140;\u0001"+
		"\u0000\u0000\u0000\u0141\u0142\u0007\u0003\u0000\u0000\u0142=\u0001\u0000"+
		"\u0000\u0000\u001aCHaou\u007f\u008f\u00a1\u00ab\u00b5\u00be\u00c8\u00d3"+
		"\u00df\u00e1\u00f3\u00f5\u0101\u0103\u010f\u0111\u0120\u0122\u012b\u0131"+
		"\u0133";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}