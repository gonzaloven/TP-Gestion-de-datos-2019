using FrbaCrucero.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.CompraReservaPasaje
{
    public partial class CompletarDatosCliente : Form
    {
        CrearPasaje pasaje;
        public CompletarDatosCliente(CrearPasaje pasaje)
        {
            InitializeComponent();
            this.pasaje = pasaje;
        }
    }
}
