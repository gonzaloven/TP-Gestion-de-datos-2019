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
using FrbaCrucero.Modelos;

namespace FrbaCrucero
{
    public partial class MenuPrincipalForm : Form
    {


        public MenuPrincipalForm(Rol rol)
        {
            InitializeComponent();
            mostrarMenuPrincipalPorRol(rol);
        }

        public MenuPrincipalForm()
        {
            InitializeComponent();
            mostrarMenuPrincipalCliente();
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

        private void mostrarMenuPrincipalPorRol(Rol rol)
        {
            Dictionary<string, ToolStripLabel> funcLabelBarra = new Dictionary<string, ToolStripLabel>();
            funcLabelBarra.Add("ABM Roles", toolStripLabelABM);
            funcLabelBarra.Add("ABM Recorridos", toolStripLabelRecorrido);
           
            foreach (Funcionalidad func in rol.GetFuncionalidades())
                if (!funcLabelBarra.ContainsKey(func.descripcion))
                {
                    funcLabelBarra[func.descripcion].Visible = false;
                }
        }

        private void mostrarMenuPrincipalCliente()
        {
            toolStripLabelABM.Visible = false;
            toolStripLabelRecorrido.Visible = false;
        }
    }
}
