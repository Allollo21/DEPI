using System.ComponentModel.DataAnnotations;

namespace Assignment.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(100)]
        public string MgrName { get; set; }

        // Navigation properties
        public virtual ICollection<Teacher> Teachers { get; set; } = new List<Teacher>();
        public virtual ICollection<Course> Courses { get; set; } = new List<Course>();
        public virtual ICollection<Student> Students { get; set; } = new List<Student>();
    }
}
