using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioProgramador.model.poco {
    public class Genero {

        private int idGenero;
        private string nombre;

        public int IdGenero { get => idGenero; set => idGenero = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
