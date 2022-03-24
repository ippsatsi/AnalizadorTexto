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
        public AnaTexto()
        {
            InitializeComponent();
        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                //agregar y buscar palabra
            }

            if (e.KeyCode == Keys.Enter)
            {
                //guardar expresion en la lista   f
            }
        }
    }
}
