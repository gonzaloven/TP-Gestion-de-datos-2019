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
        DataTable tablaTotal = new DataTable();
        public AgregarRecorrido()
        {
            InitializeComponent();
            Repositorios.RepoTramo.instancia.llenarDatos(dataGridViewTramosTotales);
            tablaTotal.Columns.Add("id", typeof(Int32));
            tablaTotal.Columns.Add("puertoDesde", typeof(String));
            tablaTotal.Columns.Add("puertoHasta", typeof(String));
            tablaTotal.Columns.Add("precio_base", typeof(Double));
            dataGridViewTramosActuales.DataSource = tablaTotal;
        }

        private void dataGridViewTramosTotales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DataGridViewRow fila = dataGridViewTramosTotales.CurrentRow;
                this.agregarTramo(fila);
            }
        }

        private void agregarTramo(DataGridViewRow fila)
        {
           var datarow = ((DataRowView)fila.DataBoundItem).Row;
           tablaTotal.Rows.Add(datarow.ItemArray);
        }


    }
}
