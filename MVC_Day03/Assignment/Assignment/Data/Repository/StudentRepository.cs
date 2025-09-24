using Assignment.Data.DbContexts;
using Assignment.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Data.Repository
{
    public class StudentRepository
    {
        ApplicationDbContext _context = new();

        public List<Student> GetAll() => _context.Students.ToList();

        public Student GetById(int id) => _context.Students.SingleOrDefault(s => s.Id.Equals(id))!;
        public Student GetStudentWithDepartmentById(int id)
        {
            return _context.Students.Include(s => s.Department).FirstOrDefault(s => s.Id == id)!;
        }
    }
}
