using FrbaCrucero.Modelos;
using FrbaCrucero.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        private void buttonPagar_Click(object sender, EventArgs e)
        {
            String metodoDePagoDesc = comboBoxMetodoDePago.Text;
            Int32 cuotas = metodoDePagoDesc == "Tarjeta de crédito" ? Decimal.ToInt32(numericUpDownCuotas.Value) : 0;
            Int32 idMetodoPago = this.obtenerIDMetodoPago(comboBoxMetodoDePago.Text);
            Int32 idCompra = new CrearCompra(idMetodoPago, cuotas).Crear();

            Dictionary<string, object> paramametrosAModificar = new Dictionary<string, object>();
            paramametrosAModificar.Add("compra_codigo", idCompra);
            
            pasajes.ForEach(pasaje => RepoPasaje.instancia.Modificar(pasaje.id, paramametrosAModificar));

            MessageBox.Show("Se pago la reserva de forma exitosa.", "Exito",
            MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private Int32 obtenerIDMetodoPago(String descripcion)
        {
            String parametroOutput = "id";
            SqlCommand cmdInsertar = new SqlCommand("FGNN_19.Obtener_id_metodo_pago");
            cmdInsertar.CommandType = CommandType.StoredProcedure;
            cmdInsertar.Parameters.Add(new SqlParameter("descripcion", descripcion));
            cmdInsertar.Parameters.Add(parametroOutput, SqlDbType.Decimal).Direction = ParameterDirection.Output;
            return ConexionDB.instancia.ejecutarStoredProcedureConOutput(cmdInsertar, parametroOutput);
        }
    }
}
