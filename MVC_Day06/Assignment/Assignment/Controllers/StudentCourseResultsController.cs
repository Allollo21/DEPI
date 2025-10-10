using Assignment.Data.DbContexts;
using Assignment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Assignment.Data.Repository;

namespace Assignment.Controllers
{
    public class StudentCourseResultsController : Controller
    {
        StudentCourseResultRepository studentCourseResultRepository = new();
        StudentRepository studentRepository = new();
        CourseRepository courseRepository = new();

        private readonly ApplicationDbContext _context;

        public StudentCourseResultsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: StudentCourseResults
        public async Task<IActionResult> Index()
        {
            var fullResults = await studentCourseResultRepository.GetAllWithRelations();
            var results = fullResults
                .Select(s => new
                {
                    Id = s.Id,
                    StudentName = s.Student.Name,
                    CourseName = s.Course.Name,
                    Grade = s.Grade,
                    DegreeColor = !s.Grade.ToLower().Contains('f') ? "green" : "red"
                })
                .ToList();

            return View(results);
        }

        // GET: StudentCourseResults/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentCourseResult = await studentCourseResultRepository.GetStudentCourseResultWithRelationsById(id);

            if (studentCourseResult == null)
            {
                return NotFound();
            }

            return View(studentCourseResult);
        }

        // GET: StudentCourseResults/Create
        public IActionResult Create()
        {
            ViewData["CourseId"] = new SelectList(courseRepository.GetAll(), "Id", "Name");
            ViewData["StudentId"] = new SelectList(studentRepository.GetAll(), "Id", "Name");
            return View();
        }

        // POST: StudentCourseResults/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,StudentId,CourseId,Grade")] StudentCourseResult studentCourseResult)
        {
            if (ModelState.IsValid)
            {
                await studentCourseResultRepository.AddStudentCourseResult(studentCourseResult);
                return RedirectToAction(nameof(Index));
            }
            ViewData["CourseId"] = new SelectList(courseRepository.GetAll(), "Id", "Name", studentCourseResult.CourseId);
            ViewData["StudentId"] = new SelectList(studentRepository.GetAll(), "Id", "Name", studentCourseResult.StudentId);
            return View(studentCourseResult);
        }

        // GET: StudentCourseResults/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentCourseResult = await studentCourseResultRepository.GetStudentCourseResultWithRelationsById(id);

            if (studentCourseResult == null)
            {
                return NotFound();
            }
            ViewData["CourseId"] = new SelectList(courseRepository.GetAll(), "Id", "Name", studentCourseResult.CourseId);
            ViewData["StudentId"] = new SelectList(studentRepository.GetAll(), "Id", "Name", studentCourseResult.StudentId);
            return View(studentCourseResult);
        }

        // POST: StudentCourseResults/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,StudentId,CourseId,Grade")] StudentCourseResult studentCourseResult)
        {
            if (id != studentCourseResult.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await studentCourseResultRepository.UpdateStudentCourseResult(studentCourseResult);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!studentCourseResultRepository.StudentCourseResultExists(studentCourseResult.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CourseId"] = new SelectList(courseRepository.GetAll(), "Id", "Name", studentCourseResult.CourseId);
            ViewData["StudentId"] = new SelectList(studentRepository.GetAll(), "Id", "Name", studentCourseResult.StudentId);
            return View(studentCourseResult);
        }

        // GET: StudentCourseResults/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentCourseResult = await studentCourseResultRepository.GetStudentCourseResultWithRelationsById(id);

            if (studentCourseResult == null)
            {
                return NotFound();
            }

            return View(studentCourseResult);
        }

        // POST: StudentCourseResults/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var studentCourseResult = await studentCourseResultRepository.FindById(id);
            if (studentCourseResult != null)
            {
                await studentCourseResultRepository.DeleteStudentCourseResult(studentCourseResult);
            }

            return RedirectToAction(nameof(Index));
        }
    }
}