using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Layer_Entity.entidades;
using Layer_Data.procesos;

namespace Layer_Logic.logica
{
    public class ORHEstadoLog: BaseLog
    {
        public ORHEstadoLog()
        {
            dao = new ORHEstadoDao();
        }
        public string[] obtenerPorCodigo(string codigo)
        {
            ORHEstado orh = (new ORHEstadoDao()).obtenerPorCodigo(codigo);
            return new string[] {
                orh.ruc,
                orh.nombre,
                orh.correo,
                orh.contrasena,
                orh.telefono,
            };
        }

        public bool actualizar(string[] datos)
        {
            ORHEstado orh = new ORHEstado();
            orh.codigo = datos[0];
            orh.ruc = datos[1];
            orh.nombre = datos[2];
            orh.correo = datos[3];
            orh.contrasena = datos[4];
            orh.telefono = datos[5];

            return (new ORHEstadoDao()).actualizar(orh);
        }
    }
}
