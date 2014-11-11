<%@ Page Title="" Language="C#" MasterPageFile="~/Consultas.Master" AutoEventWireup="true" CodeBehind="PasarInscripciones.aspx.cs" Inherits="TeacherControl.Registro.PasarInscripciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        IdInscripcion:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="IdInscripcionTextBox" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </p>
    <p>
        Estudiantes:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:DropDownList ID="EstudianteDropDownList" runat="server" Width="131px">
        </asp:DropDownList>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
    <asp:GridView ID="ConsultaGridView" runat="server">
    </asp:GridView>
    <br />
    <asp:Button ID="Guardar" runat="server" OnClick="Guardar_Click" Text="Guardar" />
</asp:Content>
