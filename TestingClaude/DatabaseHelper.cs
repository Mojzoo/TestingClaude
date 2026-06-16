using MySql.Data.MySqlClient;

namespace TestingClaude
{
    public class DatabaseHelper
    {
        // Update Pwd= if your XAMPP MySQL has a password set
        private readonly string connectionString =
            "Server=localhost;Database=testingclaude;Uid=root;Pwd=;";

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
