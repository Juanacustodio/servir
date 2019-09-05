using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Layer_Data.procesos;

namespace Layer_Logic.logica
{
    public class PostulanteLog: BaseLog
    {
        public PostulanteLog()
        {
            dao = new PostulanteDao();
        }
    }
}
