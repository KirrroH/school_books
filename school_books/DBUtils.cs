using MySql.Data.MySqlClient;

namespace school_books
{
    internal class DBUtils
    {
        public static MySqlConnection get_conn()
        {
            string host = "localhost";
            string database = "school_book";
            int port = 3306;
            string user = "root";
            string pass = "root";

            return MySQLDBUtils.get_conn(host, database, port, user, pass);
        }
    }
}