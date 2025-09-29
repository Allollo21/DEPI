using Assignment.Data.DbContexts;
using Assignment.Models;

namespace Assignment.Data.Repository
{
    public class TeacherRepository
    {
        ApplicationDbContext _context = new();

        public List<Teacher> GetAll()
        {
            return _context.Teachers.ToList();
        }
    }
}
