using FrbaCrucero.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.CompraReservaPasaje
{
    public partial class SeleccionarCompraOReserva : Form
    {
        CrearPasaje pasaje;
        public SeleccionarCompraOReserva(CrearPasaje pasaje)
        {
            InitializeComponent();
            this.pasaje = pasaje;
        }

        private void buttonComprar_Click(object sender, EventArgs e)
        {
            Comprar compra = new Comprar(pasaje);
            compra.Show();
            this.Close();
        }

        private void buttonReservar_Click(object sender, EventArgs e)
        {

        }
    }
}
