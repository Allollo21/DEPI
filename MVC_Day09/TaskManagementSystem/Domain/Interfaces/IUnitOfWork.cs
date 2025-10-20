using Domain.Models;

namespace Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ITaskRepository Tasks { get; }

        Task<int> SaveAsync();
    }
}
