<%@ Page Title="About" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.vb" Inherits="VB_CONN_ORACLE.About" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <p>Your app description page. Asarawut</p>
    <p>Use this area to provide additional information.</p>
    <p>
        <asp:Button ID="Button1" runat="server" Text="Button" />
    </p>
    <p>
        <asp:ListBox ID="ListBox1" runat="server" Width="554px"></asp:ListBox>
    </p>
    <p>
        <asp:Button ID="Button2" runat="server" Text="Button" />
    </p>
    <p>
        &nbsp;</p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p></p>
    <rsweb:ReportViewer ID="ReportViewer1" runat="server" Width="1160px">
    </rsweb:ReportViewer>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
</asp:Content>
