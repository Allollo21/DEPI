using Assignment.Data.DbContexts;
using Assignment.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Data.Repository
{
    public class DepartmentRepository
    {
        private readonly ApplicationDbContext _context;

        public DepartmentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

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

        public void UpdateDepartment(Department department)
        {
            _context.Departments.Update(department);
            _context.SaveChanges();
        }

        public void UpdateDepartmentWithRelationships(Department department, List<int> teacherIds, List<int> courseIds, List<int> studentIds)
        {
            var existingDepartment = _context.Departments
                .Include(d => d.Teachers)
                .Include(d => d.Students)
                .Include(d => d.Courses)
                .FirstOrDefault(d => d.Id == department.Id);

            if (existingDepartment == null)
            {
                throw new Exception("Department not found");
            }

            existingDepartment.Name = department.Name;
            existingDepartment.MgrName = department.MgrName;

            existingDepartment.Teachers.Clear();
            if (teacherIds != null && teacherIds.Any())
            {
                var teachers = _context.Teachers.Where(t => teacherIds.Contains(t.Id)).ToList();
                existingDepartment.Teachers = teachers;
            }

            existingDepartment.Students.Clear();
            if (studentIds != null && studentIds.Any())
            {
                var students = _context.Students.Where(s => studentIds.Contains(s.Id)).ToList();
                existingDepartment.Students = students;
            }

            var existingCourses = _context.Courses.Where(c => c.DepartmentId == existingDepartment.Id).ToList();
            foreach (var course in existingCourses)
            {
                course.DepartmentId = null;
            }

            if (courseIds != null && courseIds.Any())
            {
                var courses = _context.Courses.Where(c => courseIds.Contains(c.Id)).ToList();
                foreach (var course in courses)
                {
                    course.DepartmentId = existingDepartment.Id;
                }
            }

            _context.SaveChanges();
        }

    }
}
