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
            RepoRecorridosConMasPasajes repo = new RepoRecorridosConMasPasajes("recorridos_con_mas_pasajes");
            List<RecorridosConMasPasajesAux> recorridos = repo.getRecorridosConMasCompras(anioSeleccionado, semestreSeleccionado);

            if (recorridos != null)
            {
                this.form.showRecorridos(recorridos);
            }
            else
            {
                this.form.showErrorMessage("No se pudieron encontrar afiliados que coincidan con su busqueda.");
            }

        }

    }

    public class RecorridosConMasPasajesAux
    {
        public string PuertoSalida { get; set; }
        public string PuertoLlegada { get; set; }
        public int CantidadVendida { get; set; }
    }
}
