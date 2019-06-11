namespace FrbaCrucero.GeneracionViaje
{
    partial class SeleccionarCrucero
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
            this.groupBoxFiltroCrucero = new System.Windows.Forms.GroupBox();
            this.comboBoxHabilitado = new System.Windows.Forms.ComboBox();
            this.labelHabilitado = new System.Windows.Forms.Label();
            this.labelFiltroCrucero = new System.Windows.Forms.Label();
            this.textBoxFiltroCrucero = new System.Windows.Forms.TextBox();
            this.dataGridViewCruceros = new System.Windows.Forms.DataGridView();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBoxFiltroCrucero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCruceros)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxFiltroCrucero
            // 
            this.groupBoxFiltroCrucero.Controls.Add(this.comboBoxHabilitado);
            this.groupBoxFiltroCrucero.Controls.Add(this.labelHabilitado);
            this.groupBoxFiltroCrucero.Controls.Add(this.labelFiltroCrucero);
            this.groupBoxFiltroCrucero.Controls.Add(this.textBoxFiltroCrucero);
            this.groupBoxFiltroCrucero.Location = new System.Drawing.Point(12, 12);
            this.groupBoxFiltroCrucero.Name = "groupBoxFiltroCrucero";
            this.groupBoxFiltroCrucero.Size = new System.Drawing.Size(1048, 99);
            this.groupBoxFiltroCrucero.TabIndex = 0;
            this.groupBoxFiltroCrucero.TabStop = false;
            this.groupBoxFiltroCrucero.Text = "Filtro Crucero";
            // 
            // comboBoxHabilitado
            // 
            this.comboBoxHabilitado.FormattingEnabled = true;
            this.comboBoxHabilitado.Items.AddRange(new object[] {
            "",
            "Si",
            "No"});
            this.comboBoxHabilitado.Location = new System.Drawing.Point(97, 61);
            this.comboBoxHabilitado.Name = "comboBoxHabilitado";
            this.comboBoxHabilitado.Size = new System.Drawing.Size(141, 24);
            this.comboBoxHabilitado.TabIndex = 8;
            // 
            // labelHabilitado
            // 
            this.labelHabilitado.AutoSize = true;
            this.labelHabilitado.Location = new System.Drawing.Point(20, 61);
            this.labelHabilitado.Name = "labelHabilitado";
            this.labelHabilitado.Size = new System.Drawing.Size(71, 17);
            this.labelHabilitado.TabIndex = 7;
            this.labelHabilitado.Text = "Habilitado";
            // 
            // labelFiltroCrucero
            // 
            this.labelFiltroCrucero.AutoSize = true;
            this.labelFiltroCrucero.Location = new System.Drawing.Point(20, 29);
            this.labelFiltroCrucero.Name = "labelFiltroCrucero";
            this.labelFiltroCrucero.Size = new System.Drawing.Size(58, 17);
            this.labelFiltroCrucero.TabIndex = 1;
            this.labelFiltroCrucero.Text = "Crucero";
            // 
            // textBoxFiltroCrucero
            // 
            this.textBoxFiltroCrucero.Location = new System.Drawing.Point(97, 29);
            this.textBoxFiltroCrucero.Name = "textBoxFiltroCrucero";
            this.textBoxFiltroCrucero.Size = new System.Drawing.Size(141, 22);
            this.textBoxFiltroCrucero.TabIndex = 0;
            // 
            // dataGridViewCruceros
            // 
            this.dataGridViewCruceros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCruceros.Location = new System.Drawing.Point(12, 162);
            this.dataGridViewCruceros.Name = "dataGridViewCruceros";
            this.dataGridViewCruceros.RowTemplate.Height = 24;
            this.dataGridViewCruceros.Size = new System.Drawing.Size(1048, 367);
            this.dataGridViewCruceros.TabIndex = 1;
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(35, 118);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(86, 32);
            this.buttonLimpiar.TabIndex = 2;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(956, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SeleccionarCrucero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 541);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.dataGridViewCruceros);
            this.Controls.Add(this.groupBoxFiltroCrucero);
            this.Name = "SeleccionarCrucero";
            this.Text = "Seleccionar Crucero";
            this.groupBoxFiltroCrucero.ResumeLayout(false);
            this.groupBoxFiltroCrucero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCruceros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxFiltroCrucero;
        private System.Windows.Forms.DataGridView dataGridViewCruceros;
        private System.Windows.Forms.Label labelFiltroCrucero;
        private System.Windows.Forms.TextBox textBoxFiltroCrucero;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBoxHabilitado;
        private System.Windows.Forms.Label labelHabilitado;
    }
}