using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaVeterinaria.Models
{
    public class Veterinario:Diagnostico
    {
        private Diagnostico unDiagnostico;

        public Diagnostico undiagnostico { get => unDiagnostico; set => unDiagnostico = value; }

        //Constructor para registrar diagnóstico
        
        public Veterinario()
        {
            unDiagnostico = new Diagnostico();
        }
    }
}