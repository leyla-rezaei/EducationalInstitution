using System.ComponentModel.DataAnnotations;

namespace EducationalInstitution.Api.Validations
{
    public class BalanceAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if(value == null) return false;
            decimal balance = (decimal)value;

            if (balance < 0)
                return false;
            return true;
        }
    }
}