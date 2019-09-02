using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace Layer_Data.procesos
{
    class PostulanteDao
    {
        SqlConnection cn = conexion.Conexion.getCn();
        helpers.BDHelper BDHelper = new helpers.BDHelper();

        string spLista = "usp_listPostulante";

        public DataTable lista()
        {
            return BDHelper.execStoreProcedure(spLista);
        }
    }
}
