using System.ComponentModel.DataAnnotations;

namespace EducationalInstitution.Api.Validations
{
    public class BirthDateAttribute : ValidationAttribute
    {

        private readonly string _dateFormat;

        public BirthDateAttribute(string dateFormat)
        {
            _dateFormat = dateFormat;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return new ValidationResult(string.Format("The {0} field is required.", validationContext.DisplayName));
            }

            if (!DateTimeOffset.TryParseExact((string)value, _dateFormat, null, System.Globalization.DateTimeStyles.None, out DateTimeOffset birthDate))
            {
                return new ValidationResult(string.Format("The {0} field is not in the correct format. The correct format is {1}.", validationContext.DisplayName, _dateFormat));
            }

            if (birthDate.Year > DateTimeOffset.Now.Year)
            {
                return new ValidationResult(string.Format("{0} cannot be in the future.", validationContext.DisplayName));
            }

            return ValidationResult.Success;
        }
    }
}