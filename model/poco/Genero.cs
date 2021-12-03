using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioProgramador.model.poco {
	public class Genero {

		private int idGenero;
		private string nombre;

		public Genero(int idGenero, string nombre) {
			this.idGenero = idGenero;
			this.nombre = nombre;
		}

		public int IdGenero { get => idGenero; set => idGenero = value; }
		public string Nombre { get => nombre; set => nombre = value; }

		public override string ToString() {
			return nombre;
		}
	}
}
