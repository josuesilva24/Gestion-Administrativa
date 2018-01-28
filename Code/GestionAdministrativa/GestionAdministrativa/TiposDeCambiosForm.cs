using System;
using System.Windows.Forms;
using MappingClasses;
using System.Linq;

namespace GestionAdministrativa
{
    public partial class TiposDeCambiosForm : Form
    {
        TipoCambio TipoCambio = new TipoCambio();
        public TiposDeCambiosForm()
        {
            InitializeComponent();
        }

        private void TiposDeCambiosForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = TipoCambio.GetAllTiposCambios().
                Select( x => new
                {
                    Fecha = x.Fecha,
                    Valor =  x.Valor,
                    Activo = (x.Activo)?"Si":"No"
                }).ToList();
            
        }
    }
}
