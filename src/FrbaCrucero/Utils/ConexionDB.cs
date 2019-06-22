﻿using System;
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
            cnn = new SqlConnection(connectionString);
            return cnn;
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
            	SqlConnection cnn = crearConexion();
                cnn.Open();

				DataTable tabla = new DataTable();
            	SqlCommand sqlCmd = new SqlCommand(query, cnn);

            	tabla.Load(sqlCmd.ExecuteReader());
                cnn.Close();
				
				return tabla;
			}
			catch (Exception)
			{
                throw;
            } 
        }

        public DataTable obtenerData(SqlCommand cmd)
        {
            try
            {
                SqlConnection cnn = crearConexion();
                cnn.Open();
                cmd.Connection = cnn;
                DataTable tabla = new DataTable();
                tabla.Load(cmd.ExecuteReader());
                cnn.Close();

                return tabla;
            } catch (Exception ex)
            {
                throw ex;
            }
        }
           
        public void ejecutarQuery(SqlCommand cmd)
        {
            try
            {
                SqlConnection cnn = crearConexion();
                cnn.Open();

                cmd.Connection = cnn;
                int result = cmd.ExecuteNonQuery();
                cnn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public SqlCommand getStoreProcedure(string storeProcedureName)
        {
            SqlCommand sp = new SqlCommand(storeProcedureName, this.cnn);
            sp.CommandType = CommandType.StoredProcedure;
            return sp;
        }

    }
}