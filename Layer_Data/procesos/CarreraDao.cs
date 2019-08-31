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
    public class CarreraDao
    {
        SqlConnection cn = conexion.Conexion.getCn();
        string spLista = "usp_listCarrera";
        string spObtenerPorCodigo = "usp_codCarrera";

        public DataTable lista()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(spLista, cn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            return dt;
        }

        public Carrera obtenerPorCodigo(string codigo)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(spObtenerPorCodigo, cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@codCar", codigo);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            return new Carrera(dt.Rows[0]);
        }
    }
}
