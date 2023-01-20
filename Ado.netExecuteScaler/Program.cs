using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.netExecuteScaler
{
    internal class Program
    {
        static void Main(string[] args)
        {       
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=localhost; Initial Catalog=personel; User ID=sa; Password=1;";


            #region parametresiz
            //SqlCommand command = new SqlCommand("select Name from Customer where CustomerId=31", connection);
            //connection.Open();
            //var Name = command.ExecuteScalar();
            //Console.WriteLine(Name);
            //connection.Close();
            #endregion

            #region Parametreli
            SqlCommand command2 = new SqlCommand("select Name from Customer where CustomerId=@Id", connection);
            connection.Open();
            command2.Parameters.Add("@Id", System.Data.SqlDbType.Int).Value = 1;
            var Name2 = command2.ExecuteScalar();
            Console.WriteLine(Name2);
            connection.Close();
            #endregion

           


        }
    }
}
