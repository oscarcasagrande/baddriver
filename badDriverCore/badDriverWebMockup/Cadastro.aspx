<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="badDriverWebMockup.Cadastro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:label id="NamelLabel" runat="server" text="Name"></asp:label>
    <asp:textbox id="NameTextBox" runat="server" textmode="SingleLine"></asp:textbox>

    <br />

    <asp:label id="Label6" runat="server" text="Email"></asp:label>
    <asp:textbox id="EmailTextbox1" runat="server" textmode="Email"></asp:textbox>

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

    <asp:label id="Label4" runat="server" text="SecondEmail"></asp:label>
    <asp:textbox id="SecondEmailTextbox1" runat="server" textmode="Email"></asp:textbox>

    <br />
    
    <asp:label id="Label5" runat="server" text="Mobile Phone"></asp:label>
    <asp:textbox id="MobilePhoneTextbox1" runat="server" textmode="Phone"></asp:textbox>

    <br />

    <asp:button id="LoginButton" runat="server" text="Cadastrar" onclick="LoginButton_Click" />
</asp:Content>
