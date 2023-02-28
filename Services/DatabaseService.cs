using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ksyusha.Services
{
    internal class DatabaseService
    {
        SqlConnection connection = new SqlConnection("Data Source=;Initial catalog=;User ID=;Password=");

        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }
        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
        public SqlConnection GetConnection()
        {
            return connection;
        }
    }

}
