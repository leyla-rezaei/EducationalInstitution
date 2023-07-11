using System.ComponentModel.DataAnnotations;

namespace EducationalInstitution.Api.Validations
{
    public class NumberAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (!(value is int number))
            {
                return false;
            }
            if (number <= 0)
            {
                return false;
            }
            return true;
        }

        public override string FormatErrorMessage(string name)
        {
            return $"class number cannot be negative";
        }
    }
}