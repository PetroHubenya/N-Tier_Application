using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Helper
{
    internal class SQLHelper
    {
        /* Define the Connection String in your SQL Helper
         * so that you don't need to again and again create a connection
         * and it to your method when you interact with the database. */

        public static readonly string CONN_STRING = ConfigurationManager.ConnectionStrings["Connections"].ConnectionString;  
    }
}
