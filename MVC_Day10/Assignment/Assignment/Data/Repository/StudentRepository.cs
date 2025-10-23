using Assignment.Data.DbContexts;
using Assignment.Models;
using Microsoft.EntityFrameworkCore;
using X.PagedList;
using X.PagedList.Extensions;

namespace Assignment.Data.Repository
{
    public class StudentRepository
    {
        private readonly ApplicationDbContext _context;

        public StudentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Student> GetAll() => _context.Students.ToList();

        public List<Student> GetAllWithDepartments() => _context.Students.Include(s => s.Department).ToList();

        public IPagedList<Student> GetAllPaginated(int PageNumber, int PageSize, string searchName = "", int? departmentId = null)
        {
            var query = _context.Students.Include(s => s.Department).AsQueryable();

            if (!string.IsNullOrWhiteSpace(searchName))
            {
                query = query.Where(s => s.Name.Contains(searchName));
            }

            if (departmentId.HasValue && departmentId.Value > 0)
            {
                query = query.Where(s => s.DepartmentId == departmentId.Value);
            }

            return query.OrderBy(s => s.Name).ToPagedList(PageNumber, PageSize);
        }

        public Student GetById(int id) => _context.Students.SingleOrDefault(s => s.Id.Equals(id))!;
        public Student GetStudentWithDepartmentById(int id)
        {
            return _context.Students.Include(s => s.Department).FirstOrDefault(s => s.Id == id)!;
        }

        public void Add(Student newStudent)
        {
            _context.Students.Add(newStudent);
            _context.SaveChanges();
        }

        public void Update(Student newStudent, int oldStudentId)
        {
            Student oldStudent = GetById(oldStudentId);

            oldStudent.Name = newStudent.Name;
            oldStudent.Age = newStudent.Age;
            oldStudent.DepartmentId = newStudent.DepartmentId;

            _context.SaveChanges();
        }

        public void Delete(Student student)
        {
            _context.Students.Remove(student);
            _context.SaveChanges();
        }
    }
}
