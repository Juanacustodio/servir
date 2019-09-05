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
    class CentroEstudiosDao: BaseDao
    {
        SqlConnection cn = conexion.Conexion.getCn();
        helpers.BDHelper BDHelper = new helpers.BDHelper();

        public CentroEstudiosDao()
        {
            codigo = "@codEst";
            spLista = "usp_listCentEstudios";
            spObtenerPorCodigo = "usp_codCentEstudio";
            spCrear = "usp_insertCentEstudio";
            spActualizar = "usp_updateCentEstudio";
            spEliminar = "usp_deleteCentEstudio";
        }

        public CentroEstudios obtenerPorCodigo(string codigo)
        {
            string[,] array2D = new string[,] { { "@codEst", codigo } };
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(spObtenerPorCodigo, cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@codEst", codigo);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            return new CentroEstudios(dt.Rows[0]);
        }

        public override string[][] parametrosCrear(DataRow row)
        {
            CentroEstudios centroEstudios = new CentroEstudios(row);

            string[][] array2D = new string[][] {
                    new string[] { "@codEst", centroEstudios.codigo },
                    new string[] { "@ruc", centroEstudios.ruc },
                    new string[] { "@nombre", centroEstudios.nombre },
                    new string[] { "@tipo", centroEstudios.tipo },
                    new string[] { "@correo", centroEstudios.correo },
                    new string[] { "@telef", centroEstudios.telefono },
                    new string[] { "@estado", centroEstudios.estado },
                    new string[] { "@contras", centroEstudios.contrasena }
                };

            return array2D;
        }

        public override string[][] parametrosActualizar(DataRow row)
        {
            CentroEstudios centroEstudios = new CentroEstudios(row);

            string[][] array2D = new string[][] {
                    new string[] { "@codEst", centroEstudios.codigo },
                    new string[] { "@ruc", centroEstudios.ruc },
                    new string[] { "@nombre", centroEstudios.nombre },
                    new string[] { "@tipo", centroEstudios.tipo },
                    new string[] { "@correo", centroEstudios.correo },
                    new string[] { "@telef", centroEstudios.telefono },
                    new string[] { "@region", "" },
                    new string[] { "@contras", centroEstudios.contrasena },
                    new string[] { "@Elimin", centroEstudios.eliminado.ToString() },
                };

            return array2D;
        }
    }
}
