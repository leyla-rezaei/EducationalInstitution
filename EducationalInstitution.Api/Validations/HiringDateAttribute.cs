using System.ComponentModel.DataAnnotations;

namespace EducationalInstitution.Api.Validations
{
    public class HiringDateAttribute : ValidationAttribute
    {
        private readonly string _dateFormat;

        public HiringDateAttribute(string dateFormat)
        {
            _dateFormat = dateFormat;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return new ValidationResult($"The {validationContext.DisplayName} field is required.");
            }

            string hiringDateString = value.ToString();

            if (!DateTimeOffset.TryParseExact(hiringDateString, _dateFormat, null, System.Globalization.DateTimeStyles.None, out DateTimeOffset hiringDate))
            {
                return new ValidationResult($"The {validationContext.DisplayName} field is not in the correct format. The correct format is {_dateFormat}.");
            }

            if (hiringDate > DateTimeOffset.Now)
            {
                return new ValidationResult($"{validationContext.DisplayName} cannot be in the future.");
            }

            return ValidationResult.Success;
        }
    }
}