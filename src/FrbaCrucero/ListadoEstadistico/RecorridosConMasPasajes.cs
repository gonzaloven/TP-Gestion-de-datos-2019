using FrbaCrucero.Modelos;
using FrbaCrucero.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.ListadoEstadistico
{
    public class RecorridosConMasPasajes
    {

        private RecorridosConMasPasajesComprados form;

        public RecorridosConMasPasajesComprados Form
        {
            get { return form; }
            set { form = value; }
        }

        

        public RecorridosConMasPasajes(RecorridosConMasPasajesComprados form)
        {
            Form = form;
        }

        internal void GetRecorridosConFiltros(string anioSeleccionado, string semestreSeleccionado)
        {
            semestreSeleccionado = semestreSeleccionado.Equals("Primer semestre") ? "1" : "2";
            RepoTop5 repo = new RepoTop5("listado_estadistico");
            List<ListadosEstadisticos> recorridos = repo.getRecorridosConPasajesMasComprados(anioSeleccionado, semestreSeleccionado);

            if (recorridos != null)
            {
                this.form.showRecorridos(recorridos);
            }
            else
            {
                this.form.showErrorMessage("No se pudieron encontrar recorridos que coincidan con su busqueda.");
            }

        }

    }
}
