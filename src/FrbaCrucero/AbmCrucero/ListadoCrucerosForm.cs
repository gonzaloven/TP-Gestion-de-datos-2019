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

namespace FrbaCrucero.AbmCrucero
{
    public partial class ListadoCrucerosForm : Form
    {
        public ListadoCrucerosForm()
        {
            InitializeComponent();
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            limpiarFiltros();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            string valorDescripcion = (!String.IsNullOrEmpty(textBoxCrucero.Text)) ? textBoxCrucero.Text.Trim() : "";
            string textEstado = Convert.ToString(comboBoxEstado.SelectedItem);
            Int16 valorFueraServicio = -1;
            string textModelo = null;
            string textServicio = Convert.ToString(comboBoxServicio.SelectedItem);

            if(textEstado.Equals("En servicio"))
                valorFueraServicio = (Int16)0;
            if(textEstado.Equals("Fuera de servicio"))
                valorFueraServicio = (Int16)1;

            if (!String.IsNullOrWhiteSpace(textBoxModelo.Text))
                textModelo = textBoxModelo.Text.Trim();

            List<Crucero> cruceros = RepoCrucero.instancia.EncontrarCruceroNombreEstadoModeloServicio(valorDescripcion, valorFueraServicio, textModelo, textServicio);
            dataGridViewCrucero.DataSource = cruceros;
            dataGridViewCrucero.Columns["id"].Visible = false;
            dataGridViewCrucero.Columns["fabricante_id"].Visible = false;
            dataGridViewCrucero.Columns["habilitado"].Visible = false;
            dataGridViewCrucero.Columns["fecha_alta"].Visible = false;
            dataGridViewCrucero.Columns["baja_servicio"].Visible = false;
            dataGridViewCrucero.Columns["baja_vida_util"].Visible = false;
            dataGridViewCrucero.Columns["fecha_baja_definitiva"].Visible = false;
            dataGridViewCrucero.Columns["fecha_fuera_servicio"].Visible = false;
            dataGridViewCrucero.MultiSelect = false;

        }

        private void limpiarFiltros()
        {
            textBoxCrucero.Clear();
            comboBoxEstado.SelectedIndex = comboBoxEstado.FindStringExact("");
        }
    }
}
