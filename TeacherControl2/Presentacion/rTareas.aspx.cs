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
                    tarea.IdTarea = int.Parse(Request.QueryString["IdTarea"].ToString());
                    if (tarea.Buscar(tarea.IdTarea))
                    {
                        CodigoTareaTextBox.Text = tarea.CodigoTarea;
                        FechaTextBox.Text = tarea.Fecha.ToString("yyyy-MM-dd");
                        VenceTextBox.Text = tarea.Vence.ToString("yyyy-MM-dd");
                        AsignaturaDropDownList.SelectedIndex = AsignaturaDropDownList.Items.IndexOf(AsignaturaDropDownList.Items.FindByValue(tarea.IdAsignatura.ToString()));
                        SemestreDropDownList.SelectedIndex = SemestreDropDownList.Items.IndexOf(SemestreDropDownList.Items.FindByValue(tarea.IdSemestre.ToString()));
                        DescripcionTextBox.Text = tarea.Descripcion;
                        ResultadoEsperadoTextBox.Text = tarea.ResultadoEsperado;
                        EliminarButton.Visible = true;
                    }
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
            if (Request.QueryString["IdTarea"] != null)
            {
                tarea.IdTarea = int.Parse(Request.QueryString["IdTarea"].ToString());
                if (tarea.Modificar())
                {
                    Response.Write("Registro completado");
                }
                else
                {
                    Response.Write("Registro no completado");
                }
            }
            else
            {
                if (tarea.Insertar())
                {
                    Response.Write("Registro completado");
                }
                else
                {
                    Response.Write("Registro no completado");
                }
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

        protected void NuevoButton_Click(object sender, EventArgs e)
        {
            Nuevo();
        }
        public void Nuevo()
        {
            EliminarButton.Visible = false;
            CodigoTareaTextBox.Text = "";
            FechaTextBox.Text = "";
            VenceTextBox.Text = "";
            DescripcionTextBox.Text = "";
            ResultadoEsperadoTextBox.Text = "";
            EliminarButton.Visible = false;
        }
    }
}