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
    public class OfertaLog
    {
        OfertaDao ofertaDao = new OfertaDao();
        public DataTable obtenerLista()
        {
            return ofertaDao.lista();
        }

        public DataTable obtenerListaVacia()
        {
            return ofertaDao.listaVacia();
        }

        public bool actualizarOfertas(DataTable dt)
        {
            bool result = true;
            foreach (DataRow row in dt.Rows) {
                Oferta oferta = new Oferta(row);
                bool res = (new OfertaDao()).actualizarOferta(oferta);
                if (!res) {
                    result = false;
                }
            }

            return result;
        }

        public bool crearOfertas(DataTable dt)
        {
            bool result = true;
            foreach (DataRow row in dt.Rows) {
                Oferta oferta = new Oferta(row);
                bool res = (new OfertaDao()).crear(oferta);
                if (!res) {
                    result = false;
                }
            }

            return result;
        }

        public bool eliminar(string codigo)
        {
            return ofertaDao.eliminar(codigo);
        }
    }
}
