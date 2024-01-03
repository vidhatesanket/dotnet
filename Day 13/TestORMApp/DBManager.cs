namespace DAL;
using BOL;
// using MySql.Data.MySqlClient;
//CRUD Operations code against database inside DBManager
public class DBManager:IDBManager{
    public void Delete(int id)
    {
        using(var context = new CollectionContext())
        {
            Player pl=context.p.Find(id);
            if(pl!=null){
                context.p.Remove(pl);
                context.SaveChanges();
            }
            
        }
    }

    public List<Player> GetAll()
    {   //Deterministic Finalization
        using (var context = new CollectionContext())
        {
            //LINQ
            var tempplayer=from dept in context.p select dept;
            return  tempplayer.ToList<Player>();
        }
    }

    public Player GetById(int id)
    {
        using (var context = new CollectionContext())
        {
            var tempplayer = context.p.Find(id);
            return tempplayer;
        }
    }

    public void Insert(Player p)
    {
        using (var context = new CollectionContext())
        {
            context.p.Add(p);
            context.SaveChanges();  
        }
    }
    public void Update(Player p)
    {
        using (var context = new CollectionContext())
        {
            var theDept = context.p.Find(p.Pid);
            theDept.Pname =p.Pname;
            theDept.Skills=p.Skills;
            context.SaveChanges();
        }
    }
}