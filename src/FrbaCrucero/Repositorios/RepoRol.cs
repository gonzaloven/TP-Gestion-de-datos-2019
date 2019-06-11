using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrbaCrucero.Modelos;
using System.Data;
using System.Data.SqlClient;

namespace FrbaCrucero.Repositorios
{
    class RepoRol: AbstractRepo<Rol>
    {
        public static RepoRol instancia = new RepoRol("[FGNN_19].[Roles]");

        public RepoRol(string nombreTabla) : base(nombreTabla) 
        {
        }

        
        public override void Crear(Rol rol)
        {
            string sqlQuery = "INSERT INTO " + nombreTabla + "(descripcion) VALUES (@descripcion)";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            cmd.Parameters.Add(new SqlParameter("descripcion", rol.descripcion));

            conexionDB.ejecutarQuery(cmd);
            
        }

        public override List<Rol> ObtenerModelosDesdeTabla(DataTable table)
        {
            List<Rol> roles = new List<Rol>();

            foreach (DataRow row in table.Rows)
            {
                Int32 id = Convert.ToInt32(row["id"]);
                String descripcion = (String)row["descripcion"];
                Int16 habilitado = Convert.ToInt16(row["habilitado"]);

                Rol rol = new Rol(id, descripcion, habilitado);
                List<Funcionalidad> funcionalidades = RepoFuncionalidad.instancia.findByRol(rol);

                rol.funcionalidades = funcionalidades;

                roles.Add(rol);
            }

            return roles;
        }

        public List<Rol> EncontrarPorDescripcionYHabilitado(String descripcion, Int16 habilatado, Boolean filtarPorValor)
        {
            string sqlQuery = "SELECT * FROM " + nombreTabla + " WHERE descripcion like @DescripcionPatron";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            cmd.Parameters.Add(new SqlParameter("DescripcionPatron", descripcion + "%"));
            if (filtarPorValor)
            {
                cmd.CommandText = cmd.CommandText + " AND habilitado = @Habilitado";
                cmd.Parameters.Add(new SqlParameter("Habilitado", habilatado));
            }

            DataTable tabla = conexionDB.obtenerData(cmd);
            return ObtenerModelosDesdeTabla(tabla);
        }

        public void borrarRol(Int32 id) 
        { 
        }
            

    }
}
