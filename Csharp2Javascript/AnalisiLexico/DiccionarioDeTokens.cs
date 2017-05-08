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
            //LITERALES
            LIT_INT,
            LIT_DECIMAL,
            LIT_HEXADECIMAL,
            LIT_BINARIO,
            LIT_FLOAT,
            LIT_TRUE,
            LIT_FALSE,
            LIT_CHAR,
            LIT_STRING,
            LIT_VERBATIM,

            ID,//identificador
            EOF,//fin de archivo
            FIN_SENTENCIA,

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


            //PUNTUACION
            PUN_PARENTESIS_ABRIR,
            PUN_PARENTESIS_CERRAR,
            PUN_CORCHETE_ABRIR,
            PUN_CORCHETE_CERRAR,
            PUN_LLAVES_ABRIR,
            PUN_LLAVES_CERRAR,
            PUN_PUNTO,
            PUN_COMA,
            PUN_PUNTOYCOMA,
            PUN_DOSPUNTOS,

   
      

            ////////////////////////////////////////////////////////////
            // https://docs.microsoft.com/en-us/dotnet/articles/csharp/language-reference/operators/index
            //operadores primarios

           
            OP_NULLCONDITIONALMEMBER,// ?. //null conditional member access'
            OP_NULLCONDITIONALINDEX,// ? //null conditional index

            OP_TYPEOF,//typeof //retorna el system.type del operando representado
            OP_SIZEOF,//sizeof // retorna el tamanio en bytes del operando

            OP_POINTER,//-> // pointer dereferencing combined with member access

            ////operadores unarios

            OP_NEGACION_LOGICA,//! // negacion logica
            OP_REDONDEAR_BIT,//~ // bitwise complement
            OP_PP_INCREMENTO,//++ //pre|post - incremento
            OP_PP_DECREMENTO,//-- //pre|post- decremento



            ////operadotes multiplicativos
            OP_MULTIPLICACION,//* // multiplicacion
            OP_DIVISION,///  // division
            OP_MODULO,//%  // modulo

            ////operadores adicion
            OP_SUMA,//+ // adicion 
            OP_RESTA,//- // sustraccion

            ////Shift Operators

            OP_IQZ_BIT_SHIFT,//<< // shift bits left
            OP_DER_BIT_SHIFT,//>> // shift bits right


            //// operaciones relacionales y prueba de tipos
            OP_MAYOR_QUE,//< //mayor 
            OP_MENOR_QUE,//> // menor
            OP_MAYOR_IGUAL,//<= // mayor o igual
            OP_MENOR_IGUAL,//>= // menor o igual
            OP_IS_TIPO_COMPATIBLE,//is // type compatibility
            OP_AS_TIPO_CONVERSION,//as //type conversion


            //// operadoters de igualdad
            OP_IGUALDAD,//== //igualdad
            OP_DESIGUALDAD,//!= //desigualdad

            //// operador logico "AND"
            OP_LOG_BIT_AND,//& // logical or bitwise AND

            //// operador logico "XOR"
            OP_LOG_BIT_XOR,//^ // logical or bitwise XOR

            //// operador logico OR
            OP_LOG_BIT_OR,//| // logical or bitwise OR


            ////condicional AND
            OP_AND,//&& //AND logico

            ////condicional OR
            OP_OR,//|| // OR logico


            ////Null-coalescing operador
            OP_COALESCE,//?? //


            //// asignacion y operadores lambda
            OP_ASIGNACION,//= // asignacion
            OP_INCREMENTO,//+= //incremento
            OP_DECREMENTO,//-= //decremento
            OP_MULTIPLICACION_ASIGNACION,//*= // multiplicacion asignacion
            OP_DIVISION_ASIGNACION,///= // division asignacion
            OP_MODULO_ASIGNACION,//%=  // modulo asignacion
            OP_AND_ASIGNACION,//&= // AND asignacion
            OP_OR_ASIGNACION,//|= // OR asignacion
            OP_XOR_ASIGNACION,//^= // XOR asignacion
            OP_IQZ_SHIFT_ASIGNACION,//<<= //left shift assignment
            OP_DER_ASIGNACION//>>= //right shift assignmet


        };

        Dictionary<string, TipoDeToken> PalabrasReservadas;
        Dictionary<string, TipoDeToken> Operadores;
        Dictionary<string, TipoDeToken> Puntuacion;
       
        List<string> CaracteresEscape;//= new List<string>();

        public DiccionarioDeTokens()
        {
            definirPalabrasReservadas();
            listarCaracteresEscape();
            definirOperadores();
            definirPuntuacion();
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
            PalabrasReservadas.Add("if", TipoDeToken.PR_IF);
            PalabrasReservadas.Add("for", TipoDeToken.PR_FOR);
            PalabrasReservadas.Add("while", TipoDeToken.PR_WHILE);

            PalabrasReservadas.Add("true", TipoDeToken.LIT_TRUE);
            PalabrasReservadas.Add("false", TipoDeToken.LIT_FALSE);
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
        {
            Operadores.Add("?.", TipoDeToken.OP_NULLCONDITIONALMEMBER);
            Operadores.Add("?", TipoDeToken.OP_NULLCONDITIONALINDEX);
            Operadores.Add("typeof",TipoDeToken.OP_TYPEOF);

            Operadores.Add("sizeof", TipoDeToken.OP_SIZEOF);
            Operadores.Add("->", TipoDeToken.OP_POINTER);


            //////operadores unarios
            Operadores.Add("!", TipoDeToken.OP_NEGACION_LOGICA);
            Operadores.Add("~", TipoDeToken.OP_REDONDEAR_BIT);
            Operadores.Add("++", TipoDeToken.OP_PP_INCREMENTO);
            Operadores.Add("--", TipoDeToken.OP_PP_DECREMENTO);



            //////operadotes multiplicativos
            Operadores.Add("*", TipoDeToken.OP_MULTIPLICACION);
            Operadores.Add("/", TipoDeToken.OP_DIVISION);
            Operadores.Add("%", TipoDeToken.OP_MODULO);



            //////operadores adicion
            Operadores.Add("+", TipoDeToken.OP_SUMA);
            Operadores.Add("-", TipoDeToken.OP_RESTA);


            //////Shift Operators
            Operadores.Add("<<", TipoDeToken.OP_IQZ_BIT_SHIFT);
            Operadores.Add(">>", TipoDeToken.OP_DER_BIT_SHIFT);


            ////// operaciones relacionales y prueba de tipos
            Operadores.Add(">", TipoDeToken.OP_MAYOR_QUE);
            Operadores.Add("<", TipoDeToken.OP_MENOR_QUE);
            Operadores.Add(">=", TipoDeToken.OP_MAYOR_IGUAL);
            Operadores.Add("<=", TipoDeToken.OP_MENOR_IGUAL);
            Operadores.Add("as", TipoDeToken.OP_IS_TIPO_COMPATIBLE);
            Operadores.Add("is", TipoDeToken.OP_AS_TIPO_CONVERSION);


            ////// operadoters de igualdad
            Operadores.Add("==", TipoDeToken.OP_IGUALDAD);
            Operadores.Add("!=", TipoDeToken.OP_DESIGUALDAD);
     

            ////// operador logico "AND"
            Operadores.Add("&", TipoDeToken.OP_LOG_BIT_AND);
            

            ////// operador logico "XOR"
            Operadores.Add("^", TipoDeToken.OP_LOG_BIT_XOR);
        

            ////// operador logico OR
            Operadores.Add("|", TipoDeToken.OP_LOG_BIT_OR);
           


            //////condicional AND
            Operadores.Add("&&", TipoDeToken.OP_AND);
            

            //////condicional OR
            Operadores.Add("||", TipoDeToken.OP_OR);
            


            //////Null-coalescing operador
            Operadores.Add("??", TipoDeToken.OP_COALESCE);
        


            ////// asignacion y operadores lambda
            Operadores.Add("=", TipoDeToken.OP_ASIGNACION);
            Operadores.Add("+=", TipoDeToken.OP_INCREMENTO);
            Operadores.Add("-=", TipoDeToken.OP_DECREMENTO);
            Operadores.Add("*=", TipoDeToken.OP_MULTIPLICACION_ASIGNACION);
            Operadores.Add("/=", TipoDeToken.OP_DIVISION_ASIGNACION);
            Operadores.Add("%=", TipoDeToken.OP_MODULO_ASIGNACION);
            Operadores.Add("&=", TipoDeToken.OP_AND_ASIGNACION);
            Operadores.Add("|=", TipoDeToken.OP_OR_ASIGNACION);
            Operadores.Add("^=", TipoDeToken.OP_XOR_ASIGNACION);
            Operadores.Add("<<=", TipoDeToken.OP_IQZ_SHIFT_ASIGNACION);
            Operadores.Add(">>=", TipoDeToken.OP_DER_ASIGNACION);



        }

        void definirPuntuacion()
        {
            Puntuacion.Add("(", TipoDeToken.PUN_PARENTESIS_ABRIR);
            Puntuacion.Add(")", TipoDeToken.PUN_PARENTESIS_CERRAR);
            Puntuacion.Add("[", TipoDeToken.PUN_CORCHETE_ABRIR);
            Puntuacion.Add("]", TipoDeToken.PUN_CORCHETE_CERRAR);
            Puntuacion.Add("{", TipoDeToken.PUN_LLAVES_ABRIR);
            Puntuacion.Add("}", TipoDeToken.PUN_LLAVES_CERRAR);
            Puntuacion.Add(".", TipoDeToken.PUN_PUNTO);
            Puntuacion.Add(",", TipoDeToken.PUN_COMA);
            Puntuacion.Add(";", TipoDeToken.PUN_PUNTOYCOMA);
            Puntuacion.Add(":", TipoDeToken.PUN_DOSPUNTOS);           
        }
    }

    
}
