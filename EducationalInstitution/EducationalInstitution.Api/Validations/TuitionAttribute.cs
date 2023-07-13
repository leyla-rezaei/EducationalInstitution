using System.ComponentModel.DataAnnotations;

namespace EducationalInstitution.Api.Validations
{
   
    public class TuitionAttribute : ValidationAttribute
    {
        private readonly int _min;
        private readonly int _max;

        public TuitionAttribute(int min, int max)
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
    }
}