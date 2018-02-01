using System;
using System.Windows.Forms;
using MappingClasses;
using System.Linq;

namespace GestionAdministrativa
{
    public partial class ProveedorForm : Form
    {
        Proveedor TipoCambio = new Proveedor();
        public ProveedorForm()
        {
            InitializeComponent();
        }

        private void TiposDeCambiosForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = TipoCambio.GetAllProveedores().
                Select( x => new
                {
                    Id = x.Id,
                    Nombre = x.Nombre,
                    Identificacion = x.Identificacion,
                    TelefonoPrincipal = x.Telefono,
                    TelefonoSecundario = x.Telefono2,
                    Notas = x.Notas
                }).ToList();
            
        }
    }
}
