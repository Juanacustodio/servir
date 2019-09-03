using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

using Layer_Data.procesos;

namespace Layer_Logic.logica
{
    public class OfertaLog
    {
        OfertaDao ofertaDao = new OfertaDao();
        public DataTable obtenerLista()
        {
            return ofertaDao.lista();
        }

        public bool eliminar(string codigo)
        {
            return ofertaDao.eliminar(codigo);
        }
    }
}
