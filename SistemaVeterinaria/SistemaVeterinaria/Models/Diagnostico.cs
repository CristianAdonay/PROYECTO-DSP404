using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaVeterinaria.Models
{
    public class Diagnostico
    {
        private DateTime Fecha;
        private string Descripcion;
        private string Receta;

        public DateTime fecha { get => Fecha; set => Fecha = value; }
        public string descripcion { get => Descripcion; set => Descripcion = value; }
        public string receta { get => Receta; set => Receta = value; }

        //Constructor con parámetros

        public Diagnostico(DateTime Fecha, string Descripcion, string Receta)
        {
            this.Fecha = Fecha;
            this.Descripcion = Descripcion;
            this.Receta = Receta;
        }

        public Diagnostico()
        {

        }
    }
}