<%@ Page Title="" Language="C#" MasterPageFile="~/BasePage.Master" AutoEventWireup="true" CodeBehind="RegistroProfesores.aspx.cs" Inherits="RegEstudiantes.Presentacion.RegistroProfesores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" Display="Dynamic" ErrorMessage="Debe introducir un nombre" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox1" Display="Dynamic" ErrorMessage="Debe ser un Telefono Valido" SetFocusOnError="True" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}">*</asp:RegularExpressionValidator>
<br />
<asp:ValidationSummary ID="ValidationSummary1" runat="server" />
<br />
<asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    <asp:Button ID="PruebaButton" runat="server" Text="Prueba Session" OnClick="PruebaButton_Click"  />
<br />

     &nbsp;

</asp:Content>
