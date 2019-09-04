using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

using Layer_Data.procesos;
using Layer_Entity.entidades;

namespace Layer_Logic.logica
{
    public class CarreraLog
    {
        public DataTable obtenerLista()
        {
            CarreraDao carreraDao = new CarreraDao();
            return carreraDao.lista();
        }

        public bool actualizarCarreras(DataTable dt)
        {
            bool result = true;
            foreach (DataRow row in dt.Rows) {
                Carrera carrera = new Carrera(row);
                bool res = (new CarreraDao()).actualizar(carrera);
                if (!res)
                {
                    result = false;
                }
            }

            return result;
        }
    }
}
