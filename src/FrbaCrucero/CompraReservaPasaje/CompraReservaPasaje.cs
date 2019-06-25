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

namespace FrbaCrucero.CompraPasaje
{
    public partial class CompraReservaPasaje : Form
    {
        public CompraReservaPasaje()
        {
            InitializeComponent();
            this.textBoxFechaInicio.ReadOnly = true;
            this.textBoxFechaFin.ReadOnly = true;
            this.textBoxPuertoDestino.ReadOnly = true;
            this.textBoxPuertoOrigen.ReadOnly = true;
        }

        private void buttonSeleccionarFechaInicio_Click(object sender, EventArgs e)
        {
            SeleccionarFecha seleccionarFecha = new SeleccionarFecha(textBoxFechaInicio);
            seleccionarFecha.Show();
        }

        private void buttonSeleccionarFechaFin_Click(object sender, EventArgs e)
        {
            SeleccionarFecha seleccionarFecha = new SeleccionarFecha(textBoxFechaFin);
            seleccionarFecha.Show();
        }

        private void buttonSeleccionarPuertoOrigen_Click(object sender, EventArgs e)
        {
            SeleccionarPuerto seleccionarPuerto = new SeleccionarPuerto(textBoxPuertoOrigen);
            seleccionarPuerto.Show();
        }

        private void buttonSeleccionarPuertoDestino_Click(object sender, EventArgs e)
        {
            SeleccionarPuerto seleccionarPuerto = new SeleccionarPuerto(textBoxPuertoDestino);
            seleccionarPuerto.Show();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        public void Buscar()
        {
            string valorPuertoDesde = textBoxPuertoOrigen.Text;
            string valorPuertoHasta = textBoxPuertoDestino.Text;
            string fechaInicio = textBoxFechaInicio.Text;
            string fechaFin = textBoxFechaFin.Text;

            List<Viaje> viajes = RepoViaje.instancia
                                          .EncontrarPorParametros(valorPuertoDesde, valorPuertoHasta, fechaInicio, fechaFin);
            dataGridViewViajes.DataSource = viajes;
            dataGridViewViajes.MultiSelect = false;
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            this.textBoxFechaInicio.Text = null;
            this.textBoxFechaFin.Text = null;
            this.textBoxPuertoOrigen.Text = null;
            this.textBoxPuertoDestino.Text = null;
        }
    }
}
