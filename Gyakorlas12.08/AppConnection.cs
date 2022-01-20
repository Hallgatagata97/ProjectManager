using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektManager
{
    class AppConnection
    {
        public static string ConnectionString => ConfigurationManager.ConnectionStrings["ProjectManagerDBEntities"].ConnectionString;
    }
}
