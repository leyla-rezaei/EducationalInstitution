using System.ComponentModel.DataAnnotations;

namespace EducationalInstitution.Api.Validations
{
    public class ExamDateAttribute : ValidationAttribute
    {
        private DateTime startDate;
        private DateTime endDate;

        public override bool IsValid(object value)
        {
            if (value == null)
            {
                return true;
            }
            if (!(value is DateTime examDate))
            {
                return false;
            }
            if (startDate != null && examDate < startDate)
            {
                return false;
            }
            if (endDate != null && examDate < endDate)
            {
                return false;
            }

            if (examDate < DateTime.Now.Date)
            {
                return false;
            }
            return true;
        }
        public override string FormatErrorMessage(string name)
        {
            return $"The exam date should not be before the class start date.";
        }
    }
}