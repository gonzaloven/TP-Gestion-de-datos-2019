namespace FrbaCrucero.AbmCrucero
{
    partial class BajaTemporal
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
            this.button1 = new System.Windows.Forms.Button();
            this.labelFechaReinicioServicio = new System.Windows.Forms.Label();
            this.textBoxFechaReinicioServicio = new System.Windows.Forms.TextBox();
            this.buttonSeleccionar = new System.Windows.Forms.Button();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelFechaReinicioServicio
            // 
            this.labelFechaReinicioServicio.AutoSize = true;
            this.labelFechaReinicioServicio.Location = new System.Drawing.Point(12, 61);
            this.labelFechaReinicioServicio.Name = "labelFechaReinicioServicio";
            this.labelFechaReinicioServicio.Size = new System.Drawing.Size(148, 17);
            this.labelFechaReinicioServicio.TabIndex = 1;
            this.labelFechaReinicioServicio.Text = "Fecha reinicio servicio";
            // 
            // textBoxFechaReinicioServicio
            // 
            this.textBoxFechaReinicioServicio.Location = new System.Drawing.Point(166, 62);
            this.textBoxFechaReinicioServicio.Name = "textBoxFechaReinicioServicio";
            this.textBoxFechaReinicioServicio.Size = new System.Drawing.Size(100, 22);
            this.textBoxFechaReinicioServicio.TabIndex = 2;
            // 
            // buttonSeleccionar
            // 
            this.buttonSeleccionar.Location = new System.Drawing.Point(272, 61);
            this.buttonSeleccionar.Name = "buttonSeleccionar";
            this.buttonSeleccionar.Size = new System.Drawing.Size(100, 23);
            this.buttonSeleccionar.TabIndex = 3;
            this.buttonSeleccionar.Text = "Seleccionar";
            this.buttonSeleccionar.UseVisualStyleBackColor = true;
            this.buttonSeleccionar.Click += new System.EventHandler(this.buttonSeleccionar_Click);
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(15, 135);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(95, 44);
            this.buttonVolver.TabIndex = 4;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // BajaTemporal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 191);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.buttonSeleccionar);
            this.Controls.Add(this.textBoxFechaReinicioServicio);
            this.Controls.Add(this.labelFechaReinicioServicio);
            this.Controls.Add(this.button1);
            this.Name = "BajaTemporal";
            this.Text = "BajaTemporal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelFechaReinicioServicio;
        private System.Windows.Forms.Button buttonSeleccionar;
        public System.Windows.Forms.TextBox textBoxFechaReinicioServicio;
        private System.Windows.Forms.Button buttonVolver;
    }
}