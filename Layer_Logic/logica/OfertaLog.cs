﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

using Layer_Data.procesos;

namespace Layer_Logic.logica
{
    public class OfertaLog: BaseLog
    {
        public OfertaLog()
        {
            dao = new OfertaDao();
        }

    }
}
