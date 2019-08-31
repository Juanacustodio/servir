using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace Layer_Data.conexion
{
    class Conexion
    {
        // private static string url = "server=.;database=BD_Practicas;user ID=sa;password=12345678";
        private static string url = "Server= localhost; Database= BD_Practicas; Integrated Security = SSPI";

        public static SqlConnection getCn()
        {
            SqlConnection cn = new SqlConnection(url);
            return cn;
        }
    }
}
