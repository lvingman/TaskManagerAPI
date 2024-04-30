using TaskManager.DataAccess.Repositories;

namespace TaskManager.Services;

public interface IUnitOfWork : IDisposable
{
    //ToDo: Generar TaskRepository
    public TaskRepository TaskRepository { get; }

    Task<int> Complete();
}