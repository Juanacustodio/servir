
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

namespace Layer_Entity.entidades
{
    public class ORHEstado: Entidad
    {
        public ORHEstado()
        {

        }
        public ORHEstado(DataRow datos)
        {
            this.codigo = datos[0].ToString();
            this.ruc = datos[1].ToString();
            this.contrasena = datos[2].ToString();
            this.nombre = datos[3].ToString();
            this.correo = datos[4].ToString();
            this.usuario = datos[5].ToString();
            this.telefono = datos[6].ToString();
            this.eliminado = bool.Parse(datos[7].ToString());
        }
        public string codigo
        {
            get; set;
        }
        public string ruc
        {
            get; set;
        }
        public string contrasena
        {
            get; set;
        }
        public string nombre
        {
            get; set;
        }
        public string correo
        {
            get; set;
        }
        public string usuario
        {
            get; set;
        }
        public string telefono
        {
            get; set;
        }
        public bool eliminado
        {
            get; set;
        }
    }
}
