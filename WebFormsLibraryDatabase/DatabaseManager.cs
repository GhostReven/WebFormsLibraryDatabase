using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WebFormsLibraryDatabase {
	class DatabaseManager {
		string myConnectionString;

		public DatabaseManager(string connectionString) {
			myConnectionString = connectionString;
		}

		public string AddBook(string author, string title, string isbn10, string isbn13) {
			string query = "INSERT INTO books(`title`,`author`,`isbn10`,`isbn13`) VALUES ('" + title + "', '" + author + "', '" + isbn10 + "', '" + isbn13 + "')";

			MySqlConnection databaseConnection = new MySqlConnection(myConnectionString);
			MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection) {
				CommandTimeout = 60
			};

			try {
				databaseConnection.Open();
				MySqlDataReader myReader = commandDatabase.ExecuteReader();

				databaseConnection.Close();

				return "Book added succesfully.";
			}
			catch (Exception ex) {
				//MessageBox.Show(ex.Message);

				return ex.Message;
			}

		}

		public List<string> ListAll() {
			List<string> list = new List<string>();
			string query = "SELECT * FROM books";

			MySqlConnection databaseConnection = new MySqlConnection(myConnectionString);
			MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection) {
				CommandTimeout = 60
			};
			MySqlDataReader reader;

			try {
				databaseConnection.Open();
				reader = commandDatabase.ExecuteReader();

				if (reader.HasRows) {
					while (reader.Read()) {
						list.Add(reader.GetString(0) + "\t" + reader.GetString(1) + "\t" + reader.GetString(2) + "\t" + reader.GetString(3));
					}
				}
				return list;
			}
			catch (Exception ex) {
				list.Add(ex.Message);
				return list;
			}
		}

		public List<string> Search(int index, string searchText) {
			List<string> list = new List<string>();
			string searchTerm;
			switch (index) {
				case 0:
					searchTerm = "author";
					break;
				case 1:
					searchTerm = "title";
					break;
				case 2:
					searchTerm = "isbn10";
					break;
				case 3:
					searchTerm = "isbn13";
					break;
				default:
					searchTerm = "";
					break;
			}

			string query = "SELECT * FROM books WHERE " + searchTerm + " like '%" + searchText + "%'";

			MySqlConnection databaseConnection = new MySqlConnection(myConnectionString);
			MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection) {
				CommandTimeout = 60
			};
			MySqlDataReader reader;

			try {
				databaseConnection.Open();
				reader = commandDatabase.ExecuteReader();

				if (reader.HasRows) {
					while (reader.Read()) {
						list.Add(reader.GetString(0) + "\t" + reader.GetString(1) + "\t" + reader.GetString(2) + "\t" + reader.GetString(3));
					}
				}
				return list;
			}
			catch (Exception ex) {
				list.Add(ex.Message);
				return list;
			}
		}
	}
}
