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
                Repositorios.RepoTramo.instancia.actualizarDatosAgregar(dataGridViewTramosTotales, fila.Cells[3].Value.ToString());
            }
        }

        private void dataGridViewTramosActuales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DataGridViewRow fila = dataGridViewTramosActuales.CurrentRow;
                if (tablaTotal.Rows.Count == 1)
                    Repositorios.RepoTramo.instancia.llenarDatos(dataGridViewTramosTotales);
                else
                    Repositorios.RepoTramo.instancia.actualizarDatosQuitar(dataGridViewTramosTotales, fila.Cells[2].Value.ToString());
                this.quitarTramo(fila);
            }
        }

        private void agregarTramo(DataGridViewRow fila)
        {
           var datarow = ((DataRowView)fila.DataBoundItem).Row;
           tablaTotal.Rows.Add(datarow.ItemArray);
        }

        private void quitarTramo(DataGridViewRow fila)
        {
            var datarow = ((DataRowView)fila.DataBoundItem).Row;
            tablaTotal.Rows.Remove(datarow);
        }

    }
}
