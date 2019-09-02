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
    public class CarreraDao: Readable<Carrera>
    {
        SqlConnection cn = conexion.Conexion.getCn();
        helpers.BDHelper BDHelper = new helpers.BDHelper();

        string spLista = "usp_listCarrera";
        string spObtenerPorCodigo = "usp_codCarrera";

        public DataTable lista()
        {
            return BDHelper.execStoreProcedure(spLista);
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
