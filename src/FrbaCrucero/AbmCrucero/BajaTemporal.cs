using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.AbmCrucero
{
    public partial class BajaTemporal : Form
    {
        public BajaCrucero formBajaCrucero;
        public Int32 id;
        public BajaTemporal(BajaCrucero formBajaCrucero, Int32 id)
        {
            InitializeComponent();
            this.formBajaCrucero = formBajaCrucero;
            this.id = id;
            this.textBoxFechaReinicioServicio.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CancelarPasajesOReprogramar cancelarPasajesOReprogramar = new CancelarPasajesOReprogramar(this, id);
            cancelarPasajesOReprogramar.Show();
        }

        private void buttonSeleccionar_Click(object sender, EventArgs e)
        {
            SeleccionarFecha seleccionarFecha = new SeleccionarFecha(textBoxFechaReinicioServicio);
            seleccionarFecha.Show();
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
