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
    public partial class SalariosForm : Form
    {
        Historial_Salario_Empleado SalarioHist = new Historial_Salario_Empleado();
        public SalariosForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SalariosForm_Load(object sender, EventArgs e)
        {

            dataGridViewSalarioHistory.DataSource = SalarioHist.GetAllHistoriaSalarioEmp().
              Select(x => new
              {
                  x.Id,
                  x.Empleado,
                  x.Salario_Nuevo,
                  x.Salario_Anterios,
                  x.Fecha_Modificacion,
                  
              }).ToList();
        }
    }
}
