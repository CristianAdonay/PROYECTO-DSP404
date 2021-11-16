using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaVeterinaria.Models
{
    public class Cita
    {
        private int IDCita;
        private DateTime Hora;
        private DateTime Fecha;
        private string TipoAnimal;
        private string NombreAnimal;
        private string RazaAnimal;

        public int idcita { get => IDCita; set => IDCita = value; }
        public DateTime hora { get => Hora; set => Hora = value; }
        public DateTime fecha { get => Fecha; set => Fecha = value; }
        public string tipoanimal { get => TipoAnimal; set => TipoAnimal = value; }
        public string nombreanimal { get => NombreAnimal; set => NombreAnimal = value; }
        public string razaanimal { get => RazaAnimal; set => RazaAnimal = value; }

        //Constructor con parámetros

        public Cita(DateTime Hora, DateTime Fecha, string TipoAnimal, string NombreAnimal, string RazaAnimal)
        {
            this.TipoAnimal = TipoAnimal;
            this.NombreAnimal = NombreAnimal;
            this.RazaAnimal = RazaAnimal;
            this.Fecha = Fecha;
            this.Hora = Hora;        
        }

        public Cita()
        {

        }
    }
}