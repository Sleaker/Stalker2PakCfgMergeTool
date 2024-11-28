//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.13.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from f:/Apps/Stalker2Modding/Stalker2PakCfgMergeTool/Stalker2PakCfgMergeTool/grammar/Stalker2Cfg.g4 by ANTLR 4.13.1

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
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.1")]
[System.CLSCompliant(false)]
public partial class Stalker2CfgParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, SINGLE_LINE_COMMENT=3, INLINE_COMMENT=4, STRUCT_START=5, 
		STRUCT_END=6, STRUCT_KEY=7, ASSIGNMENT=8, PERCENTAGE=9, INTEGER=10, NUMBER=11, 
		LITERAL=12, PATH_VAL=13, STRING_ARRAY=14, STRING=15, PATH_REF=16, NEWLINE=17, 
		STRUCT_LITERAL=18, KV_SEPARATOR=19, OPEN_BRACE=20, CLOSE_BRACE=21, WS=22;
	public const int
		RULE_cfg = 0, RULE_map = 1, RULE_pair = 2, RULE_struct_pair = 3, RULE_struct_ref = 4, 
		RULE_value = 5, RULE_key = 6, RULE_array_ref = 7, RULE_set_ref = 8, RULE_number = 9, 
		RULE_struct_key = 10;
	public static readonly string[] ruleNames = {
		"cfg", "map", "pair", "struct_pair", "struct_ref", "value", "key", "array_ref", 
		"set_ref", "number", "struct_key"
	};

	private static readonly string[] _LiteralNames = {
		null, "','", "'*'", null, null, null, "'struct.end'", null, "'='", null, 
		null, null, null, null, null, null, null, null, "'bskipref'", "';'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, "SINGLE_LINE_COMMENT", "INLINE_COMMENT", "STRUCT_START", 
		"STRUCT_END", "STRUCT_KEY", "ASSIGNMENT", "PERCENTAGE", "INTEGER", "NUMBER", 
		"LITERAL", "PATH_VAL", "STRING_ARRAY", "STRING", "PATH_REF", "NEWLINE", 
		"STRUCT_LITERAL", "KV_SEPARATOR", "OPEN_BRACE", "CLOSE_BRACE", "WS"
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

	public override string GrammarFileName { get { return "Stalker2Cfg.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static Stalker2CfgParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public Stalker2CfgParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public Stalker2CfgParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	public partial class CfgContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Eof() { return GetToken(Stalker2CfgParser.Eof, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public MapContext[] map() {
			return GetRuleContexts<MapContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public MapContext map(int i) {
			return GetRuleContext<MapContext>(i);
		}
		public CfgContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_cfg; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IStalker2CfgVisitor<TResult> typedVisitor = visitor as IStalker2CfgVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitCfg(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public CfgContext cfg() {
		CfgContext _localctx = new CfgContext(Context, State);
		EnterRule(_localctx, 0, RULE_cfg);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 25;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & 1212552L) != 0)) {
				{
				{
				State = 22;
				map();
				}
				}
				State = 27;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 28;
			Match(Eof);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class MapContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public KeyContext key() {
			return GetRuleContext<KeyContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode STRUCT_START() { return GetToken(Stalker2CfgParser.STRUCT_START, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] NEWLINE() { return GetTokens(Stalker2CfgParser.NEWLINE); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NEWLINE(int i) {
			return GetToken(Stalker2CfgParser.NEWLINE, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode STRUCT_END() { return GetToken(Stalker2CfgParser.STRUCT_END, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Struct_refContext[] struct_ref() {
			return GetRuleContexts<Struct_refContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Struct_refContext struct_ref(int i) {
			return GetRuleContext<Struct_refContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public PairContext[] pair() {
			return GetRuleContexts<PairContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public PairContext pair(int i) {
			return GetRuleContext<PairContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public MapContext[] map() {
			return GetRuleContexts<MapContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public MapContext map(int i) {
			return GetRuleContext<MapContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SINGLE_LINE_COMMENT() { return GetToken(Stalker2CfgParser.SINGLE_LINE_COMMENT, 0); }
		public MapContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_map; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IStalker2CfgVisitor<TResult> typedVisitor = visitor as IStalker2CfgVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitMap(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public MapContext map() {
		MapContext _localctx = new MapContext(Context, State);
		EnterRule(_localctx, 2, RULE_map);
		int _la;
		try {
			State = 52;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case STRUCT_KEY:
			case STRING:
			case OPEN_BRACE:
				EnterOuterAlt(_localctx, 1);
				{
				State = 30;
				key();
				State = 31;
				Match(STRUCT_START);
				State = 35;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==OPEN_BRACE) {
					{
					{
					State = 32;
					struct_ref();
					}
					}
					State = 37;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				State = 38;
				Match(NEWLINE);
				State = 43;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while ((((_la) & ~0x3f) == 0 && ((1L << _la) & 1212552L) != 0)) {
					{
					State = 41;
					ErrorHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(TokenStream,2,Context) ) {
					case 1:
						{
						State = 39;
						pair();
						}
						break;
					case 2:
						{
						State = 40;
						map();
						}
						break;
					}
					}
					State = 45;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				State = 46;
				Match(STRUCT_END);
				State = 48;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,4,Context) ) {
				case 1:
					{
					State = 47;
					Match(NEWLINE);
					}
					break;
				}
				}
				break;
			case SINGLE_LINE_COMMENT:
				EnterOuterAlt(_localctx, 2);
				{
				State = 50;
				Match(SINGLE_LINE_COMMENT);
				}
				break;
			case NEWLINE:
				EnterOuterAlt(_localctx, 3);
				{
				State = 51;
				Match(NEWLINE);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class PairContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public KeyContext key() {
			return GetRuleContext<KeyContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ASSIGNMENT() { return GetToken(Stalker2CfgParser.ASSIGNMENT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ValueContext value() {
			return GetRuleContext<ValueContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NEWLINE() { return GetToken(Stalker2CfgParser.NEWLINE, 0); }
		public PairContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_pair; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IStalker2CfgVisitor<TResult> typedVisitor = visitor as IStalker2CfgVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitPair(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public PairContext pair() {
		PairContext _localctx = new PairContext(Context, State);
		EnterRule(_localctx, 4, RULE_pair);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 54;
			key();
			State = 55;
			Match(ASSIGNMENT);
			State = 57;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,6,Context) ) {
			case 1:
				{
				State = 56;
				value();
				}
				break;
			}
			State = 60;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,7,Context) ) {
			case 1:
				{
				State = 59;
				Match(NEWLINE);
				}
				break;
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Struct_pairContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public PairContext pair() {
			return GetRuleContext<PairContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode STRUCT_LITERAL() { return GetToken(Stalker2CfgParser.STRUCT_LITERAL, 0); }
		public Struct_pairContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_struct_pair; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IStalker2CfgVisitor<TResult> typedVisitor = visitor as IStalker2CfgVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitStruct_pair(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public Struct_pairContext struct_pair() {
		Struct_pairContext _localctx = new Struct_pairContext(Context, State);
		EnterRule(_localctx, 6, RULE_struct_pair);
		try {
			State = 64;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case STRUCT_KEY:
			case STRING:
			case OPEN_BRACE:
				EnterOuterAlt(_localctx, 1);
				{
				State = 62;
				pair();
				}
				break;
			case STRUCT_LITERAL:
				EnterOuterAlt(_localctx, 2);
				{
				State = 63;
				Match(STRUCT_LITERAL);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Struct_refContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_BRACE() { return GetToken(Stalker2CfgParser.OPEN_BRACE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Struct_pairContext struct_pair() {
			return GetRuleContext<Struct_pairContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_BRACE() { return GetToken(Stalker2CfgParser.CLOSE_BRACE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] KV_SEPARATOR() { return GetTokens(Stalker2CfgParser.KV_SEPARATOR); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode KV_SEPARATOR(int i) {
			return GetToken(Stalker2CfgParser.KV_SEPARATOR, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public PairContext[] pair() {
			return GetRuleContexts<PairContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public PairContext pair(int i) {
			return GetRuleContext<PairContext>(i);
		}
		public Struct_refContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_struct_ref; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IStalker2CfgVisitor<TResult> typedVisitor = visitor as IStalker2CfgVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitStruct_ref(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public Struct_refContext struct_ref() {
		Struct_refContext _localctx = new Struct_refContext(Context, State);
		EnterRule(_localctx, 8, RULE_struct_ref);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 66;
			Match(OPEN_BRACE);
			State = 67;
			struct_pair();
			State = 72;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==KV_SEPARATOR) {
				{
				{
				State = 68;
				Match(KV_SEPARATOR);
				State = 69;
				pair();
				}
				}
				State = 74;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 75;
			Match(CLOSE_BRACE);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ValueContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public NumberContext number() {
			return GetRuleContext<NumberContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LITERAL() { return GetToken(Stalker2CfgParser.LITERAL, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] STRING() { return GetTokens(Stalker2CfgParser.STRING); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode STRING(int i) {
			return GetToken(Stalker2CfgParser.STRING, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PATH_REF() { return GetToken(Stalker2CfgParser.PATH_REF, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Array_refContext array_ref() {
			return GetRuleContext<Array_refContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PATH_VAL() { return GetToken(Stalker2CfgParser.PATH_VAL, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode STRING_ARRAY() { return GetToken(Stalker2CfgParser.STRING_ARRAY, 0); }
		public ValueContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_value; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IStalker2CfgVisitor<TResult> typedVisitor = visitor as IStalker2CfgVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitValue(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ValueContext value() {
		ValueContext _localctx = new ValueContext(Context, State);
		EnterRule(_localctx, 10, RULE_value);
		int _la;
		try {
			State = 91;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case PERCENTAGE:
			case INTEGER:
			case NUMBER:
				EnterOuterAlt(_localctx, 1);
				{
				State = 77;
				number();
				}
				break;
			case LITERAL:
				EnterOuterAlt(_localctx, 2);
				{
				State = 78;
				Match(LITERAL);
				}
				break;
			case STRING:
				EnterOuterAlt(_localctx, 3);
				{
				State = 79;
				Match(STRING);
				State = 84;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==T__0) {
					{
					{
					State = 80;
					Match(T__0);
					State = 81;
					Match(STRING);
					}
					}
					State = 86;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				}
				break;
			case PATH_REF:
				EnterOuterAlt(_localctx, 4);
				{
				State = 87;
				Match(PATH_REF);
				}
				break;
			case OPEN_BRACE:
				EnterOuterAlt(_localctx, 5);
				{
				State = 88;
				array_ref();
				}
				break;
			case PATH_VAL:
				EnterOuterAlt(_localctx, 6);
				{
				State = 89;
				Match(PATH_VAL);
				}
				break;
			case STRING_ARRAY:
				EnterOuterAlt(_localctx, 7);
				{
				State = 90;
				Match(STRING_ARRAY);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class KeyContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Struct_keyContext struct_key() {
			return GetRuleContext<Struct_keyContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode STRING() { return GetToken(Stalker2CfgParser.STRING, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Array_refContext array_ref() {
			return GetRuleContext<Array_refContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Set_refContext set_ref() {
			return GetRuleContext<Set_refContext>(0);
		}
		public KeyContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_key; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IStalker2CfgVisitor<TResult> typedVisitor = visitor as IStalker2CfgVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitKey(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public KeyContext key() {
		KeyContext _localctx = new KeyContext(Context, State);
		EnterRule(_localctx, 12, RULE_key);
		try {
			State = 97;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,12,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 93;
				struct_key();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 94;
				Match(STRING);
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 95;
				array_ref();
				}
				break;
			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 96;
				set_ref();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Array_refContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_BRACE() { return GetToken(Stalker2CfgParser.OPEN_BRACE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INTEGER() { return GetToken(Stalker2CfgParser.INTEGER, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_BRACE() { return GetToken(Stalker2CfgParser.CLOSE_BRACE, 0); }
		public Array_refContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_array_ref; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IStalker2CfgVisitor<TResult> typedVisitor = visitor as IStalker2CfgVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitArray_ref(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public Array_refContext array_ref() {
		Array_refContext _localctx = new Array_refContext(Context, State);
		EnterRule(_localctx, 14, RULE_array_ref);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 99;
			Match(OPEN_BRACE);
			State = 100;
			Match(INTEGER);
			State = 101;
			Match(CLOSE_BRACE);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Set_refContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_BRACE() { return GetToken(Stalker2CfgParser.OPEN_BRACE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_BRACE() { return GetToken(Stalker2CfgParser.CLOSE_BRACE, 0); }
		public Set_refContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_set_ref; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IStalker2CfgVisitor<TResult> typedVisitor = visitor as IStalker2CfgVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitSet_ref(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public Set_refContext set_ref() {
		Set_refContext _localctx = new Set_refContext(Context, State);
		EnterRule(_localctx, 16, RULE_set_ref);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 103;
			Match(OPEN_BRACE);
			State = 104;
			Match(T__1);
			State = 105;
			Match(CLOSE_BRACE);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class NumberContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NUMBER() { return GetToken(Stalker2CfgParser.NUMBER, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PERCENTAGE() { return GetToken(Stalker2CfgParser.PERCENTAGE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INTEGER() { return GetToken(Stalker2CfgParser.INTEGER, 0); }
		public NumberContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_number; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IStalker2CfgVisitor<TResult> typedVisitor = visitor as IStalker2CfgVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitNumber(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public NumberContext number() {
		NumberContext _localctx = new NumberContext(Context, State);
		EnterRule(_localctx, 18, RULE_number);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 107;
			_la = TokenStream.LA(1);
			if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & 3584L) != 0)) ) {
			ErrorHandler.RecoverInline(this);
			}
			else {
				ErrorHandler.ReportMatch(this);
			    Consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Struct_keyContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode STRUCT_KEY() { return GetToken(Stalker2CfgParser.STRUCT_KEY, 0); }
		public Struct_keyContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_struct_key; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IStalker2CfgVisitor<TResult> typedVisitor = visitor as IStalker2CfgVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitStruct_key(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public Struct_keyContext struct_key() {
		Struct_keyContext _localctx = new Struct_keyContext(Context, State);
		EnterRule(_localctx, 20, RULE_struct_key);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 109;
			Match(STRUCT_KEY);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	private static int[] _serializedATN = {
		4,1,22,112,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,6,2,7,
		7,7,2,8,7,8,2,9,7,9,2,10,7,10,1,0,5,0,24,8,0,10,0,12,0,27,9,0,1,0,1,0,
		1,1,1,1,1,1,5,1,34,8,1,10,1,12,1,37,9,1,1,1,1,1,1,1,5,1,42,8,1,10,1,12,
		1,45,9,1,1,1,1,1,3,1,49,8,1,1,1,1,1,3,1,53,8,1,1,2,1,2,1,2,3,2,58,8,2,
		1,2,3,2,61,8,2,1,3,1,3,3,3,65,8,3,1,4,1,4,1,4,1,4,5,4,71,8,4,10,4,12,4,
		74,9,4,1,4,1,4,1,5,1,5,1,5,1,5,1,5,5,5,83,8,5,10,5,12,5,86,9,5,1,5,1,5,
		1,5,1,5,3,5,92,8,5,1,6,1,6,1,6,1,6,3,6,98,8,6,1,7,1,7,1,7,1,7,1,8,1,8,
		1,8,1,8,1,9,1,9,1,10,1,10,1,10,0,0,11,0,2,4,6,8,10,12,14,16,18,20,0,1,
		1,0,9,11,121,0,25,1,0,0,0,2,52,1,0,0,0,4,54,1,0,0,0,6,64,1,0,0,0,8,66,
		1,0,0,0,10,91,1,0,0,0,12,97,1,0,0,0,14,99,1,0,0,0,16,103,1,0,0,0,18,107,
		1,0,0,0,20,109,1,0,0,0,22,24,3,2,1,0,23,22,1,0,0,0,24,27,1,0,0,0,25,23,
		1,0,0,0,25,26,1,0,0,0,26,28,1,0,0,0,27,25,1,0,0,0,28,29,5,0,0,1,29,1,1,
		0,0,0,30,31,3,12,6,0,31,35,5,5,0,0,32,34,3,8,4,0,33,32,1,0,0,0,34,37,1,
		0,0,0,35,33,1,0,0,0,35,36,1,0,0,0,36,38,1,0,0,0,37,35,1,0,0,0,38,43,5,
		17,0,0,39,42,3,4,2,0,40,42,3,2,1,0,41,39,1,0,0,0,41,40,1,0,0,0,42,45,1,
		0,0,0,43,41,1,0,0,0,43,44,1,0,0,0,44,46,1,0,0,0,45,43,1,0,0,0,46,48,5,
		6,0,0,47,49,5,17,0,0,48,47,1,0,0,0,48,49,1,0,0,0,49,53,1,0,0,0,50,53,5,
		3,0,0,51,53,5,17,0,0,52,30,1,0,0,0,52,50,1,0,0,0,52,51,1,0,0,0,53,3,1,
		0,0,0,54,55,3,12,6,0,55,57,5,8,0,0,56,58,3,10,5,0,57,56,1,0,0,0,57,58,
		1,0,0,0,58,60,1,0,0,0,59,61,5,17,0,0,60,59,1,0,0,0,60,61,1,0,0,0,61,5,
		1,0,0,0,62,65,3,4,2,0,63,65,5,18,0,0,64,62,1,0,0,0,64,63,1,0,0,0,65,7,
		1,0,0,0,66,67,5,20,0,0,67,72,3,6,3,0,68,69,5,19,0,0,69,71,3,4,2,0,70,68,
		1,0,0,0,71,74,1,0,0,0,72,70,1,0,0,0,72,73,1,0,0,0,73,75,1,0,0,0,74,72,
		1,0,0,0,75,76,5,21,0,0,76,9,1,0,0,0,77,92,3,18,9,0,78,92,5,12,0,0,79,84,
		5,15,0,0,80,81,5,1,0,0,81,83,5,15,0,0,82,80,1,0,0,0,83,86,1,0,0,0,84,82,
		1,0,0,0,84,85,1,0,0,0,85,92,1,0,0,0,86,84,1,0,0,0,87,92,5,16,0,0,88,92,
		3,14,7,0,89,92,5,13,0,0,90,92,5,14,0,0,91,77,1,0,0,0,91,78,1,0,0,0,91,
		79,1,0,0,0,91,87,1,0,0,0,91,88,1,0,0,0,91,89,1,0,0,0,91,90,1,0,0,0,92,
		11,1,0,0,0,93,98,3,20,10,0,94,98,5,15,0,0,95,98,3,14,7,0,96,98,3,16,8,
		0,97,93,1,0,0,0,97,94,1,0,0,0,97,95,1,0,0,0,97,96,1,0,0,0,98,13,1,0,0,
		0,99,100,5,20,0,0,100,101,5,10,0,0,101,102,5,21,0,0,102,15,1,0,0,0,103,
		104,5,20,0,0,104,105,5,2,0,0,105,106,5,21,0,0,106,17,1,0,0,0,107,108,7,
		0,0,0,108,19,1,0,0,0,109,110,5,7,0,0,110,21,1,0,0,0,13,25,35,41,43,48,
		52,57,60,64,72,84,91,97
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}