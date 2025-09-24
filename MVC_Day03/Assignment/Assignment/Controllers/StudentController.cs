using Assignment.Data.Repository;
using Assignment.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment.Controllers
{
    public class StudentController : Controller
    {
        StudentRepository studentRepository = new();

        // Student/Index or /Student
        public IActionResult Index()
        {
            List<Student> students = studentRepository.GetAll();
            return View("Index", students);
        }

        // Student/Details?id= 
        public IActionResult Details(int id)
        {
            Student student = studentRepository.GetStudentWithDepartmentById(id);
            return View(student);
        }
    }
}
