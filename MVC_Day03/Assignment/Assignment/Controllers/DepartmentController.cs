using Assignment.Data.Repository;
using Assignment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Controllers
{
    public class DepartmentController : Controller
    {
        DepartmentRepository departmentRepository = new();
        StudentRepository studentRepository = new();
        TeacherRepository teacherRepository = new();
        CourseRepository courseRepository = new();

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
    }
}
