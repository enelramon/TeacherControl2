<%@ Page Title="" Language="C#" MasterPageFile="~/BasePage.Master" AutoEventWireup="true" CodeBehind="RegistroTareas.aspx.cs" Inherits="RegEstudiantes.Presentacion.RegistroTareas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<table>
    <tbody>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="IdTarea"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="IdTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Codigo"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="CodigoTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Fecha"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="FechaTextBox" runat="server" TextMode="Date"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Vence"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="VenceTextBox" runat="server" TextMode="Date"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Semestre"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="SemestreDropDownList" runat="server"></asp:DropDownList>
            </td>
            <td>
                <asp:Label ID="Label6" runat="server" Text="Asignatura"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="AsignaturaDropDownList" runat="server"></asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label7" runat="server" Text="Descripcion"></asp:Label>
            </td>
            <td colspan="3">
                <asp:TextBox ID="DescripcionTextBox" runat="server" TextMode="MultiLine" Width="100%" Rows="5"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label8" runat="server" Text="Resultado Esperado"></asp:Label>
            </td>
            <td colspan="3">
                <asp:TextBox ID="ResultadoEsperadoTextBox" runat="server" Width="100%"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="NuevoButton" runat="server" Text="Nuevo" OnClick="NuevoButton_Click" />
            </td>
            <td>
                <asp:Button ID="GuardarButton" runat="server" Text="Guardar" OnClick="GuardarButton_Click" />
            </td>
            <td>
                <asp:Button ID="EliminarButton" runat="server" Text="Eliminar" OnClick="EliminarButton_Click" />
            </td>
            <td>
                <asp:Button ID="BuscarButton" runat="server" Text="Buscar" OnClick="BuscarButton_Click" />
            </td>
        </tr>
    </tbody>
</table>
</asp:Content>
