using Assignment.Data.DbContexts;
using Assignment.Data.Repository;
using Assignment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Controllers
{
    public class DepartmentController : Controller
    {
        DepartmentRepository departmentRepository;
        StudentRepository studentRepository;
        TeacherRepository teacherRepository;
        CourseRepository courseRepository;
        ApplicationDbContext _context;

        public DepartmentController(ApplicationDbContext context)
        {
            _context = context;
            departmentRepository = new(context);
            studentRepository = new(context);
            teacherRepository = new(context);
            courseRepository = new(context);
        }

        public IActionResult Index()
        {
            var Departments = departmentRepository.GetAll();
            return View(Departments);
        }

        public IActionResult ShowDetails(int id)
        {
            var department = departmentRepository.GetDepartmentById(id);
            return View(department);
        }

        public IActionResult ShowDetailsVM(int id)
        {
            var department = departmentRepository.GetDepartmentById(id);

            if (department == null)
            {
                return NotFound();
            }

            // Get students over 25 years old in this department
            var studentsOver25 = department.Students
                .Where(s => s.Age > 25)
                .Select(s => new SelectListItem
                {
                    Value = s.Id.ToString(),
                    Text = s.Name
                })
                .ToList();

            // Determine department state based on student count
            var studentCount = department.Students?.Count ?? 0;
            var departmentState = studentCount > 50 ? "Main" : "Branch";

            var viewModel = new DepartmentVM
            {
                DepartmentId = department.Id,
                DepartmentName = department.Name,
                DepartmentState = departmentState,
                StudentCount = studentCount,
                StudentsOver25 = studentsOver25
            };

            return View(viewModel);
        }

        public IActionResult Add() 
        {
            try
            {
                ViewBag.Teachers = teacherRepository.GetAll()
                    .Select(t => new SelectListItem { Value = t.Id.ToString(), Text = t.Name })
                    .ToList();
                ViewBag.Courses = courseRepository.GetAll()
                    .Select(c => new SelectListItem { Value = c.Id.ToString(), Text = c.Name })
                    .ToList();
                ViewBag.Students = studentRepository.GetAll()
                    .Select(s => new SelectListItem { Value = s.Id.ToString(), Text = s.Name })
                    .ToList();

                return View("Add", new Department());
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View("Add", new Department());
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Save(Department department, List<int> teacherIds, List<int> courseIds, List<int> studentIds)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    // Clean the lists
                    teacherIds = teacherIds?.Where(id => id > 0).ToList() ?? new List<int>();
                    courseIds = courseIds?.Where(id => id > 0).ToList() ?? new List<int>();
                    studentIds = studentIds?.Where(id => id > 0).ToList() ?? new List<int>();

                    departmentRepository.AddDepartmentWithRelationships(department, teacherIds, courseIds, studentIds);

                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    var errorMessage = ex.InnerException?.Message ?? ex.Message;
                    ModelState.AddModelError("", $"Error saving department: {errorMessage}");
                }
            }

            ViewBag.Teachers = teacherRepository.GetAll()
                .Select(t => new SelectListItem { Value = t.Id.ToString(), Text = t.Name }).ToList();
            ViewBag.Courses = courseRepository.GetAll()
                .Select(c => new SelectListItem { Value = c.Id.ToString(), Text = c.Name }).ToList();
            ViewBag.Students = studentRepository.GetAll()
                .Select(s => new SelectListItem { Value = s.Id.ToString(), Text = s.Name }).ToList();

            return View("Add", department);
        }

        public IActionResult Edit(int id)
        {
            try
            {
                var department = departmentRepository.GetDepartmentById(id);

                if (department == null)
                {
                    return NotFound();
                }

                ViewBag.Teachers = teacherRepository.GetAll()
                    .Select(t => new SelectListItem
                    {
                        Value = t.Id.ToString(),
                        Text = t.Name,
                        Selected = department.Teachers.Any(dt => dt.Id == t.Id)
                    })
                    .ToList();

                ViewBag.Courses = courseRepository.GetAll()
                    .Select(c => new SelectListItem
                    {
                        Value = c.Id.ToString(),
                        Text = c.Name,
                        Selected = c.DepartmentId == department.Id
                    })
                    .ToList();

                ViewBag.Students = studentRepository.GetAll()
                    .Select(s => new SelectListItem
                    {
                        Value = s.Id.ToString(),
                        Text = s.Name,
                        Selected = department.Students.Any(ds => ds.Id == s.Id)
                    })
                    .ToList();

                return View(department);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SaveEdit(Department department, List<int> teacherIds, List<int> courseIds, List<int> studentIds)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    teacherIds = teacherIds?.Where(id => id > 0).ToList() ?? new List<int>();
                    courseIds = courseIds?.Where(id => id > 0).ToList() ?? new List<int>();
                    studentIds = studentIds?.Where(id => id > 0).ToList() ?? new List<int>();

                    departmentRepository.UpdateDepartmentWithRelationships(department, teacherIds, courseIds, studentIds);

                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    var errorMessage = ex.InnerException?.Message ?? ex.Message;
                    ModelState.AddModelError("", $"Error updating department: {errorMessage}");
                }
            }

            ViewBag.Teachers = teacherRepository.GetAll()
                .Select(t => new SelectListItem { Value = t.Id.ToString(), Text = t.Name }).ToList();
            ViewBag.Courses = courseRepository.GetAll()
                .Select(c => new SelectListItem { Value = c.Id.ToString(), Text = c.Name }).ToList();
            ViewBag.Students = studentRepository.GetAll()
                .Select(s => new SelectListItem { Value = s.Id.ToString(), Text = s.Name }).ToList();

            return View("Edit", department);
        }
    }
}
