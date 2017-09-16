<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="UploadDriver.aspx.cs" Inherits="badDriverWebMockup.UploadDriver" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:fileupload runat="server" id="archivesFileUpload" AllowMultiple="True"></asp:fileupload>
    <br />
    <asp:button runat="server" text="Button" id="UploadButton" OnClick="UploadButton_Click" />
    <br />
    <asp:Label ID="lblUploadStatus" runat="server" Text="Label"></asp:Label>
</asp:Content>
