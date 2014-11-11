using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace TeacherControl.Registro
{
    public partial class IniciarTareas : System.Web.UI.Page
    {
        Semestres semestre = new Semestres();

        Asignaturas asignatura = new Asignaturas();

        Secciones secciones = new Secciones();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                IdAsignaturaDropDownList.DataSource = asignatura.Listar("1=1");
                IdAsignaturaDropDownList.DataValueField = "IdAsignatura";
                IdAsignaturaDropDownList.DataTextField = "Nombre";
                IdAsignaturaDropDownList.DataBind();


                IdSeccionDropDownList.DataSource = secciones.Listar("1=1");
                IdSeccionDropDownList.DataValueField = "IdSeccion";
                IdSeccionDropDownList.DataTextField = "Numero";
                IdSeccionDropDownList.DataBind();

                IdSemestreDropDownList.DataSource = semestre.Listar("1=1");
                IdSemestreDropDownList.DataValueField = "IdSemestre";
                IdSemestreDropDownList.DataTextField = "Codigo";
                IdSemestreDropDownList.DataBind();

            }

        }

        protected void InciarButton_Click(object sender, EventArgs e)
        {
            Tareas tarea = new Tareas();

            tarea.CodigoTarea = Convert.ToString(CodigoTareaTextBox.Text);
            tarea.Fecha = Convert.ToDateTime(FechaTextBox.Text);
            tarea.Vence = Convert.ToDateTime(VenceTextBox.Text);
            tarea.IdSemestre = int.Parse(IdSemestreDropDownList.SelectedValue);
            tarea.IdAsignatura = int.Parse(IdAsignaturaDropDownList.SelectedValue);
            tarea.IdSeccion = int.Parse(IdSeccionDropDownList.SelectedValue);
            tarea.Descripcion = Convert.ToString(DescripcionTextBox.Text);

            if (tarea.Insertar())
            {
                Response.Redirect("PasarTareas.aspx?id=" + tarea.IdTareas);
            }

        }

        protected void FechaTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}