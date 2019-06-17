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
            string textModelo = textBoxModelo.Text.Trim();
            string textServicio = Convert.ToString(comboBoxServicio.SelectedItem);

            if(textEstado.Equals("En servicio"))
                valorFueraServicio = (Int16)0;
            if(textEstado.Equals("Fuera de servicio"))
                valorFueraServicio = (Int16)1;

            
            List<Crucero> cruceros = RepoCrucero.instancia.EncontrarCruceroNombreEstadoModeloServicio(valorDescripcion, valorFueraServicio, textModelo, textServicio);
            this.dataGridViewCrucero.DataSource = cruceros;
            this.dataGridViewCrucero.Columns["id"].Visible = false;
            this.dataGridViewCrucero.Columns["fabricante_id"].Visible = false;
            this.dataGridViewCrucero.Columns["habilitado"].Visible = false;
            this.dataGridViewCrucero.Columns["fecha_alta"].Visible = false;
            this.dataGridViewCrucero.Columns["baja_servicio"].Visible = false;
            this.dataGridViewCrucero.Columns["baja_vida_util"].Visible = false;
            this.dataGridViewCrucero.Columns["fecha_baja_definitiva"].Visible = false;
            this.dataGridViewCrucero.Columns["fecha_fuera_servicio"].Visible = false;

            this.dataGridViewCrucero.Columns["nombre"].HeaderText = "Nombre";
            this.dataGridViewCrucero.Columns["modelo"].HeaderText = "Modelo";
            this.dataGridViewCrucero.Columns["tipo_servicio"].HeaderText = "Tipo de servicio";
            this.dataGridViewCrucero.Columns["fecha_reinicio_servicio"].HeaderText = "Fecha reinicio servicio";
            this.dataGridViewCrucero.Columns["cant_cabinas"].HeaderText = "Cantidad de cabinas";
            dataGridViewCrucero.MultiSelect = false;

        }

        private void limpiarFiltros()
        {
            textBoxCrucero.Clear();
            comboBoxEstado.SelectedIndex = comboBoxEstado.FindStringExact("");
        }

        private void dataGridViewCrucero_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                ModificarCrucero modificarCrucero = new ModificarCrucero();
                modificarCrucero.Show();
            }
            else
            {
                EliminarCrucero eliminarCrucero = new EliminarCrucero();
                eliminarCrucero.Show();
            }
        }
    }
}
