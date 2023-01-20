using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.netExecuteReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=localhost; Initial Catalog=personel; User ID=sa; Password=1;";

            #region parametresiz
            SqlCommand command = new SqlCommand("select * from Customer", connection);

            connection.Open();
            SqlDataReader sqlDataReader = command.ExecuteReader();

            while (sqlDataReader.Read())
            {
                int customerId =(int)sqlDataReader[0];
                string name =sqlDataReader["Name"].ToString();
                string surname = sqlDataReader.GetString(2);
            }
            sqlDataReader.Close();
            connection.Close();
            #endregion

            #region Parametreli
            #endregion

            #region Store Proc
            #endregion
        }
    }
}
