using static AnalisisLexico.DiccionarioDeTokens;

namespace AnalisisLexico
{
    public class Token
    {
        public TipoDeToken tipo;
        //int[] posicion;
        int fila;
        int columna;
        string lexema;
        //Array posicion;
        //ValueType valorLexema;
    
        
        public Token(TipoDeToken tipo,string lexema, int fila, int columna)
        {
            this.tipo = tipo;
            this.lexema = lexema;
            this.fila = fila;
            this.columna = columna ;
        }

        public override string ToString()
        {
            return lexema.ToString() +" es de tipo: " + tipo;
        }   


    }
}
