<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="badDriverWebMockup.Login" %>

<%@ Register Src="~/Component/LoginWebUserControl.ascx" TagPrefix="uc1" TagName="LoginWebUserControl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:LoginWebUserControl runat="server" ID="LoginWebUserControl" />
</asp:Content>
