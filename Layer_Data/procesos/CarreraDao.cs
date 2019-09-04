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
        string spActualizar = "usp_updateCarrera";

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

        public bool actualizar(Carrera carrera)
        {
            try
            {
                string[][] array2D = new string[][] {
                    new string[] { "@codCar", carrera.codigo.ToString() },
                    new string[] { "@nombre", carrera.nombre.ToString() },
                    new string[] { "@codEst", carrera.CentroEstudios.ToString() },
                    new string[] { "@Elimin", carrera.eliminado.ToString() }
                };
                bool result = BDHelper.execStoreProcedureThatReturnBool(spActualizar, array2D);

                return result;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
