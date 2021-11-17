using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace SistemaVeterinaria.Models
{
    public class ModeloDueño
    {
        private SqlConnection MiConexion;
        private SqlCommand Comando;
        private SqlDataReader Datos;
        private string Mensaje;

        public ModeloDueño()
        {
            this.MiConexion = Conexion.getConexion();
            this.Comando = new SqlCommand();
        }

        public string mensaje { get => Mensaje; set => Mensaje = value; }

        public bool AgregarDueño(Dueño unDueño)
        {
            bool Registrado = false;
            this.Mensaje = string.Empty;
            try
            {
                Comando.Transaction = this.MiConexion.BeginTransaction();
                Comando.Connection = this.MiConexion;

                //Agregando tabla de dueños
                Comando.CommandText = "Insert into dueños values" +
                    "(@IDDueño,@Nombredueño,@Numerodui,@Direccion,@Edad,@Email,@Numerotelefono, @Fechaingreso)";
                Comando.Parameters.AddWithValue("@IDDueño", unDueño.iddueño);
                Comando.Parameters.AddWithValue("@Nombredueño", unDueño.nombredueño);
                Comando.Parameters.AddWithValue("@Numerodui", unDueño.numerodui);
                Comando.Parameters.AddWithValue("@Direccion", unDueño.direccion);
                Comando.Parameters.AddWithValue("@Edad", unDueño.edad);
                Comando.Parameters.AddWithValue("@Email", unDueño.email);
                Comando.Parameters.AddWithValue("@Numerotelefono", unDueño.numerotelefono);
                Comando.Parameters.AddWithValue("@Fechaingreso", unDueño.fechaingreso);

                //Obteniendo el ID del dueño
                Comando.Parameters.Clear();
                Comando.CommandText = "Select IDDueño from dueños " +
                    "where periddueño=@IDDueño";
                Comando.Parameters.AddWithValue("@IDDueño", unDueño.iddueño);
                unDueño.iddueño = Convert.ToInt32(Comando.ExecuteScalar());

                //Terminando
                Comando.Transaction.Commit();
                Registrado = true;
            }
            catch (SqlException ex)
            {
                Comando.Transaction.Rollback();
                this.Mensaje = ex.Message;
            }
            return Registrado;
        }
    }
}