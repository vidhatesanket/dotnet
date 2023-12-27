using MySql.Data.MySqlClient;
Console.WriteLine("Welcome to database App");
MySqlConnection connection = new MySqlConnection();
connection.ConnectionString ="server=127.0.0.1;port=3306;user=root;password=welcome;database=someshdb";

string query ="select count(*) from product";


MySqlCommand command = new MySqlCommand(query, connection);


    connection.Open();
    int count=int.Parse((command.ExecuteScalar()).ToString());
   Console.WriteLine( " Number of products available for sale "+ count);
   


