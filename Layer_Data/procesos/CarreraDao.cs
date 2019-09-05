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
    public class CarreraDao: BaseDao
    {
        SqlConnection cn = conexion.Conexion.getCn();
        helpers.BDHelper BDHelper = new helpers.BDHelper();


        public CarreraDao()
        {
            codigo = "@codCar";
            spLista = "usp_listCarrera";
            spObtenerPorCodigo = "usp_codCarrera";
            spActualizar = "usp_updateCarrera";
            spCrear = "usp_insertCarrera";
            spEliminar = "usp_deleteCarrera";
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

        public override string[][] parametrosCrear(DataRow row)
        {
            Carrera carrera = new Carrera(row);

            string[][] array2D = new string[][] {
                    new string[] { "@codCar", carrera.codigo },
                    new string[] { "@nombre", carrera.nombre },
                    new string[] { "@codEst", carrera.CentroEstudios },
                };

            return array2D;
        }

        public override string[][] parametrosActualizar(DataRow row)
        {
            Carrera carrera = new Carrera(row);

            string[][] array2D = new string[][] {
                    new string[] { "@codCar", carrera.codigo.ToString() },
                    new string[] { "@nombre", carrera.nombre.ToString() },
                    new string[] { "@codEst", carrera.CentroEstudios.ToString() },
                    new string[] { "@Elimin", carrera.eliminado.ToString() }
                };

            return array2D;
        }
    }
}
