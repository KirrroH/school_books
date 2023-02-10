using System;
using MySql.Data.MySqlClient;

namespace school_books
{
    internal class MySQLDBUtils
    {
        public static MySqlConnection get_conn(string host, string database, int port, string user, string pass)
        {
            String connString = $"Server={host};database={database};port={port};user={user};password={pass};";
            MySqlConnection conn = new MySqlConnection(connString);

            return conn;
        }
    }
}