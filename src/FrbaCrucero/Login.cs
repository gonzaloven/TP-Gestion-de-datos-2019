﻿using FrbaCrucero.Modelos;
using FrbaCrucero.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void buttonIngresarCliente_Click(object sender, EventArgs e)
        {
            MenuPrincipalForm menuPrincipalForm = new MenuPrincipalForm();
            menuPrincipalForm.Show();
        }

        private void buttonIngresarAdm_Click(object sender, EventArgs e)
        {
            string valorUsuario = textBoxAdmUsario.Text;
            string valorPassword = textBoxAdmPassword.Text;
            bool errorLogin = false;

            StringBuilder descripcion = new StringBuilder();

            if(String.IsNullOrEmpty(valorUsuario) || String.IsNullOrWhiteSpace(valorUsuario) 
                || String.IsNullOrEmpty(valorPassword) || String.IsNullOrEmpty(valorPassword))  
            {
                descripcion.Append("Usuario o password incorrecto\n");
                errorLogin = true;
            } else {
                Usuario usuario = RepoUsuario.instancia.EncontrarPorUserName(valorUsuario);
            }
          
            if(errorLogin)
            {
                DialogResult dr = MessageBox.Show(
                descripcion.ToString(), 
                "Validacion", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Error);
            } else {
                MenuPrincipalForm menuPrincipalForm = new MenuPrincipalForm();
                menuPrincipalForm.Show();
            }

        }
    }
}
