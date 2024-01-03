 using Microsoft.EntityFrameworkCore;
using BOL;
namespace DAL;
    public class CollectionContext:DbContext{
        public DbSet<Player> PlayerListDetails {get;set;}
    //    public CollectionContext(DbContextOptions<CollectionContext> options): base(options){

    //     }
    public CollectionContext(){

    }
       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conString=@"server=127.0.0.1;port=3306;user=root; password=welcome;database=someshdb";       
            optionsBuilder.UseMySQL(conString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Player>(entity => 
            {
            // entity.HasKey(e => e.Pid);
             entity.Property(e => e.Pid);
            entity.Property(e => e.Pname);
            entity.Property(e => e.Skills);
            });
             modelBuilder.Entity<Player>().ToTable("playerlist");
        }
    }

