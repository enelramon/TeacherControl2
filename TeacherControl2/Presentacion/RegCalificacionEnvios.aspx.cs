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

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Request.QueryString["IdEnvio"] != null)
            {
                int id = int.Parse(Request.QueryString["IdEnvios"]);
                IdEnvioTextBox.Text = id.ToString();
                Buscar(id);
            }
        }

        bool Buscar(int id)
        {
            bool envio = false;
            //this.IdEnvioTarea = (int)dt.Rows[0]["IdEnvioTarea"];
            //this.IdEstudiante = (int)dt.Rows[0]["IdEstudiante"];
            //this.IdTarea = (int)dt.Rows[0]["IdTarea"];
            //this.Fecha = (DateTime)dt.Rows[0]["Fecha"];
            //this.Descripcion = (string)dt.Rows[0]["Descripcion"];
            //this.ResultadoEsperado = (string)dt.Rows[0]["ResultadoEsperado"];
            //this.Adjuntar = (string)dt.Rows[0]["Adjuntar"];
            //this.Porcentaje = (float)dt.Rows[0]["PorcentajeCalificacion"];
            //this.FechaCalificacion = (DateTime)dt.Rows[0]["FechaCalificacion"];
            //this.Calificacion = (float)dt.Rows[0]["Calificacion"];
            return envio;
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

        }
    }
}