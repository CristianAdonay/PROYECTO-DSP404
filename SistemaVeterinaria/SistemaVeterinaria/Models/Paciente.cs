using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaVeterinaria.Models
{
    public class Paciente
    {
        private int IDUsuario;
        private Dueño unDueño;
        private Animal unAnimal;
        private string Entrar;
        private string Contraseña;

        public int idusuario { get => IDUsuario; set => IDUsuario = value; }
        public Dueño Undueño { get => unDueño; set => unDueño = value; }
        public Animal Unanimal { get => unAnimal; set => unAnimal = value; }
        public string entrar { get => Entrar; set => Entrar = value; }
        public string contraseña { get => Contraseña; set => Contraseña = value; }

        //Constructor

        public Paciente(string Entrar, string Contraseña)
        {
            this.Entrar = Entrar;
            this.Contraseña = Contraseña;
            this.unDueño = new Dueño();
            this.unAnimal = new Animal();

        }

        public Paciente()
        {
            this.unDueño = new Dueño();
            this.unAnimal = new Animal();
        }

        //Generar contraseña

        public string crearContraseña()
        {
            string cadena = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ0123456789@#$%&!";

            string Contraseña = string.Empty;
            Random aleatorio = new Random();
            for (int i=0;i < 6; i++)
            {
                int alea = aleatorio.Next(0, 70);
                Contraseña += cadena[alea];
            }
            return Contraseña;
        }
    }
}