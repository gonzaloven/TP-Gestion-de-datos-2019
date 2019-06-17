using FrbaCrucero.Modelos;
using FrbaCrucero.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.ListadoEstadistico
{
    public partial class ListadoEstadisticoForm : Form
    {
        public ListadoEstadisticoForm()
        {
            InitializeComponent();
        }

        private void recMasComprados_Click(object sender, EventArgs e)
        {
            List<Top5> top5s = RepoTop5.instancia.EncontrarTop5RecorridosMasComprados(dateTimePicker1.Value);
            this.dataGridEstadistico.DataSource = top5s;
        }
    }
}
