using System;
using System.Windows.Forms;
using MappingClasses;
using System.Linq;

namespace GestionAdministrativa
{
    public partial class ActividadForm : Form
    {
        Actividad TipoCambio = new Actividad();
        public ActividadForm()
        {
            InitializeComponent();
        }

        private void TiposDeCambiosForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = TipoCambio.GetAllActividades().
                Select( x => new
                {
                    Id = x.Id,
                    x.Nombre,
                    x.Descripcion
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
