using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace RegEstudiantes.Presentacion
{
    public partial class RegistroEstudiantes : System.Web.UI.Page
    {
        BLL.Estudiantes estudiantes = new BLL.Estudiantes();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["Estudianteid"] != null)
            {
                IdEstudianteTextBox.Text = Request.QueryString["Estudianteid"];
                Buscar();
            }
        }


        const string AREA = "809,829,849";
        const int ANO_INICIALD = 1978;
        const int INICIAL_MATRICULA = 0;

       

        public void Limpiar()
        {
            IdEstudianteTextBox.Text = "";
            MatriculaTextBox.Text = "";
            NombreTextBox.Text = "";
            SexoDropDownList.SelectedIndex = 0;
            DireccionTextBox.Text = "";
            FechaNacTextBox.Text = "";
            EmailTextBox.Text = "";
            TelefonoTextBox.Text = "";
            CelularTextBox.Text = "";
        }

        protected void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            
                int idestudiante = 0;
                int.TryParse(IdEstudianteTextBox.Text, out idestudiante);
                estudiantes.IdEstudiante = idestudiante;
                estudiantes.Matricula = MatriculaTextBox.Text;
                estudiantes.Nombre = NombreTextBox.Text;

                estudiantes.Direccion = DireccionTextBox.Text;
                estudiantes.FechaNac = Convert.ToDateTime(FechaNacTextBox.Text);
                estudiantes.Genero = SexoDropDownList.SelectedIndex;
                estudiantes.Email = EmailTextBox.Text;
                estudiantes.Telefono = TelefonoTextBox.Text;
                estudiantes.Celular = CelularTextBox.Text;
                if (idestudiante == 0)
                    estudiantes.Insertar();
                else
                    estudiantes.Modificar();
                Limpiar();
            }
        

        protected void EliminarButton_Click(object sender, EventArgs e)
        {
            if (IdEstudianteTextBox.Text.Length > 0)
            {
                int idestudiante = 0;
                int.TryParse(IdEstudianteTextBox.Text, out idestudiante);
                estudiantes.IdEstudiante = idestudiante;
                estudiantes.Eliminar();
            }

            Limpiar();

        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            Buscar();
        }
        void Buscar() 
        {
            int idestudiante = 0;
            int.TryParse(IdEstudianteTextBox.Text, out idestudiante);
            estudiantes.IdEstudiante = idestudiante;
            if (estudiantes.Buscar() == true)
            {
                MatriculaTextBox.Text = estudiantes.Matricula;
                NombreTextBox.Text = estudiantes.Nombre;
                DireccionTextBox.Text = estudiantes.Direccion;
                FechaNacTextBox.Text = estudiantes.FechaNac.ToString("yyyy-MM-dd");
                SexoDropDownList.SelectedIndex = estudiantes.Genero;
                EmailTextBox.Text = estudiantes.Email;
                TelefonoTextBox.Text = estudiantes.Telefono;
                CelularTextBox.Text = estudiantes.Celular;
            }
            else
                Limpiar();
        }

        protected void IdEstudianteTextBox_TextChanged(object sender, EventArgs e)
        {
            int id;
            int.TryParse(IdEstudianteTextBox.Text, out id);
            estudiantes.IdEstudiante = id;
            if (estudiantes.Buscar() == false)
            {
                IdEstudianteTextBox.Text = "";
            }
        }

        protected void IdEstudianteTextBox_PreRender(object sender, EventArgs e)
        {
            int id;
            int.TryParse(IdEstudianteTextBox.Text, out id);
            estudiantes.IdEstudiante = id;
            if (estudiantes.Buscar() == false)
            {
                IdEstudianteTextBox.Text = "";
            }
        }

        protected void IdEstudianteTextBox_TextChanged1(object sender, EventArgs e)
        {
            int id;
            int.TryParse(IdEstudianteTextBox.Text, out id);
            estudiantes.IdEstudiante = id;
            if (estudiantes.Buscar() == false)
            {
                IdEstudianteTextBox.Text = "";
            }
        }
    }
}