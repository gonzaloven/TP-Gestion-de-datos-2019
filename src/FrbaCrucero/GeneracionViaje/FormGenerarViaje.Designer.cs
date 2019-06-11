namespace FrbaCrucero.GeneracionViaje
{
    partial class FormGenerarViaje
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
            this.textBoxCrucero = new System.Windows.Forms.TextBox();
            this.textBoxPuertoDesde = new System.Windows.Forms.TextBox();
            this.textBoxPuertoHasta = new System.Windows.Forms.TextBox();
            this.textBoxFechaInicio = new System.Windows.Forms.TextBox();
            this.labelCrucero = new System.Windows.Forms.Label();
            this.labelPuertoDesde = new System.Windows.Forms.Label();
            this.labelPuertoHasta = new System.Windows.Forms.Label();
            this.labelFechaInicio = new System.Windows.Forms.Label();
            this.labelFechaFin = new System.Windows.Forms.Label();
            this.textBoxFechaFin = new System.Windows.Forms.TextBox();
            this.buttonSeleccionarCrucero = new System.Windows.Forms.Button();
            this.buttonSeleccionarPuertoDesde = new System.Windows.Forms.Button();
            this.buttonSeleccionarPuertoHasta = new System.Windows.Forms.Button();
            this.buttonSeleccionarFechaInicio = new System.Windows.Forms.Button();
            this.buttonSeleccionarFechaFin = new System.Windows.Forms.Button();
            this.buttonGenerarViaje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxCrucero
            // 
            this.textBoxCrucero.Location = new System.Drawing.Point(151, 36);
            this.textBoxCrucero.Name = "textBoxCrucero";
            this.textBoxCrucero.Size = new System.Drawing.Size(100, 22);
            this.textBoxCrucero.TabIndex = 0;
            this.textBoxCrucero.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxPuertoDesde
            // 
            this.textBoxPuertoDesde.Location = new System.Drawing.Point(151, 76);
            this.textBoxPuertoDesde.Name = "textBoxPuertoDesde";
            this.textBoxPuertoDesde.Size = new System.Drawing.Size(100, 22);
            this.textBoxPuertoDesde.TabIndex = 1;
            // 
            // textBoxPuertoHasta
            // 
            this.textBoxPuertoHasta.Location = new System.Drawing.Point(151, 117);
            this.textBoxPuertoHasta.Name = "textBoxPuertoHasta";
            this.textBoxPuertoHasta.Size = new System.Drawing.Size(100, 22);
            this.textBoxPuertoHasta.TabIndex = 2;
            // 
            // textBoxFechaInicio
            // 
            this.textBoxFechaInicio.Location = new System.Drawing.Point(151, 159);
            this.textBoxFechaInicio.Name = "textBoxFechaInicio";
            this.textBoxFechaInicio.Size = new System.Drawing.Size(100, 22);
            this.textBoxFechaInicio.TabIndex = 3;
            // 
            // labelCrucero
            // 
            this.labelCrucero.AutoSize = true;
            this.labelCrucero.Location = new System.Drawing.Point(45, 36);
            this.labelCrucero.Name = "labelCrucero";
            this.labelCrucero.Size = new System.Drawing.Size(58, 17);
            this.labelCrucero.TabIndex = 4;
            this.labelCrucero.Text = "Crucero";
            // 
            // labelPuertoDesde
            // 
            this.labelPuertoDesde.AutoSize = true;
            this.labelPuertoDesde.Location = new System.Drawing.Point(45, 76);
            this.labelPuertoDesde.Name = "labelPuertoDesde";
            this.labelPuertoDesde.Size = new System.Drawing.Size(94, 17);
            this.labelPuertoDesde.TabIndex = 5;
            this.labelPuertoDesde.Text = "Puerto origen";
            // 
            // labelPuertoHasta
            // 
            this.labelPuertoHasta.AutoSize = true;
            this.labelPuertoHasta.Location = new System.Drawing.Point(45, 117);
            this.labelPuertoHasta.Name = "labelPuertoHasta";
            this.labelPuertoHasta.Size = new System.Drawing.Size(100, 17);
            this.labelPuertoHasta.TabIndex = 6;
            this.labelPuertoHasta.Text = "Puerto destino";
            // 
            // labelFechaInicio
            // 
            this.labelFechaInicio.AutoSize = true;
            this.labelFechaInicio.Location = new System.Drawing.Point(45, 158);
            this.labelFechaInicio.Name = "labelFechaInicio";
            this.labelFechaInicio.Size = new System.Drawing.Size(83, 17);
            this.labelFechaInicio.TabIndex = 7;
            this.labelFechaInicio.Text = "Fecha inicio";
            // 
            // labelFechaFin
            // 
            this.labelFechaFin.AutoSize = true;
            this.labelFechaFin.Location = new System.Drawing.Point(45, 197);
            this.labelFechaFin.Name = "labelFechaFin";
            this.labelFechaFin.Size = new System.Drawing.Size(66, 17);
            this.labelFechaFin.TabIndex = 8;
            this.labelFechaFin.Text = "Fecha fin";
            // 
            // textBoxFechaFin
            // 
            this.textBoxFechaFin.Location = new System.Drawing.Point(151, 197);
            this.textBoxFechaFin.Name = "textBoxFechaFin";
            this.textBoxFechaFin.Size = new System.Drawing.Size(100, 22);
            this.textBoxFechaFin.TabIndex = 9;
            // 
            // buttonSeleccionarCrucero
            // 
            this.buttonSeleccionarCrucero.Location = new System.Drawing.Point(275, 36);
            this.buttonSeleccionarCrucero.Name = "buttonSeleccionarCrucero";
            this.buttonSeleccionarCrucero.Size = new System.Drawing.Size(96, 23);
            this.buttonSeleccionarCrucero.TabIndex = 10;
            this.buttonSeleccionarCrucero.Text = "Seleccionar";
            this.buttonSeleccionarCrucero.UseVisualStyleBackColor = true;
            this.buttonSeleccionarCrucero.Click += new System.EventHandler(this.buttonSeleccionarCrucero_Click);
            // 
            // buttonSeleccionarPuertoDesde
            // 
            this.buttonSeleccionarPuertoDesde.Location = new System.Drawing.Point(275, 76);
            this.buttonSeleccionarPuertoDesde.Name = "buttonSeleccionarPuertoDesde";
            this.buttonSeleccionarPuertoDesde.Size = new System.Drawing.Size(96, 23);
            this.buttonSeleccionarPuertoDesde.TabIndex = 11;
            this.buttonSeleccionarPuertoDesde.Text = "Seleccionar";
            this.buttonSeleccionarPuertoDesde.UseVisualStyleBackColor = true;
            this.buttonSeleccionarPuertoDesde.Click += new System.EventHandler(this.buttonSeleccionarPuertoDesde_Click);
            // 
            // buttonSeleccionarPuertoHasta
            // 
            this.buttonSeleccionarPuertoHasta.Location = new System.Drawing.Point(275, 117);
            this.buttonSeleccionarPuertoHasta.Name = "buttonSeleccionarPuertoHasta";
            this.buttonSeleccionarPuertoHasta.Size = new System.Drawing.Size(96, 23);
            this.buttonSeleccionarPuertoHasta.TabIndex = 12;
            this.buttonSeleccionarPuertoHasta.Text = "Seleccionar";
            this.buttonSeleccionarPuertoHasta.UseVisualStyleBackColor = true;
            this.buttonSeleccionarPuertoHasta.Click += new System.EventHandler(this.buttonSeleccionarPuertoHasta_Click);
            // 
            // buttonSeleccionarFechaInicio
            // 
            this.buttonSeleccionarFechaInicio.Location = new System.Drawing.Point(275, 158);
            this.buttonSeleccionarFechaInicio.Name = "buttonSeleccionarFechaInicio";
            this.buttonSeleccionarFechaInicio.Size = new System.Drawing.Size(96, 23);
            this.buttonSeleccionarFechaInicio.TabIndex = 13;
            this.buttonSeleccionarFechaInicio.Text = "Seleccionar";
            this.buttonSeleccionarFechaInicio.UseVisualStyleBackColor = true;
            this.buttonSeleccionarFechaInicio.Click += new System.EventHandler(this.buttonSeleccionarFechaInicio_Click);
            // 
            // buttonSeleccionarFechaFin
            // 
            this.buttonSeleccionarFechaFin.Location = new System.Drawing.Point(275, 197);
            this.buttonSeleccionarFechaFin.Name = "buttonSeleccionarFechaFin";
            this.buttonSeleccionarFechaFin.Size = new System.Drawing.Size(96, 23);
            this.buttonSeleccionarFechaFin.TabIndex = 14;
            this.buttonSeleccionarFechaFin.Text = "Seleccionar";
            this.buttonSeleccionarFechaFin.UseVisualStyleBackColor = true;
            this.buttonSeleccionarFechaFin.Click += new System.EventHandler(this.buttonSeleccionarFechaFin_Click);
            // 
            // buttonGenerarViaje
            // 
            this.buttonGenerarViaje.Location = new System.Drawing.Point(447, 84);
            this.buttonGenerarViaje.Name = "buttonGenerarViaje";
            this.buttonGenerarViaje.Size = new System.Drawing.Size(103, 82);
            this.buttonGenerarViaje.TabIndex = 15;
            this.buttonGenerarViaje.Text = "Generar";
            this.buttonGenerarViaje.UseVisualStyleBackColor = true;
            // 
            // FormGenerarViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 261);
            this.Controls.Add(this.buttonGenerarViaje);
            this.Controls.Add(this.buttonSeleccionarFechaFin);
            this.Controls.Add(this.buttonSeleccionarFechaInicio);
            this.Controls.Add(this.buttonSeleccionarPuertoHasta);
            this.Controls.Add(this.buttonSeleccionarPuertoDesde);
            this.Controls.Add(this.buttonSeleccionarCrucero);
            this.Controls.Add(this.textBoxFechaFin);
            this.Controls.Add(this.labelFechaFin);
            this.Controls.Add(this.labelFechaInicio);
            this.Controls.Add(this.labelPuertoHasta);
            this.Controls.Add(this.labelPuertoDesde);
            this.Controls.Add(this.labelCrucero);
            this.Controls.Add(this.textBoxFechaInicio);
            this.Controls.Add(this.textBoxPuertoHasta);
            this.Controls.Add(this.textBoxPuertoDesde);
            this.Controls.Add(this.textBoxCrucero);
            this.Name = "FormGenerarViaje";
            this.Text = "Generar Viaje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCrucero;
        private System.Windows.Forms.TextBox textBoxPuertoDesde;
        private System.Windows.Forms.TextBox textBoxPuertoHasta;
        private System.Windows.Forms.TextBox textBoxFechaInicio;
        private System.Windows.Forms.Label labelCrucero;
        private System.Windows.Forms.Label labelPuertoDesde;
        private System.Windows.Forms.Label labelPuertoHasta;
        private System.Windows.Forms.Label labelFechaInicio;
        private System.Windows.Forms.Label labelFechaFin;
        private System.Windows.Forms.TextBox textBoxFechaFin;
        private System.Windows.Forms.Button buttonSeleccionarCrucero;
        private System.Windows.Forms.Button buttonSeleccionarPuertoDesde;
        private System.Windows.Forms.Button buttonSeleccionarPuertoHasta;
        private System.Windows.Forms.Button buttonSeleccionarFechaInicio;
        private System.Windows.Forms.Button buttonSeleccionarFechaFin;
        private System.Windows.Forms.Button buttonGenerarViaje;
    }
}