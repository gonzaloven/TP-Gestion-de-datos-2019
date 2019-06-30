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
    class RepoReserva : AbstractRepo<Reserva>
    {
        public static RepoReserva instancia = new RepoReserva("[FGNN_19].[Reservas]");
        public static string TABLA_PASAJE = "[FGNN_19].[PASAJES]";

        public RepoReserva(string nombreTabla) : base(nombreTabla) 
        {
        }

        public override List<Reserva> ObtenerModelosDesdeTabla(System.Data.DataTable tabla)
        {
            List<Reserva> reservas = new List<Reserva>();

            foreach (DataRow row in tabla.Rows)
            {
                Int32 codigo = Convert.ToInt32(row["codigo"]);
                Int16 habilitado = Convert.ToInt16(row["habilitada"]);
                DateTime fecha = Convert.ToDateTime(row["fecha"]);

                Reserva reserva = new Reserva(codigo, habilitado, fecha);

                reservas.Add(reserva);
            }

            return reservas;
        }

        public override int Crear(Reserva entidad)
        {
            throw new NotImplementedException();
        }

        public Reserva EncontrarPorCodigo(Int32 codigo)
        {
            string sqlQuery = "SELECT * FROM " + nombreTabla + " WHERE codigo = @Codigo";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            cmd.Parameters.Add(new SqlParameter("Codigo", codigo));

            DataTable tabla = conexionDB.obtenerData(cmd);
            return ObtenerModeloDesdeTabla(tabla);
        }

        public Reserva EncontrarPorCodigoConPasajeNoComprado(Int32 codigo)
        {
            string sqlQuery = "SELECT r.* FROM " + nombreTabla + " r, " +  TABLA_PASAJE + " p WHERE p.reserva_codigo = r.codigo AND p.compra_codigo IS NULL AND r.codigo = @Codigo";
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
