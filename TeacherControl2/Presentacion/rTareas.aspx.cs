using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
namespace RegEstudiantes.Presentacion
{
    public partial class rTareas : System.Web.UI.Page
    {
        //Asignaturas asignatura = new Asignaturas();
        //Semestres semestre = new Semestres();
        Tareas tarea = new Tareas();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FechaTextBox.Text = DateTime.Today.ToString("yyyy-MM-dd");
                VenceTextBox.Text = DateTime.Today.AddDays(1).ToString("yyyy-MM-dd");

                AsignaturaDropDownList.DataSource = Asignaturas.Listar(" IdAsignatura, Nombre "," 1=1 ");
                AsignaturaDropDownList.DataValueField = "IdAsignatura";
                AsignaturaDropDownList.DataTextField = "Nombre";
                AsignaturaDropDownList.DataBind();

                SemestreDropDownList.DataSource = Semestres.Listar(" Codigo, IdSemestre", " 1=1 ");
                SemestreDropDownList.DataTextField = "Codigo";
                SemestreDropDownList.DataValueField = "IdSemestre";
                SemestreDropDownList.DataBind();

                if (Request.QueryString["IdTarea"] != null)
                {
                    EliminarButton.Visible = true;
                }
            
            }
        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            tarea.CodigoTarea = CodigoTareaTextBox.Text;
            tarea.Fecha = Convert.ToDateTime(FechaTextBox.Text);
            tarea.Vence = Convert.ToDateTime(VenceTextBox.Text);
            tarea.IdSemestre = int.Parse(SemestreDropDownList.SelectedItem.Value);
            tarea.IdAsignatura = int.Parse(AsignaturaDropDownList.SelectedItem.Value);
            tarea.Descripcion = DescripcionTextBox.Text;
            tarea.ResultadoEsperado = ResultadoEsperadoTextBox.Text;
            if (tarea.Insertar())
            {
                Response.Write("Registro Completado!");
            }else
            {
                Response.Write("Registro No Completado!");
            }
        }

        protected void EliminarButton_Click(object sender, EventArgs e)
        {
            if (Request.QueryString["IdTarea"]!=null)
            {
                tarea.IdTarea = int.Parse(Request.QueryString["IdTarea"].ToString());
                if (tarea.Eliminar())
                {
                    Response.Write("Registro Eliminado!");
                }
                else
                {
                    Response.Write("Error operacion fallida!");
                }
            }
        }
    }
}