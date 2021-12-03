using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioProgramador.model.poco {
    public class Usuario {

        private int idUsuario;
        private string user;
        private int tipo;

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string User { get => user; set => user = value; }
        public int Tipo { get => tipo; set => tipo = value; }
    }
}
