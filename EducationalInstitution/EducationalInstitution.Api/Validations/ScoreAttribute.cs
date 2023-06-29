using System.ComponentModel.DataAnnotations;

namespace EducationalInstitution.Api.Validations
{
    public class ScoreAttribute : ValidationAttribute
    {
        private readonly int _min;
        private readonly int _max;

        public ScoreAttribute(int min, int max)
        {
            _min = min;
            _max = max;
        }

        public override bool IsValid(object? value)
        {
            if (value == null || !(value is int))
            {
                return false;
            }

            int Score = (int)value;

            if (Score >= _min && Score <= _max)
            {
                return true;
            }
            return false;
        }
    }
}