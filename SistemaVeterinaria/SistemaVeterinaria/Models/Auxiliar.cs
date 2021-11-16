using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaVeterinaria.Models
{
    public class Auxiliar : Registro
    {
        private int IDAuxiliar;
        private Registro unRegistro;
        private Cita unaCita;
        private Dueño unDueño;
        private Animal unAnimal;


        //Constructor con parámetros     

        public int idauxiliar { get => IDAuxiliar; set => IDAuxiliar = value; }
        public Registro unregistro { get => unRegistro; set => unRegistro = value; }
        public Cita unacita { get => unaCita; set => unaCita = value; }
        public Dueño undueño { get => unDueño; set => unDueño = value; }
        public Animal unanimal { get => unAnimal; set => unAnimal = value; }

        public Auxiliar()
        {
            unRegistro = new Registro();
            unacita = new Cita();
            undueño = new Dueño();
            unanimal = new Animal();
        }
    }
}