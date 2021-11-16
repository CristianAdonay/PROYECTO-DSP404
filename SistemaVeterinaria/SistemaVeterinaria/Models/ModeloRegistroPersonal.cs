using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace SistemaVeterinaria.Models
{
    public class ModeloRegistroPersonal
    {
        private SqlConnection MiConexion;
        private SqlCommand Comando;
        private SqlDataReader Datos;
        private string Mensaje;


        //Constructor

        
        public ModeloRegistroPersonal()
        {
            this.MiConexion = Conexion.getConexion();
            Comando = new SqlCommand();
        }


        public string mensaje { get => Mensaje; set => Mensaje = value; }

        // Agregando parámetros y comandos para registrar personal


        public bool AgregarPersonal(RegistroPersonal unPersonal)
        {
            bool Registrado = false;
            this.Mensaje = string.Empty;
            try
            {
                Comando.Transaction = this.MiConexion.BeginTransaction();
                Comando.Connection = this.MiConexion;

                //Aregando tabla personal
                Comando.CommandText = "Insert into personales values" +
                    "@Identi,@Nombreusuario,@Contraseña,@Edad,@";
            }
            catch (SqlException ex)
            {
                this.Mensaje = ex.Message;
            }
            return Registrado;
        }
    }
}
