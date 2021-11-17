using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace SistemaVeterinaria.Models
{
    public class ModeloPaciente
    {
        private SqlConnection MiConexion;
        private SqlCommand Comando;
        private SqlDataReader Datos;
        private string Mensaje;

        //Constructor

        public ModeloPaciente()
        {
            this.MiConexion = Conexion.getConexion();
            this.Comando = new SqlCommand();
        }

        public Paciente iniciarSesion(Paciente unPaciente)
        {
            Paciente user = null;
            this.Mensaje = string.Empty;
            try
            {
                Comando.Connection = this.MiConexion;
                Comando.Transaction = this.MiConexion.BeginTransaction();
                Comando.CommandText = "Select dueños.*, pacientes.* from personas inner join pacientes" +
                    " on pacientes.pacDueño = dueños.IDDueño where pacientes.pacentrar=@Entrar and" +
                    " pacientes.paccontraseña=@Contraseña";
                Comando.Parameters.AddWithValue("@Entrar", unPaciente.entrar);
                Comando.Parameters.AddWithValue("@Contraseña", unPaciente.contraseña);
                SqlDataReader Datos = Comando.ExecuteReader();
                if (Datos.Read())
                {
                    user = new Paciente();
                    user.Undueño.iddueño = Convert.ToInt32(Datos["IDDueño"]);
                    user.idusuario = Convert.ToInt32(Datos["IDPersona"]);
                    user.entrar = Datos["pacentrar"].ToString();
                    user.contraseña = Datos["paccontraseña"].ToString();
                    user.Undueño.iddueño = Datos[""].ToString();
                    user.Undueño.nombredueño = Datos[""].ToString();
                    user.Undueño.numerodui = Datos[""].ToString();
                    user.Undueño.direccion = Datos[""].ToString();
                    user.Undueño.edad = Datos[""].ToString();
                    user.Undueño.email = Datos[""].ToString();
                    user.Undueño.numerotelefono = Datos[""].ToString();
                    user.Undueño.fechaingreso = Datos[""].ToString();
                    Datos.Close();
                  
                }
                Datos.Close();
                Comando.Transaction.Commit();
            }
            catch (SqlException ex)
            {
                Datos.Close();
                Comando.Transaction.Rollback();
                this.Mensaje = ex.Message;
            }
            return user;
        }

        //Obtener los datos personales de un dueño de acuerdo al IDDueño

        public Dueño obtenerDatosDueño(int IDDueño)
        {
            Dueño unDueño = null;
            this.Mensaje = null;
            try
            {
                Comando.Connection = this.MiConexion;
                Comando.Parameters.Clear();
                Comando.CommandText = "select * from dueños where IDDueño=@ID";
                Comando.Parameters.AddWithValue("@ID", IDDueño);
                Datos = Comando.ExecuteReader();
                if (Datos.Read())
                {
                    unDueño = new Dueño();
                    unDueño.iddueño = IDDueño;
                    
                }
            }
            catch (SqlException ex)
            {
                this.Mensaje = ex.Message;
            }
            finally
            {
                Datos.Close();
            }
            return unDueño;
        }
    }
}