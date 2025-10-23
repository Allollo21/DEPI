using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Assignment.Data.DbContexts;
using Assignment.Models;
using Assignment.Data.Repository;

namespace Assignment.Controllers
{
    public class CourseController : Controller
    {
        CourseRepository courseRepository;
        TeacherRepository teacherRepository;
        DepartmentRepository departmentRepository;

        private readonly ApplicationDbContext _context;

        public CourseController(ApplicationDbContext context)
        {
            _context = context;
            courseRepository = new CourseRepository(context);
            teacherRepository = new TeacherRepository(context);
            departmentRepository = new DepartmentRepository(context);
        }

        // GET: Course
        public async Task<IActionResult> Index()
        {
            var Courses = await courseRepository.GetAllWithRelations();
            return View(Courses);
        }

        // GET: Course/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = await courseRepository.GetCourseWithRelationsById(id);

            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }

        // GET: Course/Create
        public IActionResult Create()
        {
            ViewData["DepartmentId"] = new SelectList(departmentRepository.GetAll(), "Id", "Name");
            ViewData["TeacherId"] = new SelectList(teacherRepository.GetAll(), "Id", "Name");
            return View();
        }

        // POST: Course/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Degree,MinDegree,DepartmentId,TeacherId")] Course course)
        {
            if (ModelState.IsValid)
            {
                await courseRepository.AddCourse(course);
                return RedirectToAction(nameof(Index));
            }
            ViewData["DepartmentId"] = new SelectList(departmentRepository.GetAll(), "Id", "Name", course.DepartmentId);
            ViewData["TeacherId"] = new SelectList(teacherRepository.GetAll(), "Id", "Name", course.TeacherId);
            return View(course);
        }

        // GET: Course/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = await courseRepository.GetCourseWithRelationsById(id);

            if (course == null)
            {
                return NotFound();
            }
            ViewData["DepartmentId"] = new SelectList(departmentRepository.GetAll(), "Id", "Name", course.DepartmentId);
            ViewData["TeacherId"] = new SelectList(teacherRepository.GetAll(), "Id", "Name", course.TeacherId);
            return View(course);
        }

        // POST: Course/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Degree,MinDegree,DepartmentId,TeacherId")] Course course)
        {
            if (id != course.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await courseRepository.UpdateCourse(course);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!courseRepository.CourseExists(course.Id))
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
            ViewData["DepartmentId"] = new SelectList(departmentRepository.GetAll(), "Id", "Name", course.DepartmentId);
            ViewData["TeacherId"] = new SelectList(teacherRepository.GetAll(), "Id", "Name", course.TeacherId);
            return View(course);
        }

        // GET: Course/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = await courseRepository.GetCourseWithRelationsById(id);

            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }

        // POST: Course/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var course = await courseRepository.FindById(id);
            if (course != null)
            {
                await courseRepository.DeleteCourse(course);
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
