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

namespace FrbaCrucero.GeneracionViaje
{
    public partial class SeleccionarPuerto : Form
    {
        FormGenerarViaje form;
        TextBox textBoxParam;

        public SeleccionarPuerto(FormGenerarViaje form, TextBox textBoxParam)
        {
            InitializeComponent();
            this.form = form;
            this.textBoxParam = textBoxParam;
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxPuerto.Text = null;
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            string descripcionPuerto = textBoxPuerto.Text;
            List<Puerto> puertos = RepoPuerto.instancia.EncontrarPorDescripcionPuerto(descripcionPuerto);
            dataGridViewPuertos.DataSource = puertos;
        }

        private void dataGridViewPuertos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
                form.textBoxParam.Text = dataGridViewPuertos[2,e.RowIndex].Value.ToString();
        }

    }
}
