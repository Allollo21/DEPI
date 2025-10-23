using Assignment.Data.DbContexts;
using Assignment.Models;

namespace Assignment.Data.Repository
{
    public class TeacherRepository
    {
        private readonly ApplicationDbContext _context;

        public TeacherRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Teacher> GetAll()
        {
            return _context.Teachers.ToList();
        }
    }
}
