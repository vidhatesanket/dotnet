
namespace BOL;
public class Player{
    public int id{get;set;}
    public string name{get;set;}
    public string skills{get;set;}
    public Player(){}
    public Player(int pid,string pname,string pskills){
        id=pid;
        name=pname;
        skills=pskills;
    }
}