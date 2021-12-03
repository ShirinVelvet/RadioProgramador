using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioProgramador.model.poco {
	public class ProgramacionCancion {

		private int idProgramacionCancion;
		private int idProgramacion;
		private int posicion;
		private int idCancion;
		private bool modificado;

		public ProgramacionCancion(int idProgramacionCancion, int idProgramacion, int posicion, int idCancion, bool modificado) {
			this.idProgramacionCancion = idProgramacionCancion;
			this.idProgramacion = idProgramacion;
			this.posicion = posicion;
			this.idCancion = idCancion;
			this.modificado = modificado;
		}

		public int IdProgramacionCancion { get => idProgramacionCancion; set => idProgramacionCancion = value; }
		public int IdProgramacion { get => idProgramacion; set => idProgramacion = value; }
		public int Posicion { get => posicion; set => posicion = value; }
		public int IdCancion { get => idCancion; set => idCancion = value; }
		public bool Modificado { get => modificado; set => modificado = value; }
	}
}
