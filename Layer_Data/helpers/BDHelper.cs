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
        public static string type_datetime = "datetime";
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

        public bool execStoreProcedureThatReturnBool(string sp, string[][] array2D)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(sp, cn);
            cmd.CommandType = CommandType.StoredProcedure;
            foreach (string[] param in array2D) {
                if (param.Length > 2) {
                    if (param[2] == type_datetime) {
                        DateTime value = DateTime.Parse(param[1]);
                        cmd.Parameters.AddWithValue(param[0], value);
                    }
                }
                else {
                    cmd.Parameters.AddWithValue(param[0], param[1]);
                }
            }

            cn.Open();
            bool result = cmd.ExecuteNonQuery() > 0;
            cn.Close();

            return result;
        }
    }
}
