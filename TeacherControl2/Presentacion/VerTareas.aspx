<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/MasterPage.Master" AutoEventWireup="true" CodeBehind="VerTareas.aspx.cs" Inherits="RegEstudiantes.Presentacion.VerTareas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Ver Tareas</h2>
    <hr />
    <table>
        <tbody>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="IdTarea"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="IdTextBox" runat="server"></asp:TextBox>
                </td>
                <td></td>
                <td></td>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Puntos Disponibles"></asp:Label>
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
                <td>
                    <asp:Label ID="PuntosLabel" runat="server" Text="0" ForeColor="Green"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="Descripcion"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="5">
                    <asp:TextBox ID="DescripcionTextBox" runat="server" TextMode="MultiLine" Rows="3" Width="100%"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label6" runat="server" Text="Resultado Esperado"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="4">
                    <asp:TextBox ID="ResultadoTextBox" runat="server" Width="100%"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label7" runat="server" Text="Subir Archivo"></asp:Label>
                </td>
                <td>
                    <asp:FileUpload ID="TareaFileUpload" runat="server" />
                </td>
                <td>
                    <asp:Button ID="AdjuntarButton" runat="server" Text="Adjuntar" OnClick="AdjuntarButton_Click" />
                </td>
                <td>
                    <asp:Label ID="SubidaLabel" runat="server" Text="Estatus de subida:"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:HyperLink ID="HyperLink1" runat="server">Descargar</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Button ID="EnviarButton" runat="server" Text="Enviar" OnClick="EnviarButton_Click" Enabled="False" />
                </td>
            </tr>
        </tbody>
    </table>
</asp:Content>
