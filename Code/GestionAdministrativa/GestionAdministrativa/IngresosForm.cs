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
            dataGridViewIngreso.DataSource = ingre.GetAllIngresos().
              Select(x => new
              {
                  x.Id,
                  x.Nombre,
                  x.Fecha,
                  x.MontoColones,
                  x.MontoDolares,
                  x.TipoCambio,
                  x.IdProyecto,
              }).ToList();
        }
    }
}
