using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioProgramador.tools {
	public static class Database {

		public static MySqlConnection Conectar() {

			MySqlConnection connection = null;

			// Pendiente de crear un usuario en MySQL

			string server = "localhost";
			string database = "musica";
			string user = "Lemu";
			string password = "1807";
			int port = 3306;

			string connectionString = $"server={server};user={user};database={database};port={port};password={password}";

			connection = new MySqlConnection(connectionString);

			return connection;

		}

	}
}
