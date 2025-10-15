using Domain.Interfaces;
using Domain.Models;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Implementation
{
    public class TaskRepository : GenericRepository<TaskItem>, ITaskRepository
    {
        public TaskRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<TaskItem>> GetFilteredByCompletionAsync(bool? isCompleted)
        {
            if (!isCompleted.HasValue)
            {
                return await GetAllAsync();
            }
            return await FindAsync(t => t.IsCompleted == isCompleted.Value);
        }
    }
}
