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
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxMontoDolares = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.textBoxMontoColones = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxProyecto = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxTipocambio = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIngreso)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewIngreso
            // 
            this.dataGridViewIngreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIngreso.Location = new System.Drawing.Point(12, 150);
            this.dataGridViewIngreso.Name = "dataGridViewIngreso";
            this.dataGridViewIngreso.Size = new System.Drawing.Size(893, 150);
            this.dataGridViewIngreso.TabIndex = 0;
            this.dataGridViewIngreso.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewIngreso_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(753, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Guardar ingreso";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxMontoDolares
            // 
            this.textBoxMontoDolares.Location = new System.Drawing.Point(168, 108);
            this.textBoxMontoDolares.Name = "textBoxMontoDolares";
            this.textBoxMontoDolares.Size = new System.Drawing.Size(124, 20);
            this.textBoxMontoDolares.TabIndex = 15;
            this.textBoxMontoDolares.Text = "0";
            this.textBoxMontoDolares.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMontoDolares_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre de ingreso";
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(300, 57);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(270, 20);
            this.textBoxDescripcion.TabIndex = 9;
            // 
            // textBoxMontoColones
            // 
            this.textBoxMontoColones.Location = new System.Drawing.Point(12, 108);
            this.textBoxMontoColones.Name = "textBoxMontoColones";
            this.textBoxMontoColones.Size = new System.Drawing.Size(128, 20);
            this.textBoxMontoColones.TabIndex = 11;
            this.textBoxMontoColones.Text = "0";
            this.textBoxMontoColones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMontoColones_KeyPress);
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(609, 57);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(249, 20);
            this.textBoxId.TabIndex = 10;
            this.textBoxId.Visible = false;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(12, 57);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(236, 20);
            this.textBoxNombre.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Monto en colones";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Monto en Dolares";
            // 
            // comboBoxProyecto
            // 
            this.comboBoxProyecto.FormattingEnabled = true;
            this.comboBoxProyecto.Location = new System.Drawing.Point(475, 108);
            this.comboBoxProyecto.Name = "comboBoxProyecto";
            this.comboBoxProyecto.Size = new System.Drawing.Size(232, 21);
            this.comboBoxProyecto.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(542, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Proyecto";
            // 
            // comboBoxTipocambio
            // 
            this.comboBoxTipocambio.FormattingEnabled = true;
            this.comboBoxTipocambio.Location = new System.Drawing.Point(317, 108);
            this.comboBoxTipocambio.Name = "comboBoxTipocambio";
            this.comboBoxTipocambio.Size = new System.Drawing.Size(135, 21);
            this.comboBoxTipocambio.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(347, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Tipo Cambio";
            // 
            // IngresosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 378);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxTipocambio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxProyecto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMontoDolares);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.textBoxMontoColones);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewIngreso);
            this.Name = "IngresosForm";
            this.Text = "Ingresos";
            this.Load += new System.EventHandler(this.IngresosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIngreso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewIngreso;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxMontoDolares;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.TextBox textBoxMontoColones;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxProyecto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxTipocambio;
        private System.Windows.Forms.Label label7;
    }
}