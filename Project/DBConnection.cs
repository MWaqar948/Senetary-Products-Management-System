using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class DBConnection
    {
       static SqlConnection conn = null;
        public static SqlConnection getConnection()
        {
           
            string connectionString = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
            if (conn == null)
            {
                conn = new SqlConnection(connectionString);
                return conn;
            }
            
            return conn;
        }
    }
}
