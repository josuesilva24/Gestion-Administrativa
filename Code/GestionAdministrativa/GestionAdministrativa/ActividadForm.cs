using System;
using System.Windows.Forms;
using MappingClasses;
using System.Linq;

namespace GestionAdministrativa
{
    public partial class ActividadForm : Form
    {
        Actividad Actividad = new Actividad();
        public ActividadForm()
        {
            InitializeComponent();
        }

        private void TiposDeCambiosForm_Load(object sender, EventArgs e)
        {
            CargarGridActividad();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            EFF.Actividad Acti = new EFF.Actividad();
            Acti.Nombre = textBox1.Text;
            Acti.Descripcion = textBox2.Text;
            if (textBoxId.Text == string.Empty)
                Actividad.AddActividad(Acti);
            else
                Acti.Id = int.Parse(textBoxId.Text);
         //   Actividad.(provee);
            CargarGridActividad();
            limpiarCampos();

        }

        private void limpiarCampos() {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
        }
        private void CargarGridActividad() {
            dataGridView1.DataSource = Actividad.GetAllActividades().
               Select(x => new
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
