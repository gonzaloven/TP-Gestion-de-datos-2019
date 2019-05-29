using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace FrbaCrucero
{
	public class ConexionDB
	{
		public static ConexionDB instancia = new ConexionDB();
		private SqlConnection cnn;

        public SqlConnection crearConexion() 
		{
            var connectionString = ConfigurationManager.ConnectionStrings["GD1C2019DB"].ConnectionString;
            return new SqlConnection(connectionString);
        }
		
		public void abrirConexion() 
		{
            cnn.Open();
        }
		
		public void cerrarConexion() 
		{
            cnn.Close();
        }
		
        public DataTable obtenerData(String query) {
			try
			{
            	crearConexion();
            	abrirConexion();
				
				DataTable tabla = new DataTable();
            	SqlCommand sqlCmd = new SqlCommand(query, cnn);

            	tabla.Load(sqlCmd.ExecuteReader());
            	cerrarConexion();
				
				return tabla;
			}
			catch (Exception)
			{
                throw;
            } 
        }
	}
}