using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioProgramador.model.poco {
	public class ProgramaDia {

		private int idProgramaDia;
		private int idPrograma;
		private int dia;
		private DateTime horaInicio;
		private DateTime horaFinal;
		private int idPatron;

		public ProgramaDia(int idProgramaDia, int idPrograma, int dia, DateTime horaInicio, DateTime horaFinal, int idPatron) {
			this.idProgramaDia = idProgramaDia;
			this.idPrograma = idPrograma;
			this.dia = dia;
			this.horaInicio = horaInicio;
			this.horaFinal = horaFinal;
			this.idPatron = idPatron;
		}

		public int IdProgramaDia { get => idProgramaDia; set => idProgramaDia = value; }
		public int IdPrograma { get => idPrograma; set => idPrograma = value; }
		public int Dia { get => dia; set => dia = value; }
		public DateTime HoraInicio { get => horaInicio; set => horaInicio = value; }
		public DateTime HoraFinal { get => horaFinal; set => horaFinal = value; }
		public int IdPatron { get => idPatron; set => idPatron = value; }
	}
}
