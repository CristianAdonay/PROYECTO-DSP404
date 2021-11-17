using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaVeterinaria.Models
{
    public class Dueño:Animal
    {
        private int IDDueño;
        private string Nombredueño;
        private int Numerodui;
        private string Direccion;
        private double Edad;
        private string Email;
        private int Numerotelefono;
        private DateTime Fechaingreso;

        public int iddueño { get => IDDueño; set => IDDueño = value; }
        public string nombredueño { get => Nombredueño; set => Nombredueño = value; }
        public int numerodui { get => Numerodui; set => Numerodui = value; }
        public string direccion { get => Direccion; set => Direccion = value; }
        public double edad { get => Edad; set => Edad = value; }
        public string email { get => Email; set => Email = value; }
        public int numerotelefono { get => Numerotelefono; set => Numerotelefono = value; }
        public DateTime fechaingreso { get => Fechaingreso; set => Fechaingreso = value; }

        //Constructor con parámetros

        public Dueño(string Nombredueño, int Numerodui, string Direccion, double Edad, 
            string Email, int Numerotelefono, DateTime Fechaingreso)
        {
            this.Nombredueño = Nombredueño;
            this.Numerodui = Numerodui;
            this.Direccion = Direccion;
            this.Edad = Edad;
            this.Email = Email;
            this.Numerotelefono = Numerotelefono;
            this.Fechaingreso = Fechaingreso;
        }
        public Dueño()
        {

        }
    }
}