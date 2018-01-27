using System;
using System.Windows.Forms;
using EFF;

namespace GestionAdministrativa
{
    public partial class TiposDeCambiosForm : Form
    {
        
        public TiposDeCambiosForm()
        {
            InitializeComponent();
        }

        private void TiposDeCambiosForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = context.TipoCambios.ToList();
        }
    }
}
