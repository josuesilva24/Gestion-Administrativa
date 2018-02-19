using MappingClasses;
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
    public partial class IngresosForm : Form
    {
        Ingreso ingre = new Ingreso();
        public IngresosForm()
        {
            InitializeComponent();
        }

        private void dataGridViewIngreso_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void IngresosForm_Load(object sender, EventArgs e)
        {
            CargarProyectosCombo();
            CargarTipoCambioCombo();
            cargarGridIngreso();

            dataGridViewIngreso.Columns.Add(new DataGridViewButtonColumn
            {
                Text = "Editar",
                UseColumnTextForButtonValue = true,
                Name = "Editar",

            });
            dataGridViewIngreso.Columns.Add(new DataGridViewButtonColumn
            {
                Text = "Eliminar",
                UseColumnTextForButtonValue = true,
                Name = "Eliminar",

            });

          
        }

        private bool WithErrors()
        {
            if (textBoxNombre.Text.Trim() == String.Empty)
                return true; // Returns true if no input or only space is found
            if (textBoxDescripcion.Text.Trim() == String.Empty)
                return true;
            if (textBoxDescripcion.Text.Trim() == String.Empty)
                return true;
            if (textBoxMontoColones.Text.Trim() == String.Empty)
                return true;
            if (textBoxMontoDolares.Text.Trim() == String.Empty)
                return true;
            // Other textBoxes.

            return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (WithErrors())
            {
                MessageBox.Show("Existen campos en blanco que se deben rellenar!",
                                     "Campos vacíos!!",
                                     MessageBoxButtons.YesNo);

            }
            else
            {
                EFF.Ingreso ingr = new EFF.Ingreso();
                ingr.Nombre = textBoxNombre.Text;
                ingr.Descripcion = textBoxDescripcion.Text;
                ingr.Fecha = DateTime.Now;
                ingr.MontoColones = decimal.Parse(textBoxMontoColones.Text);
                ingr.MontoDolares = decimal.Parse(textBoxMontoDolares.Text);
                ingr.IdProyecto = int.Parse(comboBoxProyecto.SelectedValue.ToString());
                ingr.IdTipoCambio = int.Parse(comboBoxTipocambio.SelectedValue.ToString());
                if (textBoxId.Text == string.Empty)
                    ingre.AddIngreso(ingr);
                else
                {
                    ingr.Id = int.Parse(textBoxId.Text);
                    ingre.UpdateIngreso(ingr);
                }
                this.Close();
                new IngresosForm().Show();


            }
        }

        private void cargarGridIngreso()
        {
            dataGridViewIngreso.DataSource = ingre.GetAllIngresos().
              Select(x => new
              {
                  x.Id,
                  x.Nombre,
                  x.Fecha,
                  x.MontoColones,
                  x.MontoDolares,
                  x.TipoCambio,
                  Proyecto = x.IdProyecto,
              }).ToList() ;

        }

        private void CargarProyectosCombo() {

            comboBoxProyecto.DataSource = new Proyecto().GetAllProyectos();
            comboBoxProyecto.DisplayMember = "Nombre";
            comboBoxProyecto.ValueMember = "Id";
        }
        private void CargarTipoCambioCombo()
        {

            comboBoxTipocambio.DataSource = new TipoCambio().GetAllTiposCambios();
            comboBoxTipocambio.DisplayMember = "Valor";
            comboBoxTipocambio.ValueMember = "Id";
        }

        private void limpiarCampos() {
             textBoxNombre.Text = textBoxDescripcion.Text =  textBoxMontoColones.Text =  textBoxMontoDolares.Text = string.Empty;
        }

        private void dataGridViewIngreso_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewIngreso.Columns["Editar"].Index && e.RowIndex >= 0)
            {
                var ingresoID = int.Parse(dataGridViewIngreso.Rows[e.RowIndex].Cells[0].Value.ToString());

                EFF.Ingreso pr =  new Ingreso().GetIngreso(ingresoID);

                textBoxNombre.Text = pr.Nombre;
                textBoxDescripcion.Text = pr.Descripcion;
                textBoxMontoColones.Text = pr.MontoColones.ToString();
                textBoxMontoDolares.Text = pr.MontoDolares.ToString();
                comboBoxTipocambio.SelectedItem = pr.TipoCambio;
                comboBoxProyecto.SelectedItem = pr.IdProyecto;
                textBoxId.Text = pr.Id.ToString();
          
            }

            if (e.ColumnIndex == dataGridViewIngreso.Columns["Eliminar"].Index && e.RowIndex >= 0)
            {
                var confirmResult = MessageBox.Show("Está seguro de eliminar el registro?",
                                     "Confir borrado!!",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    var ingresoID = int.Parse(dataGridViewIngreso.Rows[e.RowIndex].Cells[0].Value.ToString());
                    new Ingreso().deleteIngreso(ingresoID);
                    this.Close();
                    new IngresosForm().Show();
                }
               
            }
        }

        private void textBoxMontoColones_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

       

        private void textBoxMontoDolares_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
