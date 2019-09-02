using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

namespace Layer_Entity.entidades
{
    public class CentroEstudios
    {
        public CentroEstudios(DataRow datos)
        {
            this.codigo = datos[0].ToString();
            this.ruc = datos[1].ToString();
            this.nombre = datos[2].ToString();
            this.tipo = datos[3].ToString();
            this.correo = datos[4].ToString();
            this.telefono = datos[5].ToString();
            this.estado = datos[6].ToString();
            this.contrasena = datos[7].ToString();
            this.eliminado = bool.Parse(datos[8].ToString());
        }
        public string codigo
        {
            get; set;
        }
        public string ruc
        {
            get; set;
        }
        public string nombre
        {
            get; set;
        }
        public string tipo
        {
            get; set;
        }
        public string correo
        {
            get; set;
        }
        public string telefono
        {
            get; set;
        }
        public string estado
        {
            get; set;
        }
        public string contrasena
        {
            get; set;
        }
        public bool eliminado
        {
            get; set;
        }
    }
}
