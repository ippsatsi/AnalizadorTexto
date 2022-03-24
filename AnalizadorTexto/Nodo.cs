using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorTexto
{
    public class Nodo<T>
    {
        private int posicion;
        private T dato;
        private Nodo<T> siguiente;

        public Nodo()
        {
        }

        public Nodo(int posicion, T dato, Nodo<T> siguiente)
        {
            this.Posicion = posicion;
            this.Dato = dato;
            this.Siguiente = siguiente;
        }

        public int Posicion { get => posicion; set => posicion = value; }
        public T Dato { get => dato; set => dato = value; }
        public Nodo<T> Siguiente { get => siguiente; set => siguiente = value; }
    }
}
