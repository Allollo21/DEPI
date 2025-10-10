using Assignment.Data.DbContexts;
using Assignment.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Data.Repository
{
    public class CourseRepository
    {
        ApplicationDbContext _context = new();

        public List<Course> GetAll()
        {
            return _context.Courses.ToList();
        }

        public async Task<List<Course>> GetAllWithRelations()
        {
            return await _context.Courses.Include(c => c.Department).Include(c => c.Teacher).ToListAsync();
        }

        public async Task<Course?> GetCourseWithRelationsById(int? id)
        {
            return await _context.Courses.Include(c => c.Department).Include(c => c.Teacher).FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task AddCourse(Course newCourse)
        {
            _context.Add(newCourse);
            await _context.SaveChangesAsync();
        }

        // uses lazy loading 
        public async Task<Course?> FindById(int? id)
        {
            return await _context.Courses.FindAsync(id);
        }

        public async Task UpdateCourse(Course newCourse)
        {
            _context.Update(newCourse);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCourse(Course course)
        {
            _context.Courses.Remove(course);
            await _context.SaveChangesAsync();
        }

        public bool CourseExists(int id)
        {
            return _context.Courses.Any(e => e.Id == id);
        }
    }
}
