using System.ComponentModel.DataAnnotations;

namespace EducationalInstitution.Api.Validations
{
    public class AmountAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
           if(value == null) return false;

            decimal Amount = (decimal)value;

            if (Amount < 0)
                return false;
            return true;
        }
        public override string FormatErrorMessage(string name)
        {
            return $"Enter the correct amount";
        }
    }
}