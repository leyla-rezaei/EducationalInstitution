using System.ComponentModel.DataAnnotations;

namespace EducationalInstitution.Api.Validations
{
    public class SalaryAmountAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null)
            {
                return true;
            }

            if (!(value is decimal salary))
            {
                return false;
            }

            return true;
        }
    }
}
