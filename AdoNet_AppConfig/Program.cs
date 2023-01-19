using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace AdoNet_AppConfig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection();

            // app.config connetciton string yap : 

            // App.config içerisinde bağlantı bilgilerimizi okuma

            connection.ConnectionString = ConfigurationManager.ConnectionStrings["SqlSol"].ConnectionString;
            connection.Open();
            Console.WriteLine($"Bağlantı durumu : {connection.State}");
            connection.Close();
            Console.WriteLine($"Bağlantı durumu : {connection.State}");


        }
    }
}
