using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace SistemaVeterinaria.Models
{
    public class Conexion
    {
        private static SqlConnection objConexion;
        private static string mensaje;

        //Método para obtener la conexión de SQL

        public static SqlConnection getConexion()
        {
            if (objConexion != null)
                return objConexion;
            objConexion = new SqlConnection();
            objConexion.ConnectionString = "Data Source=DESKTOP-B3K8QCK;Initial Catalog=Veterinaria_Sistema;Integrated Security=True";

            try
            {
                objConexion.Open();
                return objConexion;
            }
            catch(SqlException ex)
            {
                mensaje = ex.Message;
                return null;
            }
        }
    }
}