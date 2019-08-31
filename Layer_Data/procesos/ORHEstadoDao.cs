using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace Layer_Data.procesos
{
    class ORHEstadoDao
    {
        SqlConnection cn = conexion.Conexion.getCn();
        string spList = "usp_listORHEstado";

        public DataTable lista()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(spList, cn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            return dt;
        }
    }
}
