using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

namespace Layer_Entity.entidades
{
    public class Carrera
    {
        public Carrera()
        {

        }
        public Carrera(DataRow datos)
        {
            this.codigo = datos[0].ToString();
            this.nombre = datos[1].ToString();
            this.CentroEstudios = datos[2].ToString();
            this.eliminado = bool.Parse(datos[3].ToString());
        }
        public string codigo
        {
            get; set;
        }
        public string nombre
        {
            get; set;
        }
        public string CentroEstudios
        {
            get; set;
        }
        public bool eliminado
        {
            get; set;
        }
    }
}
