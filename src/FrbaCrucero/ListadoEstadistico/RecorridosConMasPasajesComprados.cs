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
    public partial class RecorridosConMasPasajesComprados : Form
    {

        private List<string> semestres = new List<string> { "Seleccione semestre", "Primer semestre", "Segundo semestre" };

        public RecorridosConMasPasajesComprados()
        {
            InitializeComponent();
        }

        private void initialize() {
            this.comboSemestre.Enabled = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

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
            }
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

        private void showErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void limpiarButton_Click(object sender, EventArgs e)
        {
            comboAnio.SelectedItem = comboAnio.Items[0];
            comboSemestre.Enabled = false;
            resultadosTop5Grid.DataSource = null;
        }

    }
}
