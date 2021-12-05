using MySql.Data.MySqlClient;
using RadioProgramador.model.poco;
using RadioProgramador.tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioProgramador.model.dao {
	public static class ProgramaDAO {

		public static List<Programa> GetAll() {

			List<Programa> programas = new List<Programa>();
			MySqlConnection connection = Database.Conectar();

			try {

				connection.Open();

				string sql = "SELECT programas.id, clave, id_estacion, programas.nombre, activo, estaciones.nombre FROM programas" +
					" LEFT JOIN estaciones ON estaciones.id = id_estacion";
				MySqlCommand command = new MySqlCommand(sql, connection);

				MySqlDataReader reader = command.ExecuteReader();

				while (reader.Read()) {
					int id = !reader.IsDBNull(0) ? reader.GetInt32(0) : 0;
					string clave = !reader.IsDBNull(1) ? reader.GetString(1) : "";
					int idEstacion = !reader.IsDBNull(2) ? reader.GetInt32(2) : 0;
					string nombre = !reader.IsDBNull(3) ? reader.GetString(3) : "";
					bool activo = !reader.IsDBNull(4) ? reader.GetBoolean(4) : false;
					string estacion = !reader.IsDBNull(5) ? reader.GetString(5) : "";
					Programa programa = new Programa(id, nombre, clave, idEstacion, activo, estacion);
					programas.Add(programa);
				}

				reader.Close();

			} catch (Exception ex) {
				// Esto iría al log o algo así
				Console.WriteLine(ex.Message);
			}

			connection.Close();
			return programas;

		}

		public static List<ProgramaDia> GetDias(int idPrograma) {

			List<ProgramaDia> dias = new List<ProgramaDia>();
			MySqlConnection connection = Database.Conectar();

			try {

				connection.Open();

				string sql = "SELECT id, dia, hora_inicio, hora_final, id_patron" +
					" FROM programas_dias WHERE id_programa = @idPrograma";
				MySqlCommand command = new MySqlCommand(sql, connection);
				command.Prepare();
				command.Parameters.AddWithValue("@idPrograma", idPrograma);

				MySqlDataReader reader = command.ExecuteReader();

				while (reader.Read()) {
					int id = !reader.IsDBNull(0) ? reader.GetInt32(0) : 0;
					int dia = !reader.IsDBNull(1) ? reader.GetInt32(1) : 0;
					DateTime horaInicio = !reader.IsDBNull(2) ? reader.GetDateTime(2) : new DateTime();
					DateTime horaFinal = !reader.IsDBNull(3) ? reader.GetDateTime(3) : new DateTime();
					int idPatron = !reader.IsDBNull(3) ? reader.GetInt32(3) : 0;
					ProgramaDia programaDia = new ProgramaDia(id, idPrograma, dia, horaInicio, horaFinal, idPatron);
					dias.Add(programaDia);
				}

				reader.Close();

			} catch (Exception ex) {
				// Esto iría al log o algo así
				Console.WriteLine(ex.Message);
			}

			connection.Close();
			return dias;

		}

	}
}
