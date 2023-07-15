using System.ComponentModel.DataAnnotations;

namespace EducationalInstitution.Api.Validations
{
   
    public class TuitionAttribute : ValidationAttribute
    {
        private readonly decimal _min;
        private readonly decimal _max;

        public TuitionAttribute(decimal min, decimal max)
        {
            _min = min;
            _max = max;
        }
        public override bool IsValid(object? value)
        {
            if (value == null || !(value is decimal))
            {
                return false;
            }

            decimal tuition = (decimal)value;

            if (tuition >= _min && tuition <= _max)
            {
                return true;
            }
            return false;
        }
        public override string FormatErrorMessage(string name)
        {
            return $"Enter the correct amount";
        }
    }
}