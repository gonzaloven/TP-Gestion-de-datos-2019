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
        public TextBox textBoxParam;
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
            this.textBoxParam = textBoxCrucero;
            SeleccionarCrucero seleccionarCrucero = new SeleccionarCrucero(this, textBoxParam);
            seleccionarCrucero.Show();
        }

        private void buttonSeleccionarPuertoDesde_Click(object sender, EventArgs e)
        {
            this.textBoxParam = textBoxPuertoDesde;
            SeleccionarPuerto seleccionarPuerto = new SeleccionarPuerto(this, textBoxParam);
            seleccionarPuerto.Show();
        }

        private void buttonSeleccionarPuertoHasta_Click(object sender, EventArgs e)
        {
            this.textBoxParam = textBoxPuertoHasta;
            SeleccionarPuerto seleccionarPuerto = new SeleccionarPuerto(this, textBoxParam);
            seleccionarPuerto.Show();
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
    }
}
