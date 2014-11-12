<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="rTareas.aspx.cs" Inherits="RegEstudiantes.Presentacion.rTareas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Teacher Control</title>
    <style type="text/css">
        .auto-style1 {
        }
        .auto-style2 {
            width: 136px;
        }
        .auto-style3 {
            width: 129px;
        }
        .Rojo{
            color:#ff0000;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Registro de Tareas</h1>
        <table style="width: 44%;">
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label1" runat="server" Text="Codigo Tarea"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="CodigoTareaTextBox" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="CodigoRequiredFieldValidator" CssClass="Rojo" runat="server" ControlToValidate="CodigoTareaTextBox" Display="Dynamic" ErrorMessage="Codigo requerido" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label2" runat="server" Text="Fecha"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="FechaTextBox" runat="server" TextMode="Date" Width="168px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="FechaRequiredFieldValidator" CssClass="Rojo" runat="server" ControlToValidate="FechaTextBox" Display="Dynamic" ErrorMessage="Fecha requerida" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label3" runat="server" Text="Vence"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="VenceTextBox" runat="server" TextMode="Date" Width="168px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="VenceRequiredFieldValidator" CssClass="Rojo" runat="server" ControlToValidate="VenceTextBox" Display="Dynamic" ErrorMessage="Fecha Vencimiento requerida" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label4" runat="server" Text="IdSemestre"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:DropDownList ID="SemestreDropDownList" runat="server" Height="25px" Width="173px">
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label5" runat="server" Text="IdAsignatura"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:DropDownList ID="AsignaturaDropDownList" runat="server" Height="25px" Width="172px">
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label6" runat="server" Text="Descripcion"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="DescripcionTextBox" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="DescripcionRequiredFieldValidator" CssClass="Rojo" runat="server" ControlToValidate="DescripcionTextBox" Display="Dynamic" ErrorMessage="Descripcion requerida" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label7" runat="server" Text="ResultadoEsperado"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="ResultadoEsperadoTextBox" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="ResultadoEsperadoRequiredFieldValidator" CssClass="Rojo" runat="server" ControlToValidate="ResultadoEsperadoTextBox" Display="Dynamic" ErrorMessage="Resultado esperado requerido" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1" colspan="3">
                    <asp:Button ID="GuardarButton" runat="server" Text="Guardar" Height="30px" OnClick="GuardarButton_Click" Width="80px" />
                    <asp:Button ID="NuevoButton" runat="server" OnClick="NuevoButton_Click" Text="Nuevo" />
                    <asp:Button ID="EliminarButton" runat="server" Text="Eliminar" Height="30px" OnClick="EliminarButton_Click" Width="80px" Visible="False" />
                </td>
            </tr>
            <tr>
                <td class="auto-style1" colspan="3">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="Rojo"/>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
