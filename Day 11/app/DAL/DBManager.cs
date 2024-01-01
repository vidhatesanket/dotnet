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


    public static void update(int id,string nm, string sk){
        List<Player> plist=new List<Player>();
        string query="update playerlist set pname=@name, skills=@skill where pid=@id";
        MySqlConnection conn=new MySqlConnection();
        conn.ConnectionString=connString;
        MySqlCommand cmd=new MySqlCommand(query,conn);
        conn.Open();
        cmd.Parameters.AddWithValue("@name",nm);
        cmd.Parameters.AddWithValue("@skill",sk);
        cmd.Parameters.AddWithValue("@id",id);
        cmd.ExecuteNonQuery();
        conn.Close();
        
    }

    public static void insert(int id,string nm, string sk){
        List<Player> plist=getall();

        Boolean flag=true;
        foreach (Player p in plist){
            if(p.Pid==id && p.Pname==nm && p.Skills==sk){
                flag=false;
            }
        }

        if(flag){
            string query="insert into playerlist values(@newid,@newname,@newskill)";
            MySqlConnection conn=new MySqlConnection();
            conn.ConnectionString=connString;
            MySqlCommand cmd=new MySqlCommand(query,conn);
            conn.Open();

                cmd.Parameters.AddWithValue("@newid",id);
                cmd.Parameters.AddWithValue("@newname",nm);
                cmd.Parameters.AddWithValue("@newskill",sk);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        
    }

    public static void delete(int id){
       
        string query="delete from playerlist where pid=@deleteid";
        MySqlConnection conn=new MySqlConnection();
        conn.ConnectionString=connString;
        MySqlCommand cmd=new MySqlCommand(query,conn);
        conn.Open();
        cmd.Parameters.AddWithValue("@deleteid",id);
        cmd.ExecuteNonQuery();
        conn.Close();
        
    }

}
