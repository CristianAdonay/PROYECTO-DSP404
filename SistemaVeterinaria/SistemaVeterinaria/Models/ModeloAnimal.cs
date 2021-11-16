using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace SistemaVeterinaria.Models
{
    public class ModeloAnimal
    {
        private SqlConnection MiConexion;
        private SqlCommand Comando;
        private SqlDataReader Datos;
        private string Mensaje;

        //Constructor ModeloAnimal

        public ModeloAnimal()
        {
            this.MiConexion = Conexion.getConexion();
            this.Comando = new SqlCommand();
        }

        public SqlConnection miconexion { get => MiConexion; set => MiConexion = value; }
        public SqlCommand comando { get => Comando; set => Comando = value; }
        public SqlDataReader datos { get => Datos; set => Datos = value; }
        public string mensaje { get => Mensaje; }

        //Agregando animales a la base de datos

        public int AgregarAnimal(Animal unAnimal)
        {
            int IDAnimal = 0;
            this.Mensaje = string.Empty;
            try
            {
                Comando.Connection = this.MiConexion;
                Comando.Parameters.Clear();
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandText = "AgregarAnimal";
                Comando.Parameters.AddWithValue("@idanimal", unAnimal.idanimal);
                Comando.Parameters.AddWithValue("@nombre", unAnimal.nombreanimal);
                Comando.Parameters.AddWithValue("@tipoanimal", unAnimal.tipoanimal);
                Comando.Parameters.AddWithValue("@razaanimal", unAnimal.razaanimal);
                Comando.Parameters.AddWithValue("@edadanimal", unAnimal.edadanimal);
                Comando.Parameters.AddWithValue("@nombredueño", unAnimal.nombredueño.iddueño);
                Comando.Parameters.Add("@IDAnimal", SqlDbType.Int);
                Comando.Parameters["@IDAnimal"].Direction = ParameterDirection.Output;
                Comando.ExecuteNonQuery();
                IDAnimal = Convert.ToInt32(Comando.Parameters["@IDAnimal"].Value);
            }
            catch (SqlException ex)
            {
                this.Mensaje = ex.Message;
            }
            return IDAnimal;
        }       
    }
}