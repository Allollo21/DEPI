using Microsoft.AspNetCore.Mvc.Rendering;

namespace Assignment.Models
{
    public class DepartmentVM
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentState { get; set; }
        public int StudentCount { get; set; }
        public List<SelectListItem>? StudentsOver25 { get; set; } = new List<SelectListItem>();
        public int? SelectedStudentId { get; set; }
    }
}
