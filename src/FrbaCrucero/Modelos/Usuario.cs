using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Modelos
{
    class Usuario
    {
        public Int32 id { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public Int16 intentosFallidos { get; set; }
        public Int16 habilitado { get; set; }

        public Usuario(Int32 id, string userName, string password, Int16 intentosFallidos, Int16 habilitado)
        {
            this.id = id;
            this.userName = userName;
            this.password = password;
            this.intentosFallidos = intentosFallidos;
            this.habilitado = habilitado;
        }

        public void Deshabilitar()
        {
            habilitado = 0;
        }

        public void AumentarIntentoFallido()
        {
            intentosFallidos += intentosFallidos;

            if (intentosFallidos == 3)
            {
                Deshabilitar();
            }
        }

        public void refrescarIntento()
        {
            intentosFallidos = 0;
        }



    }
}
