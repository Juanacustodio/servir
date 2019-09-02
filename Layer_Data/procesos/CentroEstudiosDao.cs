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
    class CentroEstudiosDao: Readable<CentroEstudios>
    {
        SqlConnection cn = conexion.Conexion.getCn();
        helpers.BDHelper BDHelper = new helpers.BDHelper();

        string spLista = "usp_listCentEstudios";
        string spObtenerPorCodigo = "usp_codCentEstudio";

        public DataTable lista()
        {
            return BDHelper.execStoreProcedure(spLista);
        }

        public CentroEstudios obtenerPorCodigo(string codigo)
        {
            string[,] array2D = new string[,] { { "@codEst", codigo } };
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(spObtenerPorCodigo, cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@codEst", codigo);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            return new CentroEstudios(dt.Rows[0]);
        }
    }
}
