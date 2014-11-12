<%@ Page Title="" Language="C#" MasterPageFile="~/BasePage.Master" AutoEventWireup="true" CodeBehind="ConsultaCalificaciones.aspx.cs" Inherits="TeacherControl.Consulta.ConsultaCalificaciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>




<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <h1>Consulta de Calificaciones</h1>
        <strong>Buscar Por:</strong>


        <asp:DropDownList ID="BusquedaPorDropDownList" runat="server">
            <asp:ListItem Text="Nombres"></asp:ListItem>
        </asp:DropDownList>

        <asp:TextBox ID="BusquedaTextBox" Width="200" runat="server"></asp:TextBox>

        <asp:Button ID="BuscarButton" runat="server" CssClass="btn btn-primary" Text="Buscar" OnClick="BuscarButton_Click" />

    <asp:GridView ID="ConsultaGridView" class="table table-responsive" runat="server">
    </asp:GridView>
</asp:Content>
