using System.ComponentModel.DataAnnotations;
using Domain.Attributes;

namespace Domain.Metadata
{
    public class TaskItemMetadata
    {
        [Required(ErrorMessage = "Title is required.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Title must be between 3 and 100 characters.")]
        [Display(Name = "Task Title")]
        [RegularExpression(@"^[a-zA-Z0-9\s\.\-\!]+$", ErrorMessage = "Title can only contain letters, numbers, spaces, dots, dashes, or exclamation marks.")]
        public string Title { get; set; } = null!;

        [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters.")]
        [Display(Name = "Task Description")]
        [DataType(DataType.MultilineText)]
        public string? Description { get; set; }

        [Display(Name = "Completed?")]
        public bool IsCompleted { get; set; }

        [Display(Name = "Created At")]
        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; }

        [Display(Name = "Due Date")]
        [DataType(DataType.Date)]
        [FutureDate]
        public DateTime? DueDate { get; set; }
    }
}
