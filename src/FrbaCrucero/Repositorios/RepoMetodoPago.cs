using FrbaCrucero.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Repositorios
{
    class RepoMetodoPago : AbstractRepo<MetodoPago>
    {
        public static RepoMetodoPago instancia = new RepoMetodoPago("[FGNN_19].[Metodos_Pago]");

        public RepoMetodoPago(string nombreTabla) : base(nombreTabla) 
        {
        }

        public override List<MetodoPago> ObtenerModelosDesdeTabla(System.Data.DataTable tabla)
        {
            List<MetodoPago> metodoPagos = new List<MetodoPago>();

            foreach (DataRow row in tabla.Rows)
            {
                Int32 id = Convert.ToInt32(row["id"]);
                String descripcion = Convert.ToInt32(row["descripcion"]);
                MetodoPago metodoPago = DBNull.Value.Equals(row["metodo_pago"]) ? null : RepoReserva.instancia.EncontrarPorCodigo(Convert.ToInt32(row["metodo_pago"]));
                DateTime fecha = Convert.ToDateTime(row["fecha"]);
               
                Cliente cliente = new Cliente(id, nombre, apellido, dni, direccion, telefono, fechaNacimiento, mail)

                metodoPagos.Add(cliente);
            }

            return metodoPagos;
        }

        public override int Crear(MetodoPago entidad)
        {
            throw new NotImplementedException();
        }
    }
}
