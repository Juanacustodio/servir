using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

using Layer_Entity.entidades;

namespace Layer_Data.procesos
{
    public class OfertaDao: Readable<Oferta>
    {
        SqlConnection cn = conexion.Conexion.getCn();
        helpers.BDHelper BDHelper = new helpers.BDHelper();

        string spLista = "usp_listOferta";
        string spObtenerPorCodigo = "usp_codOferta";
        string spEliminar = "usp_deleteOferta";

        public DataTable lista()
        {
            return BDHelper.execStoreProcedure(spLista);
        }

        public Oferta obtenerPorCodigo(string codigo)
        {
            string[][] array2D = new string[][] {
                new string[] { "@codOfe", codigo }
            };

            DataTable dt = BDHelper.execStoreProcedure(spObtenerPorCodigo, array2D);

            if (dt.Rows.Count == 0) {
                return null;
            }

            return new Oferta(dt.Rows[0]);
        }

        public bool eliminar(string codigo)
        {
            try
            {
                string[][] array2D = new string[][] {
                    new string[] { "@codOfe", codigo },
                    new string[] { "@Elimin", "1" }
                };
                DataTable dt = BDHelper.execStoreProcedure(spEliminar, array2D);

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
