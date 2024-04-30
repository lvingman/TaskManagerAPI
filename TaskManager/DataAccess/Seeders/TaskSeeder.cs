using Microsoft.EntityFrameworkCore;
using Task = TaskManager.Models.Task;

namespace TaskManager.DataAccess.Seeders;

public class TaskSeeder : IEntitySeeder
{
    public void SeedDatabase(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Task>().HasData(
            new Task
            {
                Id = 1,
                Title = "Test1",
                Description = "A test for a task",
                DueDate = DateOnly.Parse("30/04/2024"),
                Active = true,
                StatusID = 1
            });

    }
}