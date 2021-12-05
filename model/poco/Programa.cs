using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioProgramador.model.poco {
	public class Programa {

		private int idPrograma;
		private string nombre;
		private string clave;
		private int idEstacion;
		private string estacion;
		private bool activo;
		private List<ProgramaDia> dias = new List<ProgramaDia>();

		public Programa(int idPrograma, string nombre, string clave, int idEstacion, bool activo, string estacion) {
			this.idPrograma = idPrograma;
			this.nombre = nombre;
			this.clave = clave;
			this.idEstacion = idEstacion;
			this.activo = activo;
			this.estacion = estacion;
		}

		public int IdPrograma { get => idPrograma; set => idPrograma = value; }
		public string Nombre { get => nombre; set => nombre = value; }
		public string Clave { get => clave; set => clave = value; }
		public int IdEstacion { get => idEstacion; set => idEstacion = value; }
		public bool Activo { get => activo; set => activo = value; }
		public List<ProgramaDia> Dias { get => dias; set => dias = value; }
		public string Estacion { get => estacion; set => estacion = value; }

		public override string ToString() {
			return nombre;
		}
	}
}
