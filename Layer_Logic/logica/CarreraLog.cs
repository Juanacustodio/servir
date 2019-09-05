using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

using Layer_Data.procesos;
using Layer_Entity.entidades;

namespace Layer_Logic.logica
{
    public class CarreraLog: BaseLog
    {
        public CarreraLog()
        {
            dao = new CarreraDao();
        }
    }
}
