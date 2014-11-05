<%@ Page Title="" Language="C#" MasterPageFile="~/BasePage.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="RegEstudiantes.Presentacion.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button ID="Button1" runat="server" Text="Button" />
    <div id="spinner"   style="background-color: pink;display:none;">

        <h1>La bufanda</h1>

    </div>

    <script type="text/javascript">
        $(document).ready(function () {
            $('#Button1').click(function () {
                $('#spinner').animate();
            });
        });
    </script>

</asp:Content>
