<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="UploadDriver.aspx.cs" Inherits="badDriverWebMockup.UploadDriver" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:FileUpload runat="server" ID="archivesFileUpload" AllowMultiple="True" accept=".png,.jpg,.jpeg,.gif"></asp:FileUpload>
    <br />
    <asp:Button runat="server" Text="Button" ID="UploadButton" OnClick="UploadButton_Click" />
    <br />
    <asp:Label ID="lblUploadStatus" runat="server" Text="Label"></asp:Label>
</asp:Content>
