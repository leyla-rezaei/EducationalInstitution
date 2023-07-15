using System.ComponentModel.DataAnnotations;

namespace EducationalInstitution.Api.Validations
{
    public class CapacityAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                var capacity = (int)value;
                if (capacity <= 0)
                {
                    return new ValidationResult(ErrorMessage);
                }
            }

            return ValidationResult.Success;
        }
        public override string FormatErrorMessage(string name)
        {
            return $"capacity must be a positive integer";
        }
    }
}