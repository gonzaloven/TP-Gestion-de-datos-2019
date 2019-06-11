using FrbaCrucero.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Repositorios
{
    class RepoCrucero: AbstractRepo<Crucero>
    {
        public static RepoCrucero instancia = new RepoCrucero("[FGNN_19].[Cruceros]");

        public RepoCrucero(string nombreTabla): base(nombreTabla) 
        {
        }

        public override List<Crucero> ObtenerModelosDesdeTabla(DataTable tabla)
        {
            List<Crucero> cruceros = new List<Crucero>();

            foreach (DataRow row in tabla.Rows)
            {

                Int32 id = Convert.ToInt32(row["id"]);
                String nombre = (String)row["nombre"];
                DateTime? fecha_alta = row.Field<DateTime?>("fecha_alta");
                String modelo = (String)row["modelo"];
                Int32 fabricante_id = Convert.ToInt32(row["fabricante_id"]);
                String tipo_servicio = row.Field<String>("tipo_servicio");
                Int16 baja_servicio = Convert.ToInt16(row["baja_servicio"]);
                Int16 baja_vida_util = Convert.ToInt16(row["baja_vida_util"]);
                DateTime? fecha_fuera_servicio = row.Field<DateTime?>("fecha_fuera_servicio");
                DateTime? fecha_reinicio_servicio = row.Field<DateTime?>("fecha_reinicio_servicio");
                DateTime? fecha_baja_definitiva = row.Field<DateTime?>("fecha_baja_definitiva");
                Int16? cant_cabinas = row.Field<Int16?>("cant_cabinas");
                Int16 habilitado = Convert.ToInt16(row["habilitado"]);

                Crucero crucero = new Crucero(id, nombre, fecha_alta, modelo, 
                                              fabricante_id, tipo_servicio, baja_servicio, baja_vida_util, 
                                              fecha_fuera_servicio,fecha_reinicio_servicio, fecha_baja_definitiva, 
                                              cant_cabinas, habilitado);

                cruceros.Add(crucero);
            }

            return cruceros;
        }

        public List<Crucero> EncontrarPorNombreCrucero(string nombre)
        {
            string sqlQuery = "SELECT * FROM" + nombreTabla + " WHERE nombre LIKE @CruceroPattern";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            cmd.Parameters.Add(new SqlParameter("CruceroPattern", nombre + "%"));
            DataTable tabla = conexionDB.obtenerData(cmd);
            return ObtenerModelosDesdeTabla(tabla);
        }

        public override void Crear(Crucero entidad)
        {
            throw new NotImplementedException();
        }
    }
}
