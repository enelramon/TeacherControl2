using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace RegEstudiantes.Presentacion
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
<<<<<<< HEAD
            { 

                EstudiantesDropDownList.DataSource = Estudiantes.Listar("1=1", "IdEstudiante,Nombres");
=======
            {
                EstudiantesDropDownList.DataSource = BLL.Estudiantes.Listar("1=1", "IdEstudiante,Nombres");
>>>>>>> 4927b7c1205cb59762c56032060c522540bc5a21
                EstudiantesDropDownList.DataValueField = "IdEstudiante";
                EstudiantesDropDownList.DataTextField = "Nombres";
                EstudiantesDropDownList.DataBind();

            }
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {

        }
    }
}