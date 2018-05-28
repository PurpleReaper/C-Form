using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    class ConnectSQL
    {
        public static SqlConnection getDBConnection()
        {
            String connString = "Data Source=DESKTOP-R2O8COC\\SQLEXPRESS;Initial Catalog=DeviceManagement;Integrated Security=True";

            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }
        


    }
}
