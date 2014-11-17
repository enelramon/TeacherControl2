using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
namespace RegEstudiantes.Presentacion
{
    public partial class IniciarInscripciones : System.Web.UI.Page
    {
        Profesores profesores = new Profesores();

        Semestres semestre = new Semestres();

        Asignaturas asignatura = new Asignaturas();

        Secciones secciones = new Secciones();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                IdProfesorDropDownList.DataSource = profesores.Listar("1=1");
                IdProfesorDropDownList.DataValueField = "IdProfesor";
                IdProfesorDropDownList.DataTextField = "Nombres";
                IdProfesorDropDownList.DataBind();

                IdSemestreDropDownList.DataSource = semestre.Listar("1=1");
                IdSemestreDropDownList.DataValueField = "IdSemestre";
                IdSemestreDropDownList.DataTextField = "Codigo";
                IdSemestreDropDownList.DataBind();

                IdAsignaturaDropDownList.DataSource = asignatura.Listar("1=1");
                IdAsignaturaDropDownList.DataValueField = "IdAsignatura";
                IdAsignaturaDropDownList.DataTextField = "Nombre";
                IdAsignaturaDropDownList.DataBind();


                IdSeccionDropDownList.DataSource = secciones.Listar("1=1");
                IdSeccionDropDownList.DataValueField = "IdSeccion";
                IdSeccionDropDownList.DataTextField = "Numero";
                IdSeccionDropDownList.DataBind();


            }

        }

        protected void InciarButton_Click(object sender, EventArgs e)
        {
            Inscripcciones inscripciones = new Inscripcciones();

            inscripciones.Fecha = Convert.ToDateTime(FechaTextBox.Text);
            inscripciones.IdProfesor = int.Parse(IdProfesorDropDownList.SelectedValue);
            inscripciones.IdSemestre = int.Parse(IdSemestreDropDownList.SelectedValue);
            inscripciones.IdAsignatura = int.Parse(IdAsignaturaDropDownList.SelectedValue);
            inscripciones.IdSeccion = int.Parse(IdSeccionDropDownList.SelectedValue);
            

            if (inscripciones.Insertar())
            {
                Response.Redirect("PasarInscripciones.aspx?id=" + inscripciones.IdInscripcion);
            }
        }

        protected void IdProfesorDropDownList0_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}