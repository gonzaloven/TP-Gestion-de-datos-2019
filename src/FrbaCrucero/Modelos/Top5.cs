using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Modelos
{
    class Top5
    {
        public String descripcion1 { get; set; }
        public String descripcion2 { get; set; }
        public Int32 cantidad { get; set; }


        public Top5(String descripcion1, String descripcion2, Int32 cantidad)
        {
            this.descripcion1 = descripcion1;
            this.descripcion2 = descripcion2;
            this.cantidad = cantidad;
        }
    }
}
