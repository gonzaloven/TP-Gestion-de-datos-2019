using FrbaCrucero.Modelos;
using FrbaCrucero.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.ListadoEstadistico
{
    public class RecorridosConMasCabinas
    {
        public RecorridosConMasCabinasLibres RecorridosConMasCabinasLibres { get; set; }
        private RepoTop5 repo;

        public RecorridosConMasCabinas(RecorridosConMasCabinasLibres form)
        {
            RecorridosConMasCabinasLibres = form;
            repo = new RepoTop5("listado_estadistico");
        }

        internal void GetRecorridosConFiltros(string anioSeleccionado, string semestreSeleccionado)
        {
            semestreSeleccionado = semestreSeleccionado.Equals("Primer semestre") ? "1" : "2";
            List<ListadosEstadisticos> recorridos = repo.getRecorridosConMasCabinasLibres(anioSeleccionado, semestreSeleccionado);

            if (recorridos != null)
            {
                RecorridosConMasCabinasLibres.showRecorridos(recorridos);
            }
            else
            {
                RecorridosConMasCabinasLibres.showErrorMessage("No se pudieron encontrar recorridos que coincidan con su busqueda.");
            }

        }

        internal void GetAnios()
        {
            
            List<int> anios = repo.GetAniosRecorridosMasCabinasLibres();

            if (anios != null)
            {
                if (anios.Count > 0)
                {
                    List<string> aniosEnString = anios.ConvertAll<string>(delegate (int i) { return i.ToString(); });
                    RecorridosConMasCabinasLibres.initializeAnios(aniosEnString);
                }
                else
                {
                    RecorridosConMasCabinasLibres.showInformationMessage("No se pudieron encontrar años.");
                    RecorridosConMasCabinasLibres.Close();
                }
            }
            else
            {
                RecorridosConMasCabinasLibres.showErrorMessage("Ocurrió un error al buscar las fechas de consulta.");
                RecorridosConMasCabinasLibres.Close();
            }
        }

    }

}

