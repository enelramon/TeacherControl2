using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace RegEstudiantes.Presentacion {
    public partial class RegistroTareas : System.Web.UI.Page {

        Tareas tarea = new Tareas();

        protected void Page_Load(object sender, EventArgs e) {
            if (!IsPostBack) {
                DataTable SemestreDT = Semestres.Listar("IdSemestre, Codigo", "1=1");
                SemestreDropDownList.DataSource = SemestreDT;
                SemestreDropDownList.DataTextField = "";
                SemestreDropDownList.DataValueField = "IdSemestre";
                SemestreDropDownList.DataBind();

                DataTable AsignaturaDT = Asignaturas.Listar("1=1", "IdAsignatura, Nombre"); //encuentro esto contra-intuitivo
                AsignaturaDropDownList.DataSource = AsignaturaDT;
                AsignaturaDropDownList.DataTextField = "Nombre";
                AsignaturaDropDownList.DataValueField = "IdAsignatura";
                AsignaturaDropDownList.DataBind();

                int id = -1;
                int.TryParse(Request.QueryString["IdTarea"], out id);
                if (id > 0) {
                    Buscar(id);
                }

            }
        }

        protected void NuevoButton_Click(object sender, EventArgs e) {
            Limpiar();
        }

        protected void GuardarButton_Click(object sender, EventArgs e) {
            
            tarea.CodigoTarea = CodigoTextBox.Text;
            tarea.Fecha = FechaTextBox.Text.ToDate();
            tarea.Vence = FechaTextBox.Text.ToDate();
            tarea.IdSemestre = int.Parse(SemestreDropDownList.SelectedItem.Value);
            tarea.IdAsignatura = int.Parse(AsignaturaDropDownList.SelectedItem.Value);
            tarea.Descripcion = DescripcionTextBox.Text;
            tarea.ResultadoEsperado = ResultadoEsperadoTextBox.Text;

            int id = -1;
            int.TryParse(IdTextBox.Text, out id);
            tarea.IdTarea = id;
            if (tarea.IdTarea < 1) { //if its new
                tarea.Insertar();
            } else { //else modify
                tarea.Modificar();
            }

            Limpiar();
        }

        protected void EliminarButton_Click(object sender, EventArgs e) {
            int id = -1;
            int.TryParse(IdTextBox.Text, out id);
            tarea.IdTarea = id;
            if (tarea.IdTarea > 0) { //if there's an id
                tarea.Eliminar();
                Limpiar();
            }
        }

        protected void BuscarButton_Click(object sender, EventArgs e) {
            int id = -1;
            int.TryParse(IdTextBox.Text, out id);
            if (id > 0) {
                Buscar(id);
            }
        }

        private void Limpiar() {
            IdTextBox.Text = "";
            CodigoTextBox.Text = "";
            FechaTextBox.Text = "";
            VenceTextBox.Text = "";
            SemestreDropDownList.SelectedIndex = 0;
            AsignaturaDropDownList.SelectedIndex = 0;
            DescripcionTextBox.Text = "";
            ResultadoEsperadoTextBox.Text = "";
        }

        private void Buscar(int id) {
            if (tarea.Buscar(id)) {
                CodigoTextBox.Text = tarea.CodigoTarea;
                FechaTextBox.Text = tarea.Fecha.ToTextFieldString();
                VenceTextBox.Text = tarea.Vence.ToTextFieldString();
                foreach (ListItem item in SemestreDropDownList.Items) {
                    item.Selected = false;
                    if (item.Value == tarea.IdSemestre.ToString()) {
                        item.Selected = true;
                    }
                }
                foreach (ListItem item in AsignaturaDropDownList.Items) {
                    item.Selected = false;
                    if (item.Value == tarea.IdAsignatura.ToString()) {
                        item.Selected = true;
                    }
                }
                DescripcionTextBox.Text = tarea.Descripcion;
                ResultadoEsperadoTextBox.Text = tarea.ResultadoEsperado;
            } else {
                Limpiar();
            }
            IdTextBox.Text = id.ToString();
        }
    }
}