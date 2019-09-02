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
        static string name = "JUANA-CASA\\SQLEXPRESS";
        private static string url = "server=" + name + ";database=BD_Practicas;Integrated Security=SSPI;";
        // private static string url = "Data Source=localhost; Initial Catalog=BD_Practicas; Integrated Security=false;user id=JUANA-CASA/USUARIO ;password=";

        public static SqlConnection getCn()
        {
            SqlConnection cn = new SqlConnection(url);
            return cn;
        }
    }
}
