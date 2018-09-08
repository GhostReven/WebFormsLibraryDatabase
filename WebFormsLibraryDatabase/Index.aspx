<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="WebFormsLibraryDatabase.LibraryPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
	<head runat="server">
		<title></title>
	</head>

	<body>
		<form id="formIndex" runat="server">
			<asp:Table runat="server">
				<asp:TableRow >
					<asp:TableCell Width ="200">
						<asp:Label ID="lblSearchText" Text="Search text" runat="server" />
					</asp:TableCell><asp:TableCell >
						<asp:Label ID="lblSearchTerm" Text="Search term" runat="server" />
					</asp:TableCell>
				</asp:TableRow>
				<asp:TableRow>
					<asp:TableCell>
						<asp:textbox ID="txbSearchText" runat="server" />
					</asp:TableCell><asp:TableCell Width="">
						<asp:dropdownlist ID="ddlSearchTerm" runat="server">
							<asp:ListItem Text="Author" />
							<asp:ListItem Text="Title" />
							<asp:ListItem Text="ISBN-10" />
							<asp:ListItem Text="ISBN-13" />
						</asp:dropdownlist>
					</asp:TableCell><asp:TableCell>
						<asp:button ID="btnSearch" runat="server" text="Search" OnClick="btnSearch_Click" />
					</asp:TableCell></asp:TableRow><asp:TableRow>
					<asp:TableCell>
						<asp:label ID="lblResults" text="Results" runat="server" />
					</asp:TableCell></asp:TableRow></asp:Table><asp:Table runat="server">
				<asp:TableRow>
					<asp:TableCell>
						<asp:listbox ID="lsbResults" runat="server" Width="450">
							<asp:listitem text="Place holder" />
						</asp:listbox>
					</asp:TableCell><asp:TableCell>
						<asp:button ID="btnAddBook" runat="server" text="Add book" OnClick="btnAddBook_Click"/>
					</asp:TableCell>
				</asp:TableRow>
			</asp:Table>
		</form>
	</body>
</html>
