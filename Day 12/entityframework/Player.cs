
namespace BOL;
public class Player{
    public int Pid{get;set;}
    public string Pname{get;set;}
    public string Skills{get;set;}
    
    public Player(int a,string b,string c){
        Pid=a;
        Pname=b;
        Skills=c;
    }
}