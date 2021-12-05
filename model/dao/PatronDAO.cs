using MySql.Data.MySqlClient;
using RadioProgramador.model.poco;
using RadioProgramador.tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioProgramador.model.dao {
	public static class PatronDAO {

		public static List<Patron> GetAll() {

			List<Patron> patrones = new List<Patron>();
			MySqlConnection connection = Database.Conectar();

			try {

				connection.Open();

				string sql = "SELECT patrones.id, patrones.nombre, id_estacion, estaciones.nombre FROM patrones" +
					" LEFT JOIN estaciones ON estaciones.id = patrones.id";
				MySqlCommand command = new MySqlCommand(sql, connection);

				MySqlDataReader reader = command.ExecuteReader();

				while (reader.Read()) {
					int id = !reader.IsDBNull(0) ? reader.GetInt32(0) : 0;
					string nombre = !reader.IsDBNull(1) ? reader.GetString(1) : "";
					int idEstacion = !reader.IsDBNull(2) ? reader.GetInt32(2) : 0;
					string estacion = !reader.IsDBNull(3) ? reader.GetString(3) : "";
					Patron patron = new Patron(id, nombre, idEstacion, estacion);
					patrones.Add(patron);
				}

				reader.Close();

			} catch (Exception ex) {
				// Esto iría al log o algo así
				Console.WriteLine(ex.Message);
			}

			connection.Close();
			return patrones;

		}

		public static List<PatronElemento> GetElementos(int idPatron) {

			List<PatronElemento> elementos = new List<PatronElemento>();
			MySqlConnection connection = Database.Conectar();

			try {

				connection.Open();

				string sql = "SELECT id, posicion, id_genero, id_categoria" +
					" FROM patrones_elementos WHERE id_patron = @idPatron";
				MySqlCommand command = new MySqlCommand(sql, connection);
				command.Prepare();
				command.Parameters.AddWithValue("@idPatron", idPatron);

				MySqlDataReader reader = command.ExecuteReader();

				while (reader.Read()) {
					int id = !reader.IsDBNull(0) ? reader.GetInt32(0) : 0;
					int posicion = !reader.IsDBNull(1) ? reader.GetInt32(1) : 0;
					int idGenero = !reader.IsDBNull(2) ? reader.GetInt32(2) : 0;
					int idCategoria = !reader.IsDBNull(3) ? reader.GetInt32(3) : 0;
					PatronElemento elemento = new PatronElemento(id, idPatron, posicion, idGenero, idCategoria);
					elementos.Add(elemento);
				}

				reader.Close();

			} catch (Exception ex) {
				// Esto iría al log o algo así
				Console.WriteLine(ex.Message);
			}

			connection.Close();
			return elementos;

		}

	}
}
