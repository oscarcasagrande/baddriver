<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Homepage.aspx.cs" Inherits="badDriverWebMockup.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>home</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
      <h1>Baddrive-Busca</h1>
            <asp:TextBox ID="TextBox1" runat="server" Height="16px"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="buscar" />
        <asp:CheckBoxList ID="CheckBoxList1" runat="server">
            <asp:ListItem>placa-fabrica-modelo-cor</asp:ListItem>
            <asp:ListItem>placa-fabrica-modelo-cor</asp:ListItem>
            <asp:ListItem>placa-fabrica-modelo-cor</asp:ListItem>
            <asp:ListItem>placa-fabrica-modelo-cor</asp:ListItem>
            <asp:ListItem>placa-fabrica-modelo-cor</asp:ListItem>
        </asp:CheckBoxList>
        <p>
            <asp:Button ID="Button2" runat="server" Text="upload" />
            <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
        </p>
    </form>
    <p>
        <input id="Text1" type="text" /></p>
</body>
</html>
