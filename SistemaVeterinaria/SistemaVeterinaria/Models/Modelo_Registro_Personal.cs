using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace SistemaVeterinaria.Models
{
    public class Modelo_Registro_Personal
    {
        private SqlConnection MiConexion;
        private SqlCommand Comando;
        private SqlDataReader Datos;
        private string Mensaje;
        public Modelo_Registro_Personal()
        {
            this.MiConexion = Conexion.getConexion();
            Comando = new SqlCommand();
        }
        public string mensaje { get => Mensaje; set => Mensaje = value; }
    }

    // Agregando parámetros y comandos para registrar personal
    public Persona AgendarPersona(string identificacion)
    {
        Persona unaPersona = null;
        this.mensaje = string.Empty;
        try

        {
            {
                this.Comando.Connection = this.MiConexion;
                this.Comando.Parameters.Clear();
                Comando.CommandText = "select Personal.* from Personal" +
                    " where personal.perIdentificacion=@identificacion";
                Comando.Parameters.AddWithValue("@identificacion", identificacion);
                Datos = Comando.ExecuteReader();
                if (Datos.Read())
                {
                    unaPersona = new Personal();
                    unaPersona.IdRegistro = Convert.ToInt32(Datos["IdRegistro"]);
                    unaPersona.Nombreusuario = Datos["Nombreusuario"].ToString();
                    unaPersona.Contraseña = Datos["Contraseña"].ToString();
                    unaPersona.Nombrecompleto = Datos["Nombrecompleto"].ToString();
                    unaPersona.inEmail = Datos["Email"].ToString();
                    unaPersona.inFechaIngreso = Datos["FechaIngreso"].ToString();
                }
            }
            Datos.Close();
        }
        catch (SqlException ex)
        {
            this.Mensaje = ex.Message;
        }
        return unPersonal;
    }





}
