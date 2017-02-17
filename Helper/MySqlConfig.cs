using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Config
{
   public class MySqlConfig
    {
        public static readonly string MySqlConnectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
    }
}
