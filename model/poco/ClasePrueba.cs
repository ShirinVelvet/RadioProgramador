using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioProgramador.model.poco {
	class ClasePrueba {

		private string nombre;
		private int valor;
		private static List<string> listaOpciones = new List<string>{
			"Oh sí",
			"Oh no",
			"Oh cielos"};

		public ClasePrueba(string nombre, int valor) {
			this.nombre = nombre;
			this.valor = valor;
		}

		public string Nombre { get => nombre; set => nombre = value; }
		public int Valor { get => valor; set => valor = value; }
		public static List<string> ListaOpciones { get => listaOpciones; set => listaOpciones = value; }
	}
}
