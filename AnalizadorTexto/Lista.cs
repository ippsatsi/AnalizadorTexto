using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorTexto
{
    public class Lista<T>
    {
        private Nodo<T> inicial;
        private Nodo<T> actual;

        public Lista()
        {

        }

        public Nodo<T> Inicial { get => inicial; }
        public Nodo<T> Actual { get => actual; }

        public int BuscarPosicion(T dato)
        {
            int p;
            Nodo<T> n;

            n = inicial;
            p = -1;

            while (n != null)
            {
                if (n.Dato.Equals(dato))
                {
                    p = n.Posicion;
                    break;
                }

                n = n.Siguiente;
            }

            return p;
        }

        public void Agregar(T dato)
        {
            Nodo<T> nodo = new Nodo<T>();
            nodo.Dato = dato;

            if (actual == null)
            {
                nodo.Posicion = 1;
                actual = nodo;
                inicial = actual;
            }
            else
            {
                nodo.Posicion = actual.Posicion + 1;
                actual.Siguiente = nodo;
                actual = nodo;
            }
        }

        public void Insertar(int posicion, T dato)
        {
            Nodo<T> na, nn;

            na = inicial;

            nn = new Nodo<T>();
            nn.Posicion = posicion;
            nn.Dato = dato;

            while (na != null)
            {
                if (na.Posicion == (posicion - 1))
                {
                    nn.Siguiente = na.Siguiente;
                    na.Siguiente = nn;
                }

                na = na.Siguiente;
            }
        }

        public void Eliminar(int posicion)
        {

        }

        public Nodo<T> BuscarNodo(T dato)
        {
            Nodo<T> n;
            n = inicial;
            while (n != null)
            {
                if (n.Dato.Equals(dato))
                {
                    return n;
                }
                n = n.Siguiente;
            }
            return null;
        }
    }
}
