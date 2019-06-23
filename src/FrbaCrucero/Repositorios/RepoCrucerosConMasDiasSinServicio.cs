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
    class RepoCrucerosConMasDiasSinServicio : AbstractRepo<RepoCrucerosConMasDiasSinServicio>
    {
        public RepoCrucerosConMasDiasSinServicio(string nombreTabla) : base(nombreTabla)
        {

        }

        public override void Crear(RepoCrucerosConMasDiasSinServicio entidad)
        {
            throw new NotImplementedException();
        }

        public override List<RepoCrucerosConMasDiasSinServicio> ObtenerModelosDesdeTabla(DataTable tabla)
        {
            throw new NotImplementedException();
        }

        internal List<CrucerosConMasDiasSinServicioAux> getCruceros(string anioSeleccionado, string semestreSeleccionado)
        {
            List<CrucerosConMasDiasSinServicioAux> cruceros = new List<CrucerosConMasDiasSinServicioAux>();

            try
            {
                SPContent parametro1 = new SPContent(SqlDbType.Int, "semestre", int.Parse(semestreSeleccionado));
                SPContent parametro2 = new SPContent(SqlDbType.Int, "anio", int.Parse(anioSeleccionado));
                List<SPContent> parametros = new List<SPContent>();
                parametros.Add(parametro1);
                parametros.Add(parametro2);
                this.conexionDB.crearConexion();
                this.conexionDB.abrirConexion();

                SqlCommand procedure = CreateProcedure("FGNN_19.TOP5_cruceros_mas_dias_fuera_servicio", parametros);
                SqlDataReader sqlReader = procedure.ExecuteReader();

                if (sqlReader.HasRows)
                {
                    while (sqlReader.Read())
                    {
                        CrucerosConMasDiasSinServicioAux cruceroAux = new CrucerosConMasDiasSinServicioAux();
                        cruceroAux.Nombre = sqlReader.GetString(0);
                        cruceroAux.Modelo = sqlReader.GetString(1);
                        cruceroAux.DiasFueraDeServicio = sqlReader.GetInt32(2);

                        cruceros.Add(cruceroAux);
                    }
                }

            }
            catch (Exception e)
            {
                cruceros = null;
            }
            finally
            {
                this.conexionDB.cerrarConexion();
            }
            return cruceros;
        }
    }
}
