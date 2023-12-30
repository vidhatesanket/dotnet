namespace DAL;
using BOL;
using MySql.Data.MySqlClient;
public class DBManager{
    public static string connString=@"server=127.0.0.1;port=3306;user=root;password=welcome;database=someshdb";

    public static List<Player> getall(){
        List<Player> plist=new List<Player>();
        string query="select * from playerlist";
        MySqlConnection conn=new MySqlConnection();
        conn.ConnectionString=connString;
        MySqlCommand cmd=new MySqlCommand();
       

        cmd.Connection=conn;
        conn.Open();
        cmd.CommandText=query;
        MySqlDataReader reader=cmd.ExecuteReader();
        while (reader.Read()){
            int id=int.Parse(reader["pid"].ToString());
            string name=reader["pname"].ToString();
            string Skills=reader["skills"].ToString();
            Player p = new Player(id,name,Skills);
            plist.Add(p);
        }
        conn.Close();
        return plist;
    }

}
