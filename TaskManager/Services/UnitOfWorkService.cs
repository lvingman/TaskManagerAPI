using TaskManager.DataAccess;
using TaskManager.DataAccess.Repositories;

namespace TaskManager.Services;

public class UnitOfWorkService : IUnitOfWork
{
    //ToDo: Generar DBContext
    private readonly TaskManagerDbContext _context;
    public TaskRepository TaskRepository { get; }

    public UnitOfWorkService(TaskManagerDbContext context)
    {
        _context = context;
        TaskRepository = new TaskRepository(_context);
    }
    
    public Task<int> Complete()
    {
        return _context.SaveChangesAsync();
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}