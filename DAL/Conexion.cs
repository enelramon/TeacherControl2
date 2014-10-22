using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
namespace DAL
{
    public class Conexion
    {
        //todo:forma correcta de leer el ConnectionString
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        /// <summary>
        /// para ejecutar todos los codigos
        /// </summary>
        /// <param name="Codigo"></param>
        /// <returns></returns>
        public bool EjecutarDB(string Codigo)
        {
            bool mensaje = false;
            SqlCommand cmd = new SqlCommand();

            try
            {
                con.Open(); // abrimos la conexion
                //MessageBox.Show("Conexion abierta");

                cmd.Connection = con; //asignamos la conexion
                cmd.CommandText = Codigo;     //asignamos el comando
                cmd.ExecuteNonQuery(); // ejecutamos el comando

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                mensaje = true;
                con.Close(); //cerramos la conexion
                // MessageBox.Show("Conexion cerrada");

            }
            return mensaje;
        }

        /// <summary>
        /// para buscar datos en la base de datos
        /// </summary>
        /// <param name="comando"></param>
        /// <returns></returns>
        public DataTable BuscarDb(string comando)
        {
            SqlDataAdapter adp;
            DataTable dt = new DataTable();
            try
            {
                con.Open(); // abrimos la conexion
                adp = new SqlDataAdapter(comando, con);

                adp.Fill(dt);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close(); //cerramos la conexion

            }
            return dt;
        }
    

       //void prueba()
       // {
       //     DataTable dt = BuscarDb("select nombre from estudiantes");
       //    SqlDataReader 
       //    //dt.Rows[0]["nombre"]
       //     cmd.ExecuteScalar();
       // }

    }
}