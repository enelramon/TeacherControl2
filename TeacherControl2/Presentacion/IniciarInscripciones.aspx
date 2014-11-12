<%@ Page Title="" Language="C#" MasterPageFile="~/Consultas.Master" AutoEventWireup="true" CodeBehind="IniciarInscripciones.aspx.cs" Inherits="TeacherControl.Registro.IniciarInscripciones" %>
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
        .auto-style5 {
            width: 105px;
            height: 23px;
        }
        .auto-style6 {
            height: 23px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">Fecha</td>
            <td>
                <asp:TextBox ID="FechaTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">IdProfesor</td>
            <td>
                <asp:DropDownList ID="IdProfesorDropDownList" runat="server" Height="26px" Width="127px" OnSelectedIndexChanged="IdProfesorDropDownList0_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">IdSemestre:</td>
            <td>
                <asp:DropDownList ID="IdSemestreDropDownList" runat="server" Height="26px" Width="127px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">IdAsignatura:</td>
            <td class="auto-style4">
                <asp:DropDownList ID="IdAsignaturaDropDownList" runat="server" Height="26px" Width="127px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">IdSeccion:</td>
            <td>
                <asp:DropDownList ID="IdSeccionDropDownList" runat="server" Height="17px" Width="126px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style6"></td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Button ID="InciarButton" runat="server" OnClick="InciarButton_Click" Text="Iniciar" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
