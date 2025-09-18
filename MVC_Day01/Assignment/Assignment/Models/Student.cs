using Microsoft.AspNetCore.Mvc;

namespace Assignment.Models
{
    namespace SimpleDemo.Models
    {
        public class Student
        {
            public int Id { get; set; }
            public string? Name { get; set; }
            public int Age { get; set; }
            public string? Email { get; set; }
            public double GPA { get; set; }
            public string? Major { get; set; }
        }
    }
}
