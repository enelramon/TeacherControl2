<%@ Page Title="" Language="C#" MasterPageFile="~/BasePage.Master" AutoEventWireup="true" CodeBehind="RegCalificacionEnvios.aspx.cs" Inherits="RegEstudiantes.Presentacion.RegCalificacionEnvios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;">
        <tr>
            <td>   
    <asp:Label ID="Label1" runat="server" Text="Envio"></asp:Label>
&nbsp;<asp:TextBox ID="IdEnvioTextBox" runat="server" ReadOnly="True"></asp:TextBox>
                &nbsp;<asp:ImageButton ID="LeftImageButton" runat="server" Height="16px" ImageUrl="~/Img/Left.png" Width="16px" OnClick="LeftImageButton_Click" />
&nbsp;&nbsp;&nbsp;
    <asp:ImageButton ID="RigthImageButton" runat="server" Height="16px" ImageUrl="~/Img/rigth.png" Width="16px" OnClick="RigthImageButton_Click" />
    <br /></td>
        </tr>
        <tr>
            <td>
 
    <asp:Label ID="Label2" runat="server" Text="Tarea #"></asp:Label>
&nbsp;<asp:TextBox ID="TareaTextBox" runat="server" ReadOnly="True" Width="106px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label3" runat="server" Text="Descripion"></asp:Label>
                <br />
    <asp:TextBox ID="DescripcionTextBox" runat="server" Height="160px" ReadOnly="True" Width="244px"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td>
    <asp:Label ID="Label5" runat="server" Text="Resulltado Esperado"></asp:Label>
    <asp:TextBox ID="ResultadoEsperadTextBox" runat="server" Height="22px" ReadOnly="True" Width="106px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:LinkButton ID="DescargarLinkButton" runat="server" OnClick="DescargarLinkButton_Click">Descargar</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td>
    <asp:Label ID="Label4" runat="server" Text="Calificacion"></asp:Label>
&nbsp;&nbsp;
    <asp:TextBox ID="CalificacionTextBox" runat="server" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="CalificarButton" runat="server" Text="Calificar" OnClick="CalificarButton_Click" />
            </td>
        </tr>
    </table>
    <br />
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
    <br />
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
    <br />
</asp:Content>