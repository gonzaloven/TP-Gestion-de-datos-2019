using FrbaCrucero.Modelos;
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

namespace FrbaCrucero.AbmRol
{
    public partial class ListadoDeRoles : Form
    {
        public ListadoDeRoles()
        {
            InitializeComponent();
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxRol.Clear();
            comboBoxHabilitado.SelectedIndex = comboBoxHabilitado.FindStringExact("");
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            string valorDescripcion = (!String.IsNullOrEmpty(textBoxRol.Text)) ? textBoxRol.Text.Trim() : "";
            string textHabilitado = Convert.ToString(comboBoxHabilitado.SelectedItem);
            Boolean hayValorHabilitado = false;
            Int16 valorHabilitado = 0;

            if(!String.IsNullOrWhiteSpace(textHabilitado))
            {
                hayValorHabilitado = true;
                valorHabilitado = (textHabilitado.Equals("Si")) ? (Int16) 1 : (Int16) 0;
            }

            List<Rol> roles = RepoRol.instancia.EncontrarPorDescripcionYHabilitado(valorDescripcion, valorHabilitado, hayValorHabilitado);
            dataGridViewRoles.DataSource = roles;
        }
    }
}
