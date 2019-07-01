using FrbaCrucero.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Repositorios
{
    class RepoPasaje : AbstractRepo<Pasaje>
    {

        public static RepoPasaje instancia = new RepoPasaje("[FGNN_19].[Pasaje]");
        public static string TABLA_RESERVA = "[FGNN_19].[Reservas]";
        public static string TABLA_CLIENTE = "[FGNN_19].[Clientes]";
        public static string TABLA_COMPRA = "[FGNN_19].[Compras]";
        public static string TABLA_VIAJE = "[FGNN_19].[Viajes]";
        public static string TABLA_CABINA = "[FGNN_19].[Cabinas]";
        public static string TABLA_PASAJE = "[FGNN_19].[PASAJES]";

        public RepoPasaje(string nombreTabla) : base(nombreTabla) 
        {
        }

        public override List<Pasaje> ObtenerModelosDesdeTabla(System.Data.DataTable tabla)
        {
            List<Pasaje> pasajes = new List<Pasaje>();

            foreach (DataRow row in tabla.Rows)
            {
                Int32 id = Convert.ToInt32(row["id"]);
                Reserva reserva = DBNull.Value.Equals(row["reserva_codigo"]) ? null : RepoReserva.instancia.EncontrarPorCodigo(Convert.ToInt32(row["reserva_codigo"]));
                Cliente cliente = RepoCliente.instancia.EncontrarPorId(Convert.ToInt32(row["reserva_codigo"]));
                Compra compra = DBNull.Value.Equals(row["compra_codigo"]) ? null : RepoReserva.instancia.EncontrarPorCodigo(Convert.ToInt32(row["compra_codigo"]));

                Int16 habilitado = Convert.ToInt16(row["habilitada"]);
                DateTime fecha = Convert.ToDateTime(row["fecha"]);

                Reserva reserva = new Reserva(codigo, habilitado, fecha);

                reservas.Add(reserva);
            }

            return reservas;
        }

        public override int Crear(Pasaje entidad)
        {
            throw new NotImplementedException();
        }

        public Pasaje EncontrarPorCodigoReserva(string codigo)
        {
            string sqlQuery = "SELECT * FROM " + nombreTabla + " WHERE reserva_codigo = @Codigo";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            cmd.Parameters.Add(new SqlParameter("Codigo", codigo));

            DataTable tabla = conexionDB.obtenerData(cmd);
            if (tabla.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                return ObtenerModeloDesdeTabla(tabla);
            }
        }
    }
}
