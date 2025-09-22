using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment.Models
{
    public class StudentCourseResult
    {
        [Key]
        public int Id { get; set; }

        // Foreign Keys
        public int StudentId { get; set; }
        public int CourseId { get; set; }

        [StringLength(5)]
        public string Grade { get; set; }

        // Navigation properties
        [ForeignKey("StudentId")]
        public virtual Student Student { get; set; }

        [ForeignKey("CourseId")]
        public virtual Course Course { get; set; }
    }
}
