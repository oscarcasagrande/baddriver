<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="RecuperarSenha.aspx.cs" Inherits="badDriverWebMockup.Denunciar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <h2>recuperar senha</h2>
    <br />
    Informe seu Email <asp:TextBox ID="TextBox1" runat="server" Width="228px"></asp:TextBox>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Recuperar senha" Height="26px" Width="166px" />
    <br />

</asp:Content>
