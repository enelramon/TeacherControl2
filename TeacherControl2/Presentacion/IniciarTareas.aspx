<%@ Page Title="" Language="C#" MasterPageFile="~/Consultas.Master" AutoEventWireup="true" CodeBehind="IniciarTareas.aspx.cs" Inherits="TeacherControl.Registro.IniciarTareas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 79%;
        }
        .auto-style2 {
            width: 105px;
        }
        .auto-style3 {
            width: 105px;
            height: 26px;
        }
        .auto-style4 {
            height: 26px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">CodigoTarea:</td>
            <td>
                <asp:TextBox ID="CodigoTareaTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Fecha asignada:</td>
            <td>
                <asp:TextBox ID="FechaTextBox" runat="server" OnTextChanged="FechaTextBox_TextChanged"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Fecha Vencida:</td>
            <td>
                <asp:TextBox ID="VenceTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">IdSemestre:</td>
            <td class="auto-style4">
                <asp:DropDownList ID="IdSemestreDropDownList" runat="server" Height="26px" Width="127px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">IdAsignatura:</td>
            <td>
                <asp:DropDownList ID="IdAsignaturaDropDownList" runat="server" Height="17px" Width="126px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">IdSeccion:</td>
            <td>
                <asp:DropDownList ID="IdSeccionDropDownList" runat="server" Height="22px" Width="124px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Fescripcion:</td>
            <td>
                <asp:TextBox ID="DescripcionTextBox" runat="server" Height="85px" Width="295px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Button ID="InciarButton" runat="server" OnClick="InciarButton_Click" Text="Iniciar" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
