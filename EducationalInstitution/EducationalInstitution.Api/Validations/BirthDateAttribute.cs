using System.ComponentModel.DataAnnotations;

namespace EducationalInstitution.Api.Validations
{
    public class BirthDateAttribute : ValidationAttribute
    {
        public bool IsValid(object? value)
        {

            if (value == null || !(value is DateTime))
            {
                return false;
            }
            DateTime birthDate = (DateTime)value;

            if (birthDate > DateTime.Now)
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