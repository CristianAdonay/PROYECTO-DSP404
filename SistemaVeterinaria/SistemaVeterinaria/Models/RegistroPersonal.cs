using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaVeterinaria.Models
{
    public class RegistroPersonal
    {
        //Generando variables

        private int IDPersonal;
        private Personal unPersonal;
        private string Nombreusuario;
        private string Contraseña;
        private double Edad;
        private string Nombrecompleto;
        private int ID;
        private DateTime FechaIngreso;
        private string Email;

        //Obteniendo variables con get y set para el registro del usuario

        public int idpersonal { get => IDPersonal; set => IDPersonal = value; }
        public Personal unpersonal { get => unPersonal; set => unPersonal = value; }
        public string nombreusuario { get => Nombreusuario; set => Nombreusuario = value; }
        public string contraseña { get => Contraseña; set => Contraseña = value; }
        public double edad { get => Edad; set => Edad = value; }
        public string nombrecompleto { get => Nombrecompleto; set => Nombrecompleto = value; }
        public int id { get => ID; set => ID = value; }
        public DateTime fechaingreso { get => FechaIngreso; set => FechaIngreso = value; }
        public string email { get => Email; set => Email = value; }

        //Constructor con parámetros

        public RegistroPersonal(string Nombreusuario, string Contraseña, double Edad, 
            string Nombrecompleto, int ID, DateTime FechaIngreso, string Email)
        {
            this.unpersonal = new Personal();
            this.Nombreusuario = Nombreusuario;
            this.Contraseña = Contraseña;
            this.ID = ID;
            this.FechaIngreso = FechaIngreso;
        }

        //Generar contraseña

        public string Generarcontraseña()
        {
            string cadena = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ0123456789@#$%&!";

            string Contraseña = string.Empty;
            Random random = new Random();
            for (int i=0; i<6;i++)
            {
                int ran = random.Next(0, 70);
                Contraseña += cadena[ran];
            }
            return Contraseña;
        }
    }
}