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
    public partial class SeleccionarMetodoDePago : Form
    {
        CrearPasaje pasaje;

        public SeleccionarMetodoDePago(CrearPasaje pasaje)
        {
            InitializeComponent();
            this.pasaje = pasaje;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            String metodoDePagoDesc = comboBoxMetodoDePago.Text;
            Int32 cuotas = Decimal.ToInt32(numericUpDownCuotas.Value);
            Int32 idMetodoPago = new CrearMetodoDePago(metodoDePagoDesc, cuotas).Crear();
            pasaje.compra_codigo = new CrearCompra(idMetodoPago).Crear();
            this.Close();
        }
    }
}
