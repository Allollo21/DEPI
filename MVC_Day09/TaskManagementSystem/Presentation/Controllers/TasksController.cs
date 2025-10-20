using Application.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    public class TasksController : Controller
    {
        private readonly ITaskService _taskService;

        public TasksController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        // GET: Tasks
        public async Task<IActionResult> Index(bool? completed, string sortBy)
        {
            IEnumerable<TaskItem> tasks;

            if (completed.HasValue)
            {
                tasks = await _taskService.GetFilteredTasksByCompletionAsync(completed);
            }
            else
            {
                tasks = await _taskService.GetAllTasksAsync();
            }

            if (!string.IsNullOrEmpty(sortBy))
            {
                tasks = sortBy switch
                {
                    "DueDate" => tasks.OrderBy(t => t.DueDate),
                    "Title" => tasks.OrderBy(t => t.Title),
                    _ => tasks
                };
            }

            ViewBag.CurrentCompleted = completed;
            ViewBag.CurrentSort = sortBy;

            return View(tasks);
        }

        // GET: Tasks/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var task = await _taskService.GetTaskByIdAsync(id);
            if (task == null)
            {
                return NotFound();
            }
            return View(task);
        }

        // GET: Tasks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tasks/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TaskItem task)
        {
            if (ModelState.IsValid)
            {
                await _taskService.CreateTaskAsync(task);
                return RedirectToAction(nameof(Index));
            }
            return View(task);
        }

        // GET: Tasks/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var task = await _taskService.GetTaskByIdAsync(id);
            if (task == null)
            {
                return NotFound();
            }
            return View(task);
        }

        // POST: Tasks/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([FromRoute]int id, TaskItem task)
        {
            if (id != task.Id)
            {
                return NotFound();
            }

            if(id != task.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _taskService.UpdateTaskAsync(task);
                }
                catch (Exception)
                {
                    if (await _taskService.GetTaskByIdAsync(task.Id) == null)
                    {
                        return NotFound();
                    }
                    throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(task);
        }

        // GET: Tasks/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var task = await _taskService.GetTaskByIdAsync(id);
            if (task == null)
            {
                return NotFound();
            }
            return View(task);
        }

        // POST: Tasks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed([FromRoute]int id)
        {
            await _taskService.DeleteTaskAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
