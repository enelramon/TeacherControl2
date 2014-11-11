<%@ Page Title="" Language="C#" MasterPageFile="~/Consultas.Master" AutoEventWireup="true" CodeBehind="PasarTareas.aspx.cs" Inherits="TeacherControl.Registro.PasarTareas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        IdTarea:&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="IdTareaTextBox" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </p>
    <p>
        Estudiantes:<asp:DropDownList ID="EstudianteDropDownList" runat="server" Width="131px">
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Calificacion:<asp:DropDownList ID="CalificacionDropDownList" runat="server" Height="16px" Width="133px">
            <asp:ListItem Value="1">Exelente</asp:ListItem>
            <asp:ListItem Value="2">Buena</asp:ListItem>
            <asp:ListItem Value="3">Mala</asp:ListItem>
        </asp:DropDownList>
    </p>
    <asp:GridView ID="ConsultaGridView" runat="server">
    </asp:GridView>
    <br />
    <asp:Button ID="Guardar" runat="server" OnClick="Guardar_Click" Text="Guardar" />
</asp:Content>
