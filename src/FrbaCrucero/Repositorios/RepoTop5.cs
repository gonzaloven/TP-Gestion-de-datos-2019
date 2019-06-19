using FrbaCrucero.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Repositorios
{
    class RepoTop5: AbstractRepo<Top5>
    {

        public static RepoTop5 instancia = new RepoTop5("");

        public RepoTop5(string nombreTabla): base(nombreTabla) 
        {
        }

        public override List<Top5> ObtenerModelosDesdeTabla(DataTable table)
        {
            List<Top5> top5s = new List<Top5>();

            foreach (DataRow row in table.Rows)
            {
                String descripcion1 = (String)row["descripcion1"];
                String descripcion2 = (String)row["descripcion2"];
                Int32 cantidad = Convert.ToInt32(row["cantidad"]);

                Top5 top5 = new Top5(descripcion1, descripcion2, cantidad);

                top5s.Add(top5);
            }

            return top5s;
        }

        public List<Top5> EncontrarTop5RecorridosMasComprados(DateTime fecha)
        {
            string sqlQuery = " SELECT TOP 5 ps.descripcion AS [descripcion1], " +
                "pl.descripcion [descripcion2], COUNT(*) AS [cantidad] " +
                "FROM FGNN_19.Pasajes p " +
                "JOIN FGNN_19.Viajes v ON v.codigo = p.viaje_codigo " +
                "JOIN FGNN_19.Recorridos r ON r.id = v.recorrido_codigo " +
                "JOIN FGNN_19.Compras c ON c.codigo = p.compra_codigo " +
                "JOIN FGNN_19.Puertos ps ON ps.id = r.puerto_desde_id " +
                "JOIN FGNN_19.Puertos pl ON pl.id = r.puerto_hasta_id " +
                "WHERE c.fecha BETWEEN @fecha AND DATEADD(MONTH, 6, @fecha) " +
                "GROUP BY r.id, ps.descripcion, pl.descripcion " +
                "ORDER BY [cantidad] DESC";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            cmd.Parameters.Add(new SqlParameter("fecha", fecha));
            DataTable tabla = conexionDB.obtenerData(cmd);
            return ObtenerModelosDesdeTabla(tabla);
        }

        public override void Crear(Top5 entidad)
        {
            throw new NotImplementedException();
        }
    }
}
