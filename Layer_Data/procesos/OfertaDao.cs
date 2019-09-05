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
    public class OfertaDao: BaseDao
    {
        helpers.BDHelper BDHelper = new helpers.BDHelper();


        public OfertaDao()
        {
            codigo = "@codOfe";
            spLista = "usp_listOferta";
            spObtenerPorCodigo = "usp_codOferta";
            spCrear = "usp_insertOferta";
            spActualizar = "usp_updateOferta";
            spEliminar = "usp_deleteOferta";
        }

        public Oferta obtenerPorCodigo(string codigo)
        {
            string[][] array2D = new string[][] {
                new string[] { this.codigo, codigo }
            };

            DataTable dt = BDHelper.execStoreProcedure(spObtenerPorCodigo, array2D);

            if (dt.Rows.Count == 0) {
                return null;
            }

            return new Oferta(dt.Rows[0]);
        }

        public override string[][] parametrosCrear(DataRow row)
        {
            Oferta oferta = new Oferta(row);

            string[][] array2D = new string[][] {
                    new string[] { "@codOfe", oferta.codigo },
                    new string[] { "@carrera", oferta.carrera },
                    new string[] { "@area", oferta.area },
                    new string[] { "@ciclo", oferta.ciclo },
                    new string[] { "@tipo", oferta.tipo ? "1" : "0" },
                    new string[] { "@detalle", oferta.detalle },
                    new string[] { "@subven", oferta.subvencion.ToString() },
                    new string[] { "@habilidad", oferta.habilidades },
                    new string[] { "@region", oferta.region },
                    new string[] { "@fec_cier", oferta.fechaCierre.ToString(), helpers.BDHelper.type_datetime },
                    new string[] { "@codORH", oferta.ORHEstado }
                };

            return array2D;
        }

        public override string[][] parametrosActualizar(DataRow row)
        {
            Oferta oferta = new Oferta(row);

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

            return array2D;
        }
    }
}
