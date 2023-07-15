using System.ComponentModel.DataAnnotations;

namespace EducationalInstitution.Api.Validations
{
    public class EndDateAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {

            if (value == null)
            {
                return true;
            }

            var endDate = (DateTimeOffset)value;
            if (endDate < DateTime.Now.Date)
            {
                return false;
            }

            return true;
        }
        public override string FormatErrorMessage(string name)
        {
            return $"cannot be in the past.";
        }
    }
}