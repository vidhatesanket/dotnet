namespace DAL;
using BOL;
    public interface IDBManager{
        List<Player> GetAll();
        Player GetById(int id);
        void Insert(Player dept);
        void Update(Player dept);
        void Delete(int id);
    }
