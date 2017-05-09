namespace AnalisisLexico
{
    public class Simbolo
    {
        public int contadorColumnas;
        public int contadorFilas;
        public char caracterActual;

        public Simbolo(char caracterActual, int contadorFilas, int contadorColumnas)
        {
            this.caracterActual = caracterActual;
            this.contadorFilas = contadorFilas;
            this.contadorColumnas = contadorColumnas;
        }
    }
}
