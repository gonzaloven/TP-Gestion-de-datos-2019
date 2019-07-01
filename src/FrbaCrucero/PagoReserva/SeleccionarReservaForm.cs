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

namespace FrbaCrucero.PagoReserva
{
    public partial class SeleccionarReservaForm : Form
    {
        public SeleccionarReservaForm()
        {
            InitializeComponent();
        }

        private void buttonSeleccionar_Click(object sender, EventArgs e)
        {
            Int32 codigo = Convert.ToInt32(numericUpDownCodigo.Value);

            ReservaForm reserva = RepoReserva.instancia.EncontrarPorCodigoConPasajeNoComprado(codigo);
            if (reserva == null)
            {
                string texto = "No se encontró una reserva pagar con ese codigo";
                DialogResult dr = MessageBox.Show(
                    texto,
                    "Reserva no encontrada",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Information);
            }
            else 
            {
                List<Pasaje> pasajes = RepoPasaje.instancia.EncontrarPorCodigoReserva(reserva.codigo); 
                SeleccionarMetodoPagoReservaForm metodoPagoReserva = new SeleccionarMetodoPagoReservaForm(reserva);
                metodoPagoReserva.Show();
            }
        }
    }
}
