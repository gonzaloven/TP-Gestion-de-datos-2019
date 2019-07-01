using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Modelos
{
    class CrearReserva
    {
        public CrearReserva(){}

        public Int32 Crear()
        {
            String parametroOutput = "@id";
            SqlCommand cmdInsertar = new SqlCommand("FGNN_19.Insertar_Reserva");
            cmdInsertar.CommandType = CommandType.StoredProcedure;
            cmdInsertar.Parameters.Add(parametroOutput, SqlDbType.Decimal).Direction = ParameterDirection.Output;
            Int32 codigo = ConexionDB.instancia.ejecutarStoredProcedureConOutput(cmdInsertar, parametroOutput);
            return codigo;
        }
    }
}
