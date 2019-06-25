using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaCrucero.AbmRol;
using FrbaCrucero.AbmRecorrido;
using FrbaCrucero.GeneracionViaje;
using FrbaCrucero.AbmCrucero;
using FrbaCrucero.ListadoEstadistico;
using FrbaCrucero.CompraPasaje;

namespace FrbaCrucero
{
    public partial class MenuPrincipal : Form
    {

        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripLabel2_Click_1(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            ListadoRolesForm listadoRoles = new ListadoRolesForm();
            listadoRoles.MdiParent = this;
            listadoRoles.Show();
        }

        private void toolStripLabelRecorrido_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            ListadoRecorridoForm listadoRecorrido = new ListadoRecorridoForm();
            listadoRecorrido.MdiParent = this;
            listadoRecorrido.Show();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            FormGenerarViaje generarViaje = new FormGenerarViaje();
            generarViaje.MdiParent = this;
            generarViaje.Show();
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            ListadoCrucerosForm listadoCruceros = new ListadoCrucerosForm();
            listadoCruceros.MdiParent = this;
            listadoCruceros.Show();
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            ListadoEstadisticoForm listadoEstadistico = new ListadoEstadisticoForm();
            listadoEstadistico.MdiParent = this;
            listadoEstadistico.Show();
        }

        private void toolStripLabel5_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            CompraReservaPasaje compraReservaPasaje = new CompraReservaPasaje();
            compraReservaPasaje.MdiParent = this;
            compraReservaPasaje.Show();
        }

    }
}
