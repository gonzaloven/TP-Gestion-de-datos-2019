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

        public RecorridosConMasCabinas(RecorridosConMasCabinasLibres form)
        {
            RecorridosConMasCabinasLibres = form;
        }

        internal void GetRecorridosConFiltros(string anioSeleccionado, string semestreSeleccionado)
        {
            semestreSeleccionado = semestreSeleccionado.Equals("Primer semestre") ? "1" : "2";
            RepoTop5 repo = new RepoTop5("listado_estadistico");
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

    }

}

