using System.ComponentModel.DataAnnotations;

namespace EducationalInstitution.Api.Validations
{
    public class SalaryAmountAttribute : ValidationAttribute
    {
        private readonly decimal _min;
        private readonly decimal _max;
        public SalaryAmountAttribute(decimal min, decimal max)
        { 
            _min = min;
            _max = max;
        }
        public override bool IsValid(object value)
        {
            if (value == null || !(value is decimal))
            {
                return false;
            }

            decimal Amount = (decimal)value;

            if (Amount >= _min && Amount <= _max)
            {
                return true;
            }
            return false;
        }
    }
}