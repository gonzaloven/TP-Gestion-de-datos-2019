using FrbaCrucero.GeneracionViaje;
using FrbaCrucero.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.Repositorios
{
    class RepoViaje: AbstractRepo<Viaje>
    {
        public static RepoViaje instancia = new RepoViaje("[FGNN_19].[Viajes]");

        public RepoViaje(string nombreTabla) : base(nombreTabla) 
        {
        }

        public override void Crear(Viaje viaje)
        {
            string sqlQuery = "INSERT INTO " + nombreTabla + "(crucero_id, recorrido_codigo, fecha_inicio, fecha_fin) VALUES (@crucero_id, @recorrido_codigo, @fecha_inicio, @fecha_fin)";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            cmd.Parameters.Add(new SqlParameter("crucero_id", viaje.crucero_id));
            cmd.Parameters.Add(new SqlParameter("recorrido_codigo", viaje.recorrido_codigo));
            cmd.Parameters.Add(new SqlParameter("fecha_inicio", viaje.fecha_inicio));
            cmd.Parameters.Add(new SqlParameter("fecha_fin", viaje.fecha_fin));
            conexionDB.ejecutarQuery(cmd);

        }

        public override List<Viaje> ObtenerModelosDesdeTabla(DataTable table)
        {
            List<Viaje> viajes = new List<Viaje>();

            foreach (DataRow row in table.Rows)
            {
                Int32 id = Convert.ToInt32(row["codigo"]);
                Int32 crucero_id = Convert.ToInt32(row["crucero_id"]);
                Int32 recorrido_codigo = Convert.ToInt32(row["recorrido_codigo"]);
                DateTime fecha_inicio = Convert.ToDateTime(row["fecha_inicio"]);
                DateTime fecha_fin = Convert.ToDateTime(row["fecha_fin"]);
                DateTime fecha_fin_estimada = Convert.ToDateTime(row["fecha_fin_estimada"]);

                Viaje viaje = new Viaje(id, crucero_id, recorrido_codigo, fecha_inicio, fecha_fin, fecha_fin_estimada);

                viajes.Add(viaje);
            }

            return viajes;
        }

        /*public Int32 GenerarViaje(TextBox textBoxCrucero, TextBox textBoxPuertoDesde, 
                                    TextBox textBoxPuertoHasta, TextBox textBoxFechaInicio,
                                    TextBox textBoxFechaFin)
        {
            string sqlQuery = "FGNN_19.P_ViajesValidacion";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("nombre", textBoxCrucero.Text));
            cmd.Parameters.Add(new SqlParameter("puertoD", textBoxPuertoDesde.Text));
            cmd.Parameters.Add(new SqlParameter("puertoH", textBoxPuertoHasta.Text));
            cmd.Parameters.Add(new SqlParameter("fechaI", textBoxFechaInicio.Text));
            cmd.Parameters.Add(new SqlParameter("fechaF", textBoxFechaFin.Text));

            if (conexionDB.obtenerData(cmd).Rows[0][0].ToString() == "1")
            {
                throw new System.ArgumentException("No se puede ingresar el viaje");
            }
            else
            {
                Viaje viaje = new Viaje(
                Repositorios.RepoViaje.instancia.Crear(viaje);
            }
        }*/
    }
}
