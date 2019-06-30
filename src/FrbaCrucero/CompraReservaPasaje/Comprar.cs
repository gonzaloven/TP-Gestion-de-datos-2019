using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaCrucero.Modelos;

namespace FrbaCrucero.CompraReservaPasaje
{
    public partial class Comprar : Form
    {
        CrearPasaje pasaje;

        public Comprar(CrearPasaje pasaje)
        {
            InitializeComponent();
            this.pasaje = pasaje;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            String metodoDePagoDesc = comboBoxMetodoDePago.Text;
            Int32 cuotas = Decimal.ToInt32(numericUpDownCuotas.Value);
            Int32 idMetodoPago = new CrearMetodoDePago(metodoDePagoDesc, cuotas).Crear();
            Int32 idCompra = new CrearCompra(idMetodoPago).Crear();
            new CrearPasaje(null, pasaje.cliente_id, idCompra, pasaje.viaje_codigo, pasaje.cabina_id).Crear();

            MessageBox.Show("La compra del pasaje resulto exitosa.", "Exito",
                                MessageBoxButtons.OK, MessageBoxIcon.None);
            this.Close();
        }

        private void comboBoxMetodoDePago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMetodoDePago.Text != "Tarjeta de crédito")
                numericUpDownCuotas.ReadOnly = true;
            else
                numericUpDownCuotas.ReadOnly = false;
        }
    }
}
