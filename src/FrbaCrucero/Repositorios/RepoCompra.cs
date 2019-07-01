using FrbaCrucero.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Repositorios
{
    class RepoCompra : AbstractRepo<Compra>
    {
        public static RepoCompra instancia = new RepoCompra("[FGNN_19].[Compras]");

        public RepoCompra(string nombreTabla) : base(nombreTabla) 
        {
        }

        public override List<Compra> ObtenerModelosDesdeTabla(System.Data.DataTable tabla)
        {
            List<Cliente> clientes = new List<Cliente>();

            foreach (DataRow row in tabla.Rows)
            {
                Int32 codigo = Convert.ToInt32(row["codigo"]);
                Int32 codigoPasaje = Convert.ToInt32(row["codigo_pasaje"]);
                MetodoPago metodoPago = DBNull.Value.Equals(row["metodo_pago"]) ? null : RepoReserva.instancia.EncontrarPorCodigo(Convert.ToInt32(row["metodo_pago"]));
                DateTime fecha = Convert.ToDateTime(row["fecha"]);
               
                Cliente cliente = new Cliente(id, nombre, apellido, dni, direccion, telefono, fechaNacimiento, mail)

                clientes.Add(cliente);
            }

            return clientes;
        }

        public override int Crear(Compra entidad)
        {
            throw new NotImplementedException();
        }
    }
}
