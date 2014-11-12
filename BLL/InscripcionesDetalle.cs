using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DAL;

namespace BLL
{
    public class InscripcionesDetalle
    {
         ConexionDb conexion = new ConexionDb();

        public int Id { get; set; }
        public int IdDetalle { get; set; }
        public int IdInscripcion { get; set; }
        public int IdEstudiante { get; set; }

        public InscripcionesDetalle()
        {

        }
        public InscripcionesDetalle(int IdInscripcion, int IdEstudiante)
        {
            this.IdInscripcion = IdInscripcion;
            this.IdEstudiante = IdEstudiante;
        }


        public bool Insertar()
        {
            bool paso = true;

            paso = conexion.EjecutarDB("Insert into InscripcionesDetalle(IdInscripcion, IdEstudiante) values ('" + IdInscripcion
                + "','" + IdEstudiante + "')");

            if (paso)
            {
                this.Id = (int)conexion.ObtenerValorDb("Select max(Id) from InscripcionesDetalle");
            }

            return paso;
        }

        public bool Modificar()
        {
            return conexion.EjecutarDB("update InscripcionesDetalle set IdInscripcion ='" + IdInscripcion +
                "', IdEstudiante ='" + IdEstudiante + "' where Id = '" + IdDetalle + "'");
        }

        public bool Eliminar(string matricula)
        {
            return conexion.EjecutarDB("Delete from TareasDetalle where Id = " + IdDetalle);
        }

        public bool Buscar(string Id)
        {
            bool mensaje = false;
            DataTable dt = new DataTable();
            dt = conexion.BuscarDb("Select * From IncripcionesDetalle where Id = " + Id);
            if (dt.Rows.Count > 0)
            {
                mensaje = true;
                
                this.IdDetalle = (int)dt.Rows[0]["Id"];
                this.IdInscripcion = (int)dt.Rows[0]["IdInscripcion"];
                this.IdEstudiante = (int)dt.Rows[0]["IdEstudiante"];
  
            }
            return mensaje;
        }

        public DataTable Listar(string filtro)
        {
            DataTable dt = new DataTable();
            dt = conexion.BuscarDb("Select * From InscripcionesDetalle where " + filtro);
            return dt;
        }
    }
}