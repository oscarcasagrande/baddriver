<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="badDriverWebMockup.Cadastro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:label id="Label4" runat="server" text="name"></asp:label>
    <asp:textbox id="Textbox1" runat="server" textmode="Email"></asp:textbox>
   
     <br />
    
    <asp:label id="UserEmailLabel" runat="server" text="User/E-mail"></asp:label>
    <asp:textbox id="UserEmailTextBox" runat="server" textmode="Email"></asp:textbox>

    <br />

    <asp:label id="Label1" runat="server" text="Nickname"></asp:label>
    <asp:textbox id="NicknameTextBox" runat="server"></asp:textbox>

    <br />

    <asp:label id="Label2" runat="server" text="Password"></asp:label>
    <asp:textbox id="PasswordTextBox" runat="server" textmode="Password"></asp:textbox>

    <br />
    <asp:label id="Label3" runat="server" text="Confirm Password"></asp:label>
    <asp:textbox id="ConfirmPasswordTextBox" runat="server" textmode="Password"></asp:textbox>

    <br />

    <asp:button id="LoginButton" runat="server" text="Cadastrar" onclick="LoginButton_Click" />
</asp:Content>
