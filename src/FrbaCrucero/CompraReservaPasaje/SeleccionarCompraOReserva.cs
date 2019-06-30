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
            SeleccionarMetodoDePago seleccionarMetodoDePago = new SeleccionarMetodoDePago(pasaje);
            seleccionarMetodoDePago.Show();
            this.Close();
        }
    }
}
