﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LoginWebUserControl.ascx.cs" Inherits="badDriverWebMockup.Component.LoginWebUserControl" %>
<asp:Label ID="UserEmailLabel" runat="server" Text="User/E-mail"></asp:Label>
<asp:TextBox ID="UserEmailTextBox" runat="server"></asp:TextBox>
<asp:Button ID="LoginButton" runat="server" Text="Login" OnClick="LoginButton_Click" />
<br />
<asp:Label ID="PasswordLabel" runat="server" Text="Password"></asp:Label>
<asp:TextBox ID="PasswordTextBox" runat="server" TextMode="Password"></asp:TextBox>
<br />
<a href="">Forgot my user</a>
<a href="">Forgot my password</a>
