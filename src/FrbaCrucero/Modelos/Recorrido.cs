﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Modelos
{
    class Recorrido
    {
        public Int32 id { get; set; }
        public String codigo { get; set; }
        public String puertoDesde { get; set; }
        public String puertoHasta { get; set; }
        public Double precio_base { get; set; }
        public Int16 habilitado { get; set; }

        public Recorrido(Int32 id, String codigo, String puertoDesde, String puertoHasta, Double precio_base, Int16 habilitado)
        {
            this.id = id;
            this.codigo = codigo;
            this.puertoDesde = puertoDesde;
            this.puertoHasta = puertoHasta;
            this.precio_base = precio_base;
            this.habilitado = habilitado;
        }
    }
}
