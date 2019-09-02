using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace Layer_Data.helpers
{
    public class BDHelper
    {
        SqlConnection cn = conexion.Conexion.getCn();
        public DataTable execStoreProcedure(string sp)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(sp, cn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            return dt;
        }

        public DataTable execStoreProcedure(string sp, string[][] array2D)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(sp, cn);
            cmd.CommandType = CommandType.StoredProcedure;
            foreach (string[] param in array2D) {
                cmd.Parameters.AddWithValue(param[0], param[1]);
            }

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            return dt;
        }
    }
}
