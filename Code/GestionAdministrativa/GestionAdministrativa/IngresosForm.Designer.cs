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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIngreso)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewIngreso
            // 
            this.dataGridViewIngreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIngreso.Location = new System.Drawing.Point(12, 38);
            this.dataGridViewIngreso.Name = "dataGridViewIngreso";
            this.dataGridViewIngreso.Size = new System.Drawing.Size(650, 150);
            this.dataGridViewIngreso.TabIndex = 0;
            this.dataGridViewIngreso.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewIngreso_CellContentClick);
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
    }
}