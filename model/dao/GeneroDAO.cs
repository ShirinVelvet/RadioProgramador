using System;
using System.Collections.Generic;
using RadioProgramador.model.poco;
using MySql.Data.MySqlClient;
using RadioProgramador.tools;

namespace RadioProgramador.model.dao {
	public static class GeneroDAO {

		public static List<Genero> GetAll() {

			List<Genero> generos = new List<Genero>();
			MySqlConnection connection = Database.Conectar();

			try {

				connection.Open();

				string sql = "SELECT id, nombre FROM generos";
				MySqlCommand command = new MySqlCommand(sql, connection);

				MySqlDataReader reader = command.ExecuteReader();

				while (reader.Read()) {
					int id = !reader.IsDBNull(0) ? reader.GetInt32(0) : 0;
					string nombre = !reader.IsDBNull(1) ? reader.GetString(1) : "";
					Genero genero = new Genero(id, nombre);
					generos.Add(genero);
				}

				reader.Close();

			} catch (Exception ex) {
				// Esto iría al log o algo así
				Console.WriteLine(ex.Message);
			}

			connection.Close();
			return generos;

		}

		public static bool GuardarGenero(Genero genero) {

			bool guardado = false;
			MySqlConnection connection = Database.Conectar();

			try {

				connection.Open();

				string sql = "INSERT INTO generos (nombre) VALUES (@nombre)";
				MySqlCommand command = new MySqlCommand(sql, connection);

				command.Parameters.AddWithValue("@nombre", genero.Nombre);
				command.Prepare();
				command.ExecuteNonQuery();

				guardado = true;

			} catch (Exception ex) {
				Console.WriteLine(ex.Message);
			}

			connection.Close();
			return guardado;
		}

		public static bool ModificarGenero(Genero genero) {

			bool guardado = false;
			MySqlConnection connection = Database.Conectar();

			try {

				connection.Open();

				string sql = "UPDATE generos SET nombre = @nombre WHERE id = @id";
				MySqlCommand command = new MySqlCommand(sql, connection);

				command.Parameters.AddWithValue("@nombre", genero.Nombre);
				command.Parameters.AddWithValue("@id", genero.IdGenero);
				command.Prepare();
				command.ExecuteNonQuery();

				guardado = true;

			} catch (Exception ex) {
				Console.WriteLine(ex.Message);
			}

			connection.Close();
			return guardado;
		}
	}
}
