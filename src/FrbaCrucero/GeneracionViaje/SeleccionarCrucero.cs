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
        FormGenerarViaje form;
        TextBox textBoxParam;

        public SeleccionarCrucero(FormGenerarViaje form, TextBox textBoxParam)
        {
            InitializeComponent();
            this.form = form;
            this.textBoxParam = textBoxParam;
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxFiltroCrucero.Text = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string valorDescripcion = (!String.IsNullOrEmpty(textBoxFiltroCrucero.Text)) ? textBoxFiltroCrucero.Text.Trim() : "";

            List<Crucero> cruceros = RepoCrucero.instancia.EncontrarCruceroNombre(valorDescripcion);
            dataGridViewCruceros.DataSource = cruceros;
            dataGridViewCruceros.Columns["id"].Visible = false;
            dataGridViewCruceros.Columns["fabricante_id"].Visible = false;
            dataGridViewCruceros.Columns["habilitado"].Visible = false;
            dataGridViewCruceros.Columns["fecha_alta"].Visible = false;
            dataGridViewCruceros.Columns["baja_servicio"].Visible = false;
            dataGridViewCruceros.Columns["baja_vida_util"].Visible = false;
            dataGridViewCruceros.Columns["fecha_baja_definitiva"].Visible = false;
            dataGridViewCruceros.Columns["fecha_fuera_servicio"].Visible = false;

            this.dataGridViewCrucero.Columns["nombre"].HeaderText = "Nombre";
            this.dataGridViewCrucero.Columns["modelo"].HeaderText = "Modelo";
            this.dataGridViewCrucero.Columns["tipo_servicio"].HeaderText = "Tipo de servicio";
            this.dataGridViewCrucero.Columns["fecha_reinicio_servicio"].HeaderText = "Fecha reinicio servicio";
            this.dataGridViewCrucero.Columns["cant_cabinas"].HeaderText = "Cantidad de cabinas";
            dataGridViewCruceros.MultiSelect = false;
        }

        private void dataGridViewCruceros_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 0)
                form.textBoxParam.Text = dataGridViewCruceros[2, e.RowIndex].Value.ToString();
        }
    }
}
