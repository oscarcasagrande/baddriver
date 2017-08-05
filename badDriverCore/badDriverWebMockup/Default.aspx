<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="badDriverWebMockup.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    Marca: <asp:textbox runat="server" ID="textBoxBrand"></asp:textbox> 
    <br />

    Fabricante:  <asp:textbox runat="server" ID="textBoxSupplier"></asp:textbox>
    <br />

    Placa:  <asp:textbox runat="server" ID="textBoxLabel"></asp:textbox>
    <br />

    Cor: <asp:textbox runat="server" ID="textBoxColor"></asp:textbox>
    <br />

    Fotos: <asp:FileUpload ID="photosFileUpload" runat="server" />
    <br />

    <asp:button runat="server" text="Upload" ID="uploadButton" OnClick="uploadButton_Click" />
        
</asp:Content>