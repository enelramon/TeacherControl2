using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;


namespace BLL
{
    class AsistenciasDetalle
    {
        public int Id { get; set; }
        public int IdAsistencia { set; get; }
        public int IdEstudiante { set; get; }
        public byte Calificacion { set; get; }

        private ConexionDb Conexion = new ConexionDb();

        /// <summary>
        /// Insertar AsistenciasDetalle.....
        /// </summary>
        public bool Insertar()
        {
            return Conexion.EjecutarDB("insert into AsistenciasDetalle(Fecha, IdAsignatura, IdEstudiante, Calificacion)" +
               "Values("+ this.IdAsistencia + "," + this.IdEstudiante + "," + this.Calificacion + ")");
        }

        /// <summary>
        /// Modificar AsistenciasDetalle.....
        /// </summary>
        public bool Modificar()
        {
            return Conexion.EjecutarDB("Update AsistenciasDetalle " +
                "set IdAsistencia=" + this.IdAsistencia + "', IdEstudiante=" + this.IdEstudiante + ", Calificacion=" + this.Calificacion +  " " +
                "Where Id = " + this.Id);
        }

        /// <summary>
        /// Eliminar AsistenciasDetalle.....
        /// </summary>
        public bool Eliminar(int prmIdAsistencias)
        {
            ConexionDb Conexion = new ConexionDb();

            return Conexion.EjecutarDB("Delete from AsistenciasDetalle where Id = " + prmIdAsistencias);
        }

        /// <summary>
        /// Buscar AsistenciasDetalle.....
        /// </summary>
        public bool Buscar(int prmIdAsistencias)
        {
            DataTable Datos = new DataTable();
            bool Retorno = false;

            Datos = Conexion.BuscarDb("Select * from AsistenciasDetalle Where Id=" + prmIdAsistencias);

            if (Datos.Rows.Count > 0)
            {
                Retorno = true;

                this.Id = (int)Datos.Rows[0]["Id"];
                this.IdAsistencia = (int)Datos.Rows[0]["IdAsistencia"];
                this.IdEstudiante = (int)Datos.Rows[0]["IdEstudiante"];
                this.Calificacion = (byte)Datos.Rows[0]["Calificacion"];

            }
            return Retorno;
        }


        public DataTable Listar(string FiltroWhere)
        {

            return Conexion.BuscarDb("Select * from AsistenciasDetalle Where " + FiltroWhere);
        }


    }
}

