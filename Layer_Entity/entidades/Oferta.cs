using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer_Entity.entidades
{
    public class Oferta
    {
        public string codigo
        {
            get; set;
        }
        public string carrera
        {
            get; set;
        }
        public string area
        {
            get; set;
        }
        public string grado
        {
            get; set;
        }
        public string detalle
        {
            get; set;
        }
        public decimal subvencion
        {
            get; set;
        }
        public string ORHEstado
        {
            get; set;
        }
        public bool eliminado
        {
            get; set;
        }
    }
}
