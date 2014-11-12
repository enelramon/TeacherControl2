<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegEstudiantes.aspx.cs" Inherits="TeacherControl.Presentacion.RegEstudiantes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="width: 424px; height: 294px;">
        <table style="width: 100%; height: 94px;">
            <tr>
                <td>
        <asp:Label ID="Label1" runat="server" Text="IdEstudiante"></asp:Label>
                </td>
                <td>
        <asp:TextBox ID="IdEstudianteTextBox" runat="server" OnTextChanged="IdEstudianteTextBox_TextChanged1"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
        <asp:Label ID="Label2" runat="server" Text="Matricula"></asp:Label>
                </td>
                <td>
        <asp:TextBox ID="MatriculaTextBox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
        <asp:Label ID="Label3" runat="server" Text="Nombre "></asp:Label>
                </td>
                <td>
        <asp:TextBox ID="NombreTextBox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
        <asp:Label ID="Label5" runat="server" Text="Sexo"></asp:Label>
                </td>
                <td>
        <asp:DropDownList ID="SexoDropDownList" runat="server" >
            <asp:ListItem Value="0">Selecione un Sexo</asp:ListItem>
            <asp:ListItem Value="1">F</asp:ListItem>
            <asp:ListItem Value="2">M</asp:ListItem>
        </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
        <asp:Label ID="Label4" runat="server" Text="Direccion"></asp:Label>
                </td>
                <td>
        <asp:TextBox ID="DireccionTextBox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
        <asp:Label ID="Label6" runat="server" Text="Fecha Nac"></asp:Label>
                </td>
                <td>
        <asp:TextBox ID="FechaNacTextBox" runat="server" TextMode="Date"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
        <asp:Label ID="Label7" runat="server" Text="Email"></asp:Label>
                </td>
                <td>
        <asp:TextBox ID="EmailTextBox" runat="server" TextMode="Email"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
        <asp:Label ID="Label8" runat="server" Text="Telefono"></asp:Label>
                </td>
                <td>
        <asp:TextBox ID="TelefonoTextBox" runat="server" TextMode="Phone"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
        <asp:Label ID="Label9" runat="server" Text="Celular"></asp:Label>
                </td>
                <td>
        <asp:TextBox ID="CelularTextBox" runat="server" TextMode="Phone"></asp:TextBox>
                </td>
            </tr>
        </table>
        <br />
        <asp:Button ID="NuevoButton" runat="server" OnClick="NuevoButton_Click" Text="Nuevo" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="GuardarButton" runat="server" Text="Guardar" OnClick="GuardarButton_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="EliminarButton" runat="server" Text="Eliminar" OnClick="EliminarButton_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="BuscarButton" runat="server" Text="Buscar" OnClick="BuscarButton_Click" />
        <br />
        <br />
    </div>
    </form>
</body>
</html>
