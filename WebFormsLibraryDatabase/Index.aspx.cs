using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsLibraryDatabase {
	public partial class LibraryPage : System.Web.UI.Page {
		DatabaseManager databaseManager = new DatabaseManager("datasource=127.0.0.1;port=3306;username=root;password=DataIT2018!;database=librarydatabase;SslMode=none;");

		protected void Page_Load(object sender, EventArgs e) {
			lsbResults.Items.Clear();
			List<string> list = new List<string>(databaseManager.ListAll());

			foreach (string item in list) {
				lsbResults.Items.Add(item);
			}
			
		}

		protected void btnAddBook_Click(object sender, EventArgs e) {
			Response.Redirect("AddBook.aspx");
		}

		protected void btnSearch_Click(object sender, EventArgs e) {
			lsbResults.Items.Clear();

			if(txbSearchText.Text=="") {
				List<string> list = new List<string>(databaseManager.ListAll());

				foreach (string item in list) {
					lsbResults.Items.Add(item);
				}
			}
			else {
				List<string> list = new List<string>(databaseManager.Search(ddlSearchTerm.SelectedIndex, txbSearchText.Text));

				foreach (string item in list) {
					lsbResults.Items.Add(item);
				}
			}
			
		}
	}
}