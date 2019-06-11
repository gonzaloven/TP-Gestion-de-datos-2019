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
    public partial class SeleccionarPuerto : Form
    {
        public SeleccionarPuerto()
        {
            InitializeComponent();
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxPuerto.Text = null;
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            string descripcionPuerto = textBoxPuerto.Text;
            List<Puerto> puertos = RepoPuerto.instancia.EncontrarPorDescripcionPuerto(descripcionPuerto);
            dataGridViewPuertos.DataSource = puertos;
        }

    }
}
