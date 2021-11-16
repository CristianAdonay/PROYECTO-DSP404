using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaVeterinaria.Models
{
    public class Registro:Cita
    {
        private Cita unaCita;

        public Cita unacita { get => unaCita; set => unaCita = value; }

        //Constructor para registrar cita

        public Registro()
        {
            unaCita = new Cita();
        }
    }
}