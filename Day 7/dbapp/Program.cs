//Select Statement --------------------------------------------------------------------------------------

using MySql.Data.MySqlClient;
Console.WriteLine("Welcome to database App");
MySqlConnection connection = new MySqlConnection();
connection.ConnectionString ="server=127.0.0.1;port=3306;user=root;password=welcome;database=someshdb";
string query ="select * from product";
MySqlCommand command = new MySqlCommand(query, connection);
try{
    connection.Open();
    MySqlDataReader reader=command.ExecuteReader();
    while(reader.Read()){
       int pid=int.Parse(reader["pid"].ToString());
       string pname=reader["pname"].ToString();
       string qty=reader["qty"].ToString();
       string price=reader["price"].ToString();
       Console.WriteLine(pid+ " "+ pname+ " "+ qty+" "+price);
    }
    reader.Close();
}
catch(Exception e){
    Console.WriteLine(e.Message);
}
finally{
    connection.Close();
}



//Update Statement --------------------------------------------------------------------------------------

// using MySql.Data.MySqlClient;
// Console.WriteLine("Welcome to database App");
// MySqlConnection connection = new MySqlConnection();
// connection.ConnectionString ="server=127.0.0.1;port=3306;user=root;password=welcome;database=someshdb";


// string query="update product set pname='AB De Villiers' where pid=18";

// MySqlCommand command = new MySqlCommand(query, connection);
// connection.Open();
// command.ExecuteNonQuery();
// connection.Close();


//delete Statement --------------------------------------------------------------------------------------

// using MySql.Data.MySqlClient;
// Console.WriteLine("Welcome to database App");
// MySqlConnection connection = new MySqlConnection();
// connection.ConnectionString ="server=127.0.0.1;port=3306;user=root;password=welcome;database=someshdb";
// Console.WriteLine("Enter the id of product to be deleted:");
// int id=int.Parse(Console.ReadLine());
// string query="delete from product where pid=@id";
// MySqlCommand command = new MySqlCommand(query, connection);
// command.Parameters.AddWithValue("@id",id);
// connection.Open();
// command.ExecuteNonQuery();
// connection.Close();



//Count Statement --------------------------------------------------------------------------------------


// using MySql.Data.MySqlClient;
// Console.WriteLine("Welcome to database App");
// MySqlConnection connection = new MySqlConnection();
// connection.ConnectionString ="server=127.0.0.1;port=3306;user=root;password=welcome;database=someshdb";
// string query ="select sum(price) from product";
// MySqlCommand command = new MySqlCommand(query, connection);
// connection.Open();
// int count=int.Parse((command.ExecuteScalar()).ToString());
// Console.WriteLine( " Sum of price:  "+ count);
   




