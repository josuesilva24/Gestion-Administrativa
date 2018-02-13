namespace GestionAdministrativa
{
    partial class IngresosForm
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
            this.dataGridViewIngreso = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoDol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTipoCambio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIngreso)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewIngreso
            // 
            this.dataGridViewIngreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIngreso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Descripcion,
            this.Fecha,
            this.MontoCol,
            this.MontoDol,
            this.IdTipoCambio,
            this.IdProyecto});
            this.dataGridViewIngreso.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewIngreso.Name = "dataGridViewIngreso";
            this.dataGridViewIngreso.Size = new System.Drawing.Size(650, 150);
            this.dataGridViewIngreso.TabIndex = 0;
            this.dataGridViewIngreso.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewIngreso_CellContentClick);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // MontoCol
            // 
            this.MontoCol.HeaderText = "Monto Colones";
            this.MontoCol.Name = "MontoCol";
            // 
            // MontoDol
            // 
            this.MontoDol.HeaderText = "Monto Dolares";
            this.MontoDol.Name = "MontoDol";
            // 
            // IdTipoCambio
            // 
            this.IdTipoCambio.HeaderText = "Tipo Cambio";
            this.IdTipoCambio.Name = "IdTipoCambio";
            // 
            // IdProyecto
            // 
            this.IdProyecto.HeaderText = "Proyecto";
            this.IdProyecto.Name = "IdProyecto";
            // 
            // IngresosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 261);
            this.Controls.Add(this.dataGridViewIngreso);
            this.Name = "IngresosForm";
            this.Text = "IngresosForm";
            this.Load += new System.EventHandler(this.IngresosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIngreso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoDol;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipoCambio;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProyecto;
    }
}