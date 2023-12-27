using MySql.Data.MySqlClient;
Console.WriteLine("Welcome to database App");
MySqlConnection connection = new MySqlConnection();
connection.ConnectionString ="server=127.0.0.1;port=3306;user=root;password=welcome;database=someshdb";


string query="update product set pname='AB De Villiers' where pid=18";

MySqlCommand command = new MySqlCommand(query, connection);
connection.Open();
command.ExecuteNonQuery();