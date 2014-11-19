using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace RegEstudiantes.Presentacion
{
    public partial class RegistroUsuario : System.Web.UI.Page
    {
        Usuarios usuario = new Usuarios();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ConsultarBotton_Click(object sender, EventArgs e)
        {
            Response.Redirect("ConsultarUsuario.aspx");
        }

        protected void CrearButton_Click(object sender, EventArgs e)
        {
            usuario.Nombre = NombreTextBox.Text;
            usuario.Clave = ClaveTextBox.Text;
            usuario.Tipo = TipoDropDownList.SelectedIndex;
            usuario.Activo = ActivoCheckBox.Checked;

            usuario.Insertar();

        }
        public void Limpiar()
        {
            NombreTextBox.Text = "";
            ClaveTextBox.Text = "";
            ActivoCheckBox.Checked = false;
        }

        protected void BuscarBotton_Click(object sender, EventArgs e)
        {
            usuario.Nombre = NombreTextBox.Text;
            usuario.Buscar();

            ClaveTextBox.Text = usuario.Clave;
            TipoDropDownList.SelectedIndex = usuario.Tipo;
            ActivoCheckBox.Checked = usuario.Activo;
        }

        protected void LimpiarBotton_Click(object sender, EventArgs e)
        {
            NombreTextBox.Text = "";
            ClaveTextBox.Text = "";
            ActivoCheckBox.Checked = false;
        }

        protected void EliminarButton_Click(object sender, EventArgs e)
        {
            usuario.Nombre = NombreTextBox.Text;
            usuario.Eliminar();
            Limpiar();

        }
    }
}