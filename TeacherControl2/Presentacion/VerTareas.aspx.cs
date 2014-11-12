using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace RegEstudiantes.Presentacion {
    public partial class VerTareas : System.Web.UI.Page {

        Tareas tarea = new Tareas();
        EnviosTareas envioTarea = new EnviosTareas();
        int idTarea = -1;
        int puntosDisponibles = 0;

        protected void Page_Load(object sender, EventArgs e) {
            if (!IsPostBack) {
                int.TryParse(Request.QueryString["IdTarea"], out idTarea);
                if (idTarea > 0) {
                    tarea.Buscar(idTarea);
                    IdTextBox.Text = idTarea.ToString();
                    FechaTextBox.Text = tarea.Fecha.ToTextFieldString();
                    VenceTextBox.Text = tarea.Vence.ToTextFieldString();
                    DescripcionTextBox.Text = tarea.Descripcion;
                    ResultadoTextBox.Text = tarea.ResultadoEsperado;
                    puntosDisponibles = Math.Min((tarea.Vence.DayOfYear - DateTime.Now.DayOfYear) * 10 + 100, 100);
                    if (puntosDisponibles > 0) {
                        PuntosLabel.ForeColor = System.Drawing.Color.Green;
                    } else {
                        PuntosLabel.ForeColor = System.Drawing.Color.Red;
                    }
                    PuntosLabel.Text = puntosDisponibles.ToString() + "%";
                }
            }
        }

        protected void AdjuntarButton_Click(object sender, EventArgs e) {
            if (TareaFileUpload.HasFile) {
                try {
                    string filename = Path.GetFileName(TareaFileUpload.FileName);
                    TareaFileUpload.SaveAs(Server.MapPath("~/Tareas/") + filename);
                    SubidaLabel.Text = "Estatus de subida: Archivo Subido!";
                    EnviarButton.Enabled = true;
                    AdjuntarButton.Enabled = false;
                } catch (Exception ex) {
                    SubidaLabel.Text = "Estatus de subida: El archvio no pudo ser subido. El siguiente error ocurrio: " + ex.Message;
                    EnviarButton.Enabled = false;
                    AdjuntarButton.Enabled = true;
                }
            }
        }

        protected void EnviarButton_Click(object sender, EventArgs e) {
            DataTable dt = Estudiantes.Listar("IdEstudiante", "Matricula = " + ((string)Session["Usuario"]).ToDbString()); // TODO: Revisar si se usara esta forma
            int idEstudiante = -1;
            if (dt.Rows.Count > 0) {
                idEstudiante = (int)dt.Rows[0]["IdEstudiante"];
                int.TryParse(Request.QueryString["IdTarea"], out idTarea);
                if (idEstudiante > 0) {
                    envioTarea.IdEstudiante = idEstudiante;
                    envioTarea.IdTarea = idTarea;
                    envioTarea.Fecha = DateTime.Now;
                    envioTarea.Descripcion = DescripcionTextBox.Text;
                    envioTarea.ResultadoEsperado = ResultadoTextBox.Text;
                    envioTarea.Adjuntar = Server.MapPath("~/Tareas/") + Path.GetFileName(TareaFileUpload.FileName);
                    envioTarea.Porcentaje = puntosDisponibles / 100;
                    envioTarea.Insertar();
                    Limpiar();
                }
            }
        }

        private void Limpiar() {
            envioTarea = new EnviosTareas();
            FechaTextBox.Text = "";
            DescripcionTextBox.Text = "";
            ResultadoTextBox.Text = "";
        }
    }
}