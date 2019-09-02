using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Layer_Data.procesos;
using Layer_Entity.entidades;

namespace Layer_Logic.logica
{
    public class Login
    {
        public string[] validarUsuario(string correo, string contrasena)
        {
            ORHEstadoDao ORHDao = new ORHEstadoDao();
            ORHEstado usuario = ORHDao.validarOHR(correo, contrasena);
            if(usuario == null) {
                return null;
            }

            return new string[] { usuario.codigo, usuario.nombre };
        }
    }
}
