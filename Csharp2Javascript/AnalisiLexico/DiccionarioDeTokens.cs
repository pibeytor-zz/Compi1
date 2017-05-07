using System;
using System.Collections.Generic;
using System.Text;

namespace AnalisisLexico
{
    public class DiccionarioDeTokens
    {
        public enum TipoDeToken
        {
            //enumeracion de todos los tipos soportados: id, litnum, lit char , etc


            ID,//identificador
            EOF,//fin fe archivo

            //PALABRA RESERVADA
            PR_INT,
            PR_FLOAT,
            PR_CHAR,
            PR_STRING,
            PR_AS,
            PR_IS,
            PR_NEW,
            PR_BOOL,
            PR_IF,
            PR_FOR,
            PR_WHILE,
            PR_FALSE,
            PR_TRUE,

            //OPERADORES MATEMATICOS
            OP_SUMA,
            OP_RESTA,
            OP_DIVISION,
            OP_MULTIPLICACION,
            OP_MODULO,
            OP_ASIGNACION,

            //AGRUPACION
            CP_PARENTESIS_ABRIR,
            CP_PARENTESIS_CERRAR,
            CP_CORCHETE_ABRIR,
            CP_CORCHETE_CERRAR,
            CP_LLAVES_ABRIR,
            CP_LLALES_CERRAR,

            FIN_SENTENCIA,

            

            LIT_CHAR,
            LIT_HEX_INT,
            LIT_DECIMAL_INT,
            LIT_BIN_INT,
            LIT_FLOAT,
            
            
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
            
            LIT_ESCAPE_CHAR,
            ARG_SEPARATOR,
            LIT_STRING,
            LIT_VERBATIM_STRING
        };

        Dictionary<string, TipoDeToken> PalabrasReservadas;
        Dictionary<string, TipoDeToken> Operadores;
        Dictionary<string, TipoDeToken> Puntuacion;
       
        List<string> CaracteresEscape;//= new List<string>();

        public DiccionarioDeTokens()
        {
            definirPalabrasReservadas();
            listarCaracteresEscape();


        }

        void definirPalabrasReservadas()
        {
            PalabrasReservadas.Add("int", TipoDeToken.PR_INT);
            PalabrasReservadas.Add("float", TipoDeToken.PR_FLOAT);
            PalabrasReservadas.Add("char", TipoDeToken.PR_CHAR);
            PalabrasReservadas.Add("string", TipoDeToken.PR_STRING);
            PalabrasReservadas.Add("as", TipoDeToken.PR_AS);
            PalabrasReservadas.Add("is", TipoDeToken.PR_IS);
            PalabrasReservadas.Add("new", TipoDeToken.PR_NEW);
            PalabrasReservadas.Add("bool", TipoDeToken.PR_BOOL);
            PalabrasReservadas.Add("true", TipoDeToken.PR_TRUE);
            PalabrasReservadas.Add("false", TipoDeToken.PR_FALSE);
            PalabrasReservadas.Add("if", TipoDeToken.PR_IF);
            PalabrasReservadas.Add("for", TipoDeToken.PR_FOR);
            PalabrasReservadas.Add("while", TipoDeToken.PR_WHILE);


        }

        void listarCaracteresEscape()
        {
            CaracteresEscape.Add("\n");
            CaracteresEscape.Add("\a");
            CaracteresEscape.Add("\b");
            CaracteresEscape.Add("\f");
            CaracteresEscape.Add("\r");
            CaracteresEscape.Add("\t");
            CaracteresEscape.Add("\v");
            CaracteresEscape.Add("\'");
            CaracteresEscape.Add("\"");
            CaracteresEscape.Add("\\");
        }

        void definirOperadores()
        { }

        void definirPuntuacion()
        { }
    }

    
}
