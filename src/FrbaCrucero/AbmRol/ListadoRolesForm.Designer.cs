﻿namespace FrbaCrucero.AbmRol
{
    partial class ListadoRolesForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxHabilitado = new System.Windows.Forms.ComboBox();
            this.labelHabilitado = new System.Windows.Forms.Label();
            this.textBoxRol = new System.Windows.Forms.TextBox();
            this.labelRol = new System.Windows.Forms.Label();
            this.dataGridViewRoles = new System.Windows.Forms.DataGridView();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxHabilitado);
            this.groupBox1.Controls.Add(this.labelHabilitado);
            this.groupBox1.Controls.Add(this.textBoxRol);
            this.groupBox1.Controls.Add(this.labelRol);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(519, 94);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de búsqueda";
            // 
            // comboBoxHabilitado
            // 
            this.comboBoxHabilitado.FormattingEnabled = true;
            this.comboBoxHabilitado.Items.AddRange(new object[] {
            "",
            "Si",
            "No"});
            this.comboBoxHabilitado.Location = new System.Drawing.Point(307, 27);
            this.comboBoxHabilitado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxHabilitado.Name = "comboBoxHabilitado";
            this.comboBoxHabilitado.Size = new System.Drawing.Size(160, 24);
            this.comboBoxHabilitado.TabIndex = 7;
            // 
            // labelHabilitado
            // 
            this.labelHabilitado.AutoSize = true;
            this.labelHabilitado.Location = new System.Drawing.Point(228, 27);
            this.labelHabilitado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHabilitado.Name = "labelHabilitado";
            this.labelHabilitado.Size = new System.Drawing.Size(71, 17);
            this.labelHabilitado.TabIndex = 4;
            this.labelHabilitado.Text = "Habilitado";
            // 
            // textBoxRol
            // 
            this.textBoxRol.Location = new System.Drawing.Point(50, 29);
            this.textBoxRol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxRol.Name = "textBoxRol";
            this.textBoxRol.Size = new System.Drawing.Size(132, 22);
            this.textBoxRol.TabIndex = 2;
            // 
            // labelRol
            // 
            this.labelRol.AutoSize = true;
            this.labelRol.Location = new System.Drawing.Point(13, 29);
            this.labelRol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRol.Name = "labelRol";
            this.labelRol.Size = new System.Drawing.Size(29, 17);
            this.labelRol.TabIndex = 1;
            this.labelRol.Text = "Rol";
            // 
            // dataGridViewRoles
            // 
            this.dataGridViewRoles.AllowUserToAddRows = false;
            this.dataGridViewRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoles.Location = new System.Drawing.Point(16, 137);
            this.dataGridViewRoles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewRoles.Name = "dataGridViewRoles";
            this.dataGridViewRoles.ReadOnly = true;
            this.dataGridViewRoles.Size = new System.Drawing.Size(489, 293);
            this.dataGridViewRoles.TabIndex = 3;
            this.dataGridViewRoles.DoubleClick += new System.EventHandler(this.dataGridViewRoles_DoubleClick);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(16, 101);
            this.buttonLimpiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(100, 28);
            this.buttonLimpiar.TabIndex = 5;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(405, 101);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(100, 28);
            this.buttonBuscar.TabIndex = 6;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // ListadoRolesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 446);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.dataGridViewRoles);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ListadoRolesForm";
            this.Text = "ListadoRoles";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxRol;
        private System.Windows.Forms.Label labelRol;
        private System.Windows.Forms.DataGridView dataGridViewRoles;
        private System.Windows.Forms.Label labelHabilitado;
        private System.Windows.Forms.ComboBox comboBoxHabilitado;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonBuscar;
    }
}