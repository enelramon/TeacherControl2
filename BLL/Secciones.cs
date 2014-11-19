using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BLL
{
    public class Secciones
    {
        public int Numero { get; set; }
        public int IdAsignatura { get; set; }
        public int IdProfesor { get; set; }
        public string Aula { get; set; }
        public string HoraInicio { get; set; }
        public string HoraFin { get; set; }
        public string Activa { get; set; }
        public int IdSeccion { get; set; } 

        public bool Insertar()
        {
            string querry = "insert into Secciones(Numero,IdAsignatura,IdProfesor,Aula,HoraInicio,HoraFin,Activa)"
                + " values(" + Numero + "," + IdAsignatura + "," + IdProfesor 
                + ",'" + Aula + "','" + HoraInicio + "','" + HoraFin + "','" + Activa + "')";
            DAL.ConexionDb con = new DAL.ConexionDb();
            return con.EjecutarDB(querry);

        }

        public DataTable Search(string campos, string condicion)
        {
            string querry = "select " + campos + " from Secciones where " + condicion;
            DAL.ConexionDb con = new DAL.ConexionDb();
            return con.BuscarDb(querry);
        }

        public bool update()
        {
            DAL.ConexionDb con = new DAL.ConexionDb();
            return con.EjecutarDB("upadate Secciones set Numero =" + Numero + " ,IdAsignatura=" + IdAsignatura + ", IdProfesor='" + IdProfesor
                + ",Aula= '" + Aula + "', HoraInicio='" + HoraInicio + "', HoraFin='" + HoraFin + "',Activa='" + Activa
                + "' where IdSeccion= " + IdSeccion); ;
        }
        public bool Delete()
        {
            DAL.ConexionDb con = new DAL.ConexionDb();
            return con.EjecutarDB("delete from Secciones where= " + IdSeccion); ;
        }

        public static DataTable Listar(string condicion)
        {
            DAL.ConexionDb conexion = new DAL.ConexionDb();
            return conexion.BuscarDb("select * from Secciones where " + condicion);
        }
    }
}
