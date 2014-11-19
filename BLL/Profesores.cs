using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BLL
{
    public class Profesores
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Genero { get; set; }
        public string FechaNacimiento { get; set; }
        public string Email { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public int IdProfesor { get; set; }

        public bool Insertar()
        {
            string querry = "insert into Profesores(Nombres,Apellidos,Direccion,Genero,FechaNacimiento,Email,Telefono1,Telefono2)"
                + " values('" + Nombres + "','" + Apellidos + "','" + Direccion + "','" + Genero + "','" + FechaNacimiento + "','" + Email + "','" + Telefono1 + "','" + Telefono2 + "')";
            DAL.ConexionDb con = new DAL.ConexionDb();
            return con.EjecutarDB(querry);
        }

        public DataTable Buscar(string campos, string condicion)
        {
            string querry = "select " + campos + " from Profesores where " + condicion;
            DAL.ConexionDb con = new DAL.ConexionDb();
            return con.BuscarDb(querry);
        }

        public bool Modificar()
        {
            DAL.ConexionDb con = new DAL.ConexionDb();
            con.EjecutarDB("upadate Profesores set Nombres= '" + Nombres + "', Apellidos='" + Apellidos + "', Direccion= '" + Genero + "'"
                + " FechaNacimiento='" + FechaNacimiento + "',Email='" + Email + "',Telefono1='" + Telefono1 + "',Telefono2='" + Telefono2 + "' where IdAsignatura=" + IdProfesor);
            return true;
        }
        public bool Eliminar()
        {
            DAL.ConexionDb con = new DAL.ConexionDb();
            con.EjecutarDB("delete from Profesores where=" + IdProfesor);
            return true;
        }

        public static DataTable Listar(string condicion)
        {
            DAL.ConexionDb conexion = new DAL.ConexionDb();
            return conexion.BuscarDb("select * from Profesores where " + condicion);
        }
    }
    
}
