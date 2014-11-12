<%@ Page Title="" Language="C#" MasterPageFile="~/BasePage.Master" AutoEventWireup="true" CodeBehind="ConsultaEstudiantes.aspx.cs" Inherits="TeacherControl.Presentacion.ConsultaEstudiantes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p><asp:Button ID="AleatorioButton" runat="server" Text="Aleatorio" OnClick="AleatorioButton_Click" /></p>
    <asp:TextBox ID="BuscarTextBox" runat="server"></asp:TextBox>
    <asp:Button ID="BuscarButton" runat="server" Text="Buscar" OnClick="BuscarButton_Click" />
    <asp:GridView ID="DatosGridView" runat="server">
        <Columns>
            <asp:HyperLinkField DataNavigateUrlFields="IdEstudiante" DataNavigateUrlFormatString="~/Registros/rEstudiantes.aspx?EstudianteId={0}" Text="Editar" />
        </Columns>
    </asp:GridView>

</asp:Content>
