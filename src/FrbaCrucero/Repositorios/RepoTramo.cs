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
    class RepoTramo : AbstractRepo<Tramo>
    {
        public static RepoTramo instancia = new RepoTramo("[FGNN_19].[Tramos]");

        public RepoTramo(string nombreTabla) : base(nombreTabla) 
        {
        }

        public override List<Tramo> ObtenerModelosDesdeTabla(DataTable table)
        {
            List<Tramo> tramos = new List<Tramo>();

            foreach (DataRow row in table.Rows)
            {
                Int32 id = Convert.ToInt32(row["id"]);
                String puertoDesde = Repositorios.RepoPuerto.instancia.buscarValorID(Convert.ToInt32(row["puerto_desde_id"]));
                String puertoHasta = Repositorios.RepoPuerto.instancia.buscarValorID(Convert.ToInt32(row["puerto_hasta_id"]));
                Double precio_base = Convert.ToDouble(row["habilitado"]);

                Tramo tramo = new Tramo(id, puertoDesde, puertoHasta, precio_base);

                tramos.Add(tramo);
            }
            return tramos;
        }

        public void llenarDatos(DataGridView tablaTramosTotales)
        {
            String sqlQuery = "Select * from " + nombreTabla;
            SqlCommand cmd = new SqlCommand(sqlQuery);
            DataTable tabla = conexionDB.obtenerData(cmd);
            tablaTramosTotales.DataSource = tabla;
        }

        public void actualizarDatosAgregar(DataGridView tablaTramos, String idPuertoDesde)
        {
            String sqlQuery = "Select * from " + nombreTabla + " WHERE puerto_desde_id = @idPuertoDesde";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            cmd.Parameters.AddWithValue("idPuertoDesde", idPuertoDesde);
            DataTable tabla = conexionDB.obtenerData(cmd);
            tablaTramos.DataSource = tabla;
        }

        public void actualizarDatosQuitar(DataGridView tablaTramos, String idPuertoHasta)
        {
            String sqlQuery = "Select * from " + nombreTabla + " WHERE puerto_desde_id = @idPuertoHasta";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            cmd.Parameters.AddWithValue("idPuertoHasta", idPuertoHasta);
            DataTable tabla = conexionDB.obtenerData(cmd);
            tablaTramos.DataSource = tabla;
        }

        public override void Crear(Tramo tramo)
        {
            throw new NotImplementedException();
        }
    }
}
