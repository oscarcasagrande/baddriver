<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="RedefinirSenha.aspx.cs" Inherits="badDriverWebMockup.RedefinirSenha" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Nova senha"></asp:Label>
    <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
    <asp:Label ID="Label2" runat="server" Text="redigite senha"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server" TextMode="Password"></asp:TextBox>
    &nbsp;
		
			
	
		&nbsp;<asp:Button ID="Button1" runat="server" Text="confirma" />
</asp:Content>
