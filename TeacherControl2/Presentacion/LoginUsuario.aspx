<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginUsuario.aspx.cs" Inherits="RegEstudiantes.Presentacion.LoginUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Panel ID="Panel1" runat="server" BackColor="#999966" BorderStyle="Solid" style="z-index: 1; left: 353px; top: 182px; position: absolute; height: 283px; width: 478px">
            <asp:Label ID="UsuarioLabel" runat="server" style="z-index: 1; left: 147px; top: 80px; position: absolute" Text="Usuario"></asp:Label>
            <asp:TextBox ID="NombreTextBox" runat="server" style="z-index: 1; left: 255px; top: 81px; position: absolute"></asp:TextBox>
            <asp:Label ID="ClaveLabel" runat="server" style="z-index: 1; left: 147px; top: 153px; position: absolute" Text="Clave"></asp:Label>
            <asp:TextBox ID="ClaveTextBox" runat="server" style="z-index: 1; left: 253px; top: 154px; position: absolute" TextMode="Password"></asp:TextBox>
            <asp:Button ID="EntrarButton" runat="server" style="z-index: 1; left: 211px; top: 218px; position: absolute; height: 41px; width: 82px;" Text="Entrar" OnClick="EntrarButton_Click" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="NombreTextBox" ErrorMessage="*" ForeColor="Red" style="z-index: 1; left: 398px; top: 85px; position: absolute; margin-bottom: 0px"></asp:RequiredFieldValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="ClaveTextBox" ErrorMessage="*" ForeColor="Red" style="z-index: 1; left: 400px; top: 157px; position: absolute; width: 11px"></asp:RequiredFieldValidator>
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
