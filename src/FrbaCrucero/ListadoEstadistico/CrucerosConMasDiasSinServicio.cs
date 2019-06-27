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

namespace FrbaCrucero.ListadoEstadistico
{
    public partial class CrucerosConMasDiasSinServicio : Form
    {
        private List<string> semestres = new List<string> { "Seleccione un semestre", "Primer semestre", "Segundo semestre" };

        private CrucerosSinServicio crucerosSinServicio;

        public CrucerosConMasDiasSinServicio()
        {
            this.crucerosSinServicio = new CrucerosSinServicio(this);
            InitializeComponent();
            this.Shown += (s, e1) =>
            {
                this.crucerosSinServicio.GetAnios();
                this.initialize();
            };
        }

        private void initialize()
        {
            this.comboSemestre.Enabled = true;
            this.comboAnio.Enabled = true;
        }

        private void buscarButton_Click(object sender, EventArgs e)
        {
            string semestre = (string)comboSemestre.SelectedItem;
            string anio = (string)comboAnio.SelectedItem;
            if (anio.Equals("Seleccione un año") || semestre.Equals("Seleccione un semestre"))
            {
                showErrorMessage("Seleccione los filtros correctamente.");
            }
            else
            {
                buscarButton.Enabled = false;
                limpiarButton.Enabled = false;
                resultadosTop5Grid.DataSource = null;
                comboAnio.Enabled = false;
                comboSemestre.Enabled = false;
                this.crucerosSinServicio.GetCrucerosConFiltros(anio, semestre);
            }
        }

        public void showErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void showInformationMessage(string message)
        {
            MessageBox.Show(message, "Informacion",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void showRecorridos(List<ListadosEstadisticos> cruceros)
        {
            this.buscarButton.Enabled = true;
            this.limpiarButton.Enabled = true;
            this.comboAnio.Enabled = true;
            this.comboSemestre.Enabled = true;

            this.resultadosTop5Grid.DataSource = cruceros.Select(
                crucero => new
                {
                    Nombre = crucero.PrimeraColumna,
                    Modelo = crucero.SegundaColumna,
                    DiasFueraDeServicio = crucero.TerceraColumna
                }
            ).ToList();
        }

        private void limpiarButton_Click(object sender, EventArgs e)
        {
            comboAnio.SelectedItem = comboAnio.Items[0];
            comboSemestre.Enabled = false;
            resultadosTop5Grid.DataSource = null;
        }

        private void comboAnio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboAnio.SelectedIndex > 0)
            {
                comboSemestre.Enabled = true;
                comboSemestre.DataSource = semestres;
            }
            else
            {
                comboSemestre.DataSource = null;
                comboSemestre.Enabled = false;
            }
        }

        public void initializeAnios(List<string> anios)
        {
            anios.Insert(0, "Seleccione un año");
            comboAnio.DataSource = anios;
        }
    }
}