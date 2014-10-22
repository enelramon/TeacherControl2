<%@ Page Title="" Language="C#" MasterPageFile="~/BasePage.Master" AutoEventWireup="true" CodeBehind="PasarAsistencia.aspx.cs" Inherits="RegEstudiantes.Presentacion.PasarAsistencia" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
        }
        .auto-style2 {
            width: 271px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;">
        <tr>
            <td class="auto-style1">IdAsistencia</td>
            <td class="auto-style2">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">Estudiante</td>
            <td class="auto-style2">Calificacion</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" Width="241px">
                </asp:DropDownList>
            </td>
            <td class="auto-style2">
                <asp:DropDownList ID="DropDownList2" runat="server" Height="16px" Width="241px">
                </asp:DropDownList>
            </td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Button" />
            </td>
        </tr>
        <tr>
            <td class="auto-style1" colspan="3">
                <asp:GridView ID="GridView1" runat="server">
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
