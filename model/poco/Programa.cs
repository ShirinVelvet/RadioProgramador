using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioProgramador.model.poco {
    public class Programa {

        private int idPrograma;
        private string nombre;
        private string clave;
        private int idEstacion;
        private bool activo;

        public int IdPrograma { get => idPrograma; set => idPrograma = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Clave { get => clave; set => clave = value; }
        public int IdEstacion { get => idEstacion; set => idEstacion = value; }
        public bool Activo { get => activo; set => activo = value; }
    }
}
