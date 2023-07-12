using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace EducationalInstitution.Api.Validations
{
    public class PhoneNumberAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
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
            Regex regexphoneNumber = new Regex(@"^\+98[1-8]{2}\d{8}$");

            if (!regexphoneNumber.IsMatch((string)value))
            {
                return false;
            }
            return true;
        }

        public override string FormatErrorMessage(string name)
        {
            return $"Please enter a valid phone number.";
        }
    }
}