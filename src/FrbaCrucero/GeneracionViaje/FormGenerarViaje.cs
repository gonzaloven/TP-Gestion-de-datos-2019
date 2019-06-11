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
    public partial class FormGenerarViaje : Form
    {
        public FormGenerarViaje()
        {
            InitializeComponent();
            textBoxCrucero.ReadOnly = true;
            textBoxPuertoDesde.ReadOnly = true;
            textBoxPuertoHasta.ReadOnly = true;
            textBoxFechaInicio.ReadOnly = true;
            textBoxFechaFin.ReadOnly = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonSeleccionarCrucero_Click(object sender, EventArgs e)
        {
            SeleccionarCrucero seleccionarCrucero = new SeleccionarCrucero();
            seleccionarCrucero.Show();
        }

        private void buttonSeleccionarPuertoDesde_Click(object sender, EventArgs e)
        {
            SeleccionarPuerto seleccionarPuerto = new SeleccionarPuerto();
            seleccionarPuerto.Show();
        }

        private void buttonSeleccionarPuertoHasta_Click(object sender, EventArgs e)
        {
            SeleccionarPuerto seleccionarPuerto = new SeleccionarPuerto();
            seleccionarPuerto.Show();
        }

        private void buttonSeleccionarFechaInicio_Click(object sender, EventArgs e)
        {
            SeleccionarFecha seleccionarFecha = new SeleccionarFecha();
            seleccionarFecha.Show();
        }

        private void buttonSeleccionarFechaFin_Click(object sender, EventArgs e)
        {
            SeleccionarFecha seleccionarFecha = new SeleccionarFecha();
            seleccionarFecha.Show();
        }
    }
}
