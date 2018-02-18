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
                UseColumnTextForButtonValue = true
            });
            dataGridViewIngreso.Columns.Add(new DataGridViewButtonColumn
            {
                Text = "Eliminar",
                UseColumnTextForButtonValue = true
            });

          
        }

        private void button1_Click(object sender, EventArgs e)
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
                ingr.Id = int.Parse(textBoxId.Text);
                ingre.UpdateIngreso(ingr);
            cargarGridIngreso();
            limpiarCampos();

            dataGridViewIngreso.Refresh();

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
              }).ToList();

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
            if ( e.ColumnIndex == 7)
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

            if (e.ColumnIndex == 8)
            {
                var confirmResult = MessageBox.Show("Está seguro de eliminar el registro?",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    var ingresoID = int.Parse(dataGridViewIngreso.Rows[e.RowIndex].Cells[0].Value.ToString());
                    new Ingreso().deleteIngreso(ingresoID);
                    cargarGridIngreso();// If 'Yes', do something here.
                    dataGridViewIngreso.Refresh();
                }
               
             
                
            }
        }

    }
}
