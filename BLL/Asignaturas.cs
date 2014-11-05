using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using DAL;

namespace BLL
{
    public class Asignaturas
    {

        public int IdAsignatura { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public int Creditos { get; set; }
        public bool Activo { get; set; }

        private ConexionDb Conexion = new ConexionDb();

        public bool Insertar()
        {
            return Conexion.EjecutarDB("insert into Asignaturas(Codigo, Nombre, Creditos, Activo)" +
            "Values('" + this.Codigo + "','" + this.Nombre + "'," + this.Creditos + ",'" + this.Activo + "')");
        }

        public bool Modifcar()
        {
            return Conexion.EjecutarDB("Update Asignaturas set Codigo='" + this.Codigo + "', Nombre='" + this.Nombre + "', Creditos=" + this.Creditos + ", Activo='" + this.Activo + "' where IdAsignatura = " + IdAsignatura);
        }

        public bool Eliminar(int prmIdAsignatura)
        {
            ConexionDb Conexion = new ConexionDb();

            return Conexion.EjecutarDB("Delete from Asignaturas where IdAsignatura= " + prmIdAsignatura);
        }

        public bool Buscar(int prmIdAsignatura)
        {
            DataTable Datos = new DataTable();
            bool Retorno = false;

            Datos = Conexion.BuscarDb("Select * from Asignaturas where IdAsignatura= " + prmIdAsignatura);

            if (Datos.Rows.Count > 0)
            {
                Retorno = true;

                this.Codigo = (string)Datos.Rows[0]["Codigo"];
                this.Nombre = (string)Datos.Rows[0]["Nombre"];
                this.Creditos = (int)Datos.Rows[0]["Creditos"];
                this.Activo = (bool)Datos.Rows[0]["Activo"];
            }
            return Retorno;
        }

        public static DataTable Listar(string condicion, string columnas)
        {
            ConexionDb Conexion = new ConexionDb();
            return Conexion.BuscarDb("Select  " + columnas + "  from Asignaturas Where " + condicion);
        }
    }
}
