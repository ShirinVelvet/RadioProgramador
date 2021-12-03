using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioProgramador.model.poco
{
	public class Categoria {

		private int idCategoria;
		private string nombre;

		public Categoria(int idCategoria, string nombre) {
			this.idCategoria = idCategoria;
			this.nombre = nombre;
		}

		public int IdCategoria { get => idCategoria; set => idCategoria = value; }
		public string Nombre { get => nombre; set => nombre = value; }

		public override string ToString() {
			return nombre;
		}
	}
}
