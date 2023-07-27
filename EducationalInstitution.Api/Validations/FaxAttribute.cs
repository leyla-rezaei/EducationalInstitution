using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace EducationalInstitution.Api.Validations
{
    public class FaxAttributeAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null)
            {
                return true;
            }

            if (!(value is string fax))
            {
                return false;
            }
            string hiringDateString = value.ToString();

            fax = fax.Replace(" ", "").Replace("-", "");

            Regex regexfax = new Regex(@"^\+98(21|26|25|28|31|35|41|44|45|51|54|61|71|76|77|81|86|87)[0-9]{6,8}$");

            if (!regexfax.IsMatch((string)value))
            {
                return false;
            }
            return true;
        }

        public override string FormatErrorMessage(string name)
        {
            return $"Please enter a valid fax number.";
        }
    }
}