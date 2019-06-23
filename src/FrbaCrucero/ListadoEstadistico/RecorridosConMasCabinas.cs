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
            RepoRecorridosConMasCabinas repo = new RepoRecorridosConMasCabinas("recorridos_con_mas_cabinas");
            List<RecorridosConMasCabinasAux> recorridos = repo.getRecorridosConMasCompras(anioSeleccionado, semestreSeleccionado);

            if (recorridos != null)
            {
                RecorridosConMasCabinasLibres.showRecorridos(recorridos);
            }
            else
            {
                RecorridosConMasCabinasLibres.showErrorMessage("No se pudieron encontrar afiliados que coincidan con su busqueda.");
            }

        }

    }

    public class RecorridosConMasCabinasAux
    {
        public string PuertoSalida { get; set; }
        public string PuertoLlegada { get; set; }
        public int CantidadCabinas { get; set; }
    }
}

