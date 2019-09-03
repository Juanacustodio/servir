using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

using Layer_Data.procesos;

namespace Layer_Logic.logica
{
    public class CarreraLog
    {
        public DataTable obtenerLista()
        {
            CarreraDao carreraDao = new CarreraDao();
            return carreraDao.lista();
        }
    }
}
