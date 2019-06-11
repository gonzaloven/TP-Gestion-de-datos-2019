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

namespace FrbaCrucero.GeneracionViaje
{
    public partial class SeleccionarCrucero : Form
    {
        public SeleccionarCrucero()
        {
            InitializeComponent();
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxFiltroCrucero.Text = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string valorDescripcion = (!String.IsNullOrEmpty(textBoxFiltroCrucero.Text)) ? textBoxFiltroCrucero.Text.Trim() : "";
            string textHabilitado = Convert.ToString(comboBoxHabilitado.SelectedItem);
            Boolean hayValorHabilitado = false;
            Int16 valorHabilitado = 0;

            if (!String.IsNullOrWhiteSpace(textHabilitado))
            {
                hayValorHabilitado = true;
                valorHabilitado = (textHabilitado.Equals("Si")) ? (Int16)1 : (Int16)0;
            }

            List<Crucero> cruceros = RepoCrucero.instancia.EncontrarPorDescripcionYHabilitado(valorDescripcion, valorHabilitado, hayValorHabilitado);
            dataGridViewCruceros.DataSource = cruceros;
            dataGridViewCruceros.Columns["id"].Visible = false;
            dataGridViewCruceros.MultiSelect = false;
        }

    }
}
