using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaVeterinaria.Models
{
    public class Animal
    {
        private int IDAnimal;
        private string TipoAnimal;
        private string NombreAnimal;
        private string RazaAnimal;
        private double EdadAnimal;
        private Dueño NombreDueño;

        public int idanimal { get => IDAnimal; set => IDAnimal = value; }
        public string tipoanimal { get => TipoAnimal; set => TipoAnimal = value; }
        public string nombreanimal { get => NombreAnimal; set => NombreAnimal = value; }
        public string razaanimal { get => RazaAnimal; set => RazaAnimal = value; }
        public double edadanimal { get => EdadAnimal; set => EdadAnimal = value; }
        public Dueño nombredueño { get => nombredueño; set => nombredueño = value; }

        //Constructor con parámetros

        public Animal(int IDAnimal, string TipoAnimal, string NombreAnimal, string RazaAnimal, double EdadAnimal, Dueño NombreDueño)
        {
            this.IDAnimal = IDAnimal;
            this.TipoAnimal = TipoAnimal;
            this.NombreAnimal = NombreAnimal;
            this.RazaAnimal = RazaAnimal;
            this.EdadAnimal = EdadAnimal;
            this.NombreDueño = NombreDueño;
        }

        //Constructor vacío

        public Animal()
        {
            this.NombreDueño = new Dueño();
        }
    }
}