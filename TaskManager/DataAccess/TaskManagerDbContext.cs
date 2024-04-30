using Microsoft.EntityFrameworkCore;
using TaskManager.DataAccess.Seeders;
using Task = TaskManager.Models.Task;

namespace TaskManager.DataAccess;

public class TaskManagerDbContext : DbContext
{
    public TaskManagerDbContext(DbContextOptions<TaskManagerDbContext> options) : base(options)
    {
            
    }
    
    public DbSet<Task> Tasks { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //Se especifica la SeedData aca adentro
        var seeders = new List<IEntitySeeder>
        {
            new TaskSeeder(),
        };

        foreach (var entitySeeder in seeders)
        {
            entitySeeder.SeedDatabase(modelBuilder);
        }
    }
    
}