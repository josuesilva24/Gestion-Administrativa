using System;
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

        private void actividadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ActividadForm().Show();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EmpleadoForm().Show();
        }

        private void tipoDeSalarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TipoSalarioForm().Show();
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FacturaForm().Show();
        }
    }
}
