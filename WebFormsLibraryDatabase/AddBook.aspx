<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddBook.aspx.cs" Inherits="WebFormsLibraryDatabase.AddBook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="formAddBook" runat="server">
        
    	<asp:Label ID="lblTitle" runat="server" Text="Title"></asp:Label>
		<br />
		<asp:TextBox ID="txbTitle" runat="server"></asp:TextBox>
		<br />
		<asp:Label ID="lblAuthor" runat="server" Text="Author"></asp:Label>
		<br />
		<asp:TextBox ID="txbAuthor" runat="server"></asp:TextBox>
		<br />
		<asp:Label ID="lblISBN10" runat="server" Text="ISBN-10"></asp:Label>
		<br />
		<asp:TextBox ID="txbISBN10" runat="server"></asp:TextBox>
		<br />
		<asp:Label ID="lblISBN13" runat="server" Text="ISBN-13"></asp:Label>
		<br />
		<asp:TextBox ID="txbISBN13" runat="server"></asp:TextBox>
		<br />
		<br />
		<asp:Button ID="btnAddBook" runat="server" Text="Add book" OnClick="btnAddBook_Click" />
		<br />
		<asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
		<br />
		<asp:Button ID="btnClear" runat="server" Text="Clear fields" OnClick="btnClearFields_Click" />
		<br /> <br />
		<asp:Button ID="btnReturn" runat="server" Text="Return to search" OnClick="btnReturn_Click" />
        
    </form>
</body>
</html>
