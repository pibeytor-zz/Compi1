﻿using System;
using System.Collections.Generic;
using System.Text;

namespace lexico
{
    public enum tokenType
    {
        ID,

        LIT_ENTERO,
        LIT_DECIMAL,
        LIT_HEXADECIMAL,
        LIT_FLOAT,

        LIT_ESCAPE_CHAR,

        BOOL_KEYWORD,

        LIT_STRING,
        LIT_VERBATIM_STRING,

        EOF,
        OP_SUM,
        OP_SUBSTRACT,
        OP_DIVISION,
        OP_MULTIPLICATION,
        OP_MODULO,
        OP_ASSIGN,
        PAREN_OPEN,
        PAREN_CLOSE,
        END_STATEMENT,
        INT_KEYWORD,
        FLOAT_KEYWORD,
        CHAR_KEYWORD,
        STRING_KEYWORD,
        AS_KEYWORD,
        IS_KEYWORD,
        NEW_INSTANCE_KEYWORD,
        
        IF_CONDITIONAL_KEYWORD,
        FOR_LOOP,
        WHILE_LOOP,
        LIT_CHAR,
        LIT_HEX_INT,
        LIT_DECIMAL_INT,
        LIT_BIN_INT,
        
        FALSE_KEYWORD,
        TRUE_KEYWORD,
        BRACES_OPEN,
        BRACES_CLOSE,
        COLON_OPERATOR,
        ATTRIBUTE_OPERATOR,
        BITWISE_OR,
        BITWISE_AND,
        BITWISE_XOR,
        LESS_THAN_OPERATOR,
        GREATER_THAN_OPERATOR,
        NEGATION_OPERATOR,
        UNARY_OPERATOR,
        OP_DIVISION_AND_ASSIGN,
        OP_SUM_AND_ASSIGN,
        OP_MODULO_AND_ASSIGN,
        OP_SUBSTRACT_AND_ASSIGN,
        OP_MULTIPLICATION_AND_ASSIGN,
        OP_EQUALITY,
        OP_BITWISE_OR_AND_ASSIGN,
        OP_BITWISE_AND_AND_ASSIGN,
        OP_XOR_AND_ASSIGN,
        OP_NEGATION_EQUALITY,
        OP_BITWISE_UNARY_AND_ASSIGN,
        GREATER_THAN_OR_EQUALS,
        LESS_THAN_OR_EQUALS,
        OP_BIT_LEFT_SHIFT,
        OP_BIT_LEFT_SHIFT_AND_ASSIGN,
        OP_BIT_RIGHT_SHIFT,
        OP_BIT_RIGHT_SHIFT_AND_ASSIGN,
        OP_NULL_COALESCING,
        OP_TERNARY,
        OP_INCREMENT,
        OP_DECREMENT,
        BRACKET_OPEN,
        BRACKET_CLOSE,
       
        ARG_SEPARATOR
      

    }
}
