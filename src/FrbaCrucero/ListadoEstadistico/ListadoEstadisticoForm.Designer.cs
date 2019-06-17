namespace FrbaCrucero.ListadoEstadistico
{
    partial class ListadoEstadisticoForm
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
            this.dataGridEstadistico = new System.Windows.Forms.DataGridView();
            this.recMasComprados = new System.Windows.Forms.Button();
            this.recMasCabinasLibres = new System.Windows.Forms.Button();
            this.crucMasDiasFueraServ = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEstadistico)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridEstadistico
            // 
            this.dataGridEstadistico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEstadistico.Location = new System.Drawing.Point(12, 157);
            this.dataGridEstadistico.Name = "dataGridEstadistico";
            this.dataGridEstadistico.Size = new System.Drawing.Size(392, 258);
            this.dataGridEstadistico.TabIndex = 3;
            // 
            // recMasComprados
            // 
            this.recMasComprados.Location = new System.Drawing.Point(6, 86);
            this.recMasComprados.Name = "recMasComprados";
            this.recMasComprados.Size = new System.Drawing.Size(377, 23);
            this.recMasComprados.TabIndex = 4;
            this.recMasComprados.Text = "Top 5 de los recorridos con más pasajes comprados";
            this.recMasComprados.UseVisualStyleBackColor = true;
            this.recMasComprados.Click += new System.EventHandler(this.recMasComprados_Click);
            // 
            // recMasCabinasLibres
            // 
            this.recMasCabinasLibres.Location = new System.Drawing.Point(6, 57);
            this.recMasCabinasLibres.Name = "recMasCabinasLibres";
            this.recMasCabinasLibres.Size = new System.Drawing.Size(377, 23);
            this.recMasCabinasLibres.TabIndex = 5;
            this.recMasCabinasLibres.Text = "Top 5 de los recorridos con más cabinas libres en cada uno de los viajes";
            this.recMasCabinasLibres.UseVisualStyleBackColor = true;
            // 
            // crucMasDiasFueraServ
            // 
            this.crucMasDiasFueraServ.Location = new System.Drawing.Point(6, 115);
            this.crucMasDiasFueraServ.Name = "crucMasDiasFueraServ";
            this.crucMasDiasFueraServ.Size = new System.Drawing.Size(377, 23);
            this.crucMasDiasFueraServ.TabIndex = 6;
            this.crucMasDiasFueraServ.Text = "Top 5 de los cruceros con mayor cantidad de días fuera de servicio";
            this.crucMasDiasFueraServ.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Inicio semestre";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(89, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.recMasCabinasLibres);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.recMasComprados);
            this.groupBox1.Controls.Add(this.crucMasDiasFueraServ);
            this.groupBox1.Location = new System.Drawing.Point(15, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 147);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estadistico semestral";
            // 
            // ListadoEstadisticoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 425);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridEstadistico);
            this.Name = "ListadoEstadisticoForm";
            this.Text = "ListadoEstadistico";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEstadistico)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridEstadistico;
        private System.Windows.Forms.Button recMasComprados;
        private System.Windows.Forms.Button recMasCabinasLibres;
        private System.Windows.Forms.Button crucMasDiasFueraServ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}