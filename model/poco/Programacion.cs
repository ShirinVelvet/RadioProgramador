using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioProgramador.model.poco {
	public class Programacion {

		private int idProgramacion;
		private int idEstacion;
		private DateTime fecha;
		private int idPrograma;
		private List<ProgramacionCancion> programacionCanciones = new List<ProgramacionCancion>();

		public Programacion(int idProgramacion, int idEstacion, DateTime fecha, int idPrograma, List<ProgramacionCancion> programacionCanciones) {
			this.idProgramacion = idProgramacion;
			this.idEstacion = idEstacion;
			this.fecha = fecha;
			this.idPrograma = idPrograma;
			this.programacionCanciones = programacionCanciones;
		}

		public int IdProgramacion { get => idProgramacion; set => idProgramacion = value; }
		public int IdEstacion { get => idEstacion; set => idEstacion = value; }
		public DateTime Fecha { get => fecha; set => fecha = value; }
		public int IdPrograma { get => idPrograma; set => idPrograma = value; }
		public List<ProgramacionCancion> ProgramacionCanciones { get => programacionCanciones; set => programacionCanciones = value; }
	}
}
