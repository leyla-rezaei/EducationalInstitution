using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace EducationalInstitution.Api.Validations
{
    public class PostalCodeAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (!(value is string postalCode))
            {
                return false;
            }
            Regex regexPostalCode = new Regex(@"^\d{5}-\d{5}$");
            if (((string)value).Length != 10 && !regexPostalCode.IsMatch((string)value)) 
               {
                return false;
            }
            return true;  

        }
        public override string FormatErrorMessage(string name)
        {
            return $"Postal code must be 10 digits.";
        }
    }
}