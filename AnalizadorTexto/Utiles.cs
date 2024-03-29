﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorTexto
{
    public static class Utiles
    {

        //funcion mostrar sugerencias
        public static string sugerencias(Palabra plbra)
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

        public static void procesarExpresion(string expresion, Lista<Palabra> listaP)
        {
 
            for (int i = 0; i < expresion.Split(' ').Length; i++)
            {

                Palabra nPalabra = new Palabra(expresion.Split(' ')[i]);
                if (listaP.BuscarPosicion(nPalabra) == -1) //verificamos q no exista la palabra en la lista
                {
                    //agregamos palabra a la lista
                    listaP.Agregar(nPalabra);
                }
                
                //todo: llenado de sugerencias
                if(i != (expresion.Split(' ').Length - 1))
                {
                    string sugerencia = expresion.Split(' ')[i+1];
                    Nodo<Palabra> mi_nodo = listaP.BuscarNodo(nPalabra);

                    //Lista<Palabra> mi_lista = mi_nodo.Dato.Sugerencias;
                    Utiles.procesarExpresion(sugerencia, mi_nodo.Dato.Sugerencias);
                    
                }
            }
            return;
        }

        public static void verlista(Lista<Palabra> listaP)
        {
   
            Nodo<Palabra> n;
            n = listaP.Inicial;
            Console.WriteLine("---- Contenido de Lista: \r\n");
            while (n != null)
            {
                Console.WriteLine(n.Dato.ToString());
                n = n.Siguiente;
            }
            return;
        }
    }
}
