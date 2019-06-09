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

namespace FrbaCrucero
{
    public partial class MenuPrincipal : Form
    {
        ListadoDeRoles listadoRoles;

        public MenuPrincipal()
        {
            InitializeComponent();
            this.listadoRoles = new ListadoDeRoles();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripLabel2_Click_1(object sender, EventArgs e)
        {
            listadoRoles.Show();
        }
    }
}
