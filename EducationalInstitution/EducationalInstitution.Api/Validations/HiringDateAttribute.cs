using System.ComponentModel.DataAnnotations;

namespace EducationalInstitution.Api.Validations
{
    public class HiringDateAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null || !(value is DateTimeOffset))
            {
                return new ValidationResult("the hiring date must be a valid date.");
            }

            DateTimeOffset hiringDate = (DateTimeOffset)value;

            if (hiringDate.Year > DateTime.Now.Year)
            {
                return new ValidationResult("the hiring date should not be in the future");
            }

            return ValidationResult.Success;
        }
    }
}