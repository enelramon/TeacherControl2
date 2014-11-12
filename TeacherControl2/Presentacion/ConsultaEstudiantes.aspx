<%@ Page Title="" Language="C#" MasterPageFile="~/BasePage.Master" AutoEventWireup="true" CodeBehind="ConsultaEstudiantes.aspx.cs" Inherits="RegEstudiantes.Presentacion.ConsultaEstudiantes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    &nbsp;<asp:DropDownList ID="EstudiantesDropDownList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="EstudiantesDropDownList_SelectedIndexChanged">
        <asp:ListItem>Elija una opcion</asp:ListItem>
        <asp:ListItem>Nombre</asp:ListItem>
        <asp:ListItem>Matricula</asp:ListItem>
        <asp:ListItem>Fecha</asp:ListItem>
    </asp:DropDownList>
    <asp:TextBox ID="BuscarTextBox" runat="server" AutoPostBack="True"></asp:TextBox>
    <asp:Button ID="BuscarButton" runat="server" Text="Buscar" OnClick="BuscarButton_Click" />
    <asp:GridView ID="DatosGridView" runat="server">
        <Columns>
            <asp:HyperLinkField DataNavigateUrlFields="IdEstudiante" DataNavigateUrlFormatString="~/Presentacion/RegistroEstudiantes.aspx?EstudianteId={0}" Text="Editar" />
        </Columns>
    </asp:GridView>

</asp:Content>
