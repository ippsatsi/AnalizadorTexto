using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorTexto
{
    public static class Utiles
    {
        //public void 
        //funcion mostrar sugerencias
        public static string mostrarExpresiones(Lista<Palabra>lPlbra)
        {
            string expresion, resultado = null;
            Nodo<Palabra> nPa = lPlbra.Inicial;
            while(nPa != null)
            {
                expresion = sugerenciasToString(nPa.Dato);

                resultado = resultado + expresion + "\r\n";
            }
            return resultado;
        }

        public static string sugerenciasToString(Palabra plbra)
        {
            string resultado = null;

            Lista<Palabra> lPa = plbra.Sugerencias;
            Nodo<Palabra> nPa = lPa.Inicial;

            while(nPa.Siguiente != null)
            {
                resultado = resultado + ' ' + nPa.Dato.Cadena;

            }
            return resultado;
        }
    }
}
