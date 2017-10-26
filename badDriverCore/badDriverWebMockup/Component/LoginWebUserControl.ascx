<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LoginWebUserControl.ascx.cs" Inherits="badDriverWebMockup.Component.LoginWebUserControl" %>
<asp:Label ID="UserEmailLabel" runat="server" Text="User/E-mail"></asp:Label>
<asp:TextBox ID="UserEmailTextBox" runat="server" TextMode="Email" Type=""></asp:TextBox>
<asp:Button ID="LoginButton" runat="server" Text="Login" OnClick="LoginButton_Click" />
<br />
<asp:Label ID="PasswordLabel" runat="server" Text="Password"></asp:Label>
<asp:TextBox ID="PasswordTextBox" runat="server" TextMode="Password"></asp:TextBox>
<br />
<asp:CheckBox ID="RememberMeSetCheckBox" runat="server" Text="Manter-me Logado" />
<br />
<a href="">Forgot my user</a>
<a href="/RecuperarSenha.aspx">Forgot my password</a>
