using FrbaCrucero.ListadoEstadistico;
using FrbaCrucero.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Repositorios
{
     class RepoRecorridosConMasPasajes : AbstractRepo<RecorridosConMasPasajes>
    {

        public RepoRecorridosConMasPasajes(string nombreTabla) : base(nombreTabla)
        {

        }

        public override void Crear(RecorridosConMasPasajes entidad)
        {
            throw new NotImplementedException();
        }

        public override List<RecorridosConMasPasajes> ObtenerModelosDesdeTabla(DataTable tabla)
        {
            throw new NotImplementedException();
        }

        internal List<RecorridosConMasPasajesAux> getRecorridosConMasCompras(string anioSeleccionado, string semestreSeleccionado)
        {
            List<RecorridosConMasPasajesAux> recorridos = new List<RecorridosConMasPasajesAux>();

            try
            {
                SPContent parametro1 = new SPContent(SqlDbType.Int, "semestre", int.Parse(semestreSeleccionado));
                SPContent parametro2 = new SPContent(SqlDbType.Int, "anio", int.Parse(anioSeleccionado));
                List<SPContent> parametros = new List<SPContent>();
                parametros.Add(parametro1);
                parametros.Add(parametro2);
                this.conexionDB.crearConexion();
                this.conexionDB.abrirConexion();

                SqlCommand procedure = CreateProcedure("FGNN_19.TOP5_recorridos_mas_comprados", parametros);
                SqlDataReader sqlReader = procedure.ExecuteReader();

                if (sqlReader.HasRows)
                {
                    while (sqlReader.Read())
                    {
                        RecorridosConMasPasajesAux recorridoAux = new RecorridosConMasPasajesAux();
                        recorridoAux.PuertoSalida = sqlReader.GetString(0);
                        recorridoAux.PuertoLlegada = sqlReader.GetString(1);
                        recorridoAux.CantidadVendida = sqlReader.GetInt32(2);

                        recorridos.Add(recorridoAux);
                    }
                }

            }
            catch (Exception e)
            {
                recorridos = null;
            }
            finally
            {
                this.conexionDB.cerrarConexion();
            }
            return recorridos;
        }
    }
}
