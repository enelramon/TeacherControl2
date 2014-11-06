<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistroUsuario.aspx.cs" Inherits="LogingUsuario.GUI.RegistroUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Panel ID="Panel1" runat="server" BorderStyle="Ridge" style="z-index: 1; left: 382px; top: 192px; position: absolute; height: 290px; width: 517px">
            <asp:Button ID="ConsultarBotton" runat="server" Text="Consultar" OnClick="ConsultarBotton_Click" style="z-index: 1; left: 394px; top: 242px; position: absolute" />
            <asp:Button ID="EliminarButton" runat="server" style="z-index: 1; left: 156px; top: 239px; position: absolute" Text="Eliminar" OnClick="EliminarButton_Click" />
            <asp:Button ID="CrearButton" runat="server" style="z-index: 1; left: 45px; top: 238px; position: absolute" Text="Crear" OnClick="CrearButton_Click" />
            <asp:Button ID="BuscarBotton" runat="server" style="z-index: 1; left: 305px; top: 33px; position: absolute" Text="Buscar" OnClick="BuscarBotton_Click" />
            <asp:Label ID="NombreLabel" runat="server" style="z-index: 1; left: 26px; top: 37px; position: absolute" Text="Nombre"></asp:Label>
            <asp:TextBox ID="ClaveTextBox" runat="server" style="z-index: 1; left: 113px; top: 97px; position: absolute; margin-top: 0px" TextMode="Password"></asp:TextBox>
            <asp:Label ID="ClaveLabel" runat="server" style="z-index: 1; left: 27px; top: 99px; position: absolute; height: 17px" Text="Clave"></asp:Label>
            <asp:TextBox ID="NombreTextBox" runat="server" style="z-index: 1; left: 112px; top: 36px; position: absolute"></asp:TextBox>
            <asp:Label ID="TipoLabel" runat="server" style="z-index: 1; left: 32px; top: 167px; position: absolute; height: 17px" Text="Tipo"></asp:Label>
            <asp:DropDownList ID="TipoDropDownList" runat="server" style="z-index: 1; left: 111px; top: 158px; position: absolute">
                <asp:ListItem Value="1">Administrador</asp:ListItem>
                <asp:ListItem Value="2">Usuario</asp:ListItem>
            </asp:DropDownList>
            <asp:Button ID="LimpiarBotton" runat="server" style="z-index: 1; left: 273px; top: 241px; position: absolute" Text="Limpiar" OnClick="LimpiarBotton_Click" />
            <asp:Label ID="ActivoLabel" runat="server" style="z-index: 1; left: 306px; top: 98px; position: absolute; height: 17px" Text="Activo"></asp:Label>
            <asp:CheckBox ID="ActivoCheckBox" runat="server" style="z-index: 1; left: 377px; top: 96px; position: absolute" />
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
