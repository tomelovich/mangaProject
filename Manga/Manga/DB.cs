using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manga
{
    class DB
    {
        MySqlConnection connection = new MySqlConnection("Server=127.0.0.1;port=3306;username=root;password=;database=manga");
        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }


        public MySqlConnection getConnection()
        {
            return connection;
        }
    }
}
