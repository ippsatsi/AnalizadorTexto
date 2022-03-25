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


        }

        private void AnaTexto_Load(object sender, EventArgs e)
        {
            //Palabra pla = new Palabra("Luis");
            lista_p.Agregar(new Palabra("Jose"));
            lista_p.Agregar(new Palabra("Miguel"));
            lista_expre.Agregar()
            Console.WriteLine($"pala: {pla.Cadena}");
            //Console.WriteLine($"palabra: {pla.ToString()}");
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
                //guardar expresion en la lista   f
                string textoExpresiones, expresion = txtExpresion.Text.Trim();
                Palabra nPa = new Palabra();

                //todo: verificar cadena no vacia
                for (int i = 0; i < expresion.Split(' ').Length; i++)
                {

                    Palabra nPalabra = new Palabra(expresion.Split(' ')[i]);
                    Console.WriteLine(nPalabra.ToString());
                    Console.WriteLine($" i= {i} ");
                    nPa.Sugerencias.Agregar(nPalabra);
                    
                }

                lista_expre.Agregar(nPa);
                textoExpresiones = Utiles.mostrarExpresiones(lista_expre);
                txtListExpresiones.Clear();
                txtListExpresiones.Text = textoExpresiones;
            }
        }


    }
}
