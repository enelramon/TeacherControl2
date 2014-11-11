using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DAL;
namespace BLL
{
    public class TareasDetalle
    {
        ConexionDb conexion = new ConexionDb();

        public int Id { get; set; }
        public int IdDetalle { get; set; }
        public int IdTarea { get; set; }
        public int IdEstudiante { get; set; }
        public int Calificacion { get; set; }

        public TareasDetalle()
        {

        }
        public TareasDetalle(int IdTarea, int IdEstudiante, int Calificacion)
        {
            this.IdTarea = IdTarea;
            this.IdEstudiante = IdEstudiante;
            this.Calificacion = Calificacion;
        }


        public bool Insertar()
        {
            bool paso = true;

            paso = conexion.EjecutarDB("Insert into TareasDetalle(IdTarea, IdEstudiante, Calificacion) values ('" + IdTarea
                + "', '" + IdEstudiante + "','" + Calificacion + "')");

            if (paso)
            {
                this.Id = (int)conexion.ObtenerValorDb("Select max(Id) from TareasDetalle");
            }

            return paso;
        }

        public bool Modificar()
        {
            return conexion.EjecutarDB("update TareasDetalle set IdTarea ='" + IdTarea +
                "',IdEstudiante ='" + IdEstudiante + "',Calificacion ='" + Calificacion + "' where Id = '" + IdDetalle + "'");
        }

        public bool Eliminar(string matricula)
        {
            return conexion.EjecutarDB("Delete from TareasDetalle where Id = " + IdDetalle);
        }

                public bool Buscar(string Id)
        {
            bool mensaje = false;
            DataTable dt = new DataTable();
            dt = conexion.BuscarDb("Select * From TareasDetalle where Id = " + Id);
            if (dt.Rows.Count > 0)
            {
                mensaje = true;
                
                this.IdDetalle = (int)dt.Rows[0]["Id"];
                this.IdTarea = (int)dt.Rows[0]["IdTarea"];
                this.IdEstudiante = (int)dt.Rows[0]["IdEstudiante"];
                this.Calificacion = (int)dt.Rows[0]["Calificacion"];
            }
            return mensaje;
        }

        public DataTable Listar(string filtro)
        {
            DataTable dt = new DataTable();
            dt = conexion.BuscarDb("Select * From TareasDetalle where " + filtro);
            return dt;
        }


    }
}