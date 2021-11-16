using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace SistemaVeterinaria.Models
{
    public class ModeloCita
    {
        private SqlConnection MiConexion;
        private SqlCommand Comando;
        private SqlDataReader Datos;
        private string Mensaje;

        public ModeloCita()
        {
            this.MiConexion = Conexion.getConexion();
            Comando = new SqlCommand();
        }

        public string mensaje { get => Mensaje; set => Mensaje = value; }

        // Agregando parámetros y comandos para registrar la cita de un animal

        public bool AgregarCita(Cita unaCita)
        {
            this.Mensaje = string.Empty;
            bool Registrada = false;
            try
            {
                Comando.Connection = this.MiConexion;
                Comando.Parameters.Clear();
                Comando.CommandText = "Insert into Citas values(@tipoanimal,@nombreanimal,@razaanimal)";
                Comando.Parameters.AddWithValue("@nombreanimal", unaCita.nombreanimal);
                Comando.Parameters.AddWithValue("@tipoanimal", unaCita.tipoanimal);
                Comando.Parameters.AddWithValue("@razaanimal", unaCita.razaanimal);
                Comando.ExecuteNonQuery();
                Registrada = true;
            }
            catch (SqlException ex)
            {
                this.Mensaje = ex.Message;
            }
            return Registrada;
        }

        //Agregando parámetros y comandos para cancelar la cita de un animal

        public bool cancelarCita(Cita unaCita)
        {
            this.mensaje = string.Empty;
            bool Cancelada = false;
            try
            {
                Comando.Connection = this.MiConexion;
                Comando.Parameters.Clear();
                Comando.CommandText = "update Citas set citanombreanimal=@nombre," +
                    " citatipoanimal=@TipoAnimal where IDCita=@IDCita";
                Comando.Parameters.AddWithValue("@nombre", unaCita.nombreanimal);
                Comando.Parameters.AddWithValue("@TipoAnimal", unaCita.tipoanimal);
                Comando.Parameters.AddWithValue("@IDCita", unaCita.idcita);
                Comando.ExecuteNonQuery();
                Cancelada = true;
            }
            catch (SqlException ex)
            {
                this.Mensaje = ex.Message;
            }
            return Cancelada;
        }
    }
}