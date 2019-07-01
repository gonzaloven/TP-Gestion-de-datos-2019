using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Modelos
{
    class Cabina
    {
        Int32 codigo { get; set; }
        Crucero crucero { get; set; }
        Int32 numero { get; set; }
        Int32 piso { get; set; }
        TipoCabina tipoCabina { get; set; }
        Int16 estado { get; set; }

        public Cabina(Int32 codigo, Crucero crucero, Int32 numero, Int32 piso, TipoCabina tipoCabina, Int16 estado)
        {
            this.codigo = codigo;
            this.crucero = crucero;
            this.numero = numero;
            this.piso = piso;
            this.tipoCabina = tipoCabina;
            this.estado = estado;
        }

    }
}
