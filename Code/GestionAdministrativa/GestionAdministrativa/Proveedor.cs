using System;
using System.Windows.Forms;
using MappingClasses;
using System.Linq;

namespace GestionAdministrativa
{
    public partial class ProveedorForm : Form
    {
        Proveedor provedor = new Proveedor();
        public ProveedorForm()
        {
            InitializeComponent();
        }

        private void TiposDeCambiosForm_Load(object sender, EventArgs e)
        {
            CargarGridProveedor();
        }

        private void CargarGridProveedor()
        {
            dataGridView1.DataSource = provedor.GetAllProveedores().
                Select(x => new
                {
                    Id = x.Id,
                    Nombre = x.Nombre,
                    Identificacion = x.Identificacion,
                    TelefonoPrincipal = x.Telefono,
                    TelefonoSecundario = x.Telefono2,
                    Notas = x.Notas
                }).ToList();


        }

        private void button1_Click(object sender, EventArgs e)
        {

            EFF.Proveedor provee = new EFF.Proveedor();
            provee.Nombre = textBox1.Text;
            provee.TipoIdentificacion = comboBox1.Text;
            provee.Identificacion = textBox2.Text;
            provee.Notas = textBox3.Text;
            provee.Telefono = textBox4.Text;
            provee.Telefono2 = textBox5.Text;
            provee.Direccion = textBox6.Text;
            if (textBoxId.Text == string.Empty)
                provedor.AddProveedor(provee);
            else
                provee.Id = int.Parse(textBoxId.Text);
                provedor.UpdateProveedpr(provee);
            CargarGridProveedor();
            limpiarCampos();

            //dataGridViewIngreso.Refresh();
        }


        private void limpiarCampos()
        {
            textBox1.Text = string.Empty;
            comboBox1.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox6.Text = string.Empty;
        }
    }
}
