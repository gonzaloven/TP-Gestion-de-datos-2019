namespace FrbaCrucero.AbmRecorrido
{
    partial class ListadoRecorridoForm
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
            this.labelHabilitado = new System.Windows.Forms.Label();
            this.comboBoxHabilitado = new System.Windows.Forms.ComboBox();
            this.labelPuertoDesde = new System.Windows.Forms.Label();
            this.labelPuertoHasta = new System.Windows.Forms.Label();
            this.textBoxPuertDesde = new System.Windows.Forms.TextBox();
            this.buttonSeleccionarDesde = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxPuertoHasta = new System.Windows.Forms.TextBox();
            this.groupBoxFiltrosRecorrido = new System.Windows.Forms.GroupBox();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBoxFiltrosRecorrido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHabilitado
            // 
            this.labelHabilitado.AutoSize = true;
            this.labelHabilitado.Location = new System.Drawing.Point(21, 33);
            this.labelHabilitado.Name = "labelHabilitado";
            this.labelHabilitado.Size = new System.Drawing.Size(54, 13);
            this.labelHabilitado.TabIndex = 0;
            this.labelHabilitado.Text = "Habilitado";
            // 
            // comboBoxHabilitado
            // 
            this.comboBoxHabilitado.FormattingEnabled = true;
            this.comboBoxHabilitado.Items.AddRange(new object[] {
            "Todos",
            "Si",
            "No"});
            this.comboBoxHabilitado.Location = new System.Drawing.Point(102, 30);
            this.comboBoxHabilitado.Name = "comboBoxHabilitado";
            this.comboBoxHabilitado.Size = new System.Drawing.Size(121, 21);
            this.comboBoxHabilitado.TabIndex = 1;
            // 
            // labelPuertoDesde
            // 
            this.labelPuertoDesde.AutoSize = true;
            this.labelPuertoDesde.Location = new System.Drawing.Point(21, 68);
            this.labelPuertoDesde.Name = "labelPuertoDesde";
            this.labelPuertoDesde.Size = new System.Drawing.Size(70, 13);
            this.labelPuertoDesde.TabIndex = 2;
            this.labelPuertoDesde.Text = "Puerto desde";
            // 
            // labelPuertoHasta
            // 
            this.labelPuertoHasta.AutoSize = true;
            this.labelPuertoHasta.Location = new System.Drawing.Point(29, 106);
            this.labelPuertoHasta.Name = "labelPuertoHasta";
            this.labelPuertoHasta.Size = new System.Drawing.Size(67, 13);
            this.labelPuertoHasta.TabIndex = 4;
            this.labelPuertoHasta.Text = "Puerto hasta";
            // 
            // textBoxPuertDesde
            // 
            this.textBoxPuertDesde.Location = new System.Drawing.Point(102, 65);
            this.textBoxPuertDesde.Name = "textBoxPuertDesde";
            this.textBoxPuertDesde.Size = new System.Drawing.Size(100, 20);
            this.textBoxPuertDesde.TabIndex = 5;
            // 
            // buttonSeleccionarDesde
            // 
            this.buttonSeleccionarDesde.Location = new System.Drawing.Point(220, 63);
            this.buttonSeleccionarDesde.Name = "buttonSeleccionarDesde";
            this.buttonSeleccionarDesde.Size = new System.Drawing.Size(75, 23);
            this.buttonSeleccionarDesde.TabIndex = 6;
            this.buttonSeleccionarDesde.Text = "Seleccionar";
            this.buttonSeleccionarDesde.UseVisualStyleBackColor = true;
            this.buttonSeleccionarDesde.Click += new System.EventHandler(this.buttonSeleccionarDesde_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(220, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Seleccionar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBoxPuertoHasta
            // 
            this.textBoxPuertoHasta.Location = new System.Drawing.Point(102, 103);
            this.textBoxPuertoHasta.Name = "textBoxPuertoHasta";
            this.textBoxPuertoHasta.Size = new System.Drawing.Size(100, 20);
            this.textBoxPuertoHasta.TabIndex = 8;
            // 
            // groupBoxFiltrosRecorrido
            // 
            this.groupBoxFiltrosRecorrido.Controls.Add(this.labelPuertoDesde);
            this.groupBoxFiltrosRecorrido.Controls.Add(this.textBoxPuertoHasta);
            this.groupBoxFiltrosRecorrido.Controls.Add(this.labelHabilitado);
            this.groupBoxFiltrosRecorrido.Controls.Add(this.button1);
            this.groupBoxFiltrosRecorrido.Controls.Add(this.comboBoxHabilitado);
            this.groupBoxFiltrosRecorrido.Controls.Add(this.buttonSeleccionarDesde);
            this.groupBoxFiltrosRecorrido.Controls.Add(this.labelPuertoHasta);
            this.groupBoxFiltrosRecorrido.Controls.Add(this.textBoxPuertDesde);
            this.groupBoxFiltrosRecorrido.Location = new System.Drawing.Point(12, 12);
            this.groupBoxFiltrosRecorrido.Name = "groupBoxFiltrosRecorrido";
            this.groupBoxFiltrosRecorrido.Size = new System.Drawing.Size(530, 143);
            this.groupBoxFiltrosRecorrido.TabIndex = 9;
            this.groupBoxFiltrosRecorrido.TabStop = false;
            this.groupBoxFiltrosRecorrido.Text = "Filtros Recorrido";
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(12, 161);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpiar.TabIndex = 10;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(467, 161);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 11;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 190);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(530, 190);
            this.dataGridView1.TabIndex = 12;
            // 
            // ListadoRecorridoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 392);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.groupBoxFiltrosRecorrido);
            this.Name = "ListadoRecorridoForm";
            this.Text = "Listado Recorridos";
            this.groupBoxFiltrosRecorrido.ResumeLayout(false);
            this.groupBoxFiltrosRecorrido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelHabilitado;
        private System.Windows.Forms.ComboBox comboBoxHabilitado;
        private System.Windows.Forms.Label labelPuertoDesde;
        private System.Windows.Forms.Label labelPuertoHasta;
        private System.Windows.Forms.TextBox textBoxPuertDesde;
        private System.Windows.Forms.Button buttonSeleccionarDesde;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxPuertoHasta;
        private System.Windows.Forms.GroupBox groupBoxFiltrosRecorrido;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}