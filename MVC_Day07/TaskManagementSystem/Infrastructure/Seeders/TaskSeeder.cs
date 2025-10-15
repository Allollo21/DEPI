using Domain.Models;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Seeders
{
    public static class TaskSeeder
    {
        public static async Task SeedDataAsync(ApplicationDbContext context)
        {
            if (await context.Tasks.AnyAsync()) return; // Skip if data exists

            var tasks = new List<TaskItem>
        {
            new TaskItem
            {
                Title = "Buy groceries",
                Description = "Purchase milk, eggs, bread, and vegetables for the week.",
                IsCompleted = false,
                CreatedAt = DateTime.UtcNow.AddDays(-5),
                DueDate = DateTime.UtcNow.AddDays(2)
            },
            new TaskItem
            {
                Title = "Finish quarterly report",
                Description = "Compile sales data, analyze trends, and prepare executive summary.",
                IsCompleted = true,
                CreatedAt = DateTime.UtcNow.AddDays(-10),
                DueDate = DateTime.UtcNow.AddDays(-1)
            },
            new TaskItem
            {
                Title = "Schedule dentist appointment",
                Description = "Call the clinic and book a check-up for next month.",
                IsCompleted = false,
                CreatedAt = DateTime.UtcNow.AddDays(-2),
                DueDate = DateTime.UtcNow.AddDays(7)
            },
            new TaskItem
            {
                Title = "Exercise routine",
                Description = "Go for a 30-minute run and do strength training.",
                IsCompleted = true,
                CreatedAt = DateTime.UtcNow.AddDays(-1),
                DueDate = DateTime.UtcNow
            },
            new TaskItem
            {
                Title = "Plan family vacation",
                Description = "Research destinations, book flights, and reserve hotel for summer trip.",
                IsCompleted = false,
                CreatedAt = DateTime.UtcNow.AddDays(-15),
                DueDate = DateTime.UtcNow.AddDays(30)
            },
            new TaskItem
            {
                Title = "Update resume",
                Description = "Add recent job experience and skills to professional resume.",
                IsCompleted = false,
                CreatedAt = DateTime.UtcNow.AddDays(-3),
                DueDate = DateTime.UtcNow.AddDays(5)
            },
            new TaskItem
            {
                Title = "Read new book",
                Description = "Finish reading 'The Great Gatsby' and take notes.",
                IsCompleted = true,
                CreatedAt = DateTime.UtcNow.AddDays(-7),
                DueDate = DateTime.UtcNow.AddDays(-2)
            },
            new TaskItem
            {
                Title = "Clean garage",
                Description = "Organize tools, discard old items, and sweep the floor.",
                IsCompleted = false,
                CreatedAt = DateTime.UtcNow.AddDays(-4),
                DueDate = DateTime.UtcNow.AddDays(3)
            },
            new TaskItem
            {
                Title = "Prepare presentation",
                Description = "Create slides for team meeting on project updates.",
                IsCompleted = true,
                CreatedAt = DateTime.UtcNow.AddDays(-8),
                DueDate = DateTime.UtcNow.AddDays(-3)
            },
            new TaskItem
            {
                Title = "Grocery shopping list",
                Description = "Make a list of essentials and compare prices online.",
                IsCompleted = false,
                CreatedAt = DateTime.UtcNow.AddDays(-6),
                DueDate = DateTime.UtcNow.AddDays(1)
            }
        };

            context.Tasks.AddRange(tasks);
            await context.SaveChangesAsync();
        }
    }
}
