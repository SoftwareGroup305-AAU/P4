grammar TinyCell;

Whitespace: [ \t\r\n]+ -> channel(HIDDEN);

document: setupDefinition updateDefinition generalDeclaration*;

generalDeclaration: functionDefinition | declaration;

setupDefinition: SETUP compoundStatement;

updateDefinition: UPDATE compoundStatement;

functionDefinition:
	type identifier LPAR parameterList* RPAR compoundStatement;

type: VOID | CHAR | INT | FLOAT | BOOL | PIN;

parameterList: parameter | parameterList COMMA parameter;

parameter: type identifier;

declaration: type initialDeclaration;

initialDeclaration: identifier | identifier ASSIGN expression;

compoundStatement: LCURLY statement* RCURLY;

statement:
	ifStatement
	| loopStatement
	| jumpStatement
	| declaration SEMI
	| functionCall SEMI
	| assignment SEMI
	| expression SEMI;

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

assignment:
	identifier assignmentOperator (expression | functionCall);

functionCall: identifier LPAR parameterList* RPAR;

primitiveExpression: Numeral | String | Bool;

unaryExpression:
	primitiveExpression
	| primitiveExpression UNARYPLUS
	| primitiveExpression UNARYMINUS
	| UNARYPLUS primitiveExpression
	| UNARYMINUS primitiveExpression;

multiplicativeExpression:
	unaryExpression
	| multiplicativeExpression MULT primitiveExpression
	| multiplicativeExpression DIV primitiveExpression
	| multiplicativeExpression MOD primitiveExpression;

additiveExpression:
	multiplicativeExpression
	| additiveExpression PLUS multiplicativeExpression
	| additiveExpression MINUS multiplicativeExpression;

bitshiftExpression:
	additiveExpression
	| bitshiftExpression BITSHIFTL additiveExpression
	| bitshiftExpression BITSHIFTR additiveExpression;

comparisonExpression:
	bitshiftExpression
	| comparisonExpression LT bitshiftExpression
	| comparisonExpression GT bitshiftExpression
	| comparisonExpression LTE bitshiftExpression
	| comparisonExpression GTE bitshiftExpression;

equalityExpression:
	comparisonExpression
	| equalityExpression EQ comparisonExpression
	| equalityExpression NEQ comparisonExpression;

andExpression:
	equalityExpression
	| andExpression AND equalityExpression;

orExpression: andExpression | orExpression OR andExpression;

ternaryExpression:
	orExpression
	| orExpression QUESTION expression COLON expression;

pinExpression: ternaryExpression | SET identifier TO pinVoltage;

expression: pinExpression;

identifier: Identifier;

assignmentOperator:
	ASSIGN
	| MULTASSIGN
	| DIVASSIGN
	| MODASSIGN
	| PLUSASSIGN
	| MINUSASSIGN;

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
TRUE: 'true';
FALSE: 'false';
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
BITSHIFTL: '<<';
BITSHIFTR: '>>';
//Unary op
UNARYPLUS: '++';
UNARYMINUS: '--';

Identifier: [a-zA-Z_][a-zA-Z0-9_]*;

String: QUOTE ([a-zA-Z0-9_!@#$%^&()=;:'<>,.?/`~])* QUOTE;

Numeral: [-]? ([0] | [1-9]) [0-9]* ([.][0-9]+)?;

Bool: TRUE | FALSE;

Newline: ('\r' '\n'? | '\n' | '\\n') -> channel(HIDDEN);