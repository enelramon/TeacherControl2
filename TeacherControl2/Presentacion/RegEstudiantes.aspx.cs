using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RegEstudiantes.Enlace_de_datos;
using BLL;

namespace RegEstudiantes.Presentacion
{
    public partial class RegEstudiantes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        BLL.Estudiantes estudiantes = new BLL.Estudiantes();

        const string AREA = "809,829,849";
        const int ANO_INICIALD = 1978;
        const int INICIAL_MATRICULA = 0;

        public bool validar() 
        {
            bool retorno=false;
            string mensaje1 = "", mensaje2 = "", mensaje3 = "", mensaje4 = "", mensaje5 = "", mensaje6 = "", mensaje7 = "";
            string direccionEmail = "";
            if (NombreTextBox.Text.Length == 0)
                mensaje1 = "El nombre no puede estar vacio";
            else
                mensaje1 = "";
            if (DireccionTextBox.Text.Length == 0)
                mensaje2 = "La direccion no puede estar vacio";
            else
                mensaje2 = "";
            if (SexoDropDownList.SelectedIndex == -1)
                mensaje3 = "El Sexo no ha sido selecionado";
            else
                mensaje3 = "";

            direccionEmail = EmailTextBox.Text;

            int arroba;
            int punto;

            if (direccionEmail.Length == 0)
                mensaje4 = "Email no puede estar vacio";


            else if (direccionEmail.IndexOf("@") == -1)
                mensaje4 = "El campo tiene que tener @";

            else if (direccionEmail.IndexOf(".") == -1)
                mensaje4 = "El Campo tiene que tener .";
            else
            {

                arroba = direccionEmail.IndexOf("@");
                punto = direccionEmail.IndexOf(".");
                if (punto - arroba > 4)
                    mensaje4 = "";
                else mensaje4 = "Verifique su correo";
            }

            string areatelefono;


            areatelefono = TelefonoTextBox.Text.Substring(0, 3);


            if (TelefonoTextBox.Text.Length != 12)
                mensaje5 = "Telefono incompleto";
            else if (!AREA.Contains(areatelefono))
                mensaje5 = "El area del telefono esta incorrecto ";
            else mensaje5 = "";

            areatelefono = CelularTextBox.Text.Substring(0, 3);


            if (CelularTextBox.Text.Length != 12)
                mensaje6 = "Telefono incompleto";
            else if (!AREA.Contains(areatelefono))
                mensaje6 = "El area del telefono esta incorrecto ";
            else mensaje6 = "";

            string anoMatricula;
            anoMatricula = MatriculaTextBox.Text.Substring(0, 4);

            if (MatriculaTextBox.Text.Length != 9)
                mensaje7 = "Matricula incompleta";
            else if (Convert.ToInt16(anoMatricula) < ANO_INICIALD || Convert.ToInt16(anoMatricula) > DateTime.Now.Year)
                mensaje7 = "El ano de la matricula es incorrecto";
            else if (MatriculaTextBox.Text.Substring(5, 4) == "0000")
                mensaje7 = "El inicial de la matricula comienzan por 0001";
            else mensaje7 = "";


            if (mensaje1 == "" && mensaje2 == "" && mensaje3 == "" && mensaje4 == "" && mensaje5 == "" && mensaje6 == "" && mensaje7 == "")
                retorno = true;
            return retorno;
        }

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
            BLL.Estudiantes est = new BLL.Estudiantes();

           

                est.Insertar();


            if (validar() == true)
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