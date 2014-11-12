using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DAL;

namespace BLL {
    public class Tareas {

        public int IdTarea { set; get; }
        public string CodigoTarea { set; get; }
        public DateTime Fecha { set; get; }
        public DateTime Vence { set; get; }
        public int IdSemestre { set; get; }
        public int IdAsignatura { set; get; }
        public string Descripcion { set; get; }
        public string ResultadoEsperado { set; get; }

        ConexionDb conexion = new ConexionDb();

        public bool Insertar() {
            bool paso = conexion.EjecutarDB("insert into Tareas(CodigoTarea, Fecha, Vence, IdSemestre, IdAsignatura, Descripcion, ResultadoEsperado) values(" + CodigoTarea.ToDbString() + "," + Fecha.ToDbString() + "," + Vence.ToDbString() + "," + IdSemestre + "," + IdAsignatura + "," + Descripcion.ToDbString() + "," + ResultadoEsperado.ToDbString() + ")");
            if (paso)
                this.IdTarea = (int)conexion.ObtenerValorDb("select MAX(IdTarea) from Tareas");
            return paso;
        }


        public bool Eliminar() {
            return conexion.EjecutarDB("Delete from Tareas where IdTarea = " + IdTarea);
        }

        public bool Modificar() {
            return conexion.EjecutarDB("Update Tareas set CodigoTarea = " + CodigoTarea.ToDbString() + ", Fecha = " + Fecha.ToDbString() + ", Vence = " + Vence.ToDbString() + ", IdSemestre = " + IdSemestre + ", IdAsignatura = " + IdAsignatura + ", Descripcion = " + Descripcion.ToDbString() + ", ResultadoEsperado = " + ResultadoEsperado.ToDbString() + " where IdTarea = " + IdTarea);
        }

        public bool Buscar(int Id) {
            bool mensaje = false;
            DataTable dt;
            dt = conexion.BuscarDb("select * from Tareas where IdTarea = " + Id);
            if (dt.Rows.Count > 0) {
                mensaje = true;
                DataRow row = dt.Rows[0];
                this.IdTarea = (int)row["IdTarea"];
                this.CodigoTarea = (string)row["CodigoTarea"];
                this.Fecha = (DateTime)row["Fecha"];
                this.Vence = (DateTime)row["Vence"];
                this.IdSemestre = (int)row["IdSemestre"];
                this.IdAsignatura = (int)row["IdAsignatura"];
                this.Descripcion = (string)row["Descripcion"];
                this.ResultadoEsperado = (string)row["ResultadoEsperado"];
            }
            return mensaje;
        }

        public static DataTable Listar(string condicion) {
            ConexionDb conexion = new ConexionDb();
            return conexion.BuscarDb("select * from Tareas where " + condicion);
        }

        public static DataTable Listar(string columnas, string condicion) {
            ConexionDb conexion = new ConexionDb();
            return conexion.BuscarDb("select " + columnas + " from Tareas where " + condicion);
        }
    }
}