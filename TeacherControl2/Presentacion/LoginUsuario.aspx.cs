using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Web.UI.WebControls;
using BLL;

namespace RegEstudiantes.Presentacion
{
    public partial class LoginUsuario : System.Web.UI.Page
    {
        Usuarios usuario = new Usuarios();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void EntrarButton_Click(object sender, EventArgs e)
        {
            usuario.Nombre = NombreTextBox.Text;
            usuario.Clave = ClaveTextBox.Text;

            if (usuario.Autentificar() == true)
            {
                Session["tipo"] = usuario.Tipo;
                FormsAuthentication.RedirectFromLoginPage(usuario.Nombre, true);
                Response.Redirect("RegistroUsuario.aspx");
            }
            else
            {
                Response.Write("Contrasena o Nombre de usuario inconrrecto!!");
            }


        }
    }
}