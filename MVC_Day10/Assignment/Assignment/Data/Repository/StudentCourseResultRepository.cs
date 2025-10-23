using Assignment.Data.DbContexts;
using Assignment.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Data.Repository
{
    public class StudentCourseResultRepository
    {
        private readonly ApplicationDbContext _context;

        public StudentCourseResultRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<StudentCourseResult> GetAll()
        {
            return _context.StudentCourseResults.ToList();
        }

        public async Task<List<StudentCourseResult>> GetAllWithRelations()
        {
            return await _context.StudentCourseResults.Include(s => s.Student).Include(s => s.Course).ToListAsync();
        }

        public async Task<StudentCourseResult?> GetStudentCourseResultWithRelationsById(int? id)
        {
            return await _context.StudentCourseResults.Include(s => s.Student).Include(s => s.Course).FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task AddStudentCourseResult(StudentCourseResult newStudentCourseResult)
        {
            _context.Add(newStudentCourseResult);
            await _context.SaveChangesAsync();
        }

        // uses lazy loading 
        public async Task<StudentCourseResult?> FindById(int? id)
        {
            return await _context.StudentCourseResults.FindAsync(id);
        }

        public async Task UpdateStudentCourseResult(StudentCourseResult newStudentCourseResult)
        {
            _context.Update(newStudentCourseResult);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteStudentCourseResult(StudentCourseResult studentCourseResult)
        {
            _context.StudentCourseResults.Remove(studentCourseResult);
            await _context.SaveChangesAsync();
        }

        public bool StudentCourseResultExists(int id)
        {
            return _context.StudentCourseResults.Any(e => e.Id == id);
        }
    }
}