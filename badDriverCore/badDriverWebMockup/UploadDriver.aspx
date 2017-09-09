<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="UploadDriver.aspx.cs" Inherits="badDriverWebMockup.UploadDriver" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:fileupload runat="server" id="archivesFileUpload"></asp:fileupload>
    <br />
    <asp:button runat="server" text="Button" id="UploadButton" OnClick="UploadButton_Click" />
</asp:Content>
