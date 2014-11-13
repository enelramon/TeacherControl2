using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using DAL;

namespace BLL
{
    public class Deudas
    {
        public int IdDeuda { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Vence { get; set; }
        public int IdSemestre { get; set; }
        public int IdEstudiante { get; set; }
        public int IdAsignatura { get; set; }
        public int Cantidad { get; set; }
        public int Balance { get; set; }

        private ConexionDb Conexion = new ConexionDb();

        public bool Insertar()
        {
            return Conexion.EjecutarDb("insert into Deudas(Fecha, Vence, IdSemestre, IdEstudiante, IdAsignatura, Cantidad, Balance)" +
                "values('" + this.Fecha.ToString("MM/dd/yyyy HH:mm:ss") + "','" + this.Vence.ToString("MM/dd/yyyy HH:mm:ss") + "'," + this.IdSemestre + "," + this.IdEstudiante + "," + this.IdAsignatura + "," + this.Cantidad + "," + this.Balance + ")");
        }

        public bool Modificar()
        {
            return Conexion.EjecutarDb("Update Deudas set Fecha ='" + this.Fecha.ToString("MM/dd/yyyy HH:mm:ss") + "', Vence = '" + Vence.ToString("MM/dd/yyyy HH:mm:ss") + "', IdSemestre = " + this.IdSemestre + ", IdEstudiante = " + this.IdEstudiante + ", IdAsignatura = " + this.IdAsignatura + ", Cantidad = " + this.Cantidad + ", Balance = " + this.Balance + " where IdDeuda = " + IdDeuda);
        }

        public static bool Eliminar(int prmIdDeuda)
        {
            ConexionDb Conexion = new ConexionDb();

            return Conexion.EjecutarDb("Delete from Deudas where IdDeuda = " + prmIdDeuda);
        }

        public bool Buscar(int prmIdDeuda)
        {
            DataTable Datos = new DataTable();
            bool Retorno = false;

            Datos = Conexion.BuscarDb("Select * from Deudas where IdDeuda = " + prmIdDeuda);

            if (Datos.Rows.Count > 0)
            {
                Retorno = true;

                this.Fecha = (DateTime)Datos.Rows[0]["Fecha"];
                this.Vence = (DateTime)Datos.Rows[0]["Vence"];
                this.IdSemestre = (int)Datos.Rows[0]["IdSemestre"];
                this.IdEstudiante = (int)Datos.Rows[0]["IdEstudiante"];
                this.IdAsignatura = (int)Datos.Rows[0]["IdAsignatura"];
                this.Cantidad = (int)Datos.Rows[0]["Cantidad"];
                this.Balance = (int)Datos.Rows[0]["Balance"];
            }
            return Retorno;
        }

        public static DataTable Listar(string Columna, string Condicion)
        {
            ConexionDb Conexion = new ConexionDb();
            return Conexion.BuscarDb("Select " + Columna + " from Deudas where " + Condicion);
        }
    }
}
