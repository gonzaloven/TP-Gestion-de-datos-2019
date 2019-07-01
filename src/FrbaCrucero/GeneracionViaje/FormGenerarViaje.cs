using FrbaCrucero.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.GeneracionViaje
{
    public partial class FormGenerarViaje : Form
    {
        public TextBox textBoxParam;
        public FormGenerarViaje()
        {
            InitializeComponent();
            textBoxCrucero.ReadOnly = true;
            textBoxIDRecorrido.ReadOnly = true;
            textBoxFechaInicio.ReadOnly = true;
            textBoxFechaFin.ReadOnly = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {   
        }

        private void buttonSeleccionarCrucero_Click(object sender, EventArgs e)
        {
            ListadoCruceros listadoCruceros = new ListadoCruceros(this);
            listadoCruceros.Show();
        }

        private void buttonSeleccionarFechaInicio_Click(object sender, EventArgs e)
        {
            this.textBoxParam = textBoxFechaInicio;
            SeleccionarFecha seleccionarFecha = new SeleccionarFecha(this, textBoxParam);
            seleccionarFecha.MdiParent = this.MdiParent;
            seleccionarFecha.Show();
        }

        private void buttonSeleccionarFechaFin_Click(object sender, EventArgs e)
        {
            this.textBoxParam = textBoxFechaFin;
            SeleccionarFecha seleccionarFecha = new SeleccionarFecha(this, textBoxParam);
            seleccionarFecha.MdiParent = this.MdiParent;
            seleccionarFecha.Show();
        }

        private void buttonGenerarViaje_Click(object sender, EventArgs e)
        {
            Int32 idCrucero = Int32.Parse(textBoxCrucero.Text);
            Int32 idRecorrido = Int32.Parse(textBoxIDRecorrido.Text);
            DateTime fecha_inicio = Convert.ToDateTime(textBoxFechaInicio.Text);
            DateTime fecha_fin = Convert.ToDateTime(textBoxFechaFin.Text);
            CrearViaje crearViaje = new CrearViaje(idCrucero, idRecorrido, fecha_inicio, fecha_fin);
            crearViaje.Crear();
            MessageBox.Show("Se ha ingresado el viaje con exito.", "Exito",
                                MessageBoxButtons.OK, MessageBoxIcon.None);
            
        }

        private void buttonSeleccionarPuertoHasta_Click(object sender, EventArgs e)
        {
            ListadoRecorrido listadoRecorrido = new ListadoRecorrido(this);
            listadoRecorrido.Show();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxIDRecorrido.Text = null;
            textBoxCrucero.Text = null;
            textBoxFechaFin.Text = null;
            textBoxFechaInicio.Text = null;
        }
    }
}
