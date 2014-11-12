using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RegistroEstudiantes.Presentacion
{
    public partial class ConsultaFecha : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ConsultarButton_Click(object sender, EventArgs e)
        {
            string Consulta;
            Consulta = "FechaNacimiento between '" + DesdeTextBox.Text + "' and '" + HastaTextBox.Text + "'";
            Response.Redirect("ConsultaEstudiantes.aspx?Consulta="+ Consulta);
        }
    }
}