using Assignment.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Assignment.Data
{
    public static class DatabaseSeeder
    {
        public static void SeedData(ModelBuilder modelBuilder)
        {
            // Seed 15 Departments (some will have 50+ entities, others less)
            var departments = new List<Department>();
            for (int i = 1; i <= 15; i++)
            {
                departments.Add(new Department
                {
                    Id = i,
                    Name = $"Department of {GetDepartmentName(i)}",
                    MgrName = $"Manager {i}"
                });
            }
            modelBuilder.Entity<Department>().HasData(departments);

            // Seed 150 Teachers
            var teachers = new List<Teacher>();
            for (int i = 1; i <= 150; i++)
            {
                teachers.Add(new Teacher
                {
                    Id = i,
                    Name = $"Teacher {i}",
                    Salary = 50000 + (i * 500),
                    Address = $"{i} Academic Street",
                    DepartmentId = GetDepartmentId(i, 15) // Distribute across departments
                });
            }
            modelBuilder.Entity<Teacher>().HasData(teachers);

            // Seed 100 Instructors (similar distribution as Teachers)
            var instructors = new List<Instructor>();
            for (int i = 1; i <= 100; i++)
            {
                instructors.Add(new Instructor
                {
                    Id = i,
                    Name = $"Instructor {i}",
                    Salary = 40000 + (i * 400),  // Slightly different salary range
                    Address = $"{i} Instruction Lane",
                    DepartmentId = GetDepartmentId(i, 15) // Distribute across departments
                });
            }
            modelBuilder.Entity<Instructor>().HasData(instructors);

            // Seed 200 Courses  
            var courses = new List<Course>();
            for (int i = 1; i <= 200; i++)
            {
                courses.Add(new Course
                {
                    Id = i,
                    Name = $"Course {i}",
                    Degree = GetRandomDegree(i),
                    MinDegree = "Certificate",
                    DepartmentId = GetDepartmentId(i, 15),
                    TeacherId = GetTeacherId(i, 150)
                });
            }
            modelBuilder.Entity<Course>().HasData(courses);

            // Seed 300 Students
            var students = new List<Student>();
            for (int i = 1; i <= 300; i++)
            {
                students.Add(new Student
                {
                    Id = i,
                    Name = $"Student {i}",
                    Age = 18 + (i % 10),
                    DepartmentId = GetDepartmentId(i, 15)
                });
            }
            modelBuilder.Entity<Student>().HasData(students);

            // Seed Student Course Results (optional - add some sample grades)
            var studentCourseResults = new List<StudentCourseResult>();
            for (int i = 1; i <= 100; i++) // 100 sample results
            {
                studentCourseResults.Add(new StudentCourseResult
                {
                    Id = i,
                    StudentId = (i % 300) + 1, // Students 1-300
                    CourseId = (i % 200) + 1,  // Courses 1-200
                    Grade = GetRandomGrade(i)
                });
            }
            modelBuilder.Entity<StudentCourseResult>().HasData(studentCourseResults);

            // Seed Roles: Admin and Moderator
            var adminRoleId = "admin-role-id";
            var moderatorRoleId = "moderator-role-id";

            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = adminRoleId,
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole
                {
                    Id = moderatorRoleId,
                    Name = "Moderator",
                    NormalizedName = "MODERATOR"
                }
            );

            // Seed Admin User
            var adminUserId = "admin-user-id";
            var hasher = new PasswordHasher<ApplicationUser>();
            var adminUser = new ApplicationUser
            {
                Id = adminUserId,
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@example.com",  // Adjust if needed
                NormalizedEmail = "ADMIN@EXAMPLE.COM"
            };
            adminUser.PasswordHash = hasher.HashPassword(adminUser, "0000");

            modelBuilder.Entity<ApplicationUser>().HasData(adminUser);

            // Assign Admin role to the admin user
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = adminRoleId,
                    UserId = adminUserId
                }
            );
        }

        // Helper methods
        private static int GetDepartmentId(int index, int totalDepts)
        {
            // This ensures some departments get 50+ items, others get less
            if (index <= 60) return 1; // Department 1 gets many
            if (index <= 110) return 2; // Department 2 gets many  
            if (index <= 140) return 3; // Department 3 gets some
            return ((index - 141) % (totalDepts - 3)) + 4; // Others get distributed
        }

        private static int? GetTeacherId(int courseIndex, int totalTeachers)
        {
            return (courseIndex % totalTeachers) + 1;
        }

        private static string GetDepartmentName(int id)
        {
            string[] names = {
                "Computer Science", "Mathematics", "Physics", "Chemistry",
                "Biology", "History", "English", "Psychology", "Economics",
                "Engineering", "Art", "Music", "Philosophy", "Sociology", "Geography"
            };
            return names[id - 1];
        }

        private static string GetRandomDegree(int index)
        {
            string[] degrees = { "Bachelor", "Master", "PhD", "Certificate" };
            return degrees[index % degrees.Length];
        }

        private static string GetRandomGrade(int index)
        {
            string[] grades = { "A+", "A", "A-", "B+", "B", "B-", "C+", "C", "C-", "D", "F" };
            return grades[index % grades.Length];
        }

    }
}
