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

        private ListadoEstadisticoForm form;
        private RepoTop5 repo;

        public ListadoEstadisticoForm Form
        {
            get { return form; }
            set { form = value; }
        }

        

        public RecorridosConMasPasajes(ListadoEstadisticoForm form)
        {
            Form = form;
            repo = new RepoTop5("listado_estadistico");
        }

        internal void GetRecorridosConFiltros(string anioSeleccionado, string semestreSeleccionado)
        {
            semestreSeleccionado = semestreSeleccionado.Equals("Primer semestre") ? "1" : "2";
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

        internal void GetAnios()
        {
            
            List<int> anios = repo.GetAniosRecorridosMasComprados();

            if (anios != null)
            {
                if(anios.Count > 0)
                {
                    List<string> aniosEnString = anios.ConvertAll<string>(delegate (int i) { return i.ToString(); });
                    this.form.initializeAnios(aniosEnString);
                }
                else
                {
                    this.form.showInformationMessage("No se pudieron encontrar años.");
                    this.form.Close();
                }
            }
            else
            {
                this.form.showErrorMessage("Ocurrió un error al buscar las fechas de consulta.");
                this.form.Close();
            }
        }

    }
}
