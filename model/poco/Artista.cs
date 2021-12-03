using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioProgramador.model.poco
{
	public class Artista {

		private int idArtista;
		private string nombre;

		public Artista(int idArtista, string nombre) {
			this.idArtista = idArtista;
			this.nombre = nombre;
		}

		public int IdArtista { get => idArtista; set => idArtista = value; }
		public string Nombre { get => nombre; set => nombre = value; }

		public override string ToString() {
			return nombre;
		}
	}
}
