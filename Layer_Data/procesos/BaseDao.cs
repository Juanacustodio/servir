using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using Layer_Entity.entidades;

namespace Layer_Data.procesos
{
    public class BaseDao: Readable
    {
        helpers.BDHelper BDHelper = new helpers.BDHelper();

        protected string codigo = "";
        protected string spLista = "";
        protected string spObtenerPorCodigo = "";
        protected string spCrear = "";
        protected string spActualizar = "";
        protected string spEliminar = "";

        public DataTable lista()
        {
            return BDHelper.execStoreProcedure(spLista);
        }

        public DataTable listaVacia()
        {
            string[][] array2D = new string[][] {
                new string[] { codigo, "-" }
            };

            DataTable dt = BDHelper.execStoreProcedure(spObtenerPorCodigo, array2D);

            return dt;
        }

        public virtual string[][] parametrosCrear(DataRow row)
        {
            return new string[][] {
                    new string[] { "", "" }
                };
        }
        public bool crear(DataRow row)
        {
            try
            {
                string[][] array2D = parametrosCrear(row);
                bool result = BDHelper.execStoreProcedureThatReturnBool(spCrear, array2D);

                return result;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public virtual string[][] parametrosActualizar(DataRow row)
        {
            return new string[][] {
                    new string[] { "", "" }
                };
        }

        public bool actualizar(DataRow row)
        {
            try
            {
                string[][] array2D = parametrosActualizar(row);
                bool result = BDHelper.execStoreProcedureThatReturnBool(spActualizar, array2D);

                return result;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool eliminar(string codigo)
        {
            try
            {
                string[][] array2D = new string[][] {
                    new string[] { this.codigo, codigo },
                    new string[] { "@Elimin", "1" }
                };
                bool result = BDHelper.execStoreProcedureThatReturnBool(spEliminar, array2D);

                return result;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
