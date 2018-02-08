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
                    MontoColones = (x.MontoDolares!= null)?(x.MontoDolares*x.TipoCambio.Valor): 0,
                    MontoDolares = (x.MontoDolares != null) ? x.MontoDolares: null,
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
                UseColumnTextForButtonValue = true,
                Name = "VerDetalleFactura",
            });
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["VerDetalleFactura"].Index && e.RowIndex >= 0)
            {
                var facturaId = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                new DetalleFacturaForm(facturaId).Show();
            }
        }
    }
}
