using Assignment.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Data.DbContexts
{
    public class ApplicationDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer("Server=.;Database=Corporation;Trusted_Connection=True;TrustServerCertificate=True;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed Departments
            modelBuilder.Entity<Department>().HasData(
                new Department { Id = 1, Name = "Computer Science", MgrName = "Dr. Smith" },
                new Department { Id = 2, Name = "Mathematics", MgrName = "Dr. Johnson" },
                new Department { Id = 3, Name = "Physics", MgrName = "Dr. Brown" }
            );

            // Seed Teachers
            modelBuilder.Entity<Teacher>().HasData(
                new Teacher { Id = 1, Name = "John Doe", Salary = 75000, Address = "123 Main St", DepartmentId = 1 },
                new Teacher { Id = 2, Name = "Jane Smith", Salary = 80000, Address = "456 Oak Ave", DepartmentId = 1 },
                new Teacher { Id = 3, Name = "Mike Wilson", Salary = 72000, Address = "789 Pine Rd", DepartmentId = 2 }
            );

            // Seed Courses
            modelBuilder.Entity<Course>().HasData(
                new Course { Id = 1, Name = "Introduction to Programming", Degree = "Bachelor", MinDegree = "Certificate", DepartmentId = 1, TeacherId = 1 },
                new Course { Id = 2, Name = "Data Structures", Degree = "Bachelor", MinDegree = "Bachelor", DepartmentId = 1, TeacherId = 2 },
                new Course { Id = 3, Name = "Calculus I", Degree = "Bachelor", MinDegree = "Certificate", DepartmentId = 2, TeacherId = 3 }
            );

            // Seed Students
            modelBuilder.Entity<Student>().HasData(
                new Student { Id = 1, Name = "Alice Johnson", Age = 20, DepartmentId = 1 },
                new Student { Id = 2, Name = "Bob Williams", Age = 22, DepartmentId = 1 },
                new Student { Id = 3, Name = "Carol Davis", Age = 19, DepartmentId = 2 }
            );

            // Seed Student Course Results
            modelBuilder.Entity<StudentCourseResult>().HasData(
                new StudentCourseResult { Id = 1, StudentId = 1, CourseId = 1, Grade = "A" },
                new StudentCourseResult { Id = 2, StudentId = 1, CourseId = 2, Grade = "B+" },
                new StudentCourseResult { Id = 3, StudentId = 2, CourseId = 1, Grade = "A-" },
                new StudentCourseResult { Id = 4, StudentId = 3, CourseId = 3, Grade = "A" }
            );
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentCourseResult> StudentCourseResults { get; set; }

    }
}
