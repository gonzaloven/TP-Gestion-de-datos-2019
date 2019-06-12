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
    class RepoRecorrido : AbstractRepo<Recorrido>
    {
        public static RepoRecorrido instancia = new RepoRecorrido("[FGNN_19].[Recorridos]");

        public RepoRecorrido(string nombreTabla) : base(nombreTabla) 
        {
        }

        public override void Crear(Recorrido recorrido)
        {
            string sqlQuery = "INSERT INTO " + nombreTabla + "(codigo, puerto_desde_id, puerto_hasta_id, precio_base, habilitado) "
                                             + "VALUES (@codigo, @puerto_desde_id, @puerto_hasta_id, @precio_base, @habilitado)";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            cmd.Parameters.Add(new SqlParameter("codigo", recorrido.codigo));
            cmd.Parameters.Add(new SqlParameter("puerto_desde_id", recorrido.puertoDesde));
            cmd.Parameters.Add(new SqlParameter("puerto_hasta_id", recorrido.puertoHasta));
            cmd.Parameters.Add(new SqlParameter("precio_base", recorrido.precio_base));
            cmd.Parameters.Add(new SqlParameter("habilitado", recorrido.habilitado));

            conexionDB.ejecutarQuery(cmd);

        }

        public override List<Recorrido> ObtenerModelosDesdeTabla(DataTable table)
        {
            List<Recorrido> recorridos = new List<Recorrido>();

            foreach (DataRow row in table.Rows)
            {
                Int32 id = Convert.ToInt32(row["id"]);
                String codigo = (String)row["codigo"];
                String puertoDesde = this.buscarValorID(Convert.ToInt32(row["puerto_desde_id"]));
                String puertoHasta = this.buscarValorID(Convert.ToInt32(row["puerto_hasta_id"]));
                Double precio_base = Convert.ToDouble(row["precio_base"]);
                Int16 habilitado = Convert.ToInt16(row["habilitado"]);

                Recorrido recorrido = new Recorrido(id, codigo, puertoDesde, puertoHasta, precio_base, habilitado);

                recorridos.Add(recorrido);
            }

            return recorridos;
        }

        public List<Recorrido> EncontrarPorParametros(String puertoDesde, String puertoHasta, Int16 habilatado, Boolean filtarPorValor)
        {
            string sqlQuery;
            if (!String.IsNullOrWhiteSpace(puertoDesde) && !String.IsNullOrWhiteSpace(puertoHasta))
            {
                sqlQuery = "SELECT * FROM " + nombreTabla + ", FGNN_19.Puertos p1, FGNN_19.Puertos p2 "
                                                                 + "WHERE p1.id = puerto_desde_id AND p2.id = puerto_hasta_id "
                                                                 + "AND p1.descripcion = @puertoDesde OR p2.descripcion = @puertoHasta";
            }
            else
            {
                sqlQuery = "SELECT * FROM " + nombreTabla;
            }
            
            SqlCommand cmd = new SqlCommand(sqlQuery);
            cmd.Parameters.Add(new SqlParameter("puertoDesde", puertoDesde));
            cmd.Parameters.Add(new SqlParameter("puertoHasta", puertoHasta));
            if (filtarPorValor)
            {
                cmd.CommandText = cmd.CommandText + " AND habilitado = @Habilitado";
                cmd.Parameters.Add(new SqlParameter("Habilitado", habilatado));
            }

            DataTable tabla = conexionDB.obtenerData(cmd);
            return ObtenerModelosDesdeTabla(tabla);
        }

        public String buscarValorID(Int32 id)
        {
            string sqlQuery = "SELECT p.descripcion FROM FGNN_19.Puertos p WHERE p.id = @id";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            cmd.Parameters.Add(new SqlParameter("id", id));
            DataTable tabla = conexionDB.obtenerData(cmd);
            return tabla.Rows[0][0].ToString();
        }
    }
}
