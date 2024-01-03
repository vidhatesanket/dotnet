//use dotnet cli command
//dotnet add package Microsoft.EntityFramework

using Microsoft.EntityFrameworkCore;
using BOL;

namespace DAL;
public class CollectionContext:DbContext{
    public DbSet<Player> p{get;set;}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string conString=@"server=127.0.0.1;port=3306;user=root; password=welcome;database=someshdb";       
        optionsBuilder.UseMySQL(conString);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //Set Mapping of Table with POCO
        //Relational        instance: Table
        //Object Oriented   instance: POCO Class
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Player>(entity => 
        {
            entity.HasKey(e => e.Pid);
            entity.Property(e => e.Pname).IsRequired();
            entity.Property(e => e.Skills).IsRequired();
        });
        modelBuilder.Entity<Player>().ToTable("playerlist");
    }
}

