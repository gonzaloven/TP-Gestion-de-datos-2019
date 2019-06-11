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
        public ListadoRecorridoForm()
        {
            InitializeComponent();
            textBoxPuertDesde.ReadOnly = true;
            textBoxPuertoHasta.ReadOnly = true;
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxPuertDesde.Text = null;
            textBoxPuertoHasta.Text = null;
            comboBoxHabilitado.Text = null;
        }

        private void buttonSeleccionarDesde_Click(object sender, EventArgs e)
        {
            SeleccionarPuerto seleccionarPuerto = new SeleccionarPuerto();
            seleccionarPuerto.Show();
        }


    }
}
