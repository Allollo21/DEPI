using Assignment.Data.DbContexts;
using Assignment.Models;

namespace Assignment.Data.Repository
{
    public class CourseRepository
    {
        ApplicationDbContext _context = new();

        public List<Course> GetAll()
        {
            return _context.Courses.ToList();
        }
    }
}
