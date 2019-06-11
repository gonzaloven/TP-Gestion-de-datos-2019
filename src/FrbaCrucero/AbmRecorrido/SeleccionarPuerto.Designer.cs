namespace FrbaCrucero.AbmRecorrido
{
    partial class SeleccionarPuerto
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
            this.groupBoxFiltroPuerto = new System.Windows.Forms.GroupBox();
            this.labelPuerto = new System.Windows.Forms.Label();
            this.textBoxPuerto = new System.Windows.Forms.TextBox();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.dataGridViewPuertos = new System.Windows.Forms.DataGridView();
            this.groupBoxFiltroPuerto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPuertos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxFiltroPuerto
            // 
            this.groupBoxFiltroPuerto.Controls.Add(this.textBoxPuerto);
            this.groupBoxFiltroPuerto.Controls.Add(this.labelPuerto);
            this.groupBoxFiltroPuerto.Location = new System.Drawing.Point(12, 0);
            this.groupBoxFiltroPuerto.Name = "groupBoxFiltroPuerto";
            this.groupBoxFiltroPuerto.Size = new System.Drawing.Size(423, 90);
            this.groupBoxFiltroPuerto.TabIndex = 0;
            this.groupBoxFiltroPuerto.TabStop = false;
            this.groupBoxFiltroPuerto.Text = "Filtro puerto";
            // 
            // labelPuerto
            // 
            this.labelPuerto.AutoSize = true;
            this.labelPuerto.Location = new System.Drawing.Point(6, 40);
            this.labelPuerto.Name = "labelPuerto";
            this.labelPuerto.Size = new System.Drawing.Size(38, 13);
            this.labelPuerto.TabIndex = 0;
            this.labelPuerto.Text = "Puerto";
            // 
            // textBoxPuerto
            // 
            this.textBoxPuerto.Location = new System.Drawing.Point(50, 37);
            this.textBoxPuerto.Name = "textBoxPuerto";
            this.textBoxPuerto.Size = new System.Drawing.Size(207, 20);
            this.textBoxPuerto.TabIndex = 1;
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(12, 96);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpiar.TabIndex = 2;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(360, 96);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 3;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // dataGridViewPuertos
            // 
            this.dataGridViewPuertos.AllowUserToAddRows = false;
            this.dataGridViewPuertos.AllowUserToDeleteRows = false;
            this.dataGridViewPuertos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPuertos.Location = new System.Drawing.Point(12, 125);
            this.dataGridViewPuertos.Name = "dataGridViewPuertos";
            this.dataGridViewPuertos.ReadOnly = true;
            this.dataGridViewPuertos.Size = new System.Drawing.Size(423, 223);
            this.dataGridViewPuertos.TabIndex = 4;
            // 
            // SeleccionarPuerto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 360);
            this.Controls.Add(this.dataGridViewPuertos);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.groupBoxFiltroPuerto);
            this.Name = "SeleccionarPuerto";
            this.Text = "Seleccionar puerto";
            this.groupBoxFiltroPuerto.ResumeLayout(false);
            this.groupBoxFiltroPuerto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPuertos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxFiltroPuerto;
        private System.Windows.Forms.TextBox textBoxPuerto;
        private System.Windows.Forms.Label labelPuerto;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.DataGridView dataGridViewPuertos;
    }
}