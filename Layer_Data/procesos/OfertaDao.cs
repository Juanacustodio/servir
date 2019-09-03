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
    public class OfertaDao: Readable<Oferta>
    {
        SqlConnection cn = conexion.Conexion.getCn();
        helpers.BDHelper BDHelper = new helpers.BDHelper();

        string spLista = "usp_listOferta";
        string spObtenerPorCodigo = "usp_codOferta";
        string spCrear = "usp_insertOferta";
        string spActualizar = "usp_updateOferta";
        string spEliminar = "usp_deleteOferta";

        public DataTable lista()
        {
            return BDHelper.execStoreProcedure(spLista);
        }
        public DataTable listaVacia()
        {
            string[][] array2D = new string[][] {
                new string[] { "@codOfe", "-" }
            };

            DataTable dt = BDHelper.execStoreProcedure(spObtenerPorCodigo, array2D);

            return dt;
        }
        public Oferta obtenerPorCodigo(string codigo)
        {
            string[][] array2D = new string[][] {
                new string[] { "@codOfe", codigo }
            };

            DataTable dt = BDHelper.execStoreProcedure(spObtenerPorCodigo, array2D);

            if (dt.Rows.Count == 0) {
                return null;
            }

            return new Oferta(dt.Rows[0]);
        }
        public bool crear(Oferta oferta)
        {
            try
            {
                string tipo = oferta.tipo ? "1" : "0";
                string[][] array2D = new string[][] {
                    new string[] { "@codOfe", oferta.codigo },
                    new string[] { "@carrera", oferta.carrera },
                    new string[] { "@area", oferta.area },
                    new string[] { "@ciclo", oferta.ciclo },
                    new string[] { "@tipo", tipo },
                    new string[] { "@detalle", oferta.detalle },
                    new string[] { "@subven", oferta.subvencion.ToString() },
                    new string[] { "@habilidad", oferta.habilidades },
                    new string[] { "@region", oferta.region },
                    new string[] { "@fec_cier", oferta.fechaCierre.ToString(), helpers.BDHelper.type_datetime },
                    new string[] { "@codORH", oferta.ORHEstado }
                };
                bool result = BDHelper.execStoreProcedureThatReturnBool(spCrear, array2D);

                return result;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool actualizarOferta(Oferta oferta)
        {
            try
            {
                string tipo = oferta.tipo ? "1" : "0";
                string[][] array2D = new string[][] {
                    new string[] { "@codOfe", oferta.codigo },
                    new string[] { "@carrera", oferta.carrera },
                    new string[] { "@area", oferta.area },
                    new string[] { "@ciclo", oferta.ciclo },
                    new string[] { "@tipo", tipo },
                    new string[] { "@detalle", oferta.detalle },
                    new string[] { "@subven", oferta.subvencion.ToString() },
                    new string[] { "@habilidad", oferta.habilidades },
                    new string[] { "@region", oferta.region },
                    new string[] { "@Fcierre", oferta.fechaCierre.ToString(), helpers.BDHelper.type_datetime },
                    new string[] { "@Elimin", oferta.eliminado.ToString() }
                };
                bool result = BDHelper.execStoreProcedureThatReturnBool(spActualizar, array2D);

                return result;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool eliminar(string codigo)
        {
            try
            {
                string[][] array2D = new string[][] {
                    new string[] { "@codOfe", codigo },
                    new string[] { "@Elimin", "1" }
                };
                DataTable dt = BDHelper.execStoreProcedure(spEliminar, array2D);

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
