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
        }
    }
}
