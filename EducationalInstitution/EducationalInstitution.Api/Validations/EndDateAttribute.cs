using System.ComponentModel.DataAnnotations;

namespace EducationalInstitution.Api.Validations
{
    public class EndDateAttribute : ValidationAttribute
    {
        private DateTime startDate;

        public override bool IsValid(object value)
        {

            if (value == null)
            {
                return true;
            }

            if (!(value is DateTime endDate))
            {
                return false;
            }
            if (startDate != null && endDate < startDate)
            {
                return false;
            }

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