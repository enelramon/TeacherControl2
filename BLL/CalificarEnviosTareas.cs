using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL;

namespace BLL
{
    public class CalificarEnviosTareas
    {
        public int Id { set; get; }
        public int IdTarea { set; get; }
        public int IdEstudiante { set; get; }
        public int Calificacion { set; get; }

        ConexionDb conexion = new ConexionDb();

        public bool Insertar()
        {
            return conexion.EjecutarDB("Insert into TareasDetalle(IdTarea,IdEstudiante,Calificacion)Values(" + IdTarea + "," + IdEstudiante + "," + Calificacion + ")");
        }

        public bool Modificar()
        {
            return conexion.EjecutarDB("Update TareasDetalle set IdTarea=" + IdTarea + ",IdEstudiante=" + IdEstudiante + ",Calificacion=" + Calificacion + " Where Id=" + Id);
        }

        public bool Eliminar(int Id)
        {
            return conexion.EjecutarDB("Delete from TareasDetalle where id=" + Id);
        }

        public bool Buscar(int Id)
        {
            DataTable dt = new DataTable();
            bool Retorno = true;
            dt = conexion.BuscarDb("Select * from TareasDetalle where id=" + Id);
            if (dt.Rows.Count > 0)
            {
                this.IdTarea = (int)dt.Rows[0]["idTarea"];
                this.IdEstudiante = (int)dt.Rows[0]["idEstudiante"];
                this.Calificacion = (int)dt.Rows[0]["Calificacion"];
            }
            return Retorno;
        }

        public DataTable Listar(string Columna, string Filtro)
        {
            return conexion.BuscarDb("Select " + Columna + "from TareasDetalle where" + Filtro);
        }
    }
}