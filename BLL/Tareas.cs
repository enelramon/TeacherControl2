using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DAL;

namespace BLL
{
    public class Tareas
    {
        ConexionDb conexion = new ConexionDb();

        public int IdTareas { get; set; }
        public string CodigoTarea { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Vence { get; set; }
        public int IdSemestre { get; set; }
        public int IdAsignatura { get; set; }
        public int IdSeccion { get; set; }
        public string Descripcion { get; set; }



        public int GetIdTarea(string codigotarea, DateTime fecha, DateTime vence, int idsemestre, int idasignatura, int idseccion, string descripcion)
        {
            DataTable dt = new DataTable();
            dt = conexion.BuscarDb("Select IdTarea form Tareas where CodigoTarea = '"+  
               codigotarea +"' and Fecha = '"+ fecha.ToString("yyyy/MM/dd") +"' and Vence = '"+ vence.ToString("yyyy/MM/dd")+"' and IdSemestre = '"+ idsemestre
               +"' and IdAsignatura = '"+ idasignatura +"' and IdSeccion = '"+ IdSeccion +"' Descripcion = '"+ descripcion +"'  ");
            if (dt.Rows.Count > 0)
            {
                this.IdTareas = (int)dt.Rows[0]["IdTarea"];
            }
            return this.IdTareas;
        }


        public bool Insertar()
        {
            bool paso = true;
            paso = conexion.EjecutarDB("Insert into Tareas(CodigoTarea, Fecha, Vence, IdSemestre, IdAsignatura, IdSeccion, Descripcion) values ('" + CodigoTarea + "' , '"
            + Fecha.ToString("yyyy/MM/dd") + "', '" + Vence.ToString("yyyy/MM/dd") + "', '" + IdSemestre + "', '" + IdAsignatura + "', '" + IdSeccion + "', '" + Descripcion + "')");

            if (paso)
            {
                this.IdTareas = (int)conexion.ObtenerValorDb("select max (IdTarea) from Tareas");
            }

            return paso;
        }


        public bool Modificar()
        {
            return conexion.EjecutarDB("update Tareas set CodigoTarea = '" + CodigoTarea +
                "', Fecha = '" + Fecha + "', Vence = '" + Vence + "', IdSemestre = '" + IdSemestre +
                "', IdAsignatura = '" + IdAsignatura + "', IdSeccion = '" + IdSeccion + "', Descripcion = '" + Descripcion + "'");
        }


        public bool Eliminar()
        {
            return conexion.EjecutarDB("Delete from Tareas where IdTarea = " + IdTareas);
        }


        public bool Buscar(string Id)
        {
            bool mensaje = false;
            DataTable dt = new DataTable();
            dt = conexion.BuscarDb("Select * from Tareas where IdTarea = " + Id);

            if (dt.Rows.Count > 0)
            {
                mensaje = true;
                this.CodigoTarea = (string)dt.Rows[0]["CodigoTarea"];
                this.Fecha = (DateTime)dt.Rows[0]["Fecha"];
                this.Vence = (DateTime)dt.Rows[0]["Vence"];
                this.IdSemestre = (int)dt.Rows[0]["IdSemestre"];
                this.IdAsignatura = (int)dt.Rows[0]["IdAsignatura"];
                this.IdSeccion = (int)dt.Rows[0]["IdSeccion"];
                this.Descripcion = (string)dt.Rows[0]["Descripcion"];
            }
            return mensaje;
        }
    }
}