using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TPADestop_GA20_2_
{
    public class ConnectDB
    {
        private string username = "root";
        private string password = "";
        private string database = "kongbubank";
        private string host = "localhost";

        private string connectionStr;
        private MySqlConnection connection;
        private MySqlCommand command;
        private static ConnectDB Instance;

        public static ConnectDB getInstance()
        {
            if (Instance == null)
            {
                Instance = new ConnectDB();
            }
            return Instance;
        }

        private ConnectDB()
        {
            connectionStr = "SERVER=" + host + ";database=" + database + ";UID=" + username + ";PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionStr);
        }

        public DataTable executeQuery(string query)
        {
            DataTable data = new DataTable();

            connection.Open();
            command = new MySqlCommand(query, connection);
            data.Load(command.ExecuteReader());

            connection.Close();
            return data;
        }

        public void executeUpdate(string query)
        {
            connection.Open();

            command = new MySqlCommand(query, connection);

            command.ExecuteReader();
            connection.Close();
        }
    }
}
