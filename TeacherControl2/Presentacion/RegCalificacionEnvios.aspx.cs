﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace RegEstudiantes.Presentacion
{
    public partial class RegCalificacionEnvios : System.Web.UI.Page
    {
        EnviosTareas envio = new EnviosTareas();
        CalificarEnviosTareas calificarenvios = new CalificarEnviosTareas();
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Request.QueryString["IdEnvio"] != null)
            {
                id= int.Parse(Request.QueryString["IdEnvios"]);
                IdEnvioTextBox.Text = id.ToString();
                Buscar(id);
            }
        }

        void Buscar(int id)
        {
            envio.Buscar(id);
            TareaTextBox.Text = envio.IdTarea.ToString();
            IdEnvioTextBox.Text = envio.IdTarea.ToString();
            DescripcionTextBox.Text = envio.Descripcion;
            ResultadoEsperadTextBox.Text = envio.ResultadoEsperado;
        }

        protected void DescargarLinkButton_Click(object sender, EventArgs e)
        {
            Response.Redirect(envio.Adjuntar);
        }

        protected void RigthImageButton_Click(object sender, ImageClickEventArgs e)
        {
            
        }

        protected void LeftImageButton_Click(object sender, ImageClickEventArgs e)
        {
            
        }

        protected void CalificarButton_Click(object sender, EventArgs e)
        {
            if (envio.Buscar(id))
            {
                calificarenvios.IdTarea = id;
                calificarenvios.IdEstudiante = envio.IdEstudiante;
                calificarenvios.Calificacion = int.Parse(CalificacionTextBox.Text);
                if (calificarenvios.Id > 0)
                    calificarenvios.Modificar();
                else
                    calificarenvios.Insertar();
            }
        }
    }
}