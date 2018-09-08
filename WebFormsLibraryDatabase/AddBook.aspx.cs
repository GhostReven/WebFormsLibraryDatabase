using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsLibraryDatabase {
	public partial class AddBook : System.Web.UI.Page {
		DatabaseManager databaseManager = new DatabaseManager("datasource=127.0.0.1;port=3306;username=root;password=DataIT2018!;database=librarydatabase;SslMode=none;");

		protected void Page_Load(object sender, EventArgs e) {

		}

		protected void btnAddBook_Click(object sender, EventArgs e) {
			lblResult.Text = databaseManager.AddBook(txbAuthor.Text, txbTitle.Text, txbISBN10.Text, txbISBN13.Text);
		}

		protected void btnClearFields_Click(object sender, EventArgs e) {
			txbAuthor.Text = "";
			txbTitle.Text = "";
			txbISBN10.Text = "";
			txbISBN13.Text = "";
			lblResult.Text = "";
		}

		protected void btnReturn_Click(object sender, EventArgs e) {
			Response.Redirect("Index.aspx");
		}
	}
}