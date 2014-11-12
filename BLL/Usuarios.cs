using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class Usuarios
    {
         

        public string Nombre { set; get; }
        public string Clave { set; get; }
        public int Tipo { set; get; }
        public bool Activo { set; get; }

        ConexionDb db = new ConexionDb();
        DataTable dt = new DataTable();

        public bool Insertar()
        {
            return db.EjecutarDB(string.Format("Insert into Usuarios(Nombre, Clave, Tipo, Activo) values ('" + Nombre + "', '" + Clave + "', " + Tipo + ", '" + Activo + "')"));
        }

        public bool Autentificar()
        {
            bool retorno = false;
            dt = db.BuscarDb(string.Format("Select *from Usuarios where Nombre = '" + Nombre + "' and Clave = '" + Clave + "'"));

            if (dt.Rows.Count > 0)
            {
                retorno = true;

            }
            return retorno;

        }

        public bool Eliminar()
        {
            return db.EjecutarDB("Delete from Usuarios where Nombre = '" + Nombre + "'");
        }

        public bool Buscar()
        {
            bool retorno = false;
            dt = db.BuscarDb("Select * from Usuarios where Nombre = '" + Nombre + "'");

            if (dt.Rows.Count > 0)
            {
                Nombre = (string)dt.Rows[0]["Nombre"];
                Clave = (string)dt.Rows[0]["Clave"];
                Tipo = (int)dt.Rows[0]["Tipo"];
                Activo = (bool)dt.Rows[0]["Activo"];
                retorno = true;
            }
            return retorno;
        }

        public DataTable Listar(string Parametro)
        {
            return db.BuscarDb("Select * from Usuarios where " + Parametro);
        }

        public DataTable Listar(string Campos, string FiltroWhere)
        {
            return db.BuscarDb("Select"+Campos+"from Usuarios where " + FiltroWhere);
        }

        public bool Modificar()
        {
            return db.EjecutarDB("Update Usuarios set Nombre = '" + Nombre + "', Clave = '" + Clave + "', Tipo = " + Tipo + ", Activo = '" + Activo + "' where Nombre = "+ Nombre);
        }
    }
}
