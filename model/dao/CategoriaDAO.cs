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

	}
}
