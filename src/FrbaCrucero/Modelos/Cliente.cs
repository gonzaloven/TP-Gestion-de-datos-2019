using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.Modelos
{
    class Cliente
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public Int32 dni { get; set; }
        public string direccion { get; set; }
        public Int32 telefono { get; set; }
        public DateTime fecha_nac { get; set; }
        public string mail { get; set; }

        public Cliente(string nombre, string apellido, Int32 dni, string direccion, Int32 telefono, DateTime fecha_nac, string mail)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.direccion = direccion;
            this.telefono = telefono;
            this.fecha_nac = fecha_nac;
            this.mail = mail;
        }

        public Int32 Crear()
        {
            this.crearCliente();
            Int32 idCliente = this.idCreado();
            return idCliente;
        }

        public void Modificar(Int32 idCliente)
        {
            this.modificarCliente(idCliente);
        }

        private void modificarCliente(Int32 idCliente)
        {
            String sqlQuery = "UPDATE FGNN_19.Clientes SET nombre = @nombre, "
                            + "apellido = @apellido, direccion = @direccion, "
                            + "telefono = @telefono, fecha_nac = @fecha_nac, mail = @mail "
                            + "WHERE id = @idCliente";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            cmd.Parameters.Add(new SqlParameter("nombre", this.nombre));
            cmd.Parameters.Add(new SqlParameter("apellido", this.apellido));
            cmd.Parameters.Add(new SqlParameter("direccion", this.direccion));
            cmd.Parameters.Add(new SqlParameter("telefono", this.telefono));
            cmd.Parameters.Add(new SqlParameter("fecha_nac", this.fecha_nac));
            cmd.Parameters.Add(new SqlParameter("mail", this.mail));
            cmd.Parameters.Add(new SqlParameter("idCliente", idCliente));
            ConexionDB.instancia.ejecutarQuery(cmd);
        }

        private void crearCliente()
        {
            String sqlQuery = "INSERT INTO FGNN_19.Clientes (nombre, apellido, dni, direccion, telefono, fecha_nac, mail) "
                            + "VALUES(@nombre,@apellido,@dni,@direccion,@telefono,@fecha_nac,@mail)";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            cmd.Parameters.Add(new SqlParameter("nombre", this.nombre));
            cmd.Parameters.Add(new SqlParameter("apellido", this.apellido));
            cmd.Parameters.Add(new SqlParameter("direccion", this.direccion));
            cmd.Parameters.Add(new SqlParameter("telefono", this.telefono));
            cmd.Parameters.Add(new SqlParameter("fecha_nac", this.fecha_nac));
            cmd.Parameters.Add(new SqlParameter("mail", this.mail));
            cmd.Parameters.Add(new SqlParameter("dni", this.dni));
            ConexionDB.instancia.ejecutarQuery(cmd);
        }


        private Int32 idCreado()
        {
            String sqlQuery = "SELECT IDENT_CURRENT ('FGNN_19.Clientes')";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            DataTable resultado = ConexionDB.instancia.obtenerData(cmd);
            return Int32.Parse(resultado.Rows[0][0].ToString());
        }
    }
}
