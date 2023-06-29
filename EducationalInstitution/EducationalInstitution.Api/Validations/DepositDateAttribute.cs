using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace EducationalInstitution.Api.Validations
{
    public class DepositDateAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null)
            {
                return true;
            }

            if (!(value is string depositDate))
            {
                return false;
            }
            Regex regexDepositDate = new Regex(@"yyyy/MM/dd");

            if (!regexDepositDate.IsMatch((string)value))
            {
                return false;
            }
            return true;
        }

        public override string FormatErrorMessage(string name)
        {
            return $"entry must be a valid date";
        }
    }
}