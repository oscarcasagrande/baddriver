<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ListWorstDrivers.aspx.cs" Inherits="badDriverWebMockup.ListWorstDrivers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server" Height="128px">
        <asp:Button ID="Button1" runat="server" Text="Button" align="left" />
        <asp:ListBox ID="ListBox2" runat="server" Height="168px">
            <asp:ListItem>Driver1</asp:ListItem>
            <asp:ListItem>Driver2</asp:ListItem>
            <asp:ListItem>Driver3</asp:ListItem>
            <asp:ListItem>Driver4</asp:ListItem>
            <asp:ListItem>Driver5</asp:ListItem>
            <asp:ListItem>Driver6</asp:ListItem>
            <asp:ListItem>Driver7</asp:ListItem>
            <asp:ListItem>Driver8</asp:ListItem>
            <asp:ListItem>Driver9</asp:ListItem>
            <asp:ListItem>Driver10</asp:ListItem>
        </asp:ListBox>
        <asp:ListBox ID="ListBox1" runat="server">
            <asp:ListItem>Board1</asp:ListItem>
        </asp:ListBox>
    </asp:Panel>
</asp:Content>
