using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace EducationalInstitution.Api.Validations
{
    public class DepositIDAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null)
            {
                return true;
            }

            Regex regexDepositID = new Regex(@"^[0-9]{16,26}$");

            if (!regexDepositID.IsMatch((string)value))
            {
                return false;
            }
            return true;
        }
        public override string FormatErrorMessage(string name)
        {
            return $"the id is not correct";
        }
    }
}