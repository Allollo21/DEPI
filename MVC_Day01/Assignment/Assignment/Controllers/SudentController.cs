using Microsoft.AspNetCore.Mvc;

namespace Assignment.Controllers
{
    public class StudentController : Controller
    {
        // URL: /Student/Welcome
        public ContentResult Welcome()
        {
            ContentResult result = new ContentResult();
            result.Content = "Welcome to Student Management System!";
            return result;
        }

        // URL: /Student/ShowInfo
        public ViewResult ShowInfo()
        {
            ViewResult result = new ViewResult();
            result.ViewName = "StudentInfo";
            return result;
        }

        // URL: /Student/CheckGrade?grade=85
        public IActionResult CheckGrade(int grade)
        {
            if (grade >= 60)
            {
                return View("Success");
            }
            else
            {
                return Content($"Sorry, grade {grade} is failing. Study harder!");
            }
        }

        // Action 4: Display list of students
        // URL: /Student/List
        public IActionResult List()
        {
            return View("StudentList");
        }
    }
}
