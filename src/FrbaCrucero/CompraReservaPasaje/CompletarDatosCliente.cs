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
            textBoxNombre.ReadOnly = true;
            textBoxApellido.ReadOnly = true;
            textBoxDireccion.ReadOnly = true;
            textBoxTelefono.ReadOnly = true;
            textBoxFechaNacimiento.ReadOnly = true;
            textBoxMail.ReadOnly = true;
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {

        }
    }
}
