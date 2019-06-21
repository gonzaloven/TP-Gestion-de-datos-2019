namespace FrbaCrucero
{
    partial class MenuPrincipalForm
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBarraMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelABM = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelRecorrido = new System.Windows.Forms.ToolStripLabel();
            this.toolABMRolesLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripBarraMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(23, 23);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripBarraMenu
            // 
            this.toolStripBarraMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelABM,
            this.toolStripSeparator2,
            this.toolStripLabelRecorrido,
            this.toolStripSeparator1});
            this.toolStripBarraMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripBarraMenu.Name = "toolStripBarraMenu";
            this.toolStripBarraMenu.Size = new System.Drawing.Size(807, 25);
            this.toolStripBarraMenu.TabIndex = 1;
            this.toolStripBarraMenu.Text = "toolStrip1";
            // 
            // toolStripLabelABM
            // 
            this.toolStripLabelABM.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripLabelABM.Name = "toolStripLabelABM";
            this.toolStripLabelABM.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabelABM.Text = "Roles";
            this.toolStripLabelABM.ToolTipText = "ABM Roles";
            this.toolStripLabelABM.Click += new System.EventHandler(this.toolStripLabel2_Click_1);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabelRecorrido
            // 
            this.toolStripLabelRecorrido.Name = "toolStripLabelRecorrido";
            this.toolStripLabelRecorrido.Size = new System.Drawing.Size(58, 22);
            this.toolStripLabelRecorrido.Text = "Recorrido";
            this.toolStripLabelRecorrido.Click += new System.EventHandler(this.toolStripLabelRecorrido_Click);
            // 
            // toolABMRolesLabel2
            // 
            this.toolABMRolesLabel2.Name = "toolABMRolesLabel2";
            this.toolABMRolesLabel2.Size = new System.Drawing.Size(23, 23);
            // 
            // MenuPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 387);
            this.Controls.Add(this.toolStripBarraMenu);
            this.Name = "MenuPrincipalForm";
            this.Text = "MenuPrincipal Crucero";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStripBarraMenu.ResumeLayout(false);
            this.toolStripBarraMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStrip toolStripBarraMenu;
        private System.Windows.Forms.ToolStripLabel toolStripLabelABM;
        private System.Windows.Forms.ToolStripLabel toolABMRolesLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabelRecorrido;
    }
}

