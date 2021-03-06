﻿using FrbaCrucero.Modelos;
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

namespace FrbaCrucero.CompraPasaje
{
    public partial class SeleccionarPuerto : Form
    {
        TextBox textBoxParam;

        public SeleccionarPuerto(TextBox textBoxParam)
        {
            InitializeComponent();
            this.textBoxParam = textBoxParam;
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxPuerto.Text = null;
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            string descripcionPuerto = (!String.IsNullOrEmpty(textBoxPuerto.Text)) ? textBoxPuerto.Text.Trim() : "";
            List<Puerto> puertos = RepoPuerto.instancia.EncontrarPorDescripcionPuerto(descripcionPuerto);
            dataGridViewPuertos.DataSource = puertos;
            dataGridViewPuertos.Columns["id"].Visible = false;
            dataGridViewPuertos.Columns["descripcion"].HeaderText = "Nombre del puerto";
        }

        private void dataGridViewPuertos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
                textBoxParam.Text = dataGridViewPuertos[1, e.RowIndex].Value.ToString();
            this.Close();
        }

    }
}
