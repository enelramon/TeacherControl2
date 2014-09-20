using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RegEstudiantes.Presentacion
{
    
    public partial class RegistroProfesores : System.Web.UI.Page
        
    {
       public  string nombre="nada mas ";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void PruebaButton_Click(object sender, EventArgs e)
        {
            Session["IdProfesor"] = 10;
        }
    }
}