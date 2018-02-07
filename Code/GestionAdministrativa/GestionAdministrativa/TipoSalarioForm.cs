using System;
using System.Windows.Forms;
using MappingClasses;
using System.Linq;

namespace GestionAdministrativa
{
    public partial class TipoSalarioForm : Form
    {
        TipoSalario TipoCambio = new TipoSalario();
        public TipoSalarioForm()
        {
            InitializeComponent();
        }

        private void TiposDeCambiosForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = TipoCambio.GetAllTiposSalarios().
                Select( x => new
                {
                    x.Id,
                    x.Tipo
                }).ToList();
            DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
            bcol.HeaderText = "Button Column ";
            bcol.Text = "Click Me";
            bcol.Name = "btnClickMe";
            bcol.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(bcol);

        }
    }
}
