using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public static DataTable display(string query)
        {
            if(conn.State==ConnectionState.Closed)
              conn.Open();
            //MessageBox.Show(query);
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            System.Data.SqlClient.SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            conn.Close();
            return dt;
        }
    }
}
