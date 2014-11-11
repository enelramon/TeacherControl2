using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace TeacherControl.Registro
{
    public partial class PasarTareas : System.Web.UI.Page
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
                IdTareaTextBox.Text = id.ToString();
                
            }
        }

        protected void Guardar_Click(object sender, EventArgs e)
        {
            TareasDetalle tareadetalle = new TareasDetalle();

            tareadetalle.IdTarea = int.Parse(IdTareaTextBox.Text);
            tareadetalle.IdEstudiante = int.Parse(EstudianteDropDownList.SelectedValue);
            tareadetalle.Calificacion = int.Parse(CalificacionDropDownList.SelectedValue);

            tareadetalle.Insertar();

            ConsultaGridView.DataSource = tareadetalle.Listar("1=1");
            ConsultaGridView.DataBind();
        }
    }
}