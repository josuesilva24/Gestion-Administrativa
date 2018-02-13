namespace GestionAdministrativa
{
    partial class SalariosForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewSalarioHistory = new System.Windows.Forms.DataGridView();
            this.Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NuevoSal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AntSalario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaMod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalarioHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSalarioHistory
            // 
            this.dataGridViewSalarioHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSalarioHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Empleado,
            this.NuevoSal,
            this.AntSalario,
            this.FechaMod});
            this.dataGridViewSalarioHistory.Location = new System.Drawing.Point(49, 28);
            this.dataGridViewSalarioHistory.Name = "dataGridViewSalarioHistory";
            this.dataGridViewSalarioHistory.Size = new System.Drawing.Size(656, 150);
            this.dataGridViewSalarioHistory.TabIndex = 0;
            this.dataGridViewSalarioHistory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Empleado
            // 
            this.Empleado.HeaderText = "Empleado";
            this.Empleado.Name = "Empleado";
            // 
            // NuevoSal
            // 
            this.NuevoSal.HeaderText = "Nuevo Salario";
            this.NuevoSal.Name = "NuevoSal";
            // 
            // AntSalario
            // 
            this.AntSalario.HeaderText = "Salaraio Anterior";
            this.AntSalario.Name = "AntSalario";
            // 
            // FechaMod
            // 
            this.FechaMod.HeaderText = "Fecha de modificacion";
            this.FechaMod.Name = "FechaMod";
            // 
            // SalariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 261);
            this.Controls.Add(this.dataGridViewSalarioHistory);
            this.Name = "SalariosForm";
            this.Text = "SalariosForm";
            this.Load += new System.EventHandler(this.SalariosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalarioHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSalarioHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn NuevoSal;
        private System.Windows.Forms.DataGridViewTextBoxColumn AntSalario;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaMod;
    }
}