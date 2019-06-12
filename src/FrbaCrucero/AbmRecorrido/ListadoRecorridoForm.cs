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

namespace FrbaCrucero.AbmRecorrido
{
    public partial class ListadoRecorridoForm : Form
    {
        public TextBox textBoxParam;
        public ListadoRecorridoForm()
        {
            InitializeComponent();
            textBoxPuertDesde.ReadOnly = true;
            textBoxPuertoHasta.ReadOnly = true;
            comboBoxHabilitado.SelectedIndex = 0;
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxPuertDesde.Text = null;
            textBoxPuertoHasta.Text = null;
            comboBoxHabilitado.Text = "Todos";
        }

        private void buttonSeleccionarDesde_Click(object sender, EventArgs e)
        {
            this.textBoxParam = textBoxPuertDesde;
            SeleccionarPuerto seleccionarPuerto = new SeleccionarPuerto(this, textBoxParam);
            seleccionarPuerto.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBoxParam = textBoxPuertoHasta;
            SeleccionarPuerto seleccionarPuerto = new SeleccionarPuerto(this, textBoxParam);
            seleccionarPuerto.Show();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            string valorPuertoDesde = (!String.IsNullOrEmpty(textBoxPuertDesde.Text)) ? textBoxPuertDesde.Text.Trim() : "";
            string valorPuertoHasta = (!String.IsNullOrEmpty(textBoxPuertoHasta.Text)) ? textBoxPuertoHasta.Text.Trim() : "";
            string textHabilitado = Convert.ToString(comboBoxHabilitado.SelectedItem);
            Boolean hayValorHabilitado = false;
            Int16 valorHabilitado = 0;

            if (!textHabilitado.Equals("Todos"))
            {
                hayValorHabilitado = true;
                valorHabilitado = (textHabilitado.Equals("Si")) ? (Int16)1 : (Int16)0;
            }

            List<Recorrido> recorridos = RepoRecorrido.instancia
                                                 .EncontrarPorParametros(valorPuertoDesde, valorPuertoHasta, valorHabilitado, hayValorHabilitado);
            dataGridViewRecorrido.DataSource = recorridos;
            dataGridViewRecorrido.Columns["id"].Visible = false;
            dataGridViewRecorrido.MultiSelect = false;
        }


    }
}
