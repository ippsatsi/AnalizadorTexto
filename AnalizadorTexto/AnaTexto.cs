using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalizadorTexto
{
    public partial class AnaTexto : Form
    {
        Lista<Palabra> lista_p = new Lista<Palabra>();
        Lista<Palabra> lista_expre = new Lista<Palabra>();
        Lista<Palabra> lista_temp = new Lista<Palabra>();

        public AnaTexto()
        {
            InitializeComponent();
            txtListExpresiones.Clear();


        }

        private void AnaTexto_Load(object sender, EventArgs e)
        {
            //Palabra pla = new Palabra("Luis");
            //lista_p.Agregar(new Palabra("Jose"));
            //lista_p.Agregar(new Palabra("Miguel"));
            //lista_p.Agregar(new Palabra("Luis"));
            //lista_expre.Agregar(new Palabra("Luis", lista_p));
            //Utiles.verlista(lista_expre);

            //int num = lista_expre.BuscarPosicion(pla);
            //Console.WriteLine($"posicion: {num}---");
            //Nodo<Palabra> n;

            //n = lista_expre.Inicial;
            
            //Console.WriteLine($"mi nodo: {n.Dato.ToString()}");
            //while (n != null)
            //{
            //    Console.WriteLine(n.Dato.ToString());

            //    n = n.Siguiente;
            //}
        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtExpresion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                //agregar y buscar palabra
            }

            if (e.KeyCode == Keys.Enter)
            {
                string textoExpresiones, expresion = txtExpresion.Text.Trim();
                //Palabra nPa = new Palabra();
                textoExpresiones = txtListExpresiones.Text;
                if (textoExpresiones == "")
                {
                    txtListExpresiones.Text = expresion;
                }
                else
                {
                    txtListExpresiones.Text = textoExpresiones + "\r\n" + expresion;
                }
                //llamar a funcion procesar expresion
                Utiles.procesarExpresion(expresion, lista_expre);

                txtExpresion.Clear();

                //Nodo<Palabra> mi_nodo = lista_expre.BuscarNodo(new Palabra("hola"));

                //Lista<Palabra> mi_lista = mi_nodo.Dato.Sugerencias;
                //Utiles.procesarExpresion("casa", mi_nodo.Dato.Sugerencias);
                //Console.WriteLine("Nodo encontrado: " + mi_nodo.Dato.ToString());
                Utiles.verlista(lista_expre);
            }
        }


    }
}
