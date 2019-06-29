using FrbaCrucero.Modelos;
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

namespace FrbaCrucero.CompraReservaPasaje
{
    public partial class CompletarDatosCliente : Form
    {
        CrearPasaje pasaje;
        Int32 idCliente;
        public CompletarDatosCliente(CrearPasaje pasaje)
        {
            InitializeComponent();
            this.pasaje = pasaje;
            textBoxNombre.ReadOnly = true;
            textBoxApellido.ReadOnly = true;
            textBoxDireccion.ReadOnly = true;
            textBoxTelefono.ReadOnly = true;
            textBoxFechaNacimiento.ReadOnly = true;
            textBoxMail.ReadOnly = true;
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            this.habilitarEdicion();
        }

        private void habilitarEdicion()
        {
            textBoxNombre.ReadOnly = false;
            textBoxApellido.ReadOnly = false;
            textBoxDireccion.ReadOnly = false;
            textBoxTelefono.ReadOnly = false;
            textBoxFechaNacimiento.ReadOnly = false;
            textBoxMail.ReadOnly = false;
        }

        private void limpiarDatos()
        {
            textBoxNombre.Text = null;
            textBoxApellido.Text = null;
            textBoxDireccion.Text = null;
            textBoxTelefono.Text = null;
            textBoxFechaNacimiento.Text = null;
            textBoxMail.Text = null;
        }

        private bool todosSonNulos(List<object> parametros)
        {
            return parametros.All(valor => String.IsNullOrEmpty(valor.ToString()));
        }

        private void buttonVerificar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(textBoxDNI.Text))
            {
                Int32 dniCliente = Int32.Parse(textBoxDNI.Text);
                List<object> datosDelCliente = this.datosCliente(dniCliente);
                this.idCliente = Int32.Parse(datosDelCliente[0].ToString());

                if (!this.todosSonNulos(datosDelCliente))
                {
                    textBoxNombre.Text = datosDelCliente[1].ToString();
                    textBoxApellido.Text = datosDelCliente[2].ToString();
                    textBoxDireccion.Text = datosDelCliente[3].ToString();
                    textBoxTelefono.Text = datosDelCliente[4].ToString();
                    textBoxFechaNacimiento.Text = datosDelCliente[5].ToString();
                    textBoxMail.Text = datosDelCliente[6].ToString();
                }
                else
                {
                    MessageBox.Show("El DNI ingresado no existe en la base de datos, ingrese sus datos para registrarse", "Error",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.habilitarEdicion();
                    this.limpiarDatos();
                }
            }
            else
            {
                MessageBox.Show("El DNI ingresado no es valido, intente nuevamente", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          
        }

        private void agregarParametroOutput(SqlCommand command, String parametroOutput, SqlDbType tipo)
        {
            if (tipo != SqlDbType.VarChar)
            {
                command.Parameters.Add(parametroOutput, tipo).Direction = ParameterDirection.Output;
            }
            else
            {
                command.Parameters.Add(parametroOutput, tipo, 255).Direction = ParameterDirection.Output;
            }
            
        }

        private List<object> datosCliente(Int32 dniCliente)
        {
            String sqlQuery = "FGNN_19.Datos_cliente";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("dni", dniCliente));
            this.agregarParametroOutput(cmd, "@id", SqlDbType.Int);
            this.agregarParametroOutput(cmd, "@nombre", SqlDbType.VarChar);
            this.agregarParametroOutput(cmd, "@apellido", SqlDbType.VarChar);
            this.agregarParametroOutput(cmd, "@direccion", SqlDbType.VarChar);
            this.agregarParametroOutput(cmd, "@telefono", SqlDbType.Int);
            this.agregarParametroOutput(cmd, "@fecha_nac", SqlDbType.DateTime2);
            this.agregarParametroOutput(cmd, "@mail", SqlDbType.VarChar);
            List<String> parametros = new List<String>();
            this.agregarParametros(parametros);
            List<object> listDatosCliente = ConexionDB.instancia.ejecutarStoredProcedureConOutputs(cmd, parametros);
            return listDatosCliente;
        }

        private void agregarParametros(List<String> parametros)
        {
            parametros.Add("@id");
            parametros.Add("@nombre");
            parametros.Add("@apellido");
            parametros.Add("@direccion");
            parametros.Add("@telefono");
            parametros.Add("@fecha_nac");
            parametros.Add("@mail");
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            this.limpiarDatos();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {

        }


    }
}
