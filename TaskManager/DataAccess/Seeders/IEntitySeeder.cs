using Microsoft.EntityFrameworkCore;

namespace TaskManager.DataAccess.Seeders;

public interface IEntitySeeder
{
    void SeedDatabase(ModelBuilder modelBuilder);
}