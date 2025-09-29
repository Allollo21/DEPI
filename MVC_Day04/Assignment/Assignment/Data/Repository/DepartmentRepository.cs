using Assignment.Data.DbContexts;
using Assignment.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Data.Repository
{
    public class DepartmentRepository
    {
        ApplicationDbContext _context = new ApplicationDbContext();

        public List<Department> GetAll()
        {
             return _context.Departments.ToList();
        }

        public Department GetDepartmentById(int id)
        {
            var department = _context.Departments.Where(d => d.Id == id)
                    .Include(d => d.Teachers)
                    .Include(d => d.Courses)
                    .Include(d => d.Students)
                    .FirstOrDefault();

            return department!;
        }

        public void AddDepartment(Department NewDept)
        {
            _context.Departments.Add(NewDept);
            _context.SaveChanges();
        }

        public void AddDepartmentWithRelationships(Department department, List<int> teacherIds, List<int> courseIds, List<int> studentIds)
        {
            var newDepartment = new Department
            {
                Name = department.Name,
                MgrName = department.MgrName,
                Teachers = new List<Teacher>(),
                Students = new List<Student>()
            };

            if (teacherIds != null && teacherIds.Any())
            {
                var teachers = _context.Teachers.Where(t => teacherIds.Contains(t.Id)).ToList();
                newDepartment.Teachers = teachers;
            }

            if (studentIds != null && studentIds.Any())
            {
                var students = _context.Students.Where(s => studentIds.Contains(s.Id)).ToList();
                newDepartment.Students = students;
            }

            _context.Departments.Add(newDepartment);
            _context.SaveChanges();

            if (courseIds != null && courseIds.Any())
            {
                var courses = _context.Courses.Where(c => courseIds.Contains(c.Id)).ToList();
                foreach (var course in courses)
                {
                    course.DepartmentId = newDepartment.Id;
                }
                _context.SaveChanges();
            }
        }
    }
}
