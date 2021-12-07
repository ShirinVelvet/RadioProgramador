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

		public static bool GuardarArtista(Artista artista) {

			bool guardado = false;
			MySqlConnection connection = Database.Conectar();

			try {

				connection.Open();

				string sql = "INSERT INTO artistas (nombre) VALUES (@nombre)";
				MySqlCommand command = new MySqlCommand(sql, connection);

				command.Parameters.AddWithValue("@nombre", artista.Nombre);
				command.Prepare();
				command.ExecuteNonQuery();

				guardado = true;

			} catch (Exception ex) {
				Console.WriteLine(ex.Message);
			}

			connection.Close();
			return guardado;
		}

		public static bool ModificarArtista(Artista artista) {

			bool guardado = false;
			MySqlConnection connection = Database.Conectar();

			try {

				connection.Open();

				string sql = "UPDATE artistas SET nombre = @nombre WHERE id = @id";
				MySqlCommand command = new MySqlCommand(sql, connection);

				command.Parameters.AddWithValue("@nombre", artista.Nombre);
				command.Parameters.AddWithValue("@id", artista.IdArtista);
				command.Prepare();
				command.ExecuteNonQuery();

				guardado = true;

			} catch (Exception ex) {
				Console.WriteLine(ex.Message);
			}

			connection.Close();
			return guardado;
		}

		public static bool EliminarArtista(int id) {

			bool eliminado = false;
			MySqlConnection connection = Database.Conectar();

			try {

				connection.Open();

				string sql = "DELETE FROM artistas WHERE id = @id";
				MySqlCommand command = new MySqlCommand(sql, connection);
				command.Parameters.AddWithValue("@id", id);
				command.Prepare();
				command.ExecuteNonQuery();

				eliminado = true;

			} catch (Exception ex) {
				Console.WriteLine(ex.Message);
			}

			connection.Close();
			return eliminado;

		}

	}
}
