using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TeacherControl.BLL;

namespace TeacherControl.Consulta
{
    public partial class ConsultaCalificaciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Calificaciones calificaciones = new Calificaciones();
            ConsultaGridView.DataSource = calificaciones.Listar("");
            ConsultaGridView.DataBind();
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            Calificaciones calificaciones = new Calificaciones();
            string busqueda = BusquedaTextBox.Text;
            ConsultaGridView.DataSource = calificaciones.Listar(busqueda);
            ConsultaGridView.DataBind();
        }


    }
}