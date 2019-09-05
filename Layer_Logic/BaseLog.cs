using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using Layer_Data.procesos;

namespace Layer_Logic
{
    public class BaseLog
    {
        protected BaseDao dao = new BaseDao();

        public DataTable obtenerLista()
        {
            return dao.lista();
        }

        public DataTable obtenerListaVacia()
        {
            return dao.listaVacia();
        }

        public bool actualizar(DataTable dt)
        {
            bool result = true;
            foreach (DataRow row in dt.Rows) {
                bool res = dao.actualizar(row);
                if (!res) {
                    result = false;
                }
            }

            return result;
        }

        public bool crear(DataTable dt)
        {
            bool result = true;
            foreach (DataRow row in dt.Rows) {
                bool res = dao.crear(row);
                if (!res) {
                    result = false;
                }
            }

            return result;
        }

        public bool eliminar(string codigo)
        {
            return dao.eliminar(codigo);
        }

    }
}
