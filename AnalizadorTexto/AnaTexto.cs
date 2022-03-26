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
        Lista<Palabra> lista_sug;
        Lista<Palabra> lista_expre = new Lista<Palabra>();
        string expresion, textoExpresiones, ult_palabra;
        Nodo<Palabra> n;
        private Label[] lbl_sugerencias;
        int p;
        
        public AnaTexto()
        {
            InitializeComponent();
            txtListExpresiones.Clear();
            lbl_sugerencias = new Label[] { sug1, sug2, sug3, sug4};
        }

        private void limpiarSugerencias()
        {
            for (int i = 0; i < lbl_sugerencias.Length; i++)
            {
                lbl_sugerencias[i].Text = "";
            }
        }

        private void AnaTexto_Load(object sender, EventArgs e)
        {
            limpiarSugerencias();
        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtExpresion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                //mostrar sugerencia
                expresion = txtExpresion.Text.Trim().ToLower();
                if (expresion != "")
                {
                    //obtenemos la ultima palabra escrita
                    ult_palabra = expresion.Split(' ')[expresion.Split(' ').Length - 1];
                    //buscamos un nodo q contenga esa palabra
                    n = lista_expre.BuscarNodo(new Palabra(ult_palabra));
                    if (n != null)
                    {
                        //obtenemos sugerencias
                        lista_sug = n.Dato.Sugerencias;
                        Utiles.verlista(lista_sug);

                        //mostrar sugerencias en etiquetas
                        n = lista_sug.Inicial;
                        p = 0;
                        while (n != null && p < lbl_sugerencias.Length)
                        {
                            lbl_sugerencias[p].Text = n.Dato.Cadena;
                            p++;
                            n = n.Siguiente;
                        } 

                    }
                }
            }

            if (e.KeyCode == Keys.Enter)
            {
                expresion = txtExpresion.Text.Trim().ToLower();

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
            }
        }
    }
}
