using System.ComponentModel.DataAnnotations;

namespace EducationalInstitution.Api.Validations
{
    public class ScoreAttribute : ValidationAttribute
    {
        private readonly double _min;
        private readonly double _max;

        public ScoreAttribute(double min, double max)
        {
            _min = min;
            _max = max;
        }

        public override bool IsValid(object? value)
        {
            if (value == null || !(value is double))
            {
                return false;
            }

            double Score = (double)value;

            if (Score >= _min && Score <= _max)
            {
                return true;
            }
            return false;
        }
    }
}