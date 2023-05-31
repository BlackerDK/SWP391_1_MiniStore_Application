using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace MiniStore
{
    public class Connection
    {
        private static string _connectionString = @"Data Source=BLACKER-DK\SQLEXPRESS;Initial Catalog=ministore;User ID=sa;Password=12345";

        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
