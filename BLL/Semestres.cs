using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DAL;

namespace BLL {
    public class Semestres {

        public int IdSemestre { set; get; }
        public string Codigo { set; get; }
        public DateTime FechaInicio { set; get; }
        public DateTime FechaFin { set; get; }
        public DateTime FechaParcial1 { set; get; }
        public DateTime FechaParcial2 { set; get; }
        public DateTime FechaFinal { set; get; }
        public bool Activo { set; get; }

        ConexionDb conexion = new ConexionDb();

        public bool Insertar() {
            bool paso = conexion.EjecutarDB("insert into Semestres(Codigo, FechaInicio, FechaFin, FechaParcial1, FechaParcial2, FechaFinal, Activo) values(" + Codigo.ToDbString() + "," + FechaInicio.ToDbString() + "," + FechaFin.ToDbString() + "," + FechaParcial1.ToDbString() + "," + FechaParcial2.ToDbString() + "," + FechaFinal.ToDbString() + "," + Activo.ToDbString() + ")");
            if (paso)
                this.IdSemestre = (int)conexion.ObtenerValorDb("select MAX(IdSemestre) from Semestres");
            return paso;
        }

        public bool Eliminar() {
            return conexion.EjecutarDB("Delete from Semestres where IdSemestre = " + IdSemestre);
        }

        public bool Modificar() {
            return conexion.EjecutarDB("Update Semestres set Codigo = " + Codigo.ToDbString() + ", FechaInicio = " + FechaInicio.ToDbString() + ", FechaFin = " + FechaFin.ToDbString() + ", FechaParcial1 = " + FechaParcial1.ToDbString() + ", FechaParcial2 = " + FechaParcial2.ToDbString() + ", FechaFinal = " + FechaFinal.ToDbString() + ", Activo = " + Activo.ToDbString() + " where IdSemestre = " + IdSemestre);
        }

        public bool Buscar(int Id) {
            bool mensaje = false;
            DataTable dt;
            dt = conexion.BuscarDb("select * from Semestres where IdSemestre = " + Id);
            if (dt.Rows.Count > 0) {
                mensaje = true;
                DataRow row = dt.Rows[0];
                this.IdSemestre = (int)row["IdSemestre"];
                this.Codigo = (string)row["Codigo"];
                this.FechaInicio = (DateTime)row["FechaInicio"];
                this.FechaFin = (DateTime)row["FechaFin"];
                this.FechaParcial1 = (DateTime)row["FechaParcial1"];
                this.FechaParcial2 = (DateTime)row["FechaParcial2"];
                this.FechaFinal = (DateTime)row["FechaFinal"];
                this.Activo = (bool)row["Activo"];
            }
            return mensaje;
        }

        public static DataTable Listar(string condicion) {
            ConexionDb conexion = new ConexionDb();
            return conexion.BuscarDb("select * from Semestres where " + condicion);
        }

        public static DataTable Listar(string columnas, string condicion) {
            ConexionDb conexion = new ConexionDb();
            return conexion.BuscarDb("select " + columnas + " from Semestres where " + condicion);
        }
    }
}