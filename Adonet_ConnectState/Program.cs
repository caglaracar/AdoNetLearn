using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adonet_ConnectState
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataAccessLayer dal = new DataAccessLayer();
            dal.ConnectState();
            Console.ReadLine();

            
        }
    }
}
