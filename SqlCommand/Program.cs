using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.netSqlCommand
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection();
            

            #region Parametresiz SqlCommand

            connection.ConnectionString = "Data Source=localhost; Initial Catalog=personel; User ID=sa; Password=1;";
            //SqlCommand command = new SqlCommand("insert into Customer values (1,'Caglar','Acar')", connection);
            
            connection.Open();
            // Sql process
            int effectedRegistCount=command.ExecuteNonQuery();
            connection.Close();

            Console.WriteLine(effectedRegistCount);
            #endregion

           

            #region Parametreli SqlCommand

            #endregion

        }
    }
}
