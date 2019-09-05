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
    public class ORHEstadoDao: BaseDao
    {
        SqlConnection cn = conexion.Conexion.getCn();
        helpers.BDHelper BDHelper = new helpers.BDHelper();

        string spValidar = "usp_validarORH";

        public ORHEstadoDao()
        {
            codigo = "@codORH";
            spLista = "usp_listORHEstado";
            spObtenerPorCodigo = "usp_codORHEstado";
            spActualizar = "usp_updateORHEstado";
            spCrear = "usp_insertORHEstado";
            spEliminar = "usp_deletORHEstado";
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

        public override string[][] parametrosCrear(DataRow row)
        {
            ORHEstado orh = new ORHEstado(row);

            string[][] array2D = new string[][] {
                    new string[] { "@codORH", orh.codigo },
                    new string[] { "@ruc", orh.ruc },
                    new string[] { "@contras", orh.contrasena },
                    new string[] { "@nombre", orh.nombre },
                    new string[] { "@correo", orh.correo },
                    new string[] { "@usuario", orh.usuario },
                    new string[] { "@telef", orh.telefono },
                };

            return array2D;
        }

        public override string[][] parametrosActualizar(DataRow row)
        {
            ORHEstado orh = new ORHEstado(row);

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

            return array2D;
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

            DataTable dt = BDHelper.execStoreProcedure(spValidar, array2D);

            if(dt.Rows.Count == 0) {
                return null;
            }

            return new ORHEstado(dt.Rows[0]);
        }
    }
}
