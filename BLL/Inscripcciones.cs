using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DAL;

namespace BLL
{
    public class Inscripcciones
    {
        ConexionDb conexion = new ConexionDb();

        public int IdInscripcion { get; set; }
        public DateTime Fecha { get; set; }
        public int IdProfesor { get; set; }
        public int IdSemestre { get; set; }
        public int IdAsignatura { get; set; }
        public int IdSeccion { get; set; }



        public int GetIdSeccion(DateTime fecha ,int idprofesor, int idsemestre, int idasignatura, int idseccion)
        {
            DataTable dt = new DataTable();
            dt = conexion.BuscarDb("Select IdInscripcion from Inscripciones where Fecha = '" + fecha.ToString("yyyy/MM/dd") + "' and IdProfesor = '"+ idprofesor +"' and IdSemestre = '" + idsemestre
               + "' and IdAsignatura = '" + idasignatura + "' and IdSeccion = '" + IdSeccion + "'  ");
            if (dt.Rows.Count > 0)
            {
                this.IdInscripcion = (int)dt.Rows[0]["IdInscripcion"];
            }
            return this.IdInscripcion;
        }


        public bool Insertar()
        {
            bool paso = true;
            paso = conexion.EjecutarDB("Insert into Inscripciones(Fecha, IdProfesor, IdSemestre, IdAsignatura, IdSeccion) values ('"
            + Fecha.ToString("yyyy/MM/dd") + "', '" + IdProfesor + "', '" + IdSemestre + "', '" + IdAsignatura + "', '" + IdSeccion + "')");

            if (paso)
            {
                this.IdInscripcion = (int)conexion.ObtenerValorDb("select max (IdInscripcion) from Inscripciones");
            }

            return paso;
        }


        public bool Modificar()
        {
            return conexion.EjecutarDB("update Inscripciones set Fecha = '" + Fecha + "', IdProfesor = '" + IdProfesor + "', IdSemestre = '" + IdSemestre +
                "', IdAsignatura = '" + IdAsignatura + "', IdSeccion = '" + IdSeccion + "' ");
        }


        public bool Eliminar()
        {
            return conexion.EjecutarDB("Delete from Inscripciones where IdInscripcion = " + IdInscripcion);
        }


        public bool Buscar(string Id)
        {
            bool mensaje = false;
            DataTable dt = new DataTable();
            dt = conexion.BuscarDb("Select * from Inscripciones where IdInscripcion = " + Id);

            if (dt.Rows.Count > 0)
            {
                mensaje = true;
                this.Fecha = (DateTime)dt.Rows[0]["Fecha"];
                this.IdProfesor= (int)dt.Rows[0]["IdProfesor"];
                this.IdSemestre = (int)dt.Rows[0]["IdSemestre"];
                this.IdAsignatura = (int)dt.Rows[0]["IdAsignatura"];
                this.IdSeccion = (int)dt.Rows[0]["IdSeccion"];

            }
            return mensaje;
        }
    }
}