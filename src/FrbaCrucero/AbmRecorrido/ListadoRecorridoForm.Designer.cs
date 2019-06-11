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
            this.labelHabilitado.Location = new System.Drawing.Point(28, 41);
            this.labelHabilitado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHabilitado.Name = "labelHabilitado";
            this.labelHabilitado.Size = new System.Drawing.Size(71, 17);
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
            this.comboBoxHabilitado.Location = new System.Drawing.Point(136, 37);
            this.comboBoxHabilitado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxHabilitado.Name = "comboBoxHabilitado";
            this.comboBoxHabilitado.Size = new System.Drawing.Size(160, 24);
            this.comboBoxHabilitado.TabIndex = 1;
            // 
            // labelPuertoDesde
            // 
            this.labelPuertoDesde.AutoSize = true;
            this.labelPuertoDesde.Location = new System.Drawing.Point(28, 84);
            this.labelPuertoDesde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPuertoDesde.Name = "labelPuertoDesde";
            this.labelPuertoDesde.Size = new System.Drawing.Size(93, 17);
            this.labelPuertoDesde.TabIndex = 2;
            this.labelPuertoDesde.Text = "Puerto desde";
            // 
            // labelPuertoHasta
            // 
            this.labelPuertoHasta.AutoSize = true;
            this.labelPuertoHasta.Location = new System.Drawing.Point(39, 130);
            this.labelPuertoHasta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPuertoHasta.Name = "labelPuertoHasta";
            this.labelPuertoHasta.Size = new System.Drawing.Size(89, 17);
            this.labelPuertoHasta.TabIndex = 4;
            this.labelPuertoHasta.Text = "Puerto hasta";
            // 
            // textBoxPuertDesde
            // 
            this.textBoxPuertDesde.Location = new System.Drawing.Point(136, 80);
            this.textBoxPuertDesde.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPuertDesde.Name = "textBoxPuertDesde";
            this.textBoxPuertDesde.Size = new System.Drawing.Size(132, 22);
            this.textBoxPuertDesde.TabIndex = 5;
            // 
            // buttonSeleccionarDesde
            // 
            this.buttonSeleccionarDesde.Location = new System.Drawing.Point(293, 78);
            this.buttonSeleccionarDesde.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSeleccionarDesde.Name = "buttonSeleccionarDesde";
            this.buttonSeleccionarDesde.Size = new System.Drawing.Size(100, 28);
            this.buttonSeleccionarDesde.TabIndex = 6;
            this.buttonSeleccionarDesde.Text = "Seleccionar";
            this.buttonSeleccionarDesde.UseVisualStyleBackColor = true;
            this.buttonSeleccionarDesde.Click += new System.EventHandler(this.buttonSeleccionarDesde_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(293, 124);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "Seleccionar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBoxPuertoHasta
            // 
            this.textBoxPuertoHasta.Location = new System.Drawing.Point(136, 127);
            this.textBoxPuertoHasta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPuertoHasta.Name = "textBoxPuertoHasta";
            this.textBoxPuertoHasta.Size = new System.Drawing.Size(132, 22);
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
            this.groupBoxFiltrosRecorrido.Location = new System.Drawing.Point(16, 15);
            this.groupBoxFiltrosRecorrido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxFiltrosRecorrido.Name = "groupBoxFiltrosRecorrido";
            this.groupBoxFiltrosRecorrido.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxFiltrosRecorrido.Size = new System.Drawing.Size(707, 176);
            this.groupBoxFiltrosRecorrido.TabIndex = 9;
            this.groupBoxFiltrosRecorrido.TabStop = false;
            this.groupBoxFiltrosRecorrido.Text = "Filtros Recorrido";
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(16, 198);
            this.buttonLimpiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(100, 28);
            this.buttonLimpiar.TabIndex = 10;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(623, 198);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(100, 28);
            this.buttonBuscar.TabIndex = 11;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 234);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(707, 234);
            this.dataGridView1.TabIndex = 12;
            // 
            // ListadoRecorridoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 492);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.groupBoxFiltrosRecorrido);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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