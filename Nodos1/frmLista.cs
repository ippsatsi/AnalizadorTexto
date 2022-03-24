using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nodos1
{
    public partial class frmLista : Form
    {
        public frmLista()
        {
            InitializeComponent();
        }

        private void frmLista_Load(object sender, EventArgs e)
        {
            Lista<Persona> lista = new Lista<Persona>();

            lista.Agregar(new Persona("16778765", "DÍAZ", "PAREDES", "JUAN"));
            lista.Agregar(new Persona("16778987", "PALACIOS", "RUIZ", "ANA"));
            lista.Agregar(new Persona("17536363", "DEZA", "SOSA", "CARLOS"));
            lista.Agregar(new Persona("18363737", "BECERRA", "ROJAS", "LUIS"));

            lista.Insertar(3, new Persona("1243254", "ZEÑA", "DÍAZ", "PAULA"));

            Utiles<Persona>.Mapear(dgvLista, lista);
        }
    }
}
