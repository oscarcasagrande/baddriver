<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<%@ Register assembly="ControleMessageBox" namespace="ControleMessageBox" tagprefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" 
            CellPadding="2" DataKeyNames="CategoryID" DataSourceID="SqlDataSource1" 
            ForeColor="Black" GridLines="None" 
            onrowdeleting="GridView1_RowDeleting">
            <FooterStyle BackColor="Tan" />
            <Columns>
                <asp:CommandField ShowDeleteButton="True" />
                <asp:BoundField DataField="CategoryID" HeaderText="CategoryID" 
                    InsertVisible="False" ReadOnly="True" SortExpression="CategoryID" />
                <asp:BoundField DataField="CategoryName" HeaderText="CategoryName" 
                    SortExpression="CategoryName" />
            </Columns>
            <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" 
                HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
            <HeaderStyle BackColor="Tan" Font-Bold="True" />
            <AlternatingRowStyle BackColor="PaleGoldenrod" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:NorthwindConnectionString %>" 
            SelectCommand="SELECT [CategoryID], [CategoryName] FROM [Categories]" 
            DeleteCommand="DELETE FROM Categories WHERE (CategoryID = @CategoryID)">
            <DeleteParameters>
                <asp:ControlParameter ControlID="GridView1" Name="CategoryID" 
                    PropertyName="SelectedValue" />
            </DeleteParameters>
        </asp:SqlDataSource>
    
    </div>
    <cc1:MessageBox ID="MessageBox1" runat="server" 
        onyeschoosed="MessageBox1_YesChoosed" />
    </form>
</body>
</html>
