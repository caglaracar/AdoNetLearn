using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adonet_ConnectState
{
    internal class DataAccessLayer
    {
        SqlConnection connection;

        public DataAccessLayer()
        {
             connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["SQLTT"].ConnectionString;
            
        }

        public void ConnectState()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
                Console.WriteLine("Açıktı kapattım");
            }
            else
            {
                connection.Open();
                Console.WriteLine("Kapalıydı açtım");
            }
        }

    }
}
