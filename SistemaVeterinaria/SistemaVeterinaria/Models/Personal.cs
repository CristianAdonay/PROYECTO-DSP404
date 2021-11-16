using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaVeterinaria.Models
{
    public class Personal
    {
        private int IDPersonal;
        private string Identificacion;
        private Veterinario unVeterinario;
        private Auxiliar unAuxiliar;

        public int Idpersonal { get => IDPersonal; set => IDPersonal = value; }
        public string identificacion { get => Identificacion; set => Identificacion = value; }
        public Veterinario unveterinario { get => unVeterinario; set => unVeterinario = value; }
        public Auxiliar unauxiliar { get => unAuxiliar; set => unAuxiliar = value; }

        //Constructor con parámetros
        public Personal(string Identificacion)
        {
            this.Identificacion = Identificacion;
        }



        //Constructor con métodos

        public Personal()
        {
            unVeterinario = new Veterinario();
            unAuxiliar = new Auxiliar();
        }
    }
}