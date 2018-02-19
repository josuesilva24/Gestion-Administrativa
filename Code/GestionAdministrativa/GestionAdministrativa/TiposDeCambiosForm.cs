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
                    id= x.Id,
                    Fecha = x.Fecha,
                    Valor =  x.Valor,
                    Activo = (x.Activo)?"Si":"No"
                }).ToList();

            //dataGridView1.Columns.Add(new DataGridViewButtonColumn {
            //    Text = "Editar",
            //    UseColumnTextForButtonValue = true,
            //    Name= "Editar"
                
            //});
            dataGridView1.Columns.Add(new DataGridViewButtonColumn
            {
                Text = "Eliminar",
                UseColumnTextForButtonValue = true,
                Name = "Eliminar"

            });
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private bool WithErrors()
        {
            if (textBox1.Text.Trim() == String.Empty)
                return true; // Returns true if no input or only space is found
            //if (comboBox1.Text.Trim() == String.Empty)
            //    return true; // Returns true if no input or only space is found
            return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (WithErrors())
            {
                MessageBox.Show("Existen campos en blanco que se deben rellenar, verificar campos vacíos!",
                                     "Campos vacíos!!",
                                     MessageBoxButtons.OK);
            }
            else
            {
                EFF.TipoCambio tipoC = new EFF.TipoCambio();

                if (textBoxId.Text == string.Empty) { 
                    tipoC.Valor = int.Parse(textBox1.Text);
                    tipoC.Activo = true;//comboBox1.SelectedItem.Equals("Si") ? true:false;
                    TipoCambio.AddTipoCambio(tipoC);
                }
                else
                {
                    tipoC.Id = int.Parse(textBoxId.Text);
                    tipoC.Valor = int.Parse(textBox1.Text);
                    tipoC.Activo = true;//comboBox1.SelectedItem.Equals("Si") ? true : false;
                    TipoCambio.UpdateTipoCambio(tipoC);
                }
                this.Close();
                new TiposDeCambiosForm().Show();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //if (e.ColumnIndex == dataGridView1.Columns["Editar"].Index && e.RowIndex >= 0)
            //{
            //    var TipoCambioID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

            //    EFF.TipoCambio pr = new TipoCambio().GetTipoCambio(TipoCambioID);

            //    textBox1.Text = pr.Valor.ToString();
            //    textBoxId.Text = pr.Id.ToString();
            //    comboBox1.SelectedItem = pr.Activo == true ? "Si" : "No";
            //}

            if (e.ColumnIndex == dataGridView1.Columns["Eliminar"].Index && e.RowIndex >= 0)
            {
                var confirmResult = MessageBox.Show("Está seguro de eliminar el registro?",
                                     "Confirmar borrado!!",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    var TipoCambioID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    var Errores = new TipoCambio().deleteTipoCambio(TipoCambioID);
                    if (Errores.Count == 0)
                    {
                        this.Close();
                        new TiposDeCambiosForm().Show();
                    }
                    else {
                        MessageBox.Show(Errores[0], "Mensaje!!",MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                        new TiposDeCambiosForm().Show();
                    }
                }


            }
        }
    }
}
