using System.ComponentModel.DataAnnotations;

namespace EducationalInstitution.Api.Validations
{
    public class DepositAmountAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
           if(value == null) return false;

            decimal depositAmount = (decimal)value;

            if (depositAmount < 0)
                return false;
            return true;
        }
    }
}