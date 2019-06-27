using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaCrucero.Modelos;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using FrbaCrucero.Utils;

namespace FrbaCrucero.Repositorios
{
    class RepoTop5 : AbstractRepo<ListadosEstadisticos>
    {
        public RepoTop5(string nombreTabla) : base(nombreTabla) { 
        }

        public override List<ListadosEstadisticos> ObtenerModelosDesdeTabla(System.Data.DataTable tabla)
        {
            throw new NotImplementedException();
        }

        public override void Crear(ListadosEstadisticos entidad)
        {
            throw new NotImplementedException();
        }

        private List<ListadosEstadisticos> getListado(string anioSeleccionado, string semestreSeleccionado, string nameStore)
        {
            List<ListadosEstadisticos> listado = new List<ListadosEstadisticos>();

            try
            {
                SPContent parametro1 = new SPContent(SqlDbType.Int, "semestre", int.Parse(semestreSeleccionado));
                SPContent parametro2 = new SPContent(SqlDbType.Int, "anio", int.Parse(anioSeleccionado));
                List<SPContent> parametros = new List<SPContent>();
                parametros.Add(parametro1);
                parametros.Add(parametro2);
                this.conexionDB.crearConexion();
                this.conexionDB.abrirConexion();

                SqlCommand procedure = CreateProcedure(nameStore, parametros);
                SqlDataReader sqlReader = procedure.ExecuteReader();

                if (sqlReader.HasRows)
                {
                    while (sqlReader.Read())
                    {
                        ListadosEstadisticos fila = new ListadosEstadisticos();
                        fila.PrimeraColumna = sqlReader.GetString(0);
                        fila.SegundaColumna = sqlReader.GetString(1);
                        fila.TerceraColumna = sqlReader.GetInt32(2);

                        listado.Add(fila);
                    }
                }

            }
            catch (Exception e)
            {
                listado = null;
            }
            finally
            {
                this.conexionDB.cerrarConexion();
            }
            return listado;
        }

        internal List<ListadosEstadisticos> getCrucerosConMasDiasFueraDeServicio(string anio, string semestre) 
        {
            return this.getListado(anio, semestre, "FGNN_19.TOP5_cruceros_mas_dias_fuera_servicio");
        }

        internal List<ListadosEstadisticos> getRecorridosConMasCabinasLibres(string anio, string semestre)
        {
            return this.getListado(anio, semestre, "FGNN_19.TOP5_recorridos_mas_cabinas_libres");
        }

        internal List<ListadosEstadisticos> getRecorridosConPasajesMasComprados(string anio, string semestre)
        {
            return this.getListado(anio, semestre, "FGNN_19.TOP5_recorridos_mas_comprados");
        }

        private List<int> GetAnios(string store)
        {
            List<int> anios = new List<int>();

            try
            {
                this.conexionDB.crearConexion();
                this.conexionDB.abrirConexion();

                SqlCommand procedure = CreateProcedure(store, null);
                SqlDataReader sqlReader = procedure.ExecuteReader();

                if (sqlReader.HasRows)
                {
                    while (sqlReader.Read())
                    {
                        anios.Add(sqlReader.GetInt32(0));
                    }
                }
            }
            catch(Exception e)
            {
                anios = null;
            }
            finally
            {
                this.conexionDB.cerrarConexion();
            }
            return anios;
        }

        internal List<int> GetAniosRecorridosMasComprados()
        {
            return GetAnios("FGNN_19.Anios_TOP5_recorridos_mas_comprados");
        }

        internal List<int> GetAniosRecorridosMasCabinasLibres()
        {
            return GetAnios("FGNN_19.Anios_TOP5_recorridos_mas_cabinas_libres");
        }

        internal List<int> GetAniosCrucerosMasDiasFueraServicio()
        {
            return GetAnios("FGNN_19.Anios_TOP5_cruceros_mas_dias_fuera_servicio");
        }
    }
}
