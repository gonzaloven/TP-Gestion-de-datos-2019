using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Modelos
{
    public class CrearPasaje
    {
        public Int32 reserva_codigo { get; set; }
        public Int32 cliente_id { get; set; }
        public Int32 compra_codigo { get; set; }
        public Int32 viaje_codigo { get; set; }
        public Int32 cabina_id { get; set; }
        public Double precio { get; set; }
        public Int32 pasajeros { get; set; }
    }
}
