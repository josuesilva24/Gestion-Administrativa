using System;
using System.Windows.Forms;
using MappingClasses;
using System.Linq;

namespace GestionAdministrativa
{
    public partial class EmpleadoForm : Form
    {
        Empleado TipoCambio = new Empleado();
        public EmpleadoForm()
        {
            InitializeComponent();
        }

        private void TiposDeCambiosForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = TipoCambio.GetAllEmpleados().
                Select( x => new
                {
                    x.Id,
                    x.Nombre,
                    x.Identificacion,
                    x.TipoIdentificacion,
                    x.Salario,
                    x.Telefono,
                    x.Telefono2,
                    Tipo_Salario = x.Tipo_Salario1.Tipo,
                    x.Notas
                }).ToList();
            
        }
    }
}
