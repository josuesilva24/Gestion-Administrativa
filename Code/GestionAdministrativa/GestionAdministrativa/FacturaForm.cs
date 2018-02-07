using System;
using System.Windows.Forms;
using MappingClasses;
using System.Linq;

namespace GestionAdministrativa
{
    public partial class FacturaForm : Form
    {
        Factura MapingClass = new Factura();
        public FacturaForm()
        {
            InitializeComponent();
        }

        private void TiposDeCambiosForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = MapingClass.GetAllFacturas().
                Select( x => new
                {   
                    x.Id,
                    x.Actividad1.Descripcion,
                    x.Fecha,
                    x.MontoColones,
                    x.MontoDolares,//aca hacer la conversion por el tipo de cambio
                    Proveedor = x.Proveedor1.Nombre,
                    Poroyecto = x.Proyecto1.Nombre
                }).ToList();

            dataGridView1.Columns.Add(new DataGridViewButtonColumn
            {
                Text = "Editar",
                UseColumnTextForButtonValue = true
            });
            dataGridView1.Columns.Add(new DataGridViewButtonColumn
            {
                Text = "Eliminar",
                UseColumnTextForButtonValue = true
            });
            dataGridView1.Columns.Add(new DataGridViewButtonColumn
            {
                Text = "Ver Detalle",
                UseColumnTextForButtonValue = true
            });
        }
    }
}
