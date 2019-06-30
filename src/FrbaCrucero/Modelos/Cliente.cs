using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Modelos
{
    class Cliente
    {
        public Int32 id { get; set; }
        public String nombre { get; set; }
        public String apellido { get; set; }
        public Int32 dni { get; set; }
        public String direccion { get; set; }
        public Int32 telefono { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public String mail { get; set; }

        public Cliente(Int32 id, String nombre, String apellido, Int32 dni, String direccion, Int32 telefono,
            DateTime fechaNacimiento, String mail)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.direccion = direccion;
            this.telefono = telefono;
            this.fechaNacimiento = fechaNacimiento;
        }

    }
}
