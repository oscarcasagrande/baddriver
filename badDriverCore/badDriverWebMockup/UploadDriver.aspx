<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="UploadDriver.aspx.cs" Inherits="badDriverWebMockup.UploadDriver" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript" src="Scripts/core/cacheModel.js"></script>
    <script type="text/javascript" src="Scripts/core/cacheModelMotorcycle.js"></script>
    <script src="Scripts/dropzone/dropzone.min.js"></script>
    <link href="Scripts/dropzone/basic.min.css" rel="stylesheet" />
    <link href="Scripts/dropzone/dropzone.css" rel="stylesheet" />
    <script src="Scripts/core/core.js"></script>


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <label>Label:</label>
        <asp:TextBox ID="LabelTextbox" runat="server"></asp:TextBox>
        <asp:Button runat="server" ID="AddPhotos" Text="Upload Driver" />
        <br />
        <label>Board:</label>
        <asp:TextBox ID="BoardTextbox" runat="server"></asp:TextBox>
        <br />
        <label>Supplier:</label>
        <select id="SupplierSelect" onchange="modelSelectChange();">
            <option value=""></option>
        </select>
        <br />
        <label>Model:</label>
        <select id="ModelSelect">
            <option value=""></option>
        </select>
        <br />
        <label>Color:</label>
        <asp:DropDownList ID="ColorDropdownlist" runat="server"></asp:DropDownList>
    </div>
    <div>
        <div class="fallback">
            <asp:FileUpload runat="server" ID="archivesFileUpload" AllowMultiple="True" accept=".png,.jpg,.jpeg,.gif"></asp:FileUpload>
            <br />
            <asp:Button runat="server" Text="Enviar Bad Driver" ID="UploadButton" OnClick="UploadButton_Click" />
            <br />
            <asp:Label ID="lblUploadStatus" runat="server" Text="Label"></asp:Label>
        </div>
        <script>
            bindSupplier('form1');
        </script>
    </div>
</asp:Content>
