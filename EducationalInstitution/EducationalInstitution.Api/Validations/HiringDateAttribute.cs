using System.ComponentModel.DataAnnotations;

namespace EducationalInstitution.Api.Validations
{
    public class HiringDateAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null) return false;

            DateTimeOffset hiringDate = (DateTimeOffset)value;

            if (hiringDate.Year > DateTime.Now.Year)
            {
                return false;
            }

            return true;
        }
        public override string FormatErrorMessage(string name)
        {
            return $" cannot be in the future.";
        }
    }
}