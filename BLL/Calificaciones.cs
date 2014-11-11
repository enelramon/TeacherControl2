using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace TeacherControl.BLL
{


    public class Calificaciones
    {


        public int IdCalificaciones { get; set; }
        public DateTime Fecha { set; get; }
        public int IdAsignatura { get; set; }
        public int IdEstudiante { set; get; }
        public int Calificacion { set; get; }

        public ConexionDb Conexion = new ConexionDb();

        public bool Insertar()
        {
            return Conexion.EjecutarDB("insert into Calificaciones(Fecha,IdAsignatura,IdEstudiante,Calificacion)values ('" + Fecha.ToString("dd/MM/yyyy HH:mm:ss") + "'," + IdAsignatura + ", " + IdEstudiante + "," + Calificacion + ")");

        }

        public bool Modificar()
        {
            return Conexion.EjecutarDB("Update Calificaciones set Fecha = '" + Fecha.ToString("dd/MM/yyyy HH:mm:ss") + "', IdAsignatura = " + IdAsignatura + ", IdEstudiante= " + IdEstudiante + ", Calificacion=" + Calificacion + "where IdCalificacion =" + IdCalificaciones); 
        }
        public bool Eliminar(int prmIdCalificaciones)
        {
            return Conexion.EjecutarDB("Delete from Calificaciones where IdCalificacion = " + prmIdCalificaciones);
        }

        public bool Buscar(int prmIdCalificaciones)
        {
            DataTable Datos = new DataTable();
            bool Retorno = false;

            Datos = Conexion.BuscarDb("Select * from Calificaciones Where IdCalificacion=" + prmIdCalificaciones);

            if (Datos.Rows.Count > 0)
            {
                Retorno = true;

                this.IdCalificaciones = (int)Datos.Rows[0]["IdCalificacion"];
                this.IdAsignatura = (int)Datos.Rows[0]["IdAsignatura"];
                this.Fecha = (DateTime)Datos.Rows[0]["Fecha"];
                this.IdEstudiante = (int)Datos.Rows[0]["IdEstudiante"];
                this.Calificacion = (int)Datos.Rows[0]["Calificacion"];
                
            }


            return Retorno;
        }

        public DataTable Listar(string Busqueda)
        {
            return Conexion.BuscarDb("uspCalificacionesConsultar '" + Busqueda + "'");
        }
    }
}
