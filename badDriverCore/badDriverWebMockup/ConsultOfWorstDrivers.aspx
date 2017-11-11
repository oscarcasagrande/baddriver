<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ConsultOfWorstDrivers.aspx.cs" Inherits="badDriverWebMockup.ConsultOfWorstDrivers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>The Top Ten of Baddrivers</h1>
    <div style="text-align:center;">
  <div style="width:50%; margin: 0 auto; text-align:left;">    
    <asp:Table ID="Table1" 
            runat="server" 
            Font-Size="X-Large" 
            Width="550" 
            Font-Names="Palatino"
            BackColor="Black"
            BorderColor="Black"
            BorderWidth="2"
            ForeColor="Black"
            CellPadding="5"
            CellSpacing="5"
            >
            <asp:TableHeaderRow 
                runat="server" 
                ForeColor="Black"
                BackColor="White"
                Font-Bold="true"
                >
                <asp:TableHeaderCell>Driver</asp:TableHeaderCell>
                <asp:TableHeaderCell>Quantidade de Infrações</asp:TableHeaderCell>
                <asp:TableHeaderCell>Placa</asp:TableHeaderCell>
            </asp:TableHeaderRow>
            <asp:TableRow 
                ID="TableRow1" 
                runat="server" 
                BackColor="White"
                >
                <asp:TableCell>Driver 1</asp:TableCell>
                <asp:TableCell>400</asp:TableCell>
                <asp:TableCell>#F0FFFF</asp:TableCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow2" 
                runat="server" 
                BackColor="White"
                >
                <asp:TableCell>Driver 2</asp:TableCell>
                <asp:TableCell>370</asp:TableCell>
                <asp:TableCell>#F5F5DC</asp:TableCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow3" 
                runat="server" 
                BackColor="White"
                >
                <asp:TableCell>Driver 3</asp:TableCell>
                <asp:TableCell>300</asp:TableCell>
                <asp:TableCell>#FFE4C4</asp:TableCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow4" 
                runat="server" 
                BackColor="White"
                >
                <asp:TableCell>Driver 4</asp:TableCell>
                <asp:TableCell>250</asp:TableCell>
                <asp:TableCell>#DC143C</asp:TableCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow5" 
                runat="server" 
                BackColor="White"
                >
                <asp:TableCell>Driver 5</asp:TableCell>
                <asp:TableCell>175</asp:TableCell>
                <asp:TableCell>#00FFFF</asp:TableCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow6" 
                runat="server" 
                BackColor="White"
                >
                <asp:TableCell>Driver 6</asp:TableCell>
                <asp:TableCell>147</asp:TableCell>
                <asp:TableCell>#00FFFF</asp:TableCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow7" 
                runat="server" 
                BackColor="White"
                >
                <asp:TableCell>Driver 7</asp:TableCell>
                <asp:TableCell>132</asp:TableCell>
                <asp:TableCell>#00FFFF</asp:TableCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow8" 
                runat="server" 
                BackColor="White"
                >
                <asp:TableCell>Driver 8</asp:TableCell>
                <asp:TableCell>124</asp:TableCell>
                <asp:TableCell>#00FFFF</asp:TableCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow9" 
                runat="server" 
                BackColor="White"
                >
                <asp:TableCell>Driver 9</asp:TableCell>
                <asp:TableCell>117</asp:TableCell>
                <asp:TableCell>#00FFFF</asp:TableCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow10" 
                runat="server" 
                BackColor="White"
                >
                <asp:TableCell>Driver 10</asp:TableCell>
                <asp:TableCell>79</asp:TableCell>
                <asp:TableCell>#00FFFF</asp:TableCell>
            </asp:TableRow>
            <asp:TableFooterRow 
                runat="server" 
                BackColor="white"
                >
                <asp:TableCell 
                    ColumnSpan="3" 
                    HorizontalAlign="Right"
                    Font-Italic="true"
                    >
                </asp:TableCell>
            </asp:TableFooterRow>
        </asp:Table>
      </div>
        </div>
</asp:Content>
