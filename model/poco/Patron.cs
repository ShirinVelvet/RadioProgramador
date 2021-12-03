using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioProgramador.model.poco {
	public class Patron {

		private int idPatron;
		private string nombre;
		private int idEstacion;
		private List<PatronElemento> elementos = new List<PatronElemento>();

		public Patron(int idPatron, string nombre, int idEstacion, List<PatronElemento> elementos) {
			this.idPatron = idPatron;
			this.nombre = nombre;
			this.idEstacion = idEstacion;
			this.elementos = elementos;
		}

		public int IdPatron { get => idPatron; set => idPatron = value; }
		public string Nombre { get => nombre; set => nombre = value; }
		public int IdEstacion { get => idEstacion; set => idEstacion = value; }
		public List<PatronElemento> Elementos { get => elementos; set => elementos = value; }

		public override string ToString() {
			return nombre;
		}
	}
}
