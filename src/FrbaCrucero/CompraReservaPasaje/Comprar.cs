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
using System.Data.SqlClient;

namespace FrbaCrucero.CompraReservaPasaje
{
    public partial class Comprar : Form
    {
        CrearPasaje pasaje;

        public Comprar(CrearPasaje pasaje)
        {
            InitializeComponent();
            this.pasaje = pasaje;
            this.textBoxPrecio.Text = (pasaje.pasajeros * this.precioPasaje()).ToString();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            String metodoDePagoDesc = comboBoxMetodoDePago.Text;
            Int32 cuotas = metodoDePagoDesc == "Tarjeta de crédito" ? Decimal.ToInt32(numericUpDownCuotas.Value) : 0;
            Int32 idMetodoPago = new CrearMetodoDePago(metodoDePagoDesc, cuotas).Crear();
            Int32 idCompra = new CrearCompra(idMetodoPago).Crear();
            while (pasaje.pasajeros > 0)
            {
                new CrearPasaje(null, pasaje.cliente_id, idCompra, pasaje.viaje_codigo, pasaje.cabina_id).Crear();
                pasaje.pasajeros--;
            }

            MessageBox.Show("La compra del pasaje resulto exitosa.", "Exito",
                                MessageBoxButtons.OK, MessageBoxIcon.None);
            this.Close();
        }

        private void comboBoxMetodoDePago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMetodoDePago.Text != "Tarjeta de crédito")
            {
                numericUpDownCuotas.Visible = false;
            }
            else
            {
                numericUpDownCuotas.Visible = true;
            }
        }

        private Double precioPasaje()
        {
            String parametroOutput = "precio_final";
            SqlCommand cmdInsertar = new SqlCommand("FGNN_19.Calcular_costo_pasaje");
            cmdInsertar.CommandType = CommandType.StoredProcedure;
            cmdInsertar.Parameters.Add(new SqlParameter("idViaje", pasaje.viaje_codigo));
            cmdInsertar.Parameters.Add(new SqlParameter("idCabina", pasaje.cabina_id));
            cmdInsertar.Parameters.Add(parametroOutput, SqlDbType.Decimal).Direction = ParameterDirection.Output;
            return ConexionDB.instancia.ejecutarStoredProcedureConOutput(cmdInsertar, parametroOutput);
        }
    }
}
