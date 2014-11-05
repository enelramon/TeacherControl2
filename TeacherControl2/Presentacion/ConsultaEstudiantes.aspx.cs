using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace RegEstudiantes.Presentacion {
    public partial class ConsultaEstudiantes : System.Web.UI.Page {
        Random random = new Random();

        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void BuscarButton_Click(object sender, EventArgs e) {
            DatosGridView.DataSource = Estudiantes.StaticListar("2=2");
            DatosGridView.DataBind();
        }

        protected void AleatorioButton_Click(object sender, EventArgs e) {
            DataTable dt = Estudiantes.StaticListar("IdEstudiante", "1=1");
            int rEstudiante = random.Next(dt.Rows.Count) + 1;
            Response.Redirect("~/Presentacion/RegEstudiantes.aspx?IdEstudiante=" + rEstudiante);
        }
    }
}