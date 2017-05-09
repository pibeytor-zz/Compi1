using System;
using System.Collections.Generic;
using System.Text;

namespace AnalisisLexico
{
    class automataLexer
    {

        private readonly CadenaEntrada inputString;
        private Simbolo simboloActual;
        DiccionarioDeTokens diccionario;

        public automataLexer(CadenaEntrada inputString)
        {
            this.inputString = inputString;
            this.simboloActual = inputString.obtenerSiguenteSimbolo();
            diccionario= new DiccionarioDeTokens();
        }


    }
}
