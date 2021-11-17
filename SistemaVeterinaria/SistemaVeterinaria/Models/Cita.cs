using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaVeterinaria.Models
{
    public class Cita
    {
        private int IDCita;
        private Dueño unDueño;
        private Animal unAnimal;
        private DateTime Hora;
        private DateTime Fecha;
        private string TipoAnimal;
        private string NombreAnimal;
        private string Estado;
        private string RazaAnimal;

        public int idcita { get => IDCita; set => IDCita = value; }
        public Dueño undueño { get => unDueño; set => unDueño = value; }
        public Animal unanimal { get => unAnimal; set => unAnimal = value; }
        public DateTime hora { get => Hora; set => Hora = value; }
        public DateTime fecha { get => Fecha; set => Fecha = value; }
        public string estado { get => Estado; set => Estado = value; }
        public string tipoanimal { get => TipoAnimal; set => TipoAnimal = value; }
        public string nombreanimal { get => NombreAnimal; set => NombreAnimal = value; }
        public string razaanimal { get => RazaAnimal; set => RazaAnimal = value; }

        //Constructor con parámetros

        public Cita(Dueño unDueño, Animal unAnimal, DateTime Hora, DateTime Fecha, string Estado ,string TipoAnimal, string NombreAnimal, string RazaAnimal)
        {
            this.unDueño = unDueño;
            this.unAnimal = unAnimal;
            this.TipoAnimal = TipoAnimal;
            this.NombreAnimal = NombreAnimal;
            this.RazaAnimal = RazaAnimal;
            this.Estado = Estado;
            this.Fecha = Fecha;
            this.Hora = Hora;        
        }

        public Cita()
        {
            unDueño = new Dueño();
            unAnimal = new Animal();
        }
    }
}