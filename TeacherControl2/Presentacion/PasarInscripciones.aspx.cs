using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace TeacherControl.Registro
{
    public partial class PasarInscripciones : System.Web.UI.Page
    {
        Estudiantes estudiante = new Estudiantes();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                EstudianteDropDownList.DataSource = estudiante.Listar("1=1");
                EstudianteDropDownList.DataValueField = "IdEstudiante";
                EstudianteDropDownList.DataTextField = "Nombres";
                EstudianteDropDownList.DataBind();

                int id = int.Parse(Request.QueryString["id"].ToString());
                IdInscripcionTextBox.Text = id.ToString();

            }
        }

        protected void Guardar_Click(object sender, EventArgs e)
        {
            InscripcionesDetalle inscripciodetalle = new InscripcionesDetalle();

            inscripciodetalle.IdInscripcion = int.Parse(IdInscripcionTextBox.Text);
            inscripciodetalle.IdEstudiante = int.Parse(EstudianteDropDownList.SelectedValue);

            inscripciodetalle.Insertar();

            ConsultaGridView.DataSource = inscripciodetalle.Listar("1=1");
            ConsultaGridView.DataBind();
        }
    }
}