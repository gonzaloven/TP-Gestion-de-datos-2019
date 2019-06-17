using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.AbmCrucero
{
    public partial class SeleccionarFecha : Form
    {
        ModificarCrucero form;
        TextBox textBoxParam;

        public SeleccionarFecha(ModificarCrucero form, TextBox textBoxParam)
        {
            InitializeComponent();
            this.form = form;
            this.textBoxParam = textBoxParam;
        }
    }
}
