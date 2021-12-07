using System;
using System.Collections.Generic;
using RadioProgramador.model.poco;
using MySql.Data.MySqlClient;
using RadioProgramador.tools;


namespace RadioProgramador.model.dao {
	public static class CategoriaDAO {

		public static List<Categoria> GetAll() {

			List<Categoria> categorias = new List<Categoria>();
			MySqlConnection connection = Database.Conectar();

			try {

				connection.Open();

				string sql = "SELECT id, nombre FROM categorias";
				MySqlCommand command = new MySqlCommand(sql, connection);

				MySqlDataReader reader = command.ExecuteReader();

				while (reader.Read()) {
					int id = !reader.IsDBNull(0) ? reader.GetInt32(0) : 0;
					string nombre = !reader.IsDBNull(1) ? reader.GetString(1) : "";
					Categoria categoria = new Categoria(id, nombre);
					categorias.Add(categoria);
				}

				reader.Close();

			} catch (Exception ex) {
				// Esto iría al log o algo así
				Console.WriteLine(ex.Message);
			}

			connection.Close();
			return categorias;
		}

		public static bool GuardarCategoria(Categoria categoria) {

			bool guardado = false;
			MySqlConnection connection = Database.Conectar();

			try {

				connection.Open();

				string sql = "INSERT INTO categorias (nombre) VALUES (@nombre)";
				MySqlCommand command = new MySqlCommand(sql, connection);

				command.Parameters.AddWithValue("@nombre", categoria.Nombre);
				command.Prepare();
				command.ExecuteNonQuery();

				guardado = true;

			} catch (Exception ex) {
				Console.WriteLine(ex.Message);
			}

			connection.Close();
			return guardado;
		}

		public static bool ModificarCategoria(Categoria categoria) {

			bool guardado = false;
			MySqlConnection connection = Database.Conectar();

			try {

				connection.Open();

				string sql = "UPDATE categorias SET nombre = @nombre WHERE id = @id";
				MySqlCommand command = new MySqlCommand(sql, connection);

				command.Parameters.AddWithValue("@nombre", categoria.Nombre);
				command.Parameters.AddWithValue("@id", categoria.IdCategoria);
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
