using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using DAL;

namespace BLL
{
    public class Secciones
    {
        ConexionDb conexion = new ConexionDb();

        #region "Propiedades"
        public int IdSeccion { set; get; }
        public int Numero { set; get; }
        public int IdAsignatura { set; get; }
        public int IdProfesor { set; get; }
        public string Aula { set; get; }
        public string HoraInicio { set; get; }
        public string HoraFin { set; get; }
        public bool Activo { set; get; }
        #endregion

        #region "Metodos"

        public bool Insertar()
        {
            return conexion.EjecutarDB("Insert into Secciones(Numero, IdAsignatura, IdProfesor, Aula,HoraInicio,HoraFin,Activa) values ('" + Numero +
                "','" + IdAsignatura + "','" + IdProfesor + "','" + Aula + "','" + HoraInicio + "','" + HoraFin + "','" + true + "')");
        }

        public bool Modificar()
        {
            return conexion.EjecutarDB("update Secciones set Numero ='" + Numero +
                "',IdAsignatura ='" + IdAsignatura + "',IdProfesor ='" + IdProfesor +
                "',Aula ='" + Aula + "',HoraInicio ='" + HoraInicio +
                "',HoraFin ='" + HoraFin + "' where IdSeccion = " + IdSeccion);
        }


        public bool Eliminar(string matricula)
        {
            return conexion.EjecutarDB("Delete from Secciones where IdSeccion = " + IdSeccion);
        }


        public bool Buscar(int NumeroSeccion)
        {
            bool mensaje = false;
            DataTable dt = new DataTable();
            dt = conexion.BuscarDb("Select * From Secciones where Numero = " + NumeroSeccion);
            if (dt.Rows.Count > 0)
            {
                mensaje = true;
                this.IdSeccion = (int)dt.Rows[0]["IdSeccion"];
                this.Numero = (int)dt.Rows[0]["Numero"];
                this.IdAsignatura = (int)dt.Rows[0]["IdAsignatura"];
                this.IdProfesor = (int)dt.Rows[0]["IdProfesor"];
                this.Aula = (string)dt.Rows[0]["Aula"];
                this.HoraInicio = (string)dt.Rows[0]["HoraInicio"];
                this.HoraFin = (string)dt.Rows[0]["HoraFin"];
                this.Activo = (bool)dt.Rows[0]["Activa"];
            }
            return mensaje;
        }

        public DataTable Listar(string filtro)
        {
            DataTable dt = new DataTable();
            dt = conexion.BuscarDb("Select * From Secciones where " + filtro);
            return dt;
        }


        public DataTable Listar()
        {
            DataTable dt = new DataTable();
            dt = conexion.BuscarDb("Select * From Secciones");
            return dt;
        }
        #endregion
    }
}