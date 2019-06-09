using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace FrbaCrucero.Repositorios
{
    abstract class AbstractRepo<T>: IRepo<T> where T : class
    {
        protected string nombreTabla;
        protected ConexionDB conexionDB = ConexionDB.instancia;

        public AbstractRepo(string nombreTabla)
        {
            this.nombreTabla = nombreTabla;
        }

        public abstract List<T> ObtenerModelosDesdeTabla(DataTable tabla);
        public abstract void Crear(T entidad);
        
        public void Eliminar(Int32 id)
        {
            String sqlQuery = "DELETE FROM " + nombreTabla + " WHERE id = @id";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            conexionDB.ejecutarQuery(cmd);
        }

        public void Modificar(Int32 id, Dictionary<string, object> parametros)
        {
            string sqlQuery = crearUpdateQuery(id, parametros);
            SqlCommand cmd = new SqlCommand(sqlQuery);

            List<SqlParameter> sqlParametros = new List<SqlParameter>();
            foreach (string key in parametros.Keys) 
            {
                sqlParametros.Add(new SqlParameter(key, parametros[key]));
            }

            sqlParametros.Add(new SqlParameter("id", id));

            cmd.Parameters.Add(sqlParametros);

            conexionDB.ejecutarQuery(cmd);
        }

        public List<T> EncontrarTodos()
        {
            String sqlQuery = "SELECT * FRON " + nombreTabla;
            DataTable tabla = conexionDB.obtenerData(sqlQuery);
            return ObtenerModelosDesdeTabla(tabla);
        }

        public T EncontrarPorId(Int32 id)
        {
            String sqlQuery = "SELECT  *   FROM " + nombreTabla + " WHERE id = @id";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            SqlParameter parametro = new SqlParameter("id", id);
            cmd.Parameters.Add(parametro);

            DataTable tabla = conexionDB.obtenerData(cmd);
            return ObtenerModeloDesdeTabla(tabla);
        }

        private T ObtenerModeloDesdeTabla(DataTable tabla)
        {
            return ObtenerModelosDesdeTabla(tabla).First();
        }

        private string crearUpdateQuery(Int32 id, Dictionary<string, object> parametros)
        {
            string separador = "";
            string separadorComa = ", ";
            StringBuilder sql = new StringBuilder();
            sql.Append("UPDATE ").Append(nombreTabla).Append(" SET ");

            foreach (string key in parametros.Keys) 
            {
                sql.Append(separador).Append(key).Append(" = @").Append(key).Append(separadorComa);
            }

            sql.Append(" WHERE id = @id");

            return sql.ToString();
        }

    }   
}
