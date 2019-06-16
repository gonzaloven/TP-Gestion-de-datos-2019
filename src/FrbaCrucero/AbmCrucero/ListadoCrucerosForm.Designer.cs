namespace FrbaCrucero.AbmCrucero
{
    partial class ListadoCrucerosForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.labelEstado = new System.Windows.Forms.Label();
            this.textBoxCrucero = new System.Windows.Forms.TextBox();
            this.labelCrucero = new System.Windows.Forms.Label();
            this.textBoxModelo = new System.Windows.Forms.TextBox();
            this.labelModelo = new System.Windows.Forms.Label();
            this.comboBoxServicio = new System.Windows.Forms.ComboBox();
            this.labelServicio = new System.Windows.Forms.Label();
            this.dataGridViewCrucero = new System.Windows.Forms.DataGridView();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrucero)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxEstado);
            this.groupBox1.Controls.Add(this.labelEstado);
            this.groupBox1.Controls.Add(this.textBoxCrucero);
            this.groupBox1.Controls.Add(this.labelCrucero);
            this.groupBox1.Controls.Add(this.textBoxModelo);
            this.groupBox1.Controls.Add(this.labelModelo);
            this.groupBox1.Controls.Add(this.comboBoxServicio);
            this.groupBox1.Controls.Add(this.labelServicio);
            this.groupBox1.Location = new System.Drawing.Point(12, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 118);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de búsqueda";
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Items.AddRange(new object[] {
            "",
            "En servicio",
            "Fuera de servicio"});
            this.comboBoxEstado.Location = new System.Drawing.Point(292, 25);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEstado.TabIndex = 7;
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(246, 28);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(40, 13);
            this.labelEstado.TabIndex = 4;
            this.labelEstado.Text = "Estado";
            // 
            // textBoxCrucero
            // 
            this.textBoxCrucero.Location = new System.Drawing.Point(63, 26);
            this.textBoxCrucero.Name = "textBoxCrucero";
            this.textBoxCrucero.Size = new System.Drawing.Size(100, 20);
            this.textBoxCrucero.TabIndex = 2;
            // 
            // labelCrucero
            // 
            this.labelCrucero.AutoSize = true;
            this.labelCrucero.Location = new System.Drawing.Point(13, 25);
            this.labelCrucero.Name = "labelCrucero";
            this.labelCrucero.Size = new System.Drawing.Size(44, 13);
            this.labelCrucero.TabIndex = 1;
            this.labelCrucero.Text = "Crucero";
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.Location = new System.Drawing.Point(63, 74);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(100, 20);
            this.textBoxModelo.TabIndex = 2;
            // 
            // labelModelo
            // 
            this.labelModelo.AutoSize = true;
            this.labelModelo.Location = new System.Drawing.Point(13, 73);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(42, 13);
            this.labelModelo.TabIndex = 1;
            this.labelModelo.Text = "Modelo";
            // 
            // comboBoxServicio
            // 
            this.comboBoxServicio.FormattingEnabled = true;
            this.comboBoxServicio.Items.AddRange(new object[] {
            "",
            "Premium",
            "Estandar"});
            this.comboBoxServicio.Location = new System.Drawing.Point(292, 73);
            this.comboBoxServicio.Name = "comboBoxServicio";
            this.comboBoxServicio.Size = new System.Drawing.Size(121, 21);
            this.comboBoxServicio.TabIndex = 7;
            // 
            // labelServicio
            // 
            this.labelServicio.AutoSize = true;
            this.labelServicio.Location = new System.Drawing.Point(241, 76);
            this.labelServicio.Name = "labelServicio";
            this.labelServicio.Size = new System.Drawing.Size(45, 13);
            this.labelServicio.TabIndex = 1;
            this.labelServicio.Text = "Servicio";
            // 
            // dataGridViewCrucero
            // 
            this.dataGridViewCrucero.AllowUserToAddRows = false;
            this.dataGridViewCrucero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrucero.Location = new System.Drawing.Point(12, 153);
            this.dataGridViewCrucero.Name = "dataGridViewCrucero";
            this.dataGridViewCrucero.ReadOnly = true;
            this.dataGridViewCrucero.Size = new System.Drawing.Size(440, 238);
            this.dataGridViewCrucero.TabIndex = 3;
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(12, 124);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpiar.TabIndex = 5;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(377, 124);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 6;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // ListadoCrucerosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 404);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewCrucero);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.buttonLimpiar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ListadoCrucerosForm";
            this.Text = "ListadoCruceros";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrucero)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxCrucero;
        private System.Windows.Forms.Label labelCrucero;
        private System.Windows.Forms.TextBox textBoxModelo;
        private System.Windows.Forms.Label labelModelo;
        private System.Windows.Forms.ComboBox comboBoxServicio;
        private System.Windows.Forms.Label labelServicio;
        private System.Windows.Forms.DataGridView dataGridViewCrucero;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonBuscar;
    }
}