namespace FrbaCrucero.ListadoEstadistico
{
    partial class RecorridosConMasPasajesComprados
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
            this.limpiarButton = new System.Windows.Forms.Button();
            this.buscarButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboSemestre = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboAnio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resultadosTop5Grid = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultadosTop5Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // limpiarButton
            // 
            this.limpiarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.limpiarButton.Location = new System.Drawing.Point(10, 117);
            this.limpiarButton.Name = "limpiarButton";
            this.limpiarButton.Size = new System.Drawing.Size(75, 30);
            this.limpiarButton.TabIndex = 15;
            this.limpiarButton.Text = "Limpiar";
            this.limpiarButton.UseVisualStyleBackColor = true;
            this.limpiarButton.Click += new System.EventHandler(this.limpiarButton_Click);
            // 
            // buscarButton
            // 
            this.buscarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buscarButton.Location = new System.Drawing.Point(350, 117);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(75, 30);
            this.buscarButton.TabIndex = 16;
            this.buscarButton.Text = "Buscar";
            this.buscarButton.UseVisualStyleBackColor = true;
            this.buscarButton.Click += new System.EventHandler(this.buscarButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboSemestre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboAnio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox1.Location = new System.Drawing.Point(10, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 77);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de búsqueda";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // comboSemestre
            // 
            this.comboSemestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSemestre.FormattingEnabled = true;
            this.comboSemestre.Location = new System.Drawing.Point(264, 26);
            this.comboSemestre.Name = "comboSemestre";
            this.comboSemestre.Size = new System.Drawing.Size(139, 21);
            this.comboSemestre.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Semestre";
            // 
            // comboAnio
            // 
            this.comboAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAnio.FormattingEnabled = true;
            this.comboAnio.Location = new System.Drawing.Point(54, 26);
            this.comboAnio.Name = "comboAnio";
            this.comboAnio.Size = new System.Drawing.Size(121, 21);
            this.comboAnio.TabIndex = 1;
            this.comboAnio.SelectedIndexChanged += new System.EventHandler(this.comboAnio_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Año";
            // 
            // resultadosTop5Grid
            // 
            this.resultadosTop5Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultadosTop5Grid.Location = new System.Drawing.Point(9, 183);
            this.resultadosTop5Grid.Name = "resultadosTop5Grid";
            this.resultadosTop5Grid.Size = new System.Drawing.Size(428, 210);
            this.resultadosTop5Grid.TabIndex = 18;
            // 
            // RecorridosConMasPasajesComprados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 423);
            this.Controls.Add(this.resultadosTop5Grid);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buscarButton);
            this.Controls.Add(this.limpiarButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RecorridosConMasPasajesComprados";
            this.Text = "Recorridos con más pasajes comprados";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultadosTop5Grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button limpiarButton;
        private System.Windows.Forms.Button buscarButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboSemestre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboAnio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView resultadosTop5Grid;
    }
}