using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DAL;

namespace BLL
{
    public class Estudiantes
    {
        public int IdEstudiante { set; get; }
        public string Matricula { set; get; }
        public string Nombre { set; get; }
        public string Direccion { set; get; }
        public int Genero { set; get; }
        public DateTime FechaNac { set; get; }
        public string Email { set; get; }
        public string Telefono { set; get; }
        public string Celular { set; get; }

        ConexionDb conexion = new ConexionDb();
        
        public bool Insertar()
        {
            return conexion.EjecutarDB("insert into Estudiantes(Matricula,Nombres,Direccion,Genero,FechaNacimiento,Email,Telefono1,Telefono2)Values('" + Matricula + "','" + Nombre + "','" + Direccion + "'," + Genero + ",'" + FechaNac.ToString("MM/dd/yyyy HH:mm:ss") + "','" + Email + "','" + Telefono + "','" + Celular + "')");
        }
        
        public bool Eliminar()
        {
            return conexion.EjecutarDB("Delete from Estudiantes where IdEstudiante = " + IdEstudiante);
        }

        public bool Modificar()
        {
            return conexion.EjecutarDB("update estudiantes set Matricula ='" + Matricula + "',Nombres = '" + Nombre + "',Direccion='" + Direccion + "',Genero=" + Genero + ",FechaNacimiento='" + FechaNac.ToString("MM/dd/yyyy HH:mm:ss") + "',Email='" + Email + "',Telefono1='" + Telefono + "',Telefono2='" + Celular + "' where IdEstudiante = " + IdEstudiante);
        }
        
        public bool Buscar()
        {
            bool mensaje = false;
            DataTable dt = new DataTable();
            dt = conexion.BuscarDb("select *from Estudiantes where IdEstudiante = " + IdEstudiante);
            if (dt.Rows.Count > 0)
            {
                mensaje = true;
                this.IdEstudiante = (int)dt.Rows[0]["IdEstudiante"];
                this.Matricula = (string)dt.Rows[0]["Matricula"];
                this.Nombre = (string)dt.Rows[0]["Nombres"];
                this.Direccion = (string)dt.Rows[0]["Direccion"];
                this.Genero = (byte)dt.Rows[0]["Genero"];
                this.FechaNac = (DateTime)dt.Rows[0]["FechaNacimiento"];
                this.Email = (string)dt.Rows[0]["Email"];
                this.Telefono = (string)dt.Rows[0]["Telefono1"];
                this.Celular = (string)dt.Rows[0]["Telefono2"];
            }
            return mensaje;
        }

        public static DataTable Listar(string condicion, string columnas)
        {
            ConexionDb conexion = new ConexionDb();
            return conexion.BuscarDb("select " + columnas + " from Estudiantes Where " + condicion);
        }

      
    }
}