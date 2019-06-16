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
            this.dataGridViewCruceros.DataSource = cruceros;
            this.dataGridViewCruceros.Columns["id"].Visible = false;
            this.dataGridViewCruceros.Columns["fabricante_id"].Visible = false;
            this.dataGridViewCruceros.Columns["habilitado"].Visible = false;
            this.dataGridViewCruceros.Columns["fecha_alta"].Visible = false;
            this.dataGridViewCruceros.Columns["baja_servicio"].Visible = false;
            this.dataGridViewCruceros.Columns["baja_vida_util"].Visible = false;
            this.dataGridViewCruceros.Columns["fecha_baja_definitiva"].Visible = false;
            this.dataGridViewCruceros.Columns["fecha_fuera_servicio"].Visible = false;

            this.dataGridViewCruceros.Columns["nombre"].HeaderText = "Nombre";
            this.dataGridViewCruceros.Columns["modelo"].HeaderText = "Modelo";
            this.dataGridViewCruceros.Columns["tipo_servicio"].HeaderText = "Tipo de servicio";
            this.dataGridViewCruceros.Columns["fecha_reinicio_servicio"].HeaderText = "Fecha reinicio servicio";
            this.dataGridViewCruceros.Columns["cant_cabinas"].HeaderText = "Cantidad de cabinas";
            this.dataGridViewCruceros.MultiSelect = false;
        }

        private void dataGridViewCruceros_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 0)
                form.textBoxParam.Text = dataGridViewCruceros[2, e.RowIndex].Value.ToString();
        }
    }
}
