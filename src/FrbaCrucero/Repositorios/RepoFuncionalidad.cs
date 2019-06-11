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
    class RepoFuncionalidad : AbstractRepo<Funcionalidad>
    {
        public static RepoFuncionalidad instancia = new RepoFuncionalidad("[FGNN_2019].[Funcionalidades]");


        public RepoFuncionalidad(string table)
            : base(table)
        {
        }

        public override List<Funcionalidad> ObtenerModelosDesdeTabla(DataTable table)
        {
            List<Funcionalidad> funcionalidades = new List<Funcionalidad>();
            foreach (DataRow row in table.Rows)
            {
                Int32 id = Convert.ToInt32(row["id"]);
                String descripcion = (String)row["descripcion"];
                Funcionalidad funcionalidad = new Funcionalidad(id, descripcion);

                funcionalidades.Add(funcionalidad);
            }

            return funcionalidades;
        }

        public List<Funcionalidad> findByRol(Rol rol)
        {
            String sqlQuery = "SELECT f.* " +
            "FROM [FGNN_2019].[Funcionalidades_Roles] fr, [FGNN_2019].[Funcionalidades] f " +
            "WHERE fr.rol_id = @Id " +
            "AND fr.funcionalidad_id = f.id";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            SqlParameter parameter = new SqlParameter("Id", rol.id);
            cmd.Parameters.Add(parameter);

            DataTable table = conexionDB.obtenerData(cmd);
            return ObtenerModelosDesdeTabla(table);
        }


        public override void Crear(Funcionalidad entidad)
        {
            throw new NotImplementedException();
        }
    }
}
