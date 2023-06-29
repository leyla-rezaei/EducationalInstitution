using System.ComponentModel.DataAnnotations;

namespace EducationalInstitution.Api.Validations
{
    public class StartDateAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null)
            {
                return true;
            }
            if (!(value is DateTime startDate))
            {
                return false;
            }
            if (startDate < DateTime.Now.Date)
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