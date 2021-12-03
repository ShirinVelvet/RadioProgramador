using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioProgramador.model.poco {
	public class PatronElemento {

		private int idPatronElemento;
		private int idPatron;
		private int posicion;
		private int idGenero;
		private int idCategoria;

		public PatronElemento(int idPatronElemento, int idPatron, int posicion, int idGenero, int idCategoria) {
			this.idPatronElemento = idPatronElemento;
			this.idPatron = idPatron;
			this.posicion = posicion;
			this.idGenero = idGenero;
			this.idCategoria = idCategoria;
		}

		public int IdPatronElemento { get => idPatronElemento; set => idPatronElemento = value; }
		public int IdPatron { get => idPatron; set => idPatron = value; }
		public int Posicion { get => posicion; set => posicion = value; }
		public int IdGenero { get => idGenero; set => idGenero = value; }
		public int IdCategoria { get => idCategoria; set => idCategoria = value; }
	}
}
