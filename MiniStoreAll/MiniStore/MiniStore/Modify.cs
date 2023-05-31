using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MiniStore
{
   class Modify
    {
        public Modify() { }
        public List<Account> Acounts(string query)
        {
            SqlCommand sqlCommand; //Truy vấn các hàm insert/update/delete trong SQL
            SqlDataReader dataReader; //Dùng đề đọc dữ liệu từ bảng


            List<Account> accounts = new List<Account>();

            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    accounts.Add(new Account(dataReader.GetString(0), dataReader.GetString(1), dataReader.GetInt32(2), dataReader.GetString(3)));
                }
                sqlConnection.Close();
            }
            return accounts;
        }
    }
}
