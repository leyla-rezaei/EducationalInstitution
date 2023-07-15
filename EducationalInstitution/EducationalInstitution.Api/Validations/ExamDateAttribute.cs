using System.ComponentModel.DataAnnotations;

namespace EducationalInstitution.Api.Validations
{
    public class ExamDateAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null)
            {
                return true;
            }
            var examDate = (DateTimeOffset)value;

            if (examDate < DateTime.Now.Date)
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