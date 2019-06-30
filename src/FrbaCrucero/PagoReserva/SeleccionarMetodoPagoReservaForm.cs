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

namespace FrbaCrucero.PagoReserva
{
    public partial class SeleccionarMetodoPagoReservaForm : Form
    {
        private Reserva reserva;

        public SeleccionarMetodoPagoReservaForm(Reserva reserva)
        {
            InitializeComponent();
            this.reserva = reserva;
            numericUpDownCuotas.TabIndex = 1;
           
        }

        private void comboBoxMetodoDePago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMetodoDePago.Text == "Efectivo")
            {
                numericUpDownCuotas.Enabled = false;
            }
            else
            {
                numericUpDownCuotas.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string descripcion = comboBoxMetodoDePago.Text;
            int cuotas = Convert.ToInt32(numericUpDownCuotas.Value);

            CrearMetodoDePago metodoPago = new CrearMetodoDePago(descripcion, cuotas);
            Int32 idMetodoPago = metodoPago.Crear();

            CrearCompra compra = new CrearCompra(idMetodoPago);
            Int32 idCompra = compra.Crear();
        }
    }
}
