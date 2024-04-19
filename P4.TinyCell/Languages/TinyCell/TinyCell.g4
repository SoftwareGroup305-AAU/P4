grammar TinyCell;

document: setupDefinition updateDefinition generalDeclaration*;

generalDeclaration: functionDefinition | declaration;

setupDefinition: 'setup' compoundStatement;

updateDefinition: 'update' compoundStatement;

functionDefinition:
	type identifier '(' parameterList ')' compoundStatement;

type: 'void' | 'char' | 'int' | 'float' | 'bool' | 'pin';

parameterList: parameter | parameterList ',' parameter;

parameter: type identifier;

declaration: type initialDeclaration ';';

initialDeclaration:
	identifier
	| identifier '=' assignmentExpression;

compoundStatement: '{' statement* '}';

statement:
	ifStatement
	| loopStatement
	| jumpStatement
	| expression
	| declaration;

ifStatement:
	'if' '(' expression ')' compoundStatement
	| 'if' '(' expression ')' compoundStatement 'else' compoundStatement;

loopStatement:
	'while' '(' expression ')' compoundStatement
	| 'for' '(' expression ';' expression ';' expression ')' compoundStatement;

jumpStatement:
	'continue' ';'
	| 'break' ';'
	| 'return' expression ';';

expression:
	assignmentExpression
	| pinExpression
	| ternaryExpression;

assignmentExpression:
	ternaryExpression
	| (unaryExpression | identifier) assignmentOperator assignmentExpression;

ternaryExpression:
	orExpression
	| orExpression '?' expression ':' expression;

orExpression: andExpression | orExpression '||' andExpression;

andExpression:
	equalityExpression
	| andExpression '&&' equalityExpression;

equalityExpression:
	comparisonExpression
	| equalityExpression '==' comparisonExpression
	| equalityExpression '!=' comparisonExpression;

comparisonExpression:
	bitshiftExpression
	| comparisonExpression '<' bitshiftExpression
	| comparisonExpression '>' bitshiftExpression
	| comparisonExpression '<=' bitshiftExpression
	| comparisonExpression '>=' bitshiftExpression;

bitshiftExpression:
	additiveExpression
	| bitshiftExpression '<<' additiveExpression
	| bitshiftExpression '>>' additiveExpression;

additiveExpression:
	multiplicativeExpression
	| additiveExpression '+' multiplicativeExpression
	| additiveExpression '-' multiplicativeExpression;

multiplicativeExpression:
	unaryExpression
	| multiplicativeExpression '*' unaryExpression
	| multiplicativeExpression '/' unaryExpression
	| multiplicativeExpression '%' unaryExpression;

unaryExpression:
	primitiveExpression
	| unaryExpression '++'
	| unaryExpression '--'
	| '++' unaryExpression
	| '--' unaryExpression;

primitiveExpression: Numeral | String;

pinExpression: 'set' identifier 'to' pinVoltage;

identifier: Identifier;

assignmentOperator: '=' | '*=' | '/=' | '%=' | '+=' | '-=';

pinVoltage: 'high' | 'low';

Identifier: [a-zA-Z_][a-zA-Z0-9_]*;

String: '"' ([a-zA-Z0-9_!@#$%^&()=;:'<>,.?/`~]) '"';

Numeral: [-]? ([0] | [1-9]) [0-9]* ([.][0-9]+)?;

Whitespace: [ \t]+ -> channel(HIDDEN);

Newline: ('\r' '\n'? | '\n') -> channel(HIDDEN);