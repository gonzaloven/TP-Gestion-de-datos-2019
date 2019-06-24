using FrbaCrucero.Modelos;
using FrbaCrucero.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.ListadoEstadistico
{
    public class CrucerosSinServicio
    {
        public CrucerosConMasDiasSinServicio CrucerosConMasDiasSinServicio { get; set; }

        public CrucerosSinServicio(CrucerosConMasDiasSinServicio form)
        {
            CrucerosConMasDiasSinServicio = form;
        }

        internal void GetCrucerosConFiltros(string anioSeleccionado, string semestreSeleccionado)
        {
            semestreSeleccionado = semestreSeleccionado.Equals("Primer semestre") ? "1" : "2";
            RepoTop5 repo = new RepoTop5("listado_estadistico");
            List<ListadosEstadisticos> cruceros = repo.getCrucerosConMasDiasFueraDeServicio(anioSeleccionado, semestreSeleccionado);

            if (cruceros != null)
            {
                CrucerosConMasDiasSinServicio.showRecorridos(cruceros);
            }
            else
            {
                CrucerosConMasDiasSinServicio.showErrorMessage("No se pudieron encontrar cruceros que coincidan con su busqueda.");
            }

        }

    }
}

