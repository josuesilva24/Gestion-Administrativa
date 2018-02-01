using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAdministrativa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tiposDeCambioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TiposDeCambiosForm().Show();
        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ProveedorForm().Show();
        }
    }
}
