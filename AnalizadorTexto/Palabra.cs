using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorTexto
{
    public class Palabra 
    {
        private string cadena;
        private Lista<Palabra> sugerencias;

        public Palabra(string cadena)
        {
            this.cadena = cadena;
            this.sugerencias = new Lista<Palabra>();
        }

        public Palabra()
        {
        }

        public Palabra(string cadena, Lista<Palabra> sug)
        {
            this.cadena = cadena;
            this.sugerencias = sug;
        }
        public string Cadena { get => cadena; set => cadena = value; }
        public Lista<Palabra> Sugerencias { get => sugerencias; set => sugerencias = value; }

        public override bool Equals(object obj)
        {
            return obj is Palabra palabra &&
                   cadena == palabra.cadena;
        }

        public override string ToString()
        {
            Nodo<Palabra> nPalabra = sugerencias.Inicial;
            string expresion = null;

            while (nPalabra != null)
            {
                expresion = expresion + ' ' + nPalabra.Dato.cadena;
                nPalabra = nPalabra.Siguiente;
            }
            return expresion;
        }
    }
}
