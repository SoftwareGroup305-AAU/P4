grammar TinyCell;

document: setupDefinition updateDefinition generalDeclaration*;

generalDeclaration: functionDefinition | declaration;

setupDefinition: SETUP compoundStatement;

updateDefinition: UPDATE compoundStatement;

functionDefinition:
	type identifier LPAR parameterList RPAR compoundStatement;

type: VOID | CHAR | INT | FLOAT | BOOL | PIN;

parameterList: parameter | parameterList COMMA parameter;

parameter: type identifier;

declaration: type initialDeclaration SEMI;

initialDeclaration:
	identifier
	| identifier ASSIGN assignmentExpression;

compoundStatement: LCURLY statement* RCURLY;

statement:
	ifStatement
	| loopStatement
	| jumpStatement
	| expression
	| declaration;

ifStatement:
	IF LPAR expression RPAR compoundStatement
	| IF LPAR expression RPAR compoundStatement ELSE compoundStatement;

loopStatement:
	WHILE LPAR expression RPAR compoundStatement
	| FOR LPAR expression SEMI expression SEMI expression RPAR compoundStatement;

jumpStatement:
	CONTINUE SEMI
	| BREAK SEMI
	| RETURN expression SEMI;

expression:
	assignmentExpression
	| pinExpression
	| ternaryExpression;

assignmentExpression:
	ternaryExpression
	| (unaryExpression | identifier) assignmentOperator assignmentExpression;

ternaryExpression:
	orExpression
	| orExpression QUESTION expression COLON expression;

orExpression: andExpression | orExpression OR andExpression;

andExpression:
	equalityExpression
	| andExpression AND equalityExpression;

equalityExpression:
	comparisonExpression
	| equalityExpression EQ comparisonExpression
	| equalityExpression NEQ comparisonExpression;

comparisonExpression:
	bitshiftExpression
	| comparisonExpression LT bitshiftExpression
	| comparisonExpression GT bitshiftExpression
	| comparisonExpression LTE bitshiftExpression
	| comparisonExpression GTE bitshiftExpression;

bitshiftExpression:
	additiveExpression
	| bitshiftExpression BITSHIFTL additiveExpression
	| bitshiftExpression BITSHIFTR additiveExpression;

additiveExpression:
	multiplicativeExpression
	| additiveExpression PLUS multiplicativeExpression
	| additiveExpression MINUS multiplicativeExpression;

multiplicativeExpression:
	unaryExpression
	| multiplicativeExpression MULT unaryExpression
	| multiplicativeExpression DIV unaryExpression
	| multiplicativeExpression MOD unaryExpression;

unaryExpression:
	primitiveExpression
	| unaryExpression UNARYPLUS
	| unaryExpression UNARYMINUS
	| UNARYPLUS unaryExpression
	| UNARYMINUS unaryExpression;

primitiveExpression: Numeral | String;

pinExpression: SET identifier TO pinVoltage;

identifier: Identifier;

assignmentOperator: ASSIGN | MULTASSIGN | DIVASSIGN | MODASSIGN | PLUSASSIGN | MINUSASSIGN;

pinVoltage: VOLHIGH | VOLLOW;

//Pin op
VOLHIGH: 'high';
VOLLOW: 'low';
//Types
PIN: 'pin';
INT: 'int';
FLOAT: 'float';
STRING: 'string';
BOOL: 'bool';
VOID: 'void';
CHAR: 'char';
//Keywords
UPDATE: 'update';
SETUP: 'setup';
SET: 'set';
TO: 'to';
IF: 'if';
ELSE: 'else';
WHILE: 'while';
FOR: 'for';
CONTINUE: 'continue';
BREAK: 'break';
RETURN: 'return';
QUESTION: '?';
LPAR: '(';
RPAR: ')';
LCURLY: '{';
RCURLY: '}';
LBRACKET: '[';
RBRACKET: ']';
SEMI: ';';
DOT: '.';
COMMA: ',';
COLON: ':';
NEWLINE: '\n';
//Assignment op
ASSIGN: '=';
PLUSASSIGN: '+=';
MULTASSIGN: '*=';
DIVASSIGN: '/=';
MODASSIGN: '%=';
MINUSASSIGN: '-=';
QUOTE: '"';
//Op
MULT: '*';
DIV: '/';
PLUS: '+';
MINUS: '-';
MOD: '%';
//Relational op
AND: '&&';
OR: '||';
EQ: '==';
NEQ: '!=';
GT: '>';
LT: '<';
GTE: '>=';
LTE: '<=';
NOT: '!';
//Bitwise op
BITSHIFTL : '<<';
BITSHIFTR : '>>';
//Unary op
UNARYPLUS: '++';
UNARYMINUS: '--';

Identifier: [a-zA-Z_][a-zA-Z0-9_]*;

String: QUOTE ([a-zA-Z0-9_!@#$%^&()=;:'<>,.?/`~]) QUOTE;

Numeral: [-]? ([0] | [1-9]) [0-9]* ([.][0-9]+)?;

Whitespace: [ \t]+ -> channel(HIDDEN);

Newline: ('\r' '\n'? | '\n') -> channel(HIDDEN);