grammar SimpleLang;

// Entry point
prog:   decl+ ;

// Declarations can be variable declarations or function definitions
decl:   varDecl
    |   functionDecl
    ;

// Variable declaration
varDecl: 'int' ID ('=' expr)? ';'  ;

// Function declaration
functionDecl: 'int' ID '(' ')' '{' stat* '}' ;

// Statements include control flows, expressions, and pin operations
stat:   varDecl
    |   exprStat
    |   ifStat
    |   whileStat
    |   returnStat
    |   pinWriteStat
    ;

exprStat: expr ';' ;

ifStat: 'if' '(' expr ')' '{' stat* '}' ('else' '{' stat* '}')? ;

whileStat: 'while' '(' expr ')' '{' stat* '}' ;

returnStat: 'return' expr ';' ;

pinWriteStat: ('digitalWrite' | 'analogWrite') '(' pin=INT ',' value=expr ')' ';' ;

// Expressions
expr:   expr ('+' | '-' | '*' | '/') expr     # binOp
    |   ID '=' expr                           # assign
    |   ID '(' ')'                            # funcCall
    |   INT                                   # intLit
    |   ID                                    # id
    |   '(' expr ')'                          # parens
    ;

// Lexer rules
ID      : [a-zA-Z_][a-zA-Z_0-9]* ;           
INT     : [0-9]+ ;                            
WS      : [ \t\r\n]+ -> skip ;                
