using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

namespace Layer_Entity.entidades
{
    public class Oferta
    {
        public Oferta(DataRow datos)
        {
            this.codigo = datos[0].ToString();
            this.carrera = datos[1].ToString();
            this.area = datos[2].ToString();
            this.ciclo = datos[3].ToString();
            this.tipo = bool.Parse(datos[4].ToString());
            this.detalle = datos[5].ToString();
            this.subvencion = double.Parse(datos[6].ToString());
            this.habilidades = datos[7].ToString();
            this.region = datos[8].ToString();
            this.fechaCierre = DateTime.Parse(datos[9].ToString());
            this.ORHEstado = datos[10].ToString();
            this.eliminado = bool.Parse(datos[11].ToString());
        }
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
        public string ciclo
        {
            get; set;
        }
        public bool tipo
        {
            get; set;
        }
        public string detalle
        {
            get; set;
        }
        public double subvencion
        {
            get; set;
        }
        public string habilidades
        {
            get; set;
        }
        public string region
        {
            get; set;
        }
        public DateTime fechaCierre
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
