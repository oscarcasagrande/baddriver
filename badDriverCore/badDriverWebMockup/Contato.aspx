<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Contato.aspx.cs" Inherits="badDriverWebMockup.Contato" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:TextBox ID="EmailTextBox" runat="server"></asp:TextBox>
    <asp:TextBox ID="NomeTextBox" runat="server"></asp:TextBox>
    <asp:TextBox ID="TelefoneTextBox" runat="server"></asp:TextBox>
    <asp:TextBox ID="AssuntoTextBox" runat="server"></asp:TextBox>

    <asp:DropDownList ID="TipoDropDownList" runat="server">
        <asp:ListItem Value="" Text="Selecione" Selected="True"></asp:ListItem>
        <asp:ListItem Value="Reclamação" Text="Reclamação"></asp:ListItem>
        <asp:ListItem Value="Remoção de Driver" Text="Remoção de Driver"></asp:ListItem>
        <asp:ListItem Value="Sugestão" Text="Sugestão"></asp:ListItem>
        <asp:ListItem Value="Outros" Text="Outros"></asp:ListItem>
    </asp:DropDownList>

    <asp:TextBox ID="MensagemTextBox" TextMode="MultiLine" runat="server" Text="Mensagem..."></asp:TextBox>
    <asp:Button runat="server" ID="EnviarButton" Text="Enviar" />
</asp:Content>
