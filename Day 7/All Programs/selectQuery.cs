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