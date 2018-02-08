using System;
using System.Windows.Forms;
using MappingClasses;
using System.Linq;

namespace GestionAdministrativa
{
    public partial class DetalleFacturaForm : Form
    {
        Detalle_Factura query = new Detalle_Factura();
        static public int facId;
        public DetalleFacturaForm(int facturaId)
        {
            facId = facturaId;
            InitializeComponent();
        }

        private void TiposDeCambiosForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = query.GetDetFacturasPorFactura(facId).
                Select( x => new
                {
                     x.Id,
                    x.Cantidad,
                    x.PrecionUnidad,
                    x.Producto
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
