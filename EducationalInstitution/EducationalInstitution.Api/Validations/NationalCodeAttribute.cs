using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace EducationalInstitution.Api.Validations
{
    public class NationalCodeAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if (value == null)
                return true;

            Regex regexNationalCode = new Regex(@"^[0-9]{10}$");
            if (value.ToString().Length != 10 && (!regexNationalCode.IsMatch((string)value)))
                return false;
            return true;
        }
        public override string FormatErrorMessage(string name)
        {
            return $"Please enter a valid national code.";
        }
    }
}