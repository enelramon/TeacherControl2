<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsultarUsuario.aspx.cs" Inherits="LogingUsuario.GUI.ConsultarUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ConsultarUsuario</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Panel ID="Panel1" runat="server" Height="381px" style="z-index: 1; left: 390px; top: 213px; position: absolute; height: 381px; width: 620px" Width="620px">
            <asp:DropDownList ID="BuscarDropDownList" runat="server" style="z-index: 1; left: 55px; top: 48px; position: absolute">
                <asp:ListItem Value="1">Adminstrador</asp:ListItem>
                <asp:ListItem Value="2">Usuario</asp:ListItem>
                <asp:ListItem Value="3">Activo</asp:ListItem>
            </asp:DropDownList>
            <asp:TextBox ID="BuscarTextBox" runat="server" style="z-index: 1; left: 205px; top: 49px; position: absolute; right: 287px"></asp:TextBox>
            <asp:Button ID="BuscarButton" runat="server" style="z-index: 1; left: 420px; top: 48px; position: absolute" Text="Buscar" OnClick="BuscarButton_Click" />
            <asp:GridView ID="ListadoGridView" runat="server" style="z-index: 1; left: 42px; top: 151px; position: absolute; height: 133px; width: 187px; right: 391px">
            </asp:GridView>
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
