
namespace DAL;
using BOL;
public class DBManager:IDBManager{
    // public void Delete(int id)
    // {
    //     using(var context = new CollectionContext())
    //     {
    //         context.Player.Remove(context.Player.Find(id));
    //         context.SaveChanges();
    //     }
    // }

    public  List<Player> GetAll()
    {
        using (var context = new CollectionContext())
        {
            var players=from PlayerList in context.PlayerListDetails select PlayerList;
            return players.ToList<Player>();
        }
    }

    // public Department GetById(int id)
    // {
    //     using (var context = new CollectionContext())
    //     {
    //         var dept = context.Departments.Find(id);
    //         return dept;
    //     }
    // }

    // public void Insert(Department dept)
    // {
    //     using (var context = new CollectionContext())
    //     {
    //         context.Departments.Add(dept);
    //         context.SaveChanges();  
    //     }
    // }

    // public void Update(Department dept)
    // {
    //     using (var context = new CollectionContext())
    //     {
    //         var theDept = context.Departments.Find(dept.Id);
    //         theDept.Name =dept.Name;
    //         theDept.Location=dept.Location;
    //         context.SaveChanges();
    //     }
    // }
}