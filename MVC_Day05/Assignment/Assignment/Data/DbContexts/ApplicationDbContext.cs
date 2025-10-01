using Assignment.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Data.DbContexts
{
    public class ApplicationDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Server=.;Database=Corporation;Trusted_Connection=True;TrustServerCertificate=True;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            DatabaseSeeder.SeedData(modelBuilder);
        }   

        public DbSet<Department> Departments { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentCourseResult> StudentCourseResults { get; set; }

    }
}
