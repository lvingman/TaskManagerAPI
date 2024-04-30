using TaskManager.DataAccess.Repositories.Interfaces;
using Task = TaskManager.Models.Task;

namespace TaskManager.DataAccess.Repositories;

public class TaskRepository : Repository<Task>, ITaskRepository
{
    public TaskRepository(TaskManagerDbContext context) : base(context)
    {
    }
    
    //TODO: Generate task methods
    
}