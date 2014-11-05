using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DAL;

namespace BLL {

    public class EnviosTareas {

        public int IdEnvioTarea { get; set; }
        public int IdEstudiante { get; set; }
        public int IdTarea { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public string ResultadoEsperado { get; set; }
        public string Adjuntar { get; set; }
        public float Porcentaje { get; set; }
        public DateTime FechaCalificacion { get; set; }
        public float Calificacion { get; set; }

        ConexionDb conexion = new ConexionDb();

        public bool Insertar() {
            return conexion.EjecutarDB("insert into EnviosTareas(IdEstudiante, IdTarea, Fecha, Descripcion, ResultadoEsperado, Adjuntar, Porcentaje) values(" + IdEstudiante + "," + IdTarea + "," + Fecha.ToDbString() + "," + Descripcion.ToDbString() + "," + ResultadoEsperado.ToDbString() + "," + Adjuntar.ToDbString() + "," + Porcentaje + ");");
        }

        public bool Eliminar() {
            return conexion.EjecutarDB("delete from EnviosTareas where IdEnvioTarea = " + IdEnvioTarea);
        }

        public bool Modificar() {
            return conexion.EjecutarDB("update EnviosTareas set IdEstudiante = " + IdEstudiante + ", IdTarea = " + IdTarea + ", Fecha = " + Fecha.ToDbString() + ", Descripcion = " + Descripcion.ToDbString() + ", ResultadoEsperado = " + ResultadoEsperado.ToDbString() + ", Adjuntar = " + Adjuntar.ToDbString() + ", Porcentaje = " + Porcentaje + ", FechaCalificacion = " + FechaCalificacion.ToDbString() + ", Calificacion = " + Calificacion + " where IdEnvioTarea = " + IdEnvioTarea + ";");
        }

        public bool Buscar(int id) {
            bool mensaje = false;
            DataTable dt = conexion.BuscarDb("select * from EnviosTareas where IdEnvioTarea = " + id);
            if (dt.Rows.Count > 0) {
                mensaje = true;
                this.IdEnvioTarea = (int)dt.Rows[0]["IdEnvioTarea"];
                this.IdEstudiante = (int)dt.Rows[0]["IdEstudiante"];
                this.IdTarea = (int)dt.Rows[0]["IdTarea"];
                this.Fecha = (DateTime)dt.Rows[0]["Fecha"];
                this.Descripcion = (string)dt.Rows[0]["Descripcion"];
                this.ResultadoEsperado = (string)dt.Rows[0]["ResultadoEsperado"];
                this.Adjuntar = (string)dt.Rows[0]["Adjuntar"];
                this.Porcentaje = (float)dt.Rows[0]["Porcentaje"];
                this.FechaCalificacion = (DateTime)dt.Rows[0]["FechaCalificacion"];
                this.Calificacion = (float)dt.Rows[0]["Calificacion"];
            }
            return mensaje;
        }

        public static DataTable Listar(string condicion) {
            ConexionDb conexion = new ConexionDb();
            return conexion.BuscarDb("select * from EnviosTareas where " + condicion);
        }

        public static DataTable Listar(string columnas, string condicion) {
            ConexionDb conexion = new ConexionDb();
            return conexion.BuscarDb("select " + columnas + " from EnviosTareas where " + condicion);
        }

    }
}
