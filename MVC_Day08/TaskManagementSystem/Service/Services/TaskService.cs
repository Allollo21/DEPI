using Application.Interfaces;
using Domain.Interfaces;
using Domain.Models;

namespace Application.Services
{
    public class TaskService : ITaskService
    {
        private readonly IUnitOfWork _unitOfWork;

        public TaskService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<TaskItem>> GetAllTasksAsync()
        {
            return await _unitOfWork.Tasks.GetAllAsync();
        }

        public async Task<IEnumerable<TaskItem>> GetFilteredTasksByCompletionAsync(bool? isCompleted)
        {
            return await _unitOfWork.Tasks.GetFilteredByCompletionAsync(isCompleted);
        }

        public async Task<TaskItem?> GetTaskByIdAsync(int id)
        {
            return await _unitOfWork.Tasks.GetByIdAsync(id);
        }

        public async Task<TaskItem> CreateTaskAsync(TaskItem task)
        {
            var added = await _unitOfWork.Tasks.AddAsync(task);
            await _unitOfWork.SaveAsync();
            return added;
        }

        public async Task UpdateTaskAsync(TaskItem task)
        {
            await _unitOfWork.Tasks.UpdateAsync(task);
            await _unitOfWork.SaveAsync();
        }

        public async Task DeleteTaskAsync(int id)
        {
            var task = await _unitOfWork.Tasks.GetByIdAsync(id);
            if (task != null)
            {
                await _unitOfWork.Tasks.DeleteAsync(task);
                await _unitOfWork.SaveAsync();
            }
        }
    }
}
