using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace TeacherControlWeb
{
    public partial class rDeudasChoco : System.Web.UI.Page
    {
        Deudas deuda = new Deudas();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                IdSemestreDropDownList.DataSource = Semestres.Listar("IdSemestre, Codigo", "1=1");
                IdSemestreDropDownList.DataValueField = "IdSemestre";
                IdSemestreDropDownList.DataTextField = "Codigo";
                IdSemestreDropDownList.DataBind();

                IdEstudianteDropDownList.DataSource = Estudiantes.Listar("IdEstudiante, Nombres", "1=1");
                IdEstudianteDropDownList.DataValueField = "IdEstudiante";
                IdEstudianteDropDownList.DataTextField = "Nombres";
                IdEstudianteDropDownList.DataBind();

                IdAsignaturaDropDownList.DataSource = Asignaturas.Listar("IdAsignatura, Nombre", "1=1");
                IdAsignaturaDropDownList.DataValueField = "IdAsignatura";
                IdAsignaturaDropDownList.DataTextField = "Nombre";
                IdAsignaturaDropDownList.DataBind();
            }
        }

        protected void AceptarButton_Click(object sender, EventArgs e)
        {
            int IdDeudaChoco;
            int.TryParse(IdDeudaTextBox.Text, out IdDeudaChoco);

            int Cantidad;
            int.TryParse(CantidadTextBox.Text, out Cantidad);

            DateTime Fecha;
            DateTime.TryParse(FechaTextBox.Text, out Fecha);

            DateTime Vence;
            DateTime.TryParse(VenceTextBox.Text, out Vence);
            
            deuda.IdDeuda = IdDeudaChoco;
            deuda.Fecha = Fecha;
            deuda.Vence = Vence;
            deuda.IdSemestre = int.Parse(IdSemestreDropDownList.SelectedItem.Value);
            deuda.IdEstudiante = int.Parse(IdEstudianteDropDownList.SelectedItem.Value);
            deuda.IdAsignatura = int.Parse(IdAsignaturaDropDownList.SelectedItem.Value);
            deuda.Cantidad = Cantidad;
            deuda.Balance = Cantidad;

            if(IdDeudaChoco == 0)
            {
                deuda.Insertar();
                Nuevo();
            }
            else
            {
                deuda.Modificar();
                Nuevo();
            }
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            int IdDeudaChoco = 0;
            int.TryParse(IdDeudaTextBox.Text, out IdDeudaChoco);
            int Balance;
            int.TryParse(BalanceTextBox.Text, out Balance);

            deuda.IdDeuda = IdDeudaChoco;
            if (deuda.Buscar(IdDeudaChoco) == true)
            {
                FechaTextBox.Text = deuda.Fecha.ToString("yyyy-MM-dd");
                VenceTextBox.Text = deuda.Vence.ToString("yyyy-MM-dd");
                IdSemestreDropDownList.SelectedIndex = IdSemestreDropDownList.Items.IndexOf(IdSemestreDropDownList.Items.FindByValue(deuda.IdSemestre.ToString()));
                IdEstudianteDropDownList.SelectedIndex = IdEstudianteDropDownList.Items.IndexOf(IdEstudianteDropDownList.Items.FindByValue(deuda.IdEstudiante.ToString()));
                IdAsignaturaDropDownList.SelectedIndex = IdAsignaturaDropDownList.Items.IndexOf(IdAsignaturaDropDownList.Items.FindByValue(deuda.IdAsignatura.ToString()));
                CantidadTextBox.Text = deuda.Cantidad.ToString(); ;
                BalanceTextBox.Text = deuda.Balance.ToString();
            }
            else
            {
                Nuevo();
            }
        }

        protected void EliminarButton_Click(object sender, EventArgs e)
        {
            int IdDeudaChoco = 0;
            int.TryParse(IdDeudaTextBox.Text, out IdDeudaChoco);

            if (IdDeudaChoco != 0)
            {
                deuda.IdDeuda = IdDeudaChoco;
                Deudas.Eliminar(IdDeudaChoco);
                Nuevo();
            }
            else
            {
                Nuevo();
            }
        }

        protected void NuevoButton_Click(object sender, EventArgs e)
        {
            Nuevo();
        }
        void Nuevo()
        {
            IdDeudaTextBox.Text = "";
            FechaTextBox.Text = "";
            VenceTextBox.Text = "";
            IdSemestreDropDownList.SelectedIndex = -1;
            IdEstudianteDropDownList.SelectedIndex = -1;
            IdAsignaturaDropDownList.SelectedIndex = -1;
            CantidadTextBox.Text = "";
            BalanceTextBox.Text = "";
        }
    }
}