using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioProgramador.model.poco {
    public class Estacion {

        private int idEstacion;
        private string nombre;
        private string frecuencia;

        public int IdEstacion { get => idEstacion; set => idEstacion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Frecuencia { get => frecuencia; set => frecuencia = value; }
    }
}
