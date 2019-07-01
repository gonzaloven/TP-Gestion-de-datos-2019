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
    public partial class SeleccionarMetodoPagoReservaForm : Form
    {
        private List<Pasaje> pasajes;
        private Double totalAPagar;

        public SeleccionarMetodoPagoReservaForm(List<Pasaje> pasajes, Double totalAPagar)
        {
            InitializeComponent();
            this.pasajes = pasajes;
            this.totalAPagar = totalAPagar;
            labelTotalAPagarInfo.Text = "$ " + totalAPagar.ToString();
            numericUpDownCuotas.Value = 1;
            comboBoxMetodoDePago.SelectedIndex = 0;
        }

        private void comboBoxMetodoDePago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMetodoDePago.Text != "Tarjeta de crédito")
            {
                numericUpDownCuotas.ReadOnly = true;
                labelCuotas.Visible = false;
                numericUpDownCuotas.Visible = false;
            }
            else
            {
                labelCuotas.Visible = true;
                numericUpDownCuotas.Visible = true;
                numericUpDownCuotas.ReadOnly = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string metodoPagoDesc = comboBoxMetodoDePago.Text;
            int cuotas = Convert.ToInt32(numericUpDownCuotas.Value);

            Int32 idMetodoPago = new CrearMetodoDePago(metodoPagoDesc, cuotas).Crear();
            Int32 idCompra = new CrearCompra(idMetodoPago).Crear();

            Dictionary<string, object> paramametrosAModificar = new Dictionary<string, object>();
            paramametrosAModificar.Add("compra_codigo", idCompra);
            
            pasajes.ForEach(pasaje => RepoPasaje.instancia.Modificar(pasaje.id, paramametrosAModificar));

            MessageBox.Show("Se pago la reserva de forma exitosa.", "Exito",
            MessageBoxButtons.OK, MessageBoxIcon.None);
        }
    }
}
