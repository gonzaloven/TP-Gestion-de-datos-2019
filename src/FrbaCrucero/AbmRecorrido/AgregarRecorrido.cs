﻿using FrbaCrucero.Modelos;
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
        ListadoRecorridoForm listadoRecorridos;
        public AgregarRecorrido(ListadoRecorridoForm listadoRecorridos)
        {
            InitializeComponent();
            this.listadoRecorridos = listadoRecorridos;
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

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            String codigo = textBoxCodigo.Text;
            Int32 idPuertoDesde = Int32.Parse(dataGridViewTramosActuales[2, 0].Value.ToString());
            Int32 indiceUltimaFila = dataGridViewTramosActuales.Rows.Count - 1;
            Int32 idPuertoHasta = Int32.Parse(dataGridViewTramosActuales[3, indiceUltimaFila].Value.ToString());

            CrearRecorrido nuevoRecorrido = new CrearRecorrido(codigo, idPuertoDesde, idPuertoHasta);
            Int32 idRecorridoCreado = nuevoRecorrido.Crear();

            foreach (DataGridViewRow fila in dataGridViewTramosActuales.Rows)
            {
                Int32 idTramo = Int32.Parse(fila.Cells[1].Value.ToString());
                CrearRecorridoXTramo crearNuevoRecorridoXTramo = new CrearRecorridoXTramo(idRecorridoCreado, idTramo);
                crearNuevoRecorridoXTramo.Crear();
            }

            MessageBox.Show("Se ha ingresado el recorrido con exito.", "Exito",
                                MessageBoxButtons.OK, MessageBoxIcon.None);
            this.Close();
            listadoRecorridos.Buscar();
        }

    }
}
