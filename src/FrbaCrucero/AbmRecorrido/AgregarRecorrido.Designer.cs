namespace FrbaCrucero.AbmRecorrido
{
    partial class AgregarRecorrido
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
            this.dataGridViewTramosTotales = new System.Windows.Forms.DataGridView();
            this.Agregar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.dataGridViewTramosActuales = new System.Windows.Forms.DataGridView();
            this.Quitar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.labelTramos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTramosTotales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTramosActuales)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTramosTotales
            // 
            this.dataGridViewTramosTotales.AllowUserToAddRows = false;
            this.dataGridViewTramosTotales.AllowUserToDeleteRows = false;
            this.dataGridViewTramosTotales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTramosTotales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Agregar});
            this.dataGridViewTramosTotales.Location = new System.Drawing.Point(434, 72);
            this.dataGridViewTramosTotales.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewTramosTotales.Name = "dataGridViewTramosTotales";
            this.dataGridViewTramosTotales.ReadOnly = true;
            this.dataGridViewTramosTotales.RowTemplate.Height = 24;
            this.dataGridViewTramosTotales.Size = new System.Drawing.Size(442, 334);
            this.dataGridViewTramosTotales.TabIndex = 0;
            this.dataGridViewTramosTotales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTramosTotales_CellContentClick);
            // 
            // Agregar
            // 
            this.Agregar.HeaderText = "";
            this.Agregar.Name = "Agregar";
            this.Agregar.ReadOnly = true;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseColumnTextForButtonValue = true;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(790, 411);
            this.buttonGuardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(86, 29);
            this.buttonGuardar.TabIndex = 1;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(700, 411);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(86, 29);
            this.buttonCancelar.TabIndex = 3;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTramosActuales
            // 
            this.dataGridViewTramosActuales.AllowUserToAddRows = false;
            this.dataGridViewTramosActuales.AllowUserToDeleteRows = false;
            this.dataGridViewTramosActuales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTramosActuales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Quitar});
            this.dataGridViewTramosActuales.Location = new System.Drawing.Point(9, 72);
            this.dataGridViewTramosActuales.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewTramosActuales.Name = "dataGridViewTramosActuales";
            this.dataGridViewTramosActuales.ReadOnly = true;
            this.dataGridViewTramosActuales.RowTemplate.Height = 24;
            this.dataGridViewTramosActuales.Size = new System.Drawing.Size(376, 334);
            this.dataGridViewTramosActuales.TabIndex = 4;
            this.dataGridViewTramosActuales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTramosActuales_CellContentClick);
            // 
            // Quitar
            // 
            this.Quitar.HeaderText = "";
            this.Quitar.Name = "Quitar";
            this.Quitar.ReadOnly = true;
            this.Quitar.Text = "Quitar";
            this.Quitar.UseColumnTextForButtonValue = true;
            // 
            // labelTramos
            // 
            this.labelTramos.AutoSize = true;
            this.labelTramos.Location = new System.Drawing.Point(7, 48);
            this.labelTramos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTramos.Name = "labelTramos";
            this.labelTramos.Size = new System.Drawing.Size(106, 13);
            this.labelTramos.TabIndex = 5;
            this.labelTramos.Text = "Tramos del recorrido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(432, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Todos los tramos:";
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(7, 20);
            this.labelCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(101, 13);
            this.labelCodigo.TabIndex = 7;
            this.labelCodigo.Text = "Codigo del recorrido";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(113, 20);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 20);
            this.textBox1.TabIndex = 8;
            // 
            // AgregarRecorrido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTramos);
            this.Controls.Add(this.dataGridViewTramosActuales);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.dataGridViewTramosTotales);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AgregarRecorrido";
            this.Text = "AgregarRecorrido";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTramosTotales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTramosActuales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTramosTotales;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.DataGridView dataGridViewTramosActuales;
        private System.Windows.Forms.DataGridViewButtonColumn Quitar;
        private System.Windows.Forms.Label labelTramos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewButtonColumn Agregar;
    }
}