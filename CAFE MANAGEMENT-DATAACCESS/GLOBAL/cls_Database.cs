using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceLibraries.Classes.Database
{
    public class cls_Database
    {

        private static string _ConnectionInfo = "server = .; database = Cafe_DB; user id = sa; password = mhmdmrtd383";

        public static SqlConnection Connection()
        {
            return new SqlConnection(_ConnectionInfo);
        }

    }
}
