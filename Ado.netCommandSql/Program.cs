using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.netCommandSql
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer C1 = new Customer();
            C1.Name = "Burhan";
            C1.Surname = "Taşkesen";
            C1.CustomerId = 33;

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=localhost; Initial Catalog=personel; User ID=sa; Password=1;";
            //SqlCommand command = new SqlCommand("insert into Customer values (4,'Caglar','Acar')", connection);
            //connection.Open();
            //int result = command.ExecuteNonQuery();
            //Console.WriteLine(result);
            //connection.Close();

            #region Parametreli kullanım
            //SqlCommand command2 = new SqlCommand("insert into Customer values (@ID,@Name,@Surname)", connection);

            //command2.Parameters.Add("@ID", System.Data.SqlDbType.Int).Value = C1.CustomerId;
            //command2.Parameters.Add("@Name", System.Data.SqlDbType.NVarChar).Value = C1.Name;
            //command2.Parameters.Add("@Surname", System.Data.SqlDbType.NVarChar).Value = C1.Surname;

            //connection.Open();
            //int result2 = command2.ExecuteNonQuery();
            //Console.WriteLine(result2);
            //connection.Close();


            #endregion

            #region store proc kullanım
            SqlCommand command3 = new SqlCommand("SP_Customer_NewRegist", connection);
            command3.CommandType=System.Data.CommandType.StoredProcedure;
            



            command3.Parameters.Add("@CustomerId", System.Data.SqlDbType.Int).Value = C1.CustomerId;
            command3.Parameters.Add("@Name", System.Data.SqlDbType.NVarChar).Value = C1.Name;
            command3.Parameters.Add("@Surname", System.Data.SqlDbType.NVarChar).Value = C1.Surname;

            connection.Open();
            int result3 = command3.ExecuteNonQuery();
            Console.WriteLine(result3);
            connection.Close();


            #endregion



        }
    }
}
