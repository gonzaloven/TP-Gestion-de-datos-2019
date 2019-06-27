namespace FrbaCrucero
{
    partial class Login
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
            this.tabControlLogin = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonIngresarCliente = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBoxAdmPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxAdmUsario = new System.Windows.Forms.TextBox();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.buttonIngresarAdm = new System.Windows.Forms.Button();
            this.labelTituloIngreso = new System.Windows.Forms.Label();
            this.tabControlLogin.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlLogin
            // 
            this.tabControlLogin.Controls.Add(this.tabPage1);
            this.tabControlLogin.Controls.Add(this.tabPage2);
            this.tabControlLogin.Location = new System.Drawing.Point(12, 98);
            this.tabControlLogin.Multiline = true;
            this.tabControlLogin.Name = "tabControlLogin";
            this.tabControlLogin.SelectedIndex = 0;
            this.tabControlLogin.Size = new System.Drawing.Size(267, 274);
            this.tabControlLogin.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonIngresarCliente);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(259, 248);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cliente";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonIngresarCliente
            // 
            this.buttonIngresarCliente.Location = new System.Drawing.Point(85, 111);
            this.buttonIngresarCliente.Name = "buttonIngresarCliente";
            this.buttonIngresarCliente.Size = new System.Drawing.Size(75, 23);
            this.buttonIngresarCliente.TabIndex = 0;
            this.buttonIngresarCliente.Text = "Ingresa";
            this.buttonIngresarCliente.UseVisualStyleBackColor = true;
            this.buttonIngresarCliente.Click += new System.EventHandler(this.buttonIngresarCliente_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBoxAdmPassword);
            this.tabPage2.Controls.Add(this.labelPassword);
            this.tabPage2.Controls.Add(this.textBoxAdmUsario);
            this.tabPage2.Controls.Add(this.labelUsuario);
            this.tabPage2.Controls.Add(this.buttonIngresarAdm);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(259, 248);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Administrador";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBoxAdmPassword
            // 
            this.textBoxAdmPassword.AcceptsTab = true;
            this.textBoxAdmPassword.Location = new System.Drawing.Point(9, 85);
            this.textBoxAdmPassword.Name = "textBoxAdmPassword";
            this.textBoxAdmPassword.Size = new System.Drawing.Size(204, 20);
            this.textBoxAdmPassword.TabIndex = 4;
            this.textBoxAdmPassword.UseSystemPasswordChar = true;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(6, 69);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(53, 13);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password";
            // 
            // textBoxAdmUsario
            // 
            this.textBoxAdmUsario.AcceptsTab = true;
            this.textBoxAdmUsario.Location = new System.Drawing.Point(9, 26);
            this.textBoxAdmUsario.Name = "textBoxAdmUsario";
            this.textBoxAdmUsario.Size = new System.Drawing.Size(204, 20);
            this.textBoxAdmUsario.TabIndex = 2;
            this.textBoxAdmUsario.Tag = "";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(6, 10);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(43, 13);
            this.labelUsuario.TabIndex = 1;
            this.labelUsuario.Text = "Usuario";
            // 
            // buttonIngresarAdm
            // 
            this.buttonIngresarAdm.Location = new System.Drawing.Point(80, 207);
            this.buttonIngresarAdm.Name = "buttonIngresarAdm";
            this.buttonIngresarAdm.Size = new System.Drawing.Size(75, 23);
            this.buttonIngresarAdm.TabIndex = 0;
            this.buttonIngresarAdm.Text = "Ingresar";
            this.buttonIngresarAdm.UseVisualStyleBackColor = true;
            this.buttonIngresarAdm.Click += new System.EventHandler(this.buttonIngresarAdm_Click);
            // 
            // labelTituloIngreso
            // 
            this.labelTituloIngreso.AutoSize = true;
            this.labelTituloIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloIngreso.Location = new System.Drawing.Point(53, 37);
            this.labelTituloIngreso.Name = "labelTituloIngreso";
            this.labelTituloIngreso.Size = new System.Drawing.Size(178, 24);
            this.labelTituloIngreso.TabIndex = 1;
            this.labelTituloIngreso.Text = "Ingresar en Crucero";
            this.labelTituloIngreso.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 384);
            this.Controls.Add(this.labelTituloIngreso);
            this.Controls.Add(this.tabControlLogin);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.tabControlLogin.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlLogin;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonIngresarCliente;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBoxAdmPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxAdmUsario;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Button buttonIngresarAdm;
        private System.Windows.Forms.Label labelTituloIngreso;
    }
}