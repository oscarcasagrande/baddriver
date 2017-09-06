<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register assembly="ControleMessageBox" namespace="ControleMessageBox" tagprefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
            Text="Mensagem" />
        <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
            Text="Confirmação" />
    
    </div>
    <cc1:MessageBox ID="MessageBox1" runat="server" 
        onyeschoosed="MessageBox1_YesChoosed" />
    </form>
</body>
</html>
