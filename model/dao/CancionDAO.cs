using MySql.Data.MySqlClient;
using RadioProgramador.model.poco;
using RadioProgramador.tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioProgramador.model.dao {
	public static class CancionDAO {

		public static List<Cancion> GetAll() {

			List<Cancion> canciones = new List<Cancion>();
			MySqlConnection connection = Database.Conectar();

			try {

				connection.Open();

				string sql = "SELECT canciones.id, titulo, id_artista, id_genero, id_categoria, clave, dias, album, activa, prioridad, artistas.nombre, generos.nombre, categorias.nombre" +
					" FROM canciones" +
					" LEFT JOIN artistas ON artistas.id = id_artista" +
					" LEFT JOIN generos ON generos.id = id_genero" +
					" LEFT JOIN categorias ON categorias.id = id_categoria";

				MySqlCommand command = new MySqlCommand(sql, connection);

				MySqlDataReader reader = command.ExecuteReader();

				while (reader.Read()) {
					int id = !reader.IsDBNull(0) ? reader.GetInt32(0) : 0;
					string titulo = !reader.IsDBNull(1) ? reader.GetString(1) : "";
					int idArtista = !reader.IsDBNull(2) ? reader.GetInt32(2) : 0;
					int idGenero = !reader.IsDBNull(3) ? reader.GetInt32(3) : 0;
					int idCategoria = !reader.IsDBNull(4) ? reader.GetInt32(4) : 0;
					string clave = !reader.IsDBNull(5) ? reader.GetString(5) : "";
					string dias = !reader.IsDBNull(6) ? reader.GetString(6) : "";
					string album = !reader.IsDBNull(7) ? reader.GetString(7) : "";
					bool activa = !reader.IsDBNull(8) ? reader.GetBoolean(8) : false;
					int prioridad = !reader.IsDBNull(9) ? reader.GetInt32(9) : 0;
					string artista = !reader.IsDBNull(10) ? reader.GetString(10) : "";
					string genero = !reader.IsDBNull(11) ? reader.GetString(11) : "";
					string categoria = !reader.IsDBNull(12) ? reader.GetString(12) : "";
					Cancion cancion = new Cancion(id, titulo, album, clave, prioridad, activa, dias, idArtista, idGenero, idCategoria, artista, genero, categoria);
					canciones.Add(cancion);
				}

				reader.Close();

			} catch (Exception ex) {
				// Esto iría al log o algo así
				Console.WriteLine(ex.Message);
			}

			connection.Close();
			return canciones;

		}

	}
}
