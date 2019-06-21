using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.AbmRecorrido
{
    public partial class AgregarRecorrido : Form
    {
        public AgregarRecorrido()
        {
            InitializeComponent();
            Repositorios.RepoTramo.instancia.llenarDatos(dataGridViewTramosTotales);
        }
    }
}
