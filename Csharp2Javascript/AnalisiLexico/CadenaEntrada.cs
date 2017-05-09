namespace AnalisisLexico
{
    public class CadenaEntrada: interfazEntrada
    {
        public string EntradaInicial { get; set; }

        public int caracterActual { get; set; }

        public int contadorFilas { get; set; }

        public int contadorColumnas { get; set; }

        public CadenaEntrada(string entrada)
        {
            this.EntradaInicial = entrada;
            this.contadorFilas = 1;
            this.contadorColumnas = 1;
            this.caracterActual = 0;
        }
        public Simbolo obtenerSiguenteSimbolo()
        {
            if (caracterActual<EntradaInicial.Length)
            {
                if (EntradaInicial[caracterActual] == '\n')//cuando el caracter es enter
                {
                    ++contadorFilas;//aumenta las filas
                    contadorColumnas = 1;//reset las columnas
                }

                var retornarSimbolo = new Simbolo(EntradaInicial[caracterActual++], contadorFilas, contadorColumnas++);

                
            }

            return new Simbolo('\0', contadorFilas, contadorColumnas);
        }
    }
}
