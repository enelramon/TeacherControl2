using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace LogingUsuario.GUI
{
    public partial class ConsultarUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        Usuarios usuario = new Usuarios();
        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            string Parametro = "1=1";

            if (BuscarDropDownList.SelectedIndex == 1)
            {
                Parametro += " and Tipo  = 1 ";

            }
            else
             
             if (BuscarDropDownList.SelectedIndex == 0)
           
              Parametro += " and Tipo  = 0 ";
            
            ListadoGridView.DataSource = null;
            ListadoGridView.DataSource = usuario.Listar(Parametro);
            ListadoGridView.DataBind();
        }
    }
}