using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using DAL;

namespace BLL
{
    public class Asistencias
    {
        ConexionDb conexion = new ConexionDb();

        #region "Propiedades"
        public int IdAsistencia { set; get; }
        public DateTime Fecha { set; get; }
        public int IdSemestre { set; get; }
        public int IdAsignatura { set; get; }
        public int IdSeccion { set; get; }
        #endregion

        #region "Metodos"


        public int GetIdAsistencia(int idSeccion, int idAsignatura, int idSemestre, DateTime fecha)
        {
            DataTable dt = new DataTable();
            dt = conexion.BuscarDb("Select IdAsistencia From Asistencias Where IdSeccion = '" +
                idSeccion + "' and IdAsignatura = '" + idAsignatura + "' And IdSemestre = '" + idSemestre
                + "' And Fecha = '" + fecha.ToString("yyyy/MM/dd") + "'");
            if (dt.Rows.Count > 0)
            {

                this.IdAsistencia = (int)dt.Rows[0]["IdAsistencia"];
            }
            return this.IdAsistencia;
        }




        public bool Insertar()
        {
            bool paso = false;
            

            paso= conexion.EjecutarDB("Insert into Asistencias(Fecha, IdSemestre, IdAsignatura, IdSeccion) values ('" + Fecha.ToString("yyyy/MM/dd") + "','"
                + IdSemestre + "','" + IdAsignatura + "','" + IdSeccion + "')");

            if (paso)
            {
             this.IdAsistencia = (int)conexion.ObtenerValorDb("Select max(IdAsistencia) Asistencias");
            }
            
            return paso;

        }







        public bool Modificar()
        {
            return conexion.EjecutarDB("update Asistencias set Fecha ='" + Fecha +
                "',IdSemestre ='" + IdSemestre + "',IdAsignatura ='" + IdAsignatura + 
                "',IdSeccion ='" + IdSeccion + "' where IdAsistencia = " + IdAsistencia);
        }


        public bool Eliminar(string matricula)
        {
            return conexion.EjecutarDB("Delete from Asistencias where IdAsistencia = " + IdAsistencia);
        }


        public bool Buscar(string Id)
        {
            bool mensaje = false;
            DataTable dt = new DataTable();
            dt = conexion.BuscarDb("Select * From Asistencias where IdAsistencia = " + Id);
            if (dt.Rows.Count > 0)
            {
                mensaje = true;
                this.Fecha = (DateTime)dt.Rows[0]["Fecha"];
                this.IdSemestre = (int)dt.Rows[0]["IdSemestre"];
                this.IdAsignatura = (int)dt.Rows[0]["IdAsignatura"];
                this.IdSeccion = (int)dt.Rows[0]["IdSeccion"];
            }
            return mensaje;
        }

        public DataTable Listar(string filtro)
        {
            DataTable dt = new DataTable();
            dt = conexion.BuscarDb("Select * From Asistencias where " + filtro);
            return dt;
        }


        public DataTable Listar(int idseccion, int asignatura)
        {
            DataTable dt = new DataTable();
            dt = conexion.BuscarDb("SELECT Estudiantes.Matricula, Estudiantes.Nombres, Estudiantes.Apellidos  FROM Inscripciones "+ 
                "  INNER JOIN InscripcionesDetalle ON Inscripciones.IdInscripcion = InscripcionesDetalle.IdInscripcion " + 
                " INNER JOIN Estudiantes ON  Estudiantes.IdEstudiante = InscripcionesDetalle.IdEstudiante " +
                " INNER JOIN Secciones ON Secciones.IdSeccion = Inscripciones.IdSeccion " + 
                " WHERE Secciones.IdSeccion = " + idseccion + "AND Inscripciones.IdAsignatura = "+ asignatura);
            return dt;
        }


        public DataTable Listar()
        {
            DataTable dt = new DataTable();
            dt = conexion.BuscarDb("Select Estudiantes.Matricula, Estudiantes.Nombres,Estudiantes.Apellidos, Asistencias.Fecha, AsistenciasDetalle.Calificacion, Estudiantes.Email FROM Asistencias inner join AsistenciasDetalle ON Asistencias.IdAsistencia = AsistenciasDetalle.IdAsistencia inner join Estudiantes ON AsistenciasDetalle.IdEstudiante = Estudiantes.IdEstudiante ");
            return dt;
        }

        #endregion
    }
}