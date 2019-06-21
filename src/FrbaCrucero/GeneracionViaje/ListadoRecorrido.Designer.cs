﻿namespace FrbaCrucero.GeneracionViaje
{
    partial class ListadoRecorrido
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
            this.textBoxPuertoDesde = new System.Windows.Forms.TextBox();
            this.buttonSeleccionarDesde = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxPuertoHasta = new System.Windows.Forms.TextBox();
            this.groupBoxFiltrosRecorrido = new System.Windows.Forms.GroupBox();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.dataGridViewRecorrido = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBoxFiltrosRecorrido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecorrido)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHabilitado
            // 
            this.labelHabilitado.AutoSize = true;
            this.labelHabilitado.Location = new System.Drawing.Point(15, 33);
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
            this.labelPuertoDesde.Location = new System.Drawing.Point(12, 68);
            this.labelPuertoDesde.Name = "labelPuertoDesde";
            this.labelPuertoDesde.Size = new System.Drawing.Size(84, 13);
            this.labelPuertoDesde.TabIndex = 2;
            this.labelPuertoDesde.Text = "ID Puerto desde";
            // 
            // labelPuertoHasta
            // 
            this.labelPuertoHasta.AutoSize = true;
            this.labelPuertoHasta.Location = new System.Drawing.Point(12, 106);
            this.labelPuertoHasta.Name = "labelPuertoHasta";
            this.labelPuertoHasta.Size = new System.Drawing.Size(81, 13);
            this.labelPuertoHasta.TabIndex = 4;
            this.labelPuertoHasta.Text = "ID Puerto hasta";
            // 
            // textBoxPuertoDesde
            // 
            this.textBoxPuertoDesde.Location = new System.Drawing.Point(102, 65);
            this.textBoxPuertoDesde.Name = "textBoxPuertoDesde";
            this.textBoxPuertoDesde.Size = new System.Drawing.Size(100, 20);
            this.textBoxPuertoDesde.TabIndex = 5;
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
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.groupBoxFiltrosRecorrido.Controls.Add(this.textBoxPuertoDesde);
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
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // dataGridViewRecorrido
            // 
            this.dataGridViewRecorrido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRecorrido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.dataGridViewRecorrido.Location = new System.Drawing.Point(12, 190);
            this.dataGridViewRecorrido.Name = "dataGridViewRecorrido";
            this.dataGridViewRecorrido.Size = new System.Drawing.Size(530, 190);
            this.dataGridViewRecorrido.TabIndex = 12;
            this.dataGridViewRecorrido.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRecorrido_CellContentClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.Text = "Seleccionar";
            this.Seleccionar.UseColumnTextForButtonValue = true;
            // 
            // ListadoRecorrido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 400);
            this.Controls.Add(this.dataGridViewRecorrido);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.groupBoxFiltrosRecorrido);
            this.Name = "ListadoRecorrido";
            this.Text = "Listado Recorridos";
            this.groupBoxFiltrosRecorrido.ResumeLayout(false);
            this.groupBoxFiltrosRecorrido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecorrido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelHabilitado;
        private System.Windows.Forms.ComboBox comboBoxHabilitado;
        private System.Windows.Forms.Label labelPuertoDesde;
        private System.Windows.Forms.Label labelPuertoHasta;
        private System.Windows.Forms.TextBox textBoxPuertoDesde;
        private System.Windows.Forms.Button buttonSeleccionarDesde;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxPuertoHasta;
        private System.Windows.Forms.GroupBox groupBoxFiltrosRecorrido;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.DataGridView dataGridViewRecorrido;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccionar;
    }
}