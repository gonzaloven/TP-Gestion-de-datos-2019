namespace FrbaCrucero.ListadoEstadistico
{
    partial class CrucerosConMasDiasSinServicio
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
            this.buscarButton = new System.Windows.Forms.Button();
            this.resultadosTop5Grid = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboSemestre = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboAnio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.limpiarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.resultadosTop5Grid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buscarButton
            // 
            this.buscarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buscarButton.Location = new System.Drawing.Point(470, 116);
            this.buscarButton.Margin = new System.Windows.Forms.Padding(4);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(100, 37);
            this.buscarButton.TabIndex = 26;
            this.buscarButton.Text = "Buscar";
            this.buscarButton.UseVisualStyleBackColor = true;
            this.buscarButton.Click += new System.EventHandler(this.buscarButton_Click);
            // 
            // resultadosTop5Grid
            // 
            this.resultadosTop5Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultadosTop5Grid.Location = new System.Drawing.Point(34, 188);
            this.resultadosTop5Grid.Margin = new System.Windows.Forms.Padding(4);
            this.resultadosTop5Grid.Name = "resultadosTop5Grid";
            this.resultadosTop5Grid.Size = new System.Drawing.Size(571, 258);
            this.resultadosTop5Grid.TabIndex = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboSemestre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboAnio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox1.Location = new System.Drawing.Point(34, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(555, 95);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de búsqueda";
            // 
            // comboSemestre
            // 
            this.comboSemestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSemestre.FormattingEnabled = true;
            this.comboSemestre.Location = new System.Drawing.Point(352, 32);
            this.comboSemestre.Margin = new System.Windows.Forms.Padding(4);
            this.comboSemestre.Name = "comboSemestre";
            this.comboSemestre.Size = new System.Drawing.Size(184, 25);
            this.comboSemestre.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Semestre";
            // 
            // comboAnio
            // 
            this.comboAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAnio.FormattingEnabled = true;
            this.comboAnio.Location = new System.Drawing.Point(72, 32);
            this.comboAnio.Margin = new System.Windows.Forms.Padding(4);
            this.comboAnio.Name = "comboAnio";
            this.comboAnio.Size = new System.Drawing.Size(160, 25);
            this.comboAnio.TabIndex = 1;
            this.comboAnio.SelectedIndexChanged += new System.EventHandler(this.comboAnio_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Año";
            // 
            // limpiarButton
            // 
            this.limpiarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.limpiarButton.Location = new System.Drawing.Point(46, 116);
            this.limpiarButton.Margin = new System.Windows.Forms.Padding(4);
            this.limpiarButton.Name = "limpiarButton";
            this.limpiarButton.Size = new System.Drawing.Size(100, 37);
            this.limpiarButton.TabIndex = 23;
            this.limpiarButton.Text = "Limpiar";
            this.limpiarButton.UseVisualStyleBackColor = true;
            this.limpiarButton.Click += new System.EventHandler(this.limpiarButton_Click);
            // 
            // CrucerosConMasDiasSinServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 480);
            this.Controls.Add(this.buscarButton);
            this.Controls.Add(this.resultadosTop5Grid);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.limpiarButton);
            this.Name = "CrucerosConMasDiasSinServicio";
            this.Text = "Cruceros con más días sin servicio";
            ((System.ComponentModel.ISupportInitialize)(this.resultadosTop5Grid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buscarButton;
        private System.Windows.Forms.DataGridView resultadosTop5Grid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboSemestre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboAnio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button limpiarButton;
    }
}