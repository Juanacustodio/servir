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
    public class ORHEstadoDao: Readable<ORHEstado>
    {
        SqlConnection cn = conexion.Conexion.getCn();
        helpers.BDHelper BDHelper = new helpers.BDHelper();

        string spLista = "usp_listORHEstado";
        string spValidar = "usp_validarORH";
        string spObtenerPorCodigo = "usp_codORHEstado";
        string spActualizar = "usp_updateORHEstado";

        public DataTable lista()
        {
            return BDHelper.execStoreProcedure(spLista);
        }

        public ORHEstado obtenerPorCodigo(string codigo)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(spObtenerPorCodigo, cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@codORH", codigo);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            return new ORHEstado(dt.Rows[0]);
        }
        public bool actualizar(ORHEstado orh)
        {
            try
            {
                string[][] array2D = new string[][] {
                    new string[] { "@codORH", orh.codigo },
                    new string[] { "@ruc", orh.ruc },
                    new string[] { "@contras", orh.contrasena },
                    new string[] { "@nombre", orh.nombre },
                    new string[] { "@correo", orh.correo },
                    new string[] { "@usuario", "" },
                    new string[] { "@telef", orh.telefono },
                    new string[] { "@Elimin", "0" },
                };
                bool result = BDHelper.execStoreProcedureThatReturnBool(spActualizar, array2D);

                return result;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public ORHEstado validarOHR(string correo, string contrasena)
        {
            string[][] array2D = new string[][] {
                new string[] { "@correo", correo },
                new string[] { "@contras", contrasena },
                new string[] { "@Elimin", "0" }
            };
            // DataTable dt = new DataTable();
            // SqlCommand cmd = new SqlCommand(spValidar, cn);
            // cmd.CommandType = CommandType.StoredProcedure;
            // cmd.Parameters.AddWithValue("@correo", correo);
            // cmd.Parameters.AddWithValue("@contras", contrasena);
            // cmd.Parameters.AddWithValue("@Elimin", 0);

            // SqlDataAdapter da = new SqlDataAdapter(cmd);
            // da.Fill(dt);
            DataTable dt = BDHelper.execStoreProcedure(spValidar, array2D);

            if(dt.Rows.Count == 0) {
                return null;
            }

            return new ORHEstado(dt.Rows[0]);
        }
    }
}
