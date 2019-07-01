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

        public override int Crear(Viaje viaje)
        {
            string sqlQuery = "INSERT INTO " + nombreTabla + "(crucero_id, recorrido_codigo, fecha_inicio, fecha_fin) VALUES (@crucero_id, @recorrido_codigo, @fecha_inicio, @fecha_fin)";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            cmd.Parameters.Add(new SqlParameter("crucero_id", viaje.crucero_id));
            cmd.Parameters.Add(new SqlParameter("recorrido_codigo", viaje.recorrido_codigo));
            cmd.Parameters.Add(new SqlParameter("fecha_inicio", viaje.fecha_inicio));
            cmd.Parameters.Add(new SqlParameter("fecha_fin", viaje.fecha_fin));
            conexionDB.ejecutarQuery(cmd);

            return 1;
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
                DateTime? fecha_fin_estimada = row.Field<DateTime?>("fecha_fin_estimada");

                Viaje viaje = new Viaje(id, crucero_id, recorrido_codigo, fecha_inicio, fecha_fin, fecha_fin_estimada);

                viajes.Add(viaje);
            }

            return viajes;
        }

        public List<Viaje> EncontrarPorParametros(String puertoDesde, String puertoHasta, String fechaInicio, String fechaFin)
        {
            string sqlQuery;
            if (String.IsNullOrWhiteSpace(puertoDesde) && String.IsNullOrWhiteSpace(puertoHasta))
            {
                sqlQuery = "SELECT v.codigo, v.crucero_id, v.recorrido_codigo, v.fecha_inicio, v.fecha_fin, v.fecha_fin_estimada"
                                + " FROM FGNN_19.Viajes v WHERE v.codigo > 0";
            }
            else
            {
                sqlQuery = "SELECT v.codigo, v.crucero_id, v.recorrido_codigo, v.fecha_inicio, v.fecha_fin, v.fecha_fin_estimada"
                                + " FROM FGNN_19.Viajes v, FGNN_19.Recorridos r WHERE v.codigo > 0 AND v.recorrido_codigo = r.id";
            }
            SqlCommand cmd = new SqlCommand(sqlQuery);

            if (!String.IsNullOrWhiteSpace(puertoDesde))
            {
                cmd.CommandText = cmd.CommandText + " AND r.puerto_desde_id = @puertoDesde";
                cmd.Parameters.Add(new SqlParameter("puertoDesde", Int32.Parse(puertoDesde)));
            }

            if (!String.IsNullOrWhiteSpace(puertoHasta))
            {
                cmd.CommandText = cmd.CommandText + " AND r.puerto_hasta_id = @puertoHasta";
                cmd.Parameters.Add(new SqlParameter("puertoHasta", Int32.Parse(puertoHasta)));
            }

            if (!String.IsNullOrWhiteSpace(fechaInicio))
            {
                cmd.CommandText = cmd.CommandText + " AND v.fecha_inicio = @fechaInicio";
                cmd.Parameters.Add(new SqlParameter("fechaInicio", Convert.ToDateTime(fechaInicio)));
            }

            if (!String.IsNullOrWhiteSpace(fechaFin))
            {
                cmd.CommandText = cmd.CommandText + " AND v.fecha_fin = @fechaFin";
                cmd.Parameters.Add(new SqlParameter("fechaFin", Convert.ToDateTime(fechaFin)));
            }

            DataTable tabla = conexionDB.obtenerData(cmd);
            return ObtenerModelosDesdeTabla(tabla);  
        }

        public Viaje EncontrarPorCodigo(Int32 codigo)
        {
            String sqlQuery = "SELECT  *   FROM " + nombreTabla + " WHERE codigo = @Codigo";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            SqlParameter parametro = new SqlParameter("Codigo", codigo);
            cmd.Parameters.Add(parametro);

            DataTable tabla = conexionDB.obtenerData(cmd);
            return ObtenerModeloDesdeTabla(tabla);
        }
    }
}
