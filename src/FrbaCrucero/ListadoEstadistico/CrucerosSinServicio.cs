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
        public ListadoEstadisticoForm CrucerosConMasDiasSinServicio { get; set; }
        private RepoTop5 repo;

        public CrucerosSinServicio(ListadoEstadisticoForm form)
        {
            CrucerosConMasDiasSinServicio = form;
            repo = new RepoTop5("listado_estadistico");
        }

        internal void GetCrucerosConFiltros(string anioSeleccionado, string semestreSeleccionado)
        {
            semestreSeleccionado = semestreSeleccionado.Equals("Primer semestre") ? "1" : "2";
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

        internal void GetAnios()
        {

            List<int> anios = repo.GetAniosCrucerosMasDiasFueraServicio();

            if (anios != null)
            {
                if (anios.Count > 0)
                {
                    List<string> aniosEnString = anios.ConvertAll<string>(delegate (int i) { return i.ToString(); });
                    CrucerosConMasDiasSinServicio.initializeAnios(aniosEnString);
                }
                else
                {
                    CrucerosConMasDiasSinServicio.showInformationMessage("No se pudieron encontrar años.");
                    CrucerosConMasDiasSinServicio.Close();
                }
            }
            else
            {
                CrucerosConMasDiasSinServicio.showErrorMessage("Ocurrió un error al buscar las fechas de consulta.");
                CrucerosConMasDiasSinServicio.Close();
            }
        }

    }
}

