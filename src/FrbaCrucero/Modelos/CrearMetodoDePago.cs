using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Modelos
{
    class CrearMetodoDePago
    {
        public String descripcion { get; set; }
        public Int32 cuotas { get; set; }

        public CrearMetodoDePago(String descripcion, Int32 cuotas)
        {
            this.descripcion = descripcion;
            this.cuotas = cuotas;
        }

        public Int32 Crear()
        {
            String parametroOutput = "id";
            SqlCommand cmdInsertar = new SqlCommand("FGNN_19.Insertar_Metodo_pago");
            cmdInsertar.CommandType = CommandType.StoredProcedure;
            cmdInsertar.Parameters.Add(new SqlParameter("descripcion", descripcion));
            cmdInsertar.Parameters.Add(new SqlParameter("cuotas", cuotas));
            cmdInsertar.Parameters.Add(parametroOutput, SqlDbType.Decimal).Direction = ParameterDirection.Output;
            Int32 id = ConexionDB.instancia.ejecutarStoredProcedureConOutput(cmdInsertar, parametroOutput);
            return id;
        }
    }
}
