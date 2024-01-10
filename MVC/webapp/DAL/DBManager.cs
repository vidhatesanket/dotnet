using System.Data;
using BOL;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Signers;
namespace DAL;

public static class DBManager{
    public static string connString="server=127.0.0.1;port=3306;user=root;password=Sanket@01;database=temp";
    public static List<Player> getAll(){
        List<Player> plist=new List<Player>();
        MySqlConnection conn=new MySqlConnection();
      
        conn.ConnectionString=connString;
        string query="select * from player";
        conn.Open();
        MySqlCommand cmd=new MySqlCommand(query,conn);
        MySqlDataReader reader=cmd.ExecuteReader();
        
        while(reader.Read()){
            int id=int.Parse(reader["pid"].ToString());
            string nm=reader["pname"].ToString();
            string sk=reader["skills"].ToString();
            Player p = new Player(id,nm,sk);
            plist.Add(p);
        }
        return plist;
    }

    public static void updatePlayer(int id,string name,string skills){
        string query="update player set pname=@nm, skills=@sk where pid=@id";

        MySqlConnection conn=new MySqlConnection();
        conn.ConnectionString=connString;

        MySqlCommand cmd=new MySqlCommand(query,conn);
        conn.Open();
        cmd.Parameters.AddWithValue("@id",id);
        cmd.Parameters.AddWithValue("@nm",name);
        cmd.Parameters.AddWithValue("@sk",skills);
        cmd.ExecuteNonQuery();

    }

    public static void delete(int id){
        string query="delete from player where pid=@id";
        MySqlConnection conn=new MySqlConnection();
        conn.ConnectionString=connString;
        conn.Open();
        MySqlCommand cmd=new MySqlCommand(query,conn);
        cmd.Parameters.AddWithValue("@id",id);
        cmd.ExecuteNonQuery();
        conn.Close();

    }

    public static void addNewPlayer(int id,string name,string skills){
        string query="insert into player values(@id,@nm,@sk)";
        MySqlConnection conn=new MySqlConnection();
        conn.ConnectionString=connString;
        conn.Open();
        MySqlCommand cmd=new MySqlCommand(query,conn);
        cmd.Parameters.AddWithValue("@id",id);
        cmd.Parameters.AddWithValue("@nm",name);
        cmd.Parameters.AddWithValue("@sk",skills);
        cmd.ExecuteNonQuery();
    }


}