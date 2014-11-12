<%@ Page Title="" Language="C#" MasterPageFile="~/BasePage.Master" AutoEventWireup="true" CodeBehind="RegCalificacionEnvios.aspx.cs" Inherits="RegEstudiantes.Presentacion.RegCalificacionEnvios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Envio"></asp:Label>
&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="IdEnvioTextBox" runat="server" ReadOnly="True"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:ImageButton ID="LeftImageButton" runat="server" Height="16px" ImageUrl="~/Img/Left.png" Width="16px" OnClick="LeftImageButton_Click" />
&nbsp;&nbsp;&nbsp;
    <asp:ImageButton ID="RigthImageButton" runat="server" Height="16px" ImageUrl="~/Img/rigth.png" Width="16px" OnClick="RigthImageButton_Click" />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Tarea #"></asp:Label>
&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TareaTextBox" runat="server" ReadOnly="True"></asp:TextBox>
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label3" runat="server" Text="Descripion"></asp:Label>
    <br />
    <asp:TextBox ID="escripcionTextBox" runat="server" Height="160px" ReadOnly="True" Width="244px"></asp:TextBox>
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:LinkButton ID="DescargarLinkButton" runat="server" OnClick="DescargarLinkButton_Click">Descargar</asp:LinkButton>
    <br />
    <asp:Label ID="Label4" runat="server" Text="Calificacion"></asp:Label>
&nbsp;&nbsp;
    <asp:TextBox ID="TextBox4" runat="server" ReadOnly="True"></asp:TextBox>
    <br />
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="CalificarButton" runat="server" Text="Calificar" OnClick="CalificarButton_Click" />
    <br />
    <br />
</asp:Content>
