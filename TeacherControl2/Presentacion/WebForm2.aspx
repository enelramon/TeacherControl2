<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="RegEstudiantes.Presentacion.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        consulta de asistencias x estudiantes<br />
        <asp:DropDownList ID="EstudiantesDropDownList" runat="server" Height="16px" Width="110px">
            <asp:ListItem></asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="BuscarButton" runat="server" OnClick="BuscarButton_Click" Text="Buscar" />
    
    </div>
    </form>
</body>
</html>
