using System;
namespace AnalisisLexico
{
    public class excepcionLexica : Exception
    {
        public excepcionLexica()
        { }

        public excepcionLexica(string mensaje): base(mensaje)
        { }

        public excepcionLexica(string mensaje, Exception innerExeption) : base(mensaje, innerExeption)
        { }
    }
}
