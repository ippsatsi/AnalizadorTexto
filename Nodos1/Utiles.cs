using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nodos1
{
    public static class Utiles<T>
    {
        public static void Mapear(DataGridView dgv, Lista<T> lista)
        {
            Nodo<T> nodo;
            int fila;
            DataGridViewRow row;
            string cadena, columna, valor;

            nodo = lista.Inicial;

            if (nodo != null)
            {
                for (int i = 0; i < nodo.Dato.ToString().Split('-').Length; i++)
                {
                    columna = nodo.Dato.ToString().Split('-')[i].Split(':')[0];
                    dgv.Columns.Add(columna, columna);
                }
            }

            while (nodo != null)
            {
                fila = dgv.Rows.Add();
                row = dgv.Rows[fila];

                cadena = nodo.Dato.ToString();

                for (int i = 0; i < cadena.Split('-').Length; i++)
                {
                    columna = cadena.Split('-')[i].Split(':')[0];
                    valor = cadena.Split('-')[i].Split(':')[1];
                    row.Cells[columna].Value = valor;
                }

                nodo = nodo.Siguiente;
            }
        }
    }
}
