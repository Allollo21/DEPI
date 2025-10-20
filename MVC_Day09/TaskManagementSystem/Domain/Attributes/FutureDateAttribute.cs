using System.ComponentModel.DataAnnotations;

namespace Domain.Attributes
{
    public class FutureDateAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value is DateTime date && date > DateTime.UtcNow)
            {
                return ValidationResult.Success;
            }
            return new ValidationResult(ErrorMessage ?? "Due Date must be in the future.");
        }
    }
}
