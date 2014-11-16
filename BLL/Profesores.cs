using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using DAL;

namespace BLL
{
    public class Profesores
    {
        ConexionDb conexion = new ConexionDb();

        #region "Propiedades"
        public int IdProfesor { set; get; }
        public string Nombres { set; get; }
        public string Apellidos { set; get; }
        public string Direccion { set; get; }
        public int Genero { set; get; }
        public DateTime FechaNacimiento { set; get; }
        public string Email { set; get; }
        public string Telefono1 { set; get; }
        public string Telefono2 { set; get; }
        #endregion

        #region "Metodos"
        public bool Insertar()
        {
            return conexion.EjecutarDB("Insert into Profesores( Nombres, Apellidos, Direccion,Genero,FechaNacimiento,Email,Telefono1,Telefono2)values('" 
                + Nombres + "','" + Apellidos + "','" + Direccion + "','" + Genero + "','" + FechaNacimiento.ToString("MM/dd/yyyy") +
                "','" + Email + "','" + Telefono1 + "','" + Telefono2 + "')");
        }

        public bool Modificar()
        {
            return conexion.EjecutarDB("update Profesores set Nombres='" + Nombres + "',Apellidos='" +
                Apellidos + "',Direccion='" + Direccion + "',Genero='" + Genero + "',FechaNacimiento='" + 
                FechaNacimiento.ToString("MM/dd/yyyy") + "',Email='" + Email + "',Telefono1='" + Telefono1 +
                "',Telefono2='" + Telefono2 + "' where IdProfesor=" + IdProfesor);

        }


        public bool Eliminar(int IdProfesor)
        {
            return conexion.EjecutarDB("Delete from Profesores where IdProfesor =" + IdProfesor);
        }


        public bool Buscar(string prmNombre)
        {
            bool Retorno = false;
            DataTable Datos = new DataTable();
            Datos = conexion.BuscarDb("Select * From Profesores where Nombres = '" + prmNombre + "'");
            if (Datos.Rows.Count > 0)
            {
                Retorno = true;
                this.IdProfesor = (int)Datos.Rows[0]["IdProfesor"];
                this.Nombres = (string)Datos.Rows[0]["Nombres"];
                this.Apellidos = (string)Datos.Rows[0]["Apellidos"];
                this.Direccion = (string)Datos.Rows[0]["Direccion"];
                this.Genero = Convert.ToInt32((byte)Datos.Rows[0]["Genero"]);
                this.FechaNacimiento = (DateTime)Datos.Rows[0]["FechaNacimiento"];
                this.Email = (string)Datos.Rows[0]["Email"];
                this.Telefono1 = (string)Datos.Rows[0]["Telefono1"];
                this.Telefono2 = (string)Datos.Rows[0]["Telefono2"];    
            }
            return Retorno;
        }

        public DataTable Listar(string filtroWhere)
        {

            return conexion.BuscarDb("Select * From Profesores where " + filtroWhere);

        }



        public DataTable Listar()
        {
            DataTable dt = new DataTable();
            dt = conexion.BuscarDb("Select * From Profesores");
            return dt;
        }
        #endregion
    }
}