using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace EducationalInstitution.Api.Validations
{
    public class MobileNumberAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if (value == null)
            {
                return true;
            }

            if (!(value is string phoneNumber))
            {
                return false;
            }

            phoneNumber = phoneNumber.Replace(" ", "").Replace("-", "");
            Regex regexMobileNumber = new Regex(@"^\+989\d{9}$");

            if (!regexMobileNumber.IsMatch((string)value))
            {
                return false;
            }
            return true;
        }
        public override string FormatErrorMessage(string name)
        {
            return $" you must enter a valid mobile number";
        }
    }
}