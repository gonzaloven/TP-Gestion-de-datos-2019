namespace FrbaCrucero.AbmCrucero
{
    partial class BajaCrucero
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
            this.buttonBajaTemporal = new System.Windows.Forms.Button();
            this.buttonBajaDefinitiva = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBajaTemporal
            // 
            this.buttonBajaTemporal.Location = new System.Drawing.Point(44, 80);
            this.buttonBajaTemporal.Name = "buttonBajaTemporal";
            this.buttonBajaTemporal.Size = new System.Drawing.Size(127, 57);
            this.buttonBajaTemporal.TabIndex = 0;
            this.buttonBajaTemporal.Text = "Baja temporal";
            this.buttonBajaTemporal.UseVisualStyleBackColor = true;
            this.buttonBajaTemporal.Click += new System.EventHandler(this.buttonBajaTemporal_Click);
            // 
            // buttonBajaDefinitiva
            // 
            this.buttonBajaDefinitiva.Location = new System.Drawing.Point(224, 80);
            this.buttonBajaDefinitiva.Name = "buttonBajaDefinitiva";
            this.buttonBajaDefinitiva.Size = new System.Drawing.Size(127, 57);
            this.buttonBajaDefinitiva.TabIndex = 1;
            this.buttonBajaDefinitiva.Text = "Baja definitiva";
            this.buttonBajaDefinitiva.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(12, 181);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(82, 29);
            this.buttonCancelar.TabIndex = 2;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // BajaCrucero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 222);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonBajaDefinitiva);
            this.Controls.Add(this.buttonBajaTemporal);
            this.Name = "BajaCrucero";
            this.Text = "BajaCrucero";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBajaTemporal;
        private System.Windows.Forms.Button buttonBajaDefinitiva;
        private System.Windows.Forms.Button buttonCancelar;
    }
}