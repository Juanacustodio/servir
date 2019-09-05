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
    interface Readable
    {
        DataTable lista();
        DataTable listaVacia();
        bool crear(DataRow row);
        bool actualizar(DataRow row);
        bool eliminar(string codigo);
    }
}
