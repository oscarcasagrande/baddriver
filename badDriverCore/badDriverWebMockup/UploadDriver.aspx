<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="UploadDriver.aspx.cs" Inherits="badDriverWebMockup.UploadDriver" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="Scripts/dropzone/dropzone.min.js"></script>
    <link href="Scripts/dropzone/basic.min.css" rel="stylesheet" />
    <link href="Scripts/dropzone/dropzone.css" rel="stylesheet" />


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <div class="fallback">
            <asp:fileupload runat="server" id="archivesFileUpload" allowmultiple="True" accept=".png,.jpg,.jpeg,.gif"></asp:fileupload>
            <br />
            <asp:button runat="server" text="Button" id="UploadButton" onclick="UploadButton_Click" />
            <br />
            <asp:label id="lblUploadStatus" runat="server" text="Label"></asp:label>
        </div>
    </div>
</asp:Content>
