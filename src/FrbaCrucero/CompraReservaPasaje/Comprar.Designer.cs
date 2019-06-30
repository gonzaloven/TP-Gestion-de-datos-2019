namespace FrbaCrucero.CompraReservaPasaje
{
    partial class Comprar
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
            this.labelMetodoDePago = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxMetodoDePago = new System.Windows.Forms.ComboBox();
            this.numericUpDownCuotas = new System.Windows.Forms.NumericUpDown();
            this.groupBoxPago = new System.Windows.Forms.GroupBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCuotas)).BeginInit();
            this.groupBoxPago.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMetodoDePago
            // 
            this.labelMetodoDePago.AutoSize = true;
            this.labelMetodoDePago.Location = new System.Drawing.Point(6, 26);
            this.labelMetodoDePago.Name = "labelMetodoDePago";
            this.labelMetodoDePago.Size = new System.Drawing.Size(85, 13);
            this.labelMetodoDePago.TabIndex = 0;
            this.labelMetodoDePago.Text = "Metodo de pago";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cuotas";
            // 
            // comboBoxMetodoDePago
            // 
            this.comboBoxMetodoDePago.FormattingEnabled = true;
            this.comboBoxMetodoDePago.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta de débito",
            "Tarjeta de crédito"});
            this.comboBoxMetodoDePago.Location = new System.Drawing.Point(97, 23);
            this.comboBoxMetodoDePago.Name = "comboBoxMetodoDePago";
            this.comboBoxMetodoDePago.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMetodoDePago.TabIndex = 2;
            this.comboBoxMetodoDePago.SelectedIndex = 0;
            this.comboBoxMetodoDePago.SelectedIndexChanged += new System.EventHandler(this.comboBoxMetodoDePago_SelectedIndexChanged);
            // 
            // numericUpDownCuotas
            // 
            this.numericUpDownCuotas.Location = new System.Drawing.Point(98, 55);
            this.numericUpDownCuotas.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownCuotas.Name = "numericUpDownCuotas";
            this.numericUpDownCuotas.ReadOnly = true;
            this.numericUpDownCuotas.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownCuotas.TabIndex = 3;
            // 
            // groupBoxPago
            // 
            this.groupBoxPago.Controls.Add(this.label1);
            this.groupBoxPago.Controls.Add(this.numericUpDownCuotas);
            this.groupBoxPago.Controls.Add(this.comboBoxMetodoDePago);
            this.groupBoxPago.Controls.Add(this.labelMetodoDePago);
            this.groupBoxPago.Location = new System.Drawing.Point(12, 12);
            this.groupBoxPago.Name = "groupBoxPago";
            this.groupBoxPago.Size = new System.Drawing.Size(266, 100);
            this.groupBoxPago.TabIndex = 4;
            this.groupBoxPago.TabStop = false;
            this.groupBoxPago.Text = "Pago de pasaje";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(207, 120);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 5;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // Comprar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 155);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.groupBoxPago);
            this.Name = "Comprar";
            this.Text = "SeleccionarMetodoDePago";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCuotas)).EndInit();
            this.groupBoxPago.ResumeLayout(false);
            this.groupBoxPago.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelMetodoDePago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxMetodoDePago;
        private System.Windows.Forms.NumericUpDown numericUpDownCuotas;
        private System.Windows.Forms.GroupBox groupBoxPago;
        private System.Windows.Forms.Button buttonGuardar;
    }
}