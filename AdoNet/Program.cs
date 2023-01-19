using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection();
            #region part1

            //connection.ConnectionString = "Data Source=localhost; Initial Catalog=personel; User ID=sa; Password=1;";

            //connection.Open();
            //Console.WriteLine($"Bağlantı durumu : {connection.State}");
            //connection.Close();
            //Console.WriteLine($"Bağlantı durumu : {connection.State}");
            #endregion

            #region part2
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "localhost";
            builder.InitialCatalog = "personel";
            builder.UserID = "sa";
            builder.Password = "1";

            connection.ConnectionString = builder.ConnectionString;

            connection.Open();
            Console.WriteLine($"Bağlantı durumu : {connection.State}");
            connection.Close();
            Console.WriteLine($"Bağlantı durumu : {connection.State}");
            #endregion


            #region part3
            
            #endregion


        }
    }
}
