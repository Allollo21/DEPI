using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Degree { get; set; }

        [StringLength(50)]
        public string MinDegree { get; set; }

        // Foreign Keys
        public int? DepartmentId { get; set; }
        public int? TeacherId { get; set; }

        // Navigation properties
        [ForeignKey("DepartmentId")]
        public virtual Department? Department { get; set; }

        [ForeignKey("TeacherId")]
        public virtual Teacher? Teacher { get; set; }

        public virtual ICollection<StudentCourseResult>? StudentCourseResults { get; set; } = new List<StudentCourseResult>();
    }

}
