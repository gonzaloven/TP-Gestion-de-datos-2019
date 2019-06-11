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

namespace FrbaCrucero.AbmRol
{
    public partial class RolForm : Form
    {
        private Rol rolOriginal;
        private Rol rolModificado;

        public RolForm()
        {
            InitializeComponent();
        }

        public RolForm(Rol rol)
        {
            InitializeComponent();
            this.rolOriginal = rol;
            this.rolModificado = rol;
            desactivarEditado(rol);
        }

        public void AgregarFuncionalidad(Funcionalidad funcionalidad)
        {
            rolModificado.AgregarFuncionalidad(funcionalidad);
            dataGridViewFuncionalidades.DataSource = rolModificado.GetFuncionalidades();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            buttonAceptar.Show();
            buttonCancelar.Show();
            buttonEliminarFunc.Show();
            buttonAgregarFunc.Show();
            textBoxDescripcion.Enabled = true;
            checkBoxHabilitado.Enabled = true;
            buttonEditar.Hide();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            rolModificado = rolOriginal;
            desactivarEditado(rolOriginal);
        }

        private void buttonAgregarFunc_Click(object sender, EventArgs e)
        {
            List<Funcionalidad> todasFunc = RepoFuncionalidad.instancia.EncontrarTodos();
            List<Funcionalidad> rolFun = rolModificado.GetFuncionalidades();
            List<Funcionalidad> faltantesFunc = todasFunc.Where(p => !rolFun.Any(l => p.id == l.id)).ToList();

            Form agregarFuncionalidad = new FormAgregarFuncionalidad(faltantesFunc, this);
            agregarFuncionalidad.MdiParent = this.MdiParent;
            agregarFuncionalidad.Show();
        }

        private void buttonEliminarFunc_Click(object sender, EventArgs e)
        {
            Funcionalidad funcionalidad = (Funcionalidad)dataGridViewFuncionalidades.CurrentRow.DataBoundItem;
            rolModificado.EliminarFuncionalidad(funcionalidad);
            refresDataGridView(rolModificado.GetFuncionalidades());
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            rolModificado.descripcion = textBoxDescripcion.Text;
            rolModificado.habilitado = (checkBoxHabilitado.Checked) ? Convert.ToInt16(1) : Convert.ToInt16(0);
            Dictionary<string, object> paramentrosAModificar = new Dictionary<string,object>();
            paramentrosAModificar.Add("descripcion", rolModificado.descripcion);
            paramentrosAModificar.Add("habilitado", rolModificado.habilitado);

            RepoRol.instancia.Modificar(rolModificado.id, paramentrosAModificar);
            this.Close();            
        }

        private void desactivarEditado(Rol rol)
        {
            buttonEditar.Show();
            buttonEditar.Show();
            buttonAceptar.Hide();
            buttonCancelar.Hide();
            buttonEliminarFunc.Hide();
            buttonAgregarFunc.Hide();
            textBoxDescripcion.Text = rol.descripcion;
            textBoxDescripcion.Enabled = false;
            checkBoxHabilitado.Checked = (rol.habilitado == 1) ? true : false;
            checkBoxHabilitado.Enabled = false;
            dataGridViewFuncionalidades.ReadOnly = true;
            dataGridViewFuncionalidades.DataSource = rol.GetFuncionalidades();
            dataGridViewFuncionalidades.Columns["id"].Visible = false;
            dataGridViewFuncionalidades.Columns["descripcion"].HeaderText = "Funcionalidad";
            dataGridViewFuncionalidades.MultiSelect = false;
        }



        private void RolForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool sePuedeCerrar = true;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Agregar Funcionalidad")
                {
                    sePuedeCerrar = false;
                    f.BringToFront();
                }
            }

            if (!sePuedeCerrar)
            {
                e.Cancel = true;
            }

        }

        private void refresDataGridView(List<Funcionalidad> funcionalidades)
        {
            dataGridViewFuncionalidades.DataSource = null;
            dataGridViewFuncionalidades.DataSource = funcionalidades;
            dataGridViewFuncionalidades.Columns["id"].Visible = false;
            dataGridViewFuncionalidades.Columns["descripcion"].HeaderText = "Funcionalidad";
            dataGridViewFuncionalidades.MultiSelect = false;
        }
    }
}
