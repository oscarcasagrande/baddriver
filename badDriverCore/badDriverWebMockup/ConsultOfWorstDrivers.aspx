<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ConsultOfWorstDrivers.aspx.cs" Inherits="badDriverWebMockup.ConsultOfWorstDrivers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="Contents/css/Css Centralizar.css" rel="stylesheet" />
    <h1>The Top Ten of Baddrivers</h1>
    <table>
        <thead>
            <tr>
                <td>Quantidade
                </td>
                <td>Placa
                </td>
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="Top10Repeater" runat="server">
                <ItemTemplate>
                    <tr>
                        <td>
                            <%# DataBinder.Eval(Container,"DataItem.IncidentQuantity") %></td>
                        <td><%# DataBinder.Eval(Container,"DataItem.Label") %></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>
