<%@ Page Title="" Language="C#" MasterPageFile="~/BasePage.Master" AutoEventWireup="true" CodeBehind="ConsultaFecha.aspx.cs" Inherits="RegistroEstudiantes.Presentacion.ConsultaFecha" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label" runat="server" Text="Desde"></asp:Label>
&nbsp;<asp:TextBox ID="DesdeTextBox" runat="server" TextMode="Date"></asp:TextBox>
&nbsp;
    <br />
    <asp:Label ID="Label2" runat="server" Text="Hasta"></asp:Label>
&nbsp;
    <asp:TextBox ID="HastaTextBox" runat="server" TextMode="Date"></asp:TextBox>
&nbsp;
    <br />
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="ConsultarButton" runat="server" OnClick="ConsultarButton_Click" Text="Consultar" />
</asp:Content>
