using Assignment.Data.Repository;
using Assignment.Models;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace Assignment.Controllers
{
    public class StudentController : Controller
    {
        StudentRepository studentRepository = new();
        DepartmentRepository departmentRepository = new();

        // Student/Index or /Student
        public IActionResult Index(int PageNumber = 1, string searchName = "", int? departmentId = null)
        {
            int PageSize = 50;
            IPagedList<Student> students = studentRepository.GetAllPaginated(PageNumber, PageSize, searchName, departmentId);

            ViewBag.SearchName = searchName;
            ViewBag.DepartmentId = departmentId;
            ViewBag.Departments = departmentRepository.GetAll();

            return View("Index", students);
        }

        // Student/Details?id= 
        public IActionResult Details(int id)
        {
            Student student = studentRepository.GetStudentWithDepartmentById(id);
            return View(student);
        }

        public IActionResult Add()
        {
            ViewBag.Departments = departmentRepository.GetAll();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SaveAdd(Student student)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    studentRepository.Add(student);

                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.Message.ToString());
                }
            }

            ViewBag.Departments = departmentRepository.GetAll();
            return View("Add", student);
        }

        public IActionResult Edit(int id) 
        {
            ViewBag.Departments = departmentRepository.GetAll();
            return View(studentRepository.GetById(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SaveEdit(Student newStudent)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    studentRepository.Update(newStudent, newStudent.Id);
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);
                }

                return RedirectToAction(nameof(Index));
            }

            ViewBag.Departments = departmentRepository.GetAll();
            return View("Edit", newStudent);
        }

        public IActionResult Delete(int id)
        {
            return View(studentRepository.GetById(id));
        }

        public IActionResult ConfirmDelete(int id)
        {
            Student student = studentRepository.GetById(id);
            if(student is not null)
            {
                studentRepository.Delete(student);

                return RedirectToAction(nameof(Index));
            }

            return NotFound();
        }
    }
}
