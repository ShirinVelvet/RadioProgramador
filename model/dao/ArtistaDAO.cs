using MySql.Data.MySqlClient;
using RadioProgramador.model.poco;
using RadioProgramador.tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioProgramador.model.dao {
	public static class ArtistaDAO {

		public static List<Artista> GetAll() {

			List<Artista> artistas = new List<Artista>();
			MySqlConnection connection = Database.Conectar();

			try {
				
				connection.Open();

				string sql = "SELECT id, nombre FROM artistas";
				MySqlCommand command = new MySqlCommand(sql, connection);

				MySqlDataReader reader = command.ExecuteReader();

				while(reader.Read()) {
					int id = !reader.IsDBNull(0) ? reader.GetInt32(0) : 0;
					string nombre = !reader.IsDBNull(1) ? reader.GetString(1) : "";
					Artista artista = new Artista(id, nombre);
					artistas.Add(artista);
				}

				reader.Close();

			} catch (Exception ex) {
				// Esto iría al log o algo así
				Console.WriteLine(ex.Message);
			}

			connection.Close();
			return artistas;

		}

	}
}
